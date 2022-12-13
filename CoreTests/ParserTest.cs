using Core.Utils;
using Xunit;

namespace CoreTests
{
    public class ParserTest
    {
        [Fact]
        public void testStringParser()
        {
            Parser parser = new Parser();
            var result = parser.parseRaw("GUID 68e20133a5a944adaeb4c369876a9c1a\n\nHook_Tactical\n\nBlueprint_1_Build 27");
            Assert.NotNull(result);
            Assert.Equal(3, result.Count);
        }
    }
}