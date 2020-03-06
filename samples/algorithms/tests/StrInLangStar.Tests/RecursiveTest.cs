using System;
using Xunit;
using Algorithms;

namespace StrInLangStar.Tests
{
    public class RecursiveTest
    {
        [Fact]
        public void TestTrue()
        {
            Assert.True("aaa".IsInLanguageStarRecursive("a"));
        }

        [Fact]
        public void TestFalse()
        {
            Assert.False("aaa".IsInLanguageStarRecursive("b"));
        }
    }
}
