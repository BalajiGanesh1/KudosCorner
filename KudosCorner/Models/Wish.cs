using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KudosCorner.Models
{
    public class Wish
    {
        [Key]
        public int? WishID { get; set; }

        public int ?PsiogUserID{ get; set; }
       
        public int ?KudoID{ get; set; }
        public string Message { get; set; }
        
        }
}