using System.Collections.Generic;

namespace Skynet.Dtos.ChannelProgram
{
    public class ChannelProgramBatchDto
    {
        public IReadOnlyCollection<ChannelProgramDto> AddedChannelPrograms { get; set; }

        public IReadOnlyCollection<ChannelProgramDto> DeletedChannelPrograms { get; set; }
    }
}