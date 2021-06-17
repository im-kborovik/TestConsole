using System;
using System.Collections.Generic;
using System.Text;

namespace Skynet.Dtos.Channel
{
	public enum Channel
	{
		All = -1,
		None = 0,
		Retail = 1,
		Wholesale = 2,
		CorrespondentDelegated = 3,
		CorrespondentNonDelegated = 4,
		Correspondent = 5
	}
}
