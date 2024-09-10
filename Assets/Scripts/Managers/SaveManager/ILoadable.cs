public interface ILoadable<in T>
{
    string Id { get; set; }
    void LoadData(T data);
}