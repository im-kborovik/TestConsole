namespace Skynet.Dtos.Sso
{
    public class CompanySsoInfoDataRequestDto
    {
        public string IssuerUrl { get; set; }

        public string SsoUrl { get; set; }

        public string X509Certificate { get; set; }
    }
}