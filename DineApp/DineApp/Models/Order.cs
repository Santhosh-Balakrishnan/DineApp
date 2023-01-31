namespace DineApp.Models
{
    public class Order
    {
        public Order(Table table)
        {
            Table = table;
        }
        public int Id { get; set; }
        public Table Table { get; set; }
    }
}
