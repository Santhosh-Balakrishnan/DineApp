namespace DineApp.Models
{
    public class BillDesk
    {
        public BillDesk(int noOfTables)
        {
            Tables = InitializeTables(noOfTables);
            Orders = new List<Order>();
        }
        public List<Table> Tables { get; set; }
        public List<Order> Orders { get; set; }
        private List<Table> InitializeTables(int noOfTables)
        {
            var tables = new List<Table>();

            for (int i = 1; i <= noOfTables; i++)
            {
                tables.Add(new Table(i,i.ToString()));
            }

            return tables;
        }
    }
}
