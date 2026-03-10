public class ProductSeed
{
    public IEnumerable<ProductsEntity> GetProducts()
    {
        return new List<ProductsEntity>()
        {
            new ProductsEntity(1, 
            "Leavening Agent Cookies", 
            "https://res.cloudinary.com/domjgouem/image/upload/v1773126939/Leaving_Agent_v7hdz0.jpg", 
            "Leavening cookies means using ingredients that create gas (usually carbon dioxide) so the cookie dough expands, spreads, or becomes lighter during baking. Without leavening, cookies tend to be dense, flat, and harder.",
            "Boxes",
            277.01),
            new ProductsEntity(2, 
            "Chocolate Chips Cookies", 
            "https://res.cloudinary.com/domjgouem/image/upload/v1773126987/chocolate_chips_umkv0r.jpg", 
            "A chocolate chip cookie is a classic, indulgent treat featuring a buttery, soft-baked or chewy center, crisp edges, and gooey pockets of melted chocolate throughout.",
            "Boxes",
            271.82),
            new ProductsEntity(3, 
            "Aachener Printen", 
            "https://res.cloudinary.com/domjgouem/image/upload/v1773134527/Aachener-printen-1_kydao2.jpg", 
            "Aachener Printen are a type of Lebkuchen. The term is a protected designation of origin and so all manufacturers can be found in or near Aachen.",
            "Boxes",
            300.11),
            new ProductsEntity(4, 
            "Abernethy Cookies",
            "https://res.cloudinary.com/domjgouem/image/upload/v1773134626/Abernethy_Biscuits._sxzjue.jpg",
            "Invented by Scottish doctor John Abernethy in the 18th century as a digestive. An adaptation of the plain captain's biscuit or hardtack, with the added ingredients of sugar (for energy), and caraway seeds.",
            "Boxes",
            450.92),
            new ProductsEntity(5,
            "Acibadem kurabiyesi Cookies",
            "https://res.cloudinary.com/domjgouem/image/upload/v1773134825/Acibadem_Kurabiyesi_tz32eu.jpg",
            "Traditional Turkish biscuit ('kurabiye') made of almonds, sugar and egg whites. ",
            "Boxes",
            872.33)
        };
    }
}