using Xunit;

namespace SomeProject.Tests
{
    public class SomeClassTests
    {
        [Theory]
        [InlineData(TimeOfDay.Morning)]
        [InlineData(TimeOfDay.Night)]
        public void Test(TimeOfDay timeOfDay)
        {
            SomeClass.Hello(timeOfDay);
        }
    }
}
