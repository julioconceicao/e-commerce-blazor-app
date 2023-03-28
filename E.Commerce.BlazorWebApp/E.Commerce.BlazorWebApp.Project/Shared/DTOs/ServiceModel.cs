using E.Commerce.BlazorWebApp.Project.Shared.Models;

namespace E.Commerce.BlazorWebApp.Project.Shared.DTOs
{
    internal class ServiceModel
    {
        public List<Product>? ProductList { get; set; } = null;
        public Product? SingleProduct { get; set; } = null;
        public bool Success { get; set; } = true;
        public string? CssClass { get; set; } = "success";
        public string? Message { get; set; } = null;
    }
}
