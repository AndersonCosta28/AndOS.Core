using System.Text.Json;

namespace AndOS.Core.StorageConfigs;
public class GcpStorageConfig : StorageConfig
{
    public string ProjectId { get; set; }
    public string BucketName { get; set; }
    public string CredentialsJson { get; set; }
    public override JsonDocument ToJsonDocument() => JsonDocument.Parse(JsonSerializer.Serialize(this));
}