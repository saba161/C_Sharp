public class FailSoftArray
{
    int[] a;
    public int Length;
    public bool ErrFlag;

    public FailSoftArray(int size)
    {
        a = new int[size];
        Length = size;
    }

    public int this[int index]
    {
        get
        {
            if (oK(index))
            {
                ErrFlag = false;
                return a[index];
            }
            else
            {
                ErrFlag = true;
                return 0;
            }
        }
        set
        {
            if (oK(index))
            {
                a[index] = value;
                ErrFlag = false;
            }
            else
            {
                ErrFlag = true;
            }
        }
    }

    private bool oK(int index)
    {
        if (index >= 0 & index < Length) return true;
        return false;
    }
}