
class Product 
{
    public int Id;
    public string Name;
    public int Price;
    public bool Nuts;
    public string Image;
    public bool Vegeterian;
    public int Spiciness;
    public string Category;
}

var product1 = new Product();
product1.Id = 1234;
product1.Name = "tempura";
product1.Price = 12;
product1.Nuts = false;
product1.Image = "image";
product1.Vegeterian = false;
product1.Spiciness = 0;
product1.Category = "japanese";