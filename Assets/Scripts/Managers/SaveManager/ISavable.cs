public interface ISavable<out T>
{
    string Id { get; }
    T SaveData();
}
