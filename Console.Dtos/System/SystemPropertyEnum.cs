using System.ComponentModel;
using System.Runtime.Serialization;

namespace Skynet.Dtos.System
{
    public enum SystemPropertyEnum
    {
        
        BlendTargetInstanceName,
        
        BlendAccessToken,
        BlendDeployment,
        BlendSpecialId,
        
        HubSpotOauthCode, //HubSpot Oauth code to get token
        HubSpotAccessToken,//Access Token for Hubspot calls
        HubSpotRereshToken,//Refresh Token for Hubspot calls
        HubSpotTokenExpiresAt,
        HubSpotPortalId,//Portal Id for Hubspot instance
        HubSpotAPIKey,
        SlackAccessToken, //Slack OAuth token
        SlackBotAccessToken,//Slack Bot OAuthToken
        ThreeCXServerIP,
        TelnyxAPIKey,
        TelnyxOrganizationID,
        TelnyxMessagingID,
        testKey,
        AzureTenantID,
        FannieUsername,
        FanniePassword,
        FannieCreditProvider,
        FannieCreditProviderUsername,
        FannieCreditProviderPassword,
        HubSpotDealStagesEditLoan,
        HubSpotDealStagesRunAUS,
        StripeAccountId,
        ValuationPartnersUsername,
        ValuationPartnersPassword,
        ValuationPartnersClientId,
        QuickBooksOAuthCode,
        QuickBooksRealmId,
        QuickBooksAccessToken,
        QuickBooksTokenExpiresAt,
        QuickBooksRefreshToken,
        QuickBooksRefreshTokenExpiresAt,
        FactualDataUsername,
        FactualDataPassword,
        LastHubSpotEngagementSyncTime,
        FreddieClientId,
        FreddieClientSecret,
        FreddieLPAUsername,
        FreddieLPAPassword,
        FreddieLPAToken,
        FreddieLPATokenExpiresAt,
        FreddieSellerNumber,
        TelnyxCallControlConnectionId,
        TelnyxSipConnectionId,
        TelnyxDefaultOutboundNumber,
        
        
    }
}
