public class Restaurant
{
    public string Name { get; set; }
    public List<Table> Tables { get; set; }

    public Restaurant()
    {
        Tables = new List<Table>();
    }

    public void AddTable(Table table)
    {
        Tables.Add(table);
    }
}


