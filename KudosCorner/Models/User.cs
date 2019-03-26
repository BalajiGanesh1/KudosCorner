using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.Core;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace KudosCorner.Models
{
    public class User
    {
       
        public int ID;

        public List<int> AchievementsKudoID { get; set; }
        public List<int> WishesId { get; set; }
        public string UserName;
        public string EMail;

        public virtual ICollection<Kudo> My_Achievements { get; set; }
        public virtual ICollection<Wish> My_Wishes { get; set; }

    }
}