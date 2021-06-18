using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Scriban;
using Scriban.Parsing;
using Scriban.Runtime;
using Skynet.Dtos.ApplyForm.Application;
using Skynet.Forms.Services;

namespace TestConsole
{
    public class Tester
    {
        private static readonly FormsDynamicFieldsService _dynamicService = new();
        private bool _writeResult = true;

        public Tester(bool writeTemplate = true)
        {
            if (!writeTemplate)
            {
                return;
            }

            TemplateBase = GetTemplate();

            WriteLine("Base Template");
            Underline();
            WriteLine(TemplateBase);
        }

        public Tester(string template)
        {
            TemplateBase = template;
        }

        private string TemplateBase { get; }

        private static ApplicationDto Model { get; } = ApplicationHelper.GetFormTemplateViewModelStub();

        public static string GetTemplate()
        {
            var scheme = _dynamicService.GetScheme();

            return string.Join("\n",
                               scheme.Select(q => "<span data-dynamic-type=\"" + q.Type + "\" data-dynamic-value=\"" + q.Field + "\">" + q.Title + "</span>"));
        }


        public Tester RenderByScriban(bool isPreview = false)
        {
            var template = Template.Parse(TemplateBase);

            if (template.HasErrors)
            {
                WriteLine(string.Join("\n",
                                      template.Messages
                                              .Where(q => q.Type == ParserMessageType.Error)
                                              .Select(q => q.Message)));

                return this;
            }

            var context = new CustomTemplateContext();
            var models = new ScriptObject
                         {
                             ["Application"] = Model,
                             ["isPreview"] = isPreview
                         };
            context.PushGlobal(models);
            var testFunc = new DynamicFieldFunction();
            context.PushGlobal(testFunc);
            Bench(nameof(RenderByScriban),
                  () =>
                  {
                      var result = template.Render(context);
                      TryWriteResult(result);

                      return result;
                  });


            return this;
        }

        #region Help methods

        public Tester Underline()
        {
            return WriteLine(new string('-', 40));
        }

        public Tester WriteLine(string message)
        {
            Console.WriteLine(message);

            return this;
        }

        public Tester WriteTemplate()
        {
            Console.WriteLine(TemplateBase);

            return this;
        }

        private void TryWriteResult(string result)
        {
            if (_writeResult)
            {
                WriteLine(result);
            }
        }

        private static T Bench<T>(string benchName, Func<T> func)
        {
            var watcher = Stopwatch.StartNew();

            var result = func();

            watcher.Stop();

            Console.WriteLine($"{benchName}: {watcher.Elapsed.Seconds}s and {watcher.Elapsed.TotalMilliseconds}ms");

            return result;
        }

        public Tester SetWriteResult()
        {
            _writeResult = true;

            return this;
        }

        public Tester SetNotWriteResult()
        {
            _writeResult = false;

            return this;
        }

        #endregion Help methods
    }

    public class CustomTemplateContext : TemplateContext
    {
        public CustomTemplateContext()
        {
            EnableRelaxedTargetAccess = true;
            MemberRenamer = q => q.Name;
            TemplateLoader = new CustomLoader();
            CachedTemplates.Add("d_field", Template.Parse("{{ render_dynamic_field Application.Status \"default value\" \"preview\" }}"));
        }
    }

    public class DynamicFieldFunction : ScriptObject
    {
        public static string RenderDynamicField(object field, string defaultValue, string previewValue)
        {
            return "Test";
        }
    }

    public class CustomLoader : ITemplateLoader
    {
        public string GetPath(TemplateContext context, SourceSpan callerSpan, string templateName)
        {
            return templateName;
        }

        public string Load(TemplateContext context, SourceSpan callerSpan, string templatePath)
        {
            var cached = context.CachedTemplates[templatePath];

            return cached.ToText();
        }

        public ValueTask<string> LoadAsync(TemplateContext context, SourceSpan callerSpan, string templatePath)
        {
            return ValueTask.FromResult(Load(context, callerSpan, templatePath));
        }
    }
}