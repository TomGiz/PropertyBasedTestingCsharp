using PropertyBasedTestingCsharp.AppCore;
using Xunit;
using FsCheck;
using FsCheck.Xunit;

namespace PropertyBasedTestingCsharp.Tests
{
    public class MathTests
    {
        [Property]
        public Property Negate_after_Negate_is_invariant(int x)
        {
            return (Math.Negate(Math.Negate(x)) == x).ToProperty();
        }

        
        // [Property]
        // public Property Add1_after_Add1_is_invariant(int x)
        // {
        //     return (Math.Add(Math.Add(x, 1), 1) == x).ToProperty();
        // }

         [Property]
        public Property Add0_is_invariant(int x)
        {
            return (Math.Add(x, 0) == x).ToProperty();
        }
    }
}
