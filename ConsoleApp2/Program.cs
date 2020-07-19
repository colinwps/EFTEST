using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2.Models;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            CDBContext dBContext = new CDBContext();
            var listUser = dBContext.userInfos.ToList();
            
        }
    }
}
