namespace AutoRest.AzureResourceSchema.Models
{
    public class ResourceDefinition
    {
        public JsonSchema Schema { get; set; }

        public ResourceDescriptor Descriptor { get; set; }
    }
}