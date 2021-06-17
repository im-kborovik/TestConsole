using System;

namespace Skynet.Dtos.ChannelProgram
{
    public class ChannelProgramDto
    {
        public Guid ChannelId { get; set; }
        public Guid ProgramId { get; set; }
        public Guid CompanyId { get; set; }
        public bool IsExcludedForLocalCompany { get; set; }
    }
}
