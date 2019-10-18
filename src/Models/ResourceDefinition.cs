namespace AutoRest.AzureResourceSchema.Models
{
    public class ResourceDefinition
    {
        public ResourceDescriptor Descriptor { get; set; }

        public ResourceName Name { get; set; }

        public JsonSchema BaseSchema { get; set; }
    }
}