using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KudosCorner.Models
{
    public class Kudo
    {
        [Key]
        public int KudoID { get; set; }
      
        public string Image_Link { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        
       

        public virtual ICollection<PsiogUser> Achievers { get; set; }
        public virtual List<Wish> Congrats_Messages { get; set; }




    }
}