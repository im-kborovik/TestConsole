using System;

namespace Skynet.Dtos.Enums.Adjustment
{
    [Serializable]
    public enum Channel: byte
    {
        All = 6, // was -1
        None = 0,
        Retail = 1,
        Wholesale = 2,
        CorrespondentDelegated = 3,
        CorrespondentNonDelegated = 4,
        Correspondent = 5
    }
}
