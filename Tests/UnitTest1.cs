using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange 
            int dummy = 10;
            //Act
            int result = 10 * 10;
            //Assert
            Assert.IsTrue(result > 99);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange 
            int dummy = 10;
            //Act
            int result = 10 + 10;
            //Assert
            Assert.IsTrue(result == 20);
        }

        [TestMethod]
        public void TestMethod3()
        {
            //Arrange 
            int dummy = 10;
            //Act
            int result = 10 - 10;
            //Assert
            Assert.IsTrue(result == 0);
        }
    }
}
