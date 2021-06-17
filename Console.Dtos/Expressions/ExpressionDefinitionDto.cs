using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using EntitiesDictionary = System.Collections.ObjectModel.ReadOnlyDictionary<string, System.Collections.ObjectModel.ReadOnlyDictionary<string, string>>;
using FunctionsDictionary = System.Collections.ObjectModel.ReadOnlyDictionary<string, System.Collections.Generic.IReadOnlyDictionary<string, object>>;
using StringCollectionsDictionary = System.Collections.ObjectModel.ReadOnlyDictionary<string, System.Collections.Generic.IReadOnlyCollection<string>>;

namespace Skynet.Dtos.Expressions
{
    public class ExpressionDefinitionDto
    {
        public ExpressionDefinitionDto(IEnumerable<EntityDefinitionDto> entities,
                                       IEnumerable<EnumDefinitionDto> types,
                                       FunctionsDictionary functions,
                                       StringCollectionsDictionary commonTypes,
                                       StringCollectionsDictionary lookups,
                                       StringCollectionsDictionary valueMasks, 
                                       StringCollectionsDictionary dynamicCommonTypes = null)
        {
            RootEntities = entities.Where(x => x.IsRootEntity).Select(x => x.Name).ToArray();
            Entities = new EntitiesDictionary(entities.ToDictionary(x => x.Name,
                                                                    x => new ReadOnlyDictionary<string, string>(x.Properties)));
            EnumTypes = new StringCollectionsDictionary(types.OrderBy(x => x.Name)
                                                             .ToDictionary(x => x.Name, x => x.AllowedValues));
            Functions = functions;
            CommonTypes = commonTypes;
            DynamicCommonTypes = dynamicCommonTypes;
            Lookups = lookups;
            ValueMasks = valueMasks;
        }

        public IReadOnlyCollection<string> RootEntities { get; }

        public EntitiesDictionary Entities { get; }

        public StringCollectionsDictionary EnumTypes { get; }

        public StringCollectionsDictionary CommonTypes { get; }

        public StringCollectionsDictionary DynamicCommonTypes { get; }

        public FunctionsDictionary Functions { get; }

        public StringCollectionsDictionary Lookups { get; }

        public StringCollectionsDictionary ValueMasks { get; }
    }
}