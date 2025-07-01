
namespace Person;

internal class CommonRepsitory<T> : ICommonRepository1<T> where T : class
{
    private readonly List<T> list;
    public CommonRepsitory()
    {
        list = new List<T>();
    }

    int ICommonRepository1<T>.Delete(T item)
    {
        bool rem = list.Remove(item);
        if(rem)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }

    List<T> ICommonRepository1<T>.GetAll()
    {
        return list;
    }

    T ICommonRepository1<T>.GetDetails(int id)
    {
        return list[id];
    }

    int ICommonRepository1<T>.Insert(T item)
    {
        list.Add(item);
        return 1;
    }

    int ICommonRepository1<T>.Update(T item)
    {
        throw new NotImplementedException();
    }
}
