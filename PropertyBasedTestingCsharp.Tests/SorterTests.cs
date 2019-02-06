using PropertyBasedTestingCsharp.AppCore;
using Xunit;
using FsCheck;
using FsCheck.Xunit;
using System.Linq;

namespace PropertyBasedTestingCsharp.Tests
{
    public class SorterTests
    {
        ISorter<int> _sorter =  new NumberSorter();

        [Fact]
        public void Can_sort_an_arbitrary_array()
        {
            var @in = new int[] {4, 7, 3, 0, 1, 9};
            var exp = new int[] {0, 1, 3, 4, 7, 9};

            var sorted = _sorter.Sort(@in);

            Assert.Equal(exp, sorted);
        }

        [Fact]
        public void Sorting_an_empty_array_results_in_an_empty_array() 
        {
            var @in = new int[] {};
            var exp = new int[] {};

            var sorted = _sorter.Sort(@in);

            Assert.Equal(exp, sorted);
        }

        [Property(MaxTest = 200)]
        public Property Sorting_an_array_preserves_array_length(int[] array)
        {
            return (_sorter.Sort(array).ToList().Count == array.Length).ToProperty();
        }

        [Property(Verbose=true)]
        public Property Sorting_twice_is_equivalent_to_Sorting_once(int[] array)
        {
            // return (
            //     _sorter.Sort(array)
            //     == 
            //     _sorter.Sort(_sorter.Sort(array))
            //     ).ToProperty();
            // // "==" denotes referential equality, while we want structural equality

             return (
                _sorter.Sort(array).SequenceEqual(
                                    _sorter.Sort(_sorter.Sort(array))
                    )
                ).ToProperty();
        }
    }
}
