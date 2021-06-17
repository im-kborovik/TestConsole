using System;
using System.Collections.Generic;

namespace Skynet.Dtos.LockDesk
{
    public class LockDeskSettingsDto
    {
        public DateTime MainLockDeskOpenTime { get; set; }

        public DateTime MainLockDeskCloseTime { get; set; }

        public bool IsMainLockDeskSwitch { get; set; }

        public bool IsRetailLockDesk { get; set; }

        public bool IsWholesaleLockDesk { get; set; }

        public bool IsCorrespondentDelegatedLockDesk { get; set; }

        public bool IsCorrespondentNonDelegatedLockDesk { get; set; }

        public List<TradeManagementSettingsDto> TradeManagementSettings { get; set; } 
    }
}
