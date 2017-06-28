using Microsoft.VisualStudio.TestTools.UnitTesting;
using Starcraft;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starcraft.Tests
{
    [TestClass()]
    public class GoDoWaTests
    {
        [TestMethod()]
        public void ReturnReturnTest()
        {
            Starcraft.GoDoWa goDowa = new GoDoWa();
            string strTemp = string.Empty;
            strTemp = goDowa.ReturnReturn(new string[] { "저그와 ", "테란" });

            if (String.IsNullOrEmpty(strTemp))
            {
                Assert.Fail();
            }


        }

    }
}