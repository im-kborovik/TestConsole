using System;

namespace Skynet.Dtos.ChannelProgram
{
    public class CompanyChannelProgramDto
    {
        public Guid ChannelId { get; set; }
        public Guid ProgramId { get; set; }
        public Guid CompanyId { get; set; }
    }
}
