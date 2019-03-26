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
        public int ID { get; set; }

        public int UserID{ get; set; }
        public int KudoID{ get; set; }
       public string Message { get; set; }
    }
}