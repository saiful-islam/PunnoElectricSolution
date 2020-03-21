using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DotPOS.Service
{
    public class UserManagement
    {
        public bool IsValidUser(string _user,string _password)
        {
            try
            {
                DataOperation dataOperation = new DataOperation();
                string _query = "select Password from [desktop].[User] where UserName='" + _user + "'";
                SecurePasswordHasher obj = new SecurePasswordHasher();
                return obj.Verify(_password, dataOperation.GetDataTable(_query).Rows[0][0].ToString());
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
