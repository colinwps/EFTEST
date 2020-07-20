using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2.Models;
using ConsoleApp2.MySqlModels;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            CMysqlDBContext K = new CMysqlDBContext();
            
            var list = K.userInfos.ToList();
            K.Dispose();

            CDBContext dBContext = new CDBContext();


            var listUser = dBContext.userInfos.ToList();

        }
    }
}
