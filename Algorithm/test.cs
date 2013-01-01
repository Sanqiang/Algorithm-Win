public class BB<T>
{
    public T[] arr;
}

public class zz<T> : BB<T>, System.Collections.Generic.IComparer<T>
{
    public void cs()
    {
        this.arr = null;

    }

    public bool bigger(T another) { return Compare(arr[0], another) >= 0; }

    public int Compare(T x, T y)
    {
        return 1;
    }
}

public class zz2<T> : BB<T> where T : System.IComparable<T>
{
    public bool zz(T another)
    {
        return another.CompareTo(arr[0]) < 0;
    }
}