using System;
using System.Linq;

public class Kata
{
    public static string IsSortedAndHow(int[] array)
    {
        bool ascending = array.SequenceEqual(array.OrderBy(x => x));
        bool descending = array.SequenceEqual(array.OrderByDescending(x => x));

        if (ascending)
            return "yes, ascending";
        else if (descending)
            return "yes, descending";
        else
            return "no";
    }
}