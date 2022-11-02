namespace Lab6.Interfaces
{
    public interface IMyList<T>
    {
        void Add(T item);
        T this[int index] { get; set; }
        int Count { get; }
        int Capacity { get; set; }
    }
}
