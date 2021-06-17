using System;
using System.Collections.Generic;

namespace Skynet.Dtos.Company
{
    public static class InternalCompanyIDs
    {
        public static Dictionary<string, Guid> InternalCompanyIdDictionary {
            get { return new Dictionary<string, Guid>() {{"Interfirst", new Guid("90174502-24cc-4a96-8d98-c8edb07b80a5")}, {"ZeroMortgage", new Guid("500040d2-fed4-498e-b9cc-64c1d6d5ef0c")}}; }
    }
}

}
