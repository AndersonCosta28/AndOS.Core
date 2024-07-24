using System.Text.Json;

namespace AndOS.Core.StorageConfigs;

public abstract class StorageConfig
{
    public abstract JsonDocument ToJsonDocument();
}