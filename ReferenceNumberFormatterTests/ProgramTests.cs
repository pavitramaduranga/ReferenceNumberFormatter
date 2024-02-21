using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod]
        public void TestIncrement_000002()
        {
            char[] input = "000002".ToCharArray();
            Program.Increment(input);
            Assert.AreEqual("000003", new string(input));
        }

        [TestMethod]
        public void TestIncrement_999999()
        {
            char[] input = "999999".ToCharArray();
            Program.Increment(input);
            Assert.AreEqual("000000", new string(input));
        }

        [TestMethod]
        public void TestIncrement_999899()
        {
            char[] input = "999899".ToCharArray();
            Program.Increment(input);
            Assert.AreEqual("999900", new string(input));
        }

        [TestMethod]
        public void TestIncrement_GL_321()
        {
            char[] input = "GL-321".ToCharArray();
            Program.Increment(input);
            Assert.AreEqual("GL-322", new string(input));
        }

        [TestMethod]
        public void TestIncrement_GL_999()
        {
            char[] input = "GL-999".ToCharArray();
            Program.Increment(input);
            Assert.AreEqual("GL-000", new string(input));
        }

        [TestMethod]
        public void TestIncrement_DRI000EDERS0RE()
        {
            char[] input = "DRI000EDERS0RE".ToCharArray();
            Program.Increment(input);
            Assert.AreEqual("DRI000EDERS0RE", new string(input));
        }

        [TestMethod]
        public void TestIncrement_DRI000EDERS0RE99999()
        {
            char[] input = "DRI000EDERS0RE99999".ToCharArray();
            Program.Increment(input);
            Assert.AreEqual("DRI000EDERS0RE00000", new string(input));
        }
    }
}