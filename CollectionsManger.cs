public class CollectionsManager
{
    public void AddItem<T>(List<T> collection, T item)
    {
        collection.Add(item);
    }

    public void RemoveItem<T>(List<T> collection, T item)
    {
        collection.Remove(item);
    }

    public T FindItem<T>(List<T> collection, Func<T, bool> predicate)
    {
        return collection.FirstOrDefault(predicate);
    }
}
