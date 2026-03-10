public class ProductSeed
{
    public IEnumerable<ProductsEntity> GetProducts()
    {
        return new List<ProductsEntity>()
        {
            new ProductsEntity(1, 
            "1 box of Leavening Agent Cookies", 
            "https://res.cloudinary.com/domjgouem/image/upload/v1773126939/Leaving_Agent_v7hdz0.jpg", 
            "Leavening cookies means using ingredients that create gas (usually carbon dioxide) so the cookie dough expands, spreads, or becomes lighter during baking. Without leavening, cookies tend to be dense, flat, and harder.",
            200),
            new ProductsEntity(2, 
            "1 box of Chocolate Chips Cookies", 
            "https://res.cloudinary.com/domjgouem/image/upload/v1773126987/chocolate_chips_umkv0r.jpg", 
            "A chocolate chip cookie is a classic, indulgent treat featuring a buttery, soft-baked or chewy center, crisp edges, and gooey pockets of melted chocolate throughout.",
            200)
        };
    }
}