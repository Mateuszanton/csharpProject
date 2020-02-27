using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace SecondProject.Exercise_8a
{
    [TestFixture] 
    class UnitTest
    {
        [Test]
        public void testMethod()
        {
            int x = 1;
            Assert.IsTrue(x.Equals(1));
        }
    }
}
