using System;
using System.Collections.Generic;
using System.Linq;

namespace PropertyBasedTestingCsharp.AppCore
{
    public interface ISorter<T> where T: IComparable 
    {
        IList<T> Sort(IList<T> @in);
    }

    public class NumberSorter: ISorter<int>
    {
        public IList<int> Sort(IList<int> @in) 
        {
            var @out = new List<int>(@in);
            return @out.OrderBy(x=>x).ToList();
            // return @in.OrderBy(x=>x);
        }
    }
}
