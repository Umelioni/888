
namespace Lab6.Interfaces
{
    public interface IMyDictionary<TKey, TValue>
    {
        void Add(TKey key, TValue value);
        TValue this[TKey index] { get; set; }
        int Count { get; }
        int Capacity { get; set; }
    }
}
