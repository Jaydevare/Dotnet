namespace Person;

internal interface ICommonRepository1<T>
{
    List<T> GetAll();
    T GetDetails(int id);
    int Insert(T item);
    int Update(T item);
    int Delete(T item);
}
