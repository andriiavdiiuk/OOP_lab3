
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.DAL.Models
{
    public class GameAccountModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public int CurrentRating { get; set; }
        public string AccountType { get; set; }
    }
}

