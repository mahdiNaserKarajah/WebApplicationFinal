namespace ResturantFinal.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public string Barcode { get; set; }
        public string Type { get; set; }
        public string Country_Of_Origin { get; set; }
    }
}
