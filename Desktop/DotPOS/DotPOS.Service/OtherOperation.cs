using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DotPOS.Service
{
    public class OtherOperation
    {
        public string GetTextFromValue(string strValue)
        {
            if (string.IsNullOrEmpty(strValue.Trim()))
            {
                return "NULL";
            }
            else
            {
                return "'" + strValue + "'";
            }
        }
        public string GetNumericFromValue(string strValue)
        {
            if (string.IsNullOrEmpty(strValue.Trim()))
            {
                return "NULL";
            }
            else
            {
                return  strValue;
            }
        }
        
    }
}
