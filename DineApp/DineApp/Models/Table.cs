namespace DineApp.Models
{
    public class Table
    {
        public Table(int tableNo, string tableName)
        {
            No = tableNo;
            TableName = tableName;
        }
        public int No { get; set; }
       public string TableName { get; set; }
      
       public int NoOfPeople { get; set; }

       public TableState TableState { get; set; }
      
       public List<string> Items { get; set; }

       public bool IsBillable { get; set; } = true;

    }
}
