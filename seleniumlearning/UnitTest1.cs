namespace seleniumlearning
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void sum()
        {
            int x = 1;
            int y = 6;
            int z = x + y;
        }
    }
}