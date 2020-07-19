using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace ConsoleApp2.Models
{
    [Serializable]
    public class UserInfo
    {
        [Column("ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Column("UserID")]
        public string UserID { get; set; }
        [Column("UserName")]
        public string UserName { get; set; }
        [Column("UserDate")]
        public DateTime? UserDate { get; set; }
    }
}
