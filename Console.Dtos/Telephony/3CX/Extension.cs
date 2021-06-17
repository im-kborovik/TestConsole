namespace Skynet.Dtos.Telephony._3CX
{
    public class FwdProfile
    {
        public string Name { get; set; }
    }
    public class Extension
    {
        public string Number { get; set; }
        public string EmailAddress { get; set; }
        public string OutboundCallerId { get; set; }
        public bool RecordCalls { get; set; }
        public bool IsRegistered { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        string AuthID { get; set; }

        string AuthPassword { get; set; }




        public string SIPID { get; set; }

        public bool SupportReinvite { get; set; }

        public bool SupportReplaces { get; set; }

        public bool VMEnabled { get; set; }

        public string VMPIN { get; set; }

        public bool VMPlayCallerID { get; set; }
        public FwdProfile CurrentProfile { get; set; }

    }
}
