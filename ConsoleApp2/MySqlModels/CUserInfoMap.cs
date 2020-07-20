﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace ConsoleApp2.MySqlModels
{
    public class CUserInfoMap:EntityTypeConfiguration<UserInfo>
    {
        public CUserInfoMap()
        {
            this.ToTable("userinfo");
            this.HasKey(t=>t.ID);
        }
    }
}
