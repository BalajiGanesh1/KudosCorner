using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.Core;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace KudosCorner.Models
{
    public class PsiogUser
    {
        [Key]
        public int? PsiogUserID { get; set; }
        public string UserName { get; set; }
        public string EMail { get; set; }

        public virtual ICollection<Kudo> My_Achievements { get; set; }
        public virtual ICollection<Wish> My_Wishes { get; set; }

    }
}