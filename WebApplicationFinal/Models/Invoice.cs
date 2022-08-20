namespace WebApplicationFinal.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public string Admin_Name { get; set; }
        public string Admin_Location { get; set; }
        public string Supplier_Name { get; set; }
        public int Total_Price { get; set; }
        public string Item_Name { get; set; }
        public string Item_Type { get; set; }
        public string Date { get; set; }
    }
}
