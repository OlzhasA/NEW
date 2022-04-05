using NUnit.Framework;

namespace SeleniumLearning
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            TestContext.Progress.WriteLine("Setup execution");
        }

        [Test]
        public void Test1()
        {
            TestContext.Progress.WriteLine("execution OF TEST 1");
        }

        [Test]
        public void Test2()
        {
            TestContext.Progress.WriteLine("execution OF TEST 2");
        }

        [TearDown]

        public void CloseBrowser()
        {
            TestContext.Progress.WriteLine("Tear down method");
        }


    }
}