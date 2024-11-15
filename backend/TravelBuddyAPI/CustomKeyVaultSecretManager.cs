using Azure.Extensions.AspNetCore.Configuration.Secrets;
using Azure.Security.KeyVault.Secrets;

namespace TravelBuddyAPI;

public class CustomKeyVaultSecretManager : KeyVaultSecretManager
{

    public override string GetKey(KeyVaultSecret secret)
    {

        return secret.Name switch
        {
            "Geoapify-Key" => "Geoapify:Key",
            "Cognito-Authority" => "Cognito:Authority",
            "Cognito-Audience" => "Cognito:Audience",
            _ => secret.Name
        };
    }
}