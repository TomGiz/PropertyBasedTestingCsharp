using System;
using System.Collections.Generic;
using System.Linq;

namespace PropertyBasedTestingCsharp.AppCore
{
    public interface ISorter<T> where T: IComparable 
    {
        IList<T> Sort(IList<T> @in);
    }

    public class LazyNumberSorter: ISorter<int>
    {
        public IList<int> Sort(IList<int> @in) 
        {
            var @out = new List<int>();
            return @out;
        }
    }
    
    public class BrokenNumberSorter: ISorter<int>
    {
        public IList<int> Sort(IList<int> @in) 
        {
            IDictionary<int, object> dict = new SortedDictionary<int, object>(); 
            // using IDictionary due to popular market demand in IDictionary developer

            foreach (var i in @in)
            {
                if (!dict.ContainsKey(i))
                    dict.Add(i, null); // using null to minimize memory footprint
            }

            return dict.Keys.ToList();
        }
    }

    public class NumberSorter: ISorter<int>
    {
        public IList<int> Sort(IList<int> @in) 
        {
            return @in.OrderBy(x=>x).ToList();
        }
    }
}
