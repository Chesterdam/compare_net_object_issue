using System;
using System.Collections.Generic;

using KellermanSoftware.CompareNetObjects;
using Xunit;

namespace compare_net_object_issue
{
    public class UnitTest1
    {
        [Fact]
        public void TwoInequalObjectsShouldBeDetectedAsInequal()
        {
            CompareLogic compareLogic = new CompareLogic();

            var a = (1, new List<(string first, (string, int) second)> { ("foo", ("bar", 2)) });
            var b = (1, new List<(string first, (string, int) second)> { ("foo", ("foo", 2)) });

            var result = compareLogic.Compare(a, b);

            Assert.False(result.AreEqual);
        }
    }
}
