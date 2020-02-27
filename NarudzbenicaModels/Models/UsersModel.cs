using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NarudzbenicaModels.Models
{
    public class UsersModel
    {
        public  int ID { get; set; }
        public String UserName { get; set; }
        public String UserPassword { get; set; }
        public String Permission { get; set; } // It should be user level acces admin or user
        public DateTime Date { get; set; }
    }
}
