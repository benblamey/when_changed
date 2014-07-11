using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using when_changed;
using System.IO;
using System.Reflection;

namespace when_changed_tests
{
    [TestClass]
    public class arg_parser_test
    {
        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }



        [TestMethod]
        public void TestMethod1()
        {      
            var watcher = Program.createWatcher("C:/foo.txt");
            Assert.AreEqual(@"C:\", watcher.Path);
            Assert.AreEqual("foo.txt", watcher.Filter);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var watcher = Program.createWatcher("C:/*.txt");
            Assert.AreEqual(@"C:\", watcher.Path);
            Assert.AreEqual("*.txt", watcher.Filter);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var watcher = Program.createWatcher("C:/*");
            Assert.AreEqual(@"C:\", watcher.Path);
            Assert.AreEqual("*", watcher.Filter);
        }
    }
}
