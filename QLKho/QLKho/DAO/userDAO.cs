using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKho.DAO
{
    class userDAO
    {
        private static userDAO instance;

        internal static userDAO Instance
        {
            get { if (instance == null) instance = new userDAO(); return instance; }
            private set { instance = value; }
        }
        public int login(string username, string pass)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" select  dbo.login_user('" + username + "','" + pass +"')");
            return result;
        }
    }
}
