using Newtonsoft.Json;
using System.Text.Json;
namespace AndOS.Core.StorageConfigs;

public class AzureBlobStorageConfig : StorageConfig
{
    public string AccountName { get; set; }

    public string AccountKey { get; set; }

    public string ContainerName { get; set; }

    public string DefaultEndpointsProtocol { get; set; }

    public string EndpointSuffix { get; set; }

    public bool IsAzurite { get; set; }

    public string Url => IsAzurite ? $"{DefaultEndpointsProtocol}://{EndpointSuffix}/{AccountName}/{ContainerName}" :
                                     $"{DefaultEndpointsProtocol}://{AccountName}.{EndpointSuffix}/{ContainerName}";
    public override JsonDocument ToJsonDocument()
    {
        var jsonString = JsonConvert.SerializeObject(this);
        return JsonDocument.Parse(jsonString);
    }

    public override string ToString()
    {
        if (IsAzurite)
            return $"{nameof(DefaultEndpointsProtocol)}={DefaultEndpointsProtocol};{nameof(AccountName)}={AccountName};{nameof(AccountKey)}={AccountKey};BlobEndpoint={DefaultEndpointsProtocol}://{EndpointSuffix}/{AccountName};";
        else
            return $"{nameof(DefaultEndpointsProtocol)}={DefaultEndpointsProtocol};{nameof(AccountName)}={AccountName};{nameof(AccountKey)}={AccountKey};{nameof(EndpointSuffix)}={EndpointSuffix};";
    }
}