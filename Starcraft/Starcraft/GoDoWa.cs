using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Starcraft
{
    public class GoDoWa
    {
        public string ReturnReturn(string[] x)
        {
            string strImsi = string.Empty;
            try
            {
                strImsi = x[0] + x[1];
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return strImsi;
        }

    }

}