public class ProductsEntity : BaseEntity
{
    public int ProductId { get; set; }

    public string ProductImageUrl { get; set; }

    public string ProductName { get; set; }

    public string ProductDescription { get; set; }

    public string ProductType { get; set; }

    public double Amount { get; set; }

    public ProductsEntity() { }

    public ProductsEntity(int productId, string productName, string productImageUrl, string productDescription, string productType, double amount)
    {
        this.Id = Guid.NewGuid();
        this.ProductId = productId;
        this.ProductImageUrl = productImageUrl;
        this.ProductName = productName;
        this.ProductDescription = productDescription;
        this.ProductType = productType;
        this.Amount = amount;
        this.CreatedOn = DateTimeOffset.Now;
        this.CreatedBy = "SYSTEM";
        this.CreatedByType = "SYSTEM";
        this.ModifiedOn = DateTimeOffset.Now;
        this.ModifiedBy = "SYSTEM";
        this.ModifiedByType = "SYSTEM";
        this.IsActive = true;
    }
}