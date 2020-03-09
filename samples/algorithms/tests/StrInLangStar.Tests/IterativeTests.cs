using Xunit;
using Algorithms;

namespace StrInLangStar.Tests
{
    public class IterativeTest
    {
        [Fact]
        public void TestTrue()
        {
            Assert.True("aaa".IsInLanguageStarIterative("a"));
        }

        [Fact]
        public void TestFalse()
        {
            Assert.False("aaa".IsInLanguageStarIterative("b"));
        }
    }
}
