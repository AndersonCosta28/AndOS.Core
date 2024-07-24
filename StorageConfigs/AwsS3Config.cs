using System.Text.Json;

namespace AndOS.Core.StorageConfigs;
public class AwsS3Config : StorageConfig
{
    public string AccessKey { get; set; }
    public string SecretKey { get; set; }
    public string BucketName { get; set; }
    public string Region { get; set; }

    public override JsonDocument ToJsonDocument() => JsonDocument.Parse(JsonSerializer.Serialize(this));
}