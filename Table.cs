public class Table
{
    public int TableId { get; set; }
    public int Capacity { get; set; }
    public int Cost{get;set;}
    public bool IsReserved { get; set; }

    public override string ToString()
    {
        return $"Id: {TableId}, Capacity: {Capacity}, Cost: {Cost}, Is reserved: {IsReserved}";
    }
}
