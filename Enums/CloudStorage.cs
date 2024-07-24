using System.ComponentModel;

namespace AndOS.Core.Enums;

public enum CloudStorage
{
    [Description("Azure - Blob storage")]
    Azure_BlobStorage,
    [Description("Amazon web service - S3")]
    AWS_S3Storage,
    [Description("Google Cloud Plataform - Cloud Storage")]
    GCP_CloudStorage
}