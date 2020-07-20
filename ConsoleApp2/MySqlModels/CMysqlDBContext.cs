using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MySql.Data.Entity;


namespace ConsoleApp2.MySqlModels
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class CMysqlDBContext:DbContext
    {
        public CMysqlDBContext():base("name = mysql")
        { }

        public DbSet<UserInfo> userInfos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CUserInfoMap());
        }
    }
}
