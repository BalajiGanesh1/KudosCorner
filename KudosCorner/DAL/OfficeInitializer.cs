using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using KudosCorner.Models;


namespace KudosCorner.DAL
{
    public class OfficeInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<OfficeContext>
    {
        protected override void Seed(OfficeContext context)
        {
            User achiever1 = new User();
            achiever1.EMail = "KalpanaChawla@gmail.com";
            achiever1.UserName = "Kalpana Chawla";

            User user2 = new User();
            user2.EMail = "markzuckerburg@gmail.com";
            user2.UserName = " Zuckerberg";

            Wish wish1 = new Wish();
            wish1.UserID = user2.ID;
            wish1.Message = "Congrats Kalpana and Team!!!";
           

          
            Kudo kudo1 = new Kudo();
            wish1.KudoID = kudo1.ID;
            user2.My_Wishes.Add(wish1);
            kudo1.Image_Link = "https://images.pexels.com/photos/355906/pexels-photo-355906.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500";
            kudo1.Description = "NASA Launches rocket into space";
            kudo1.Achievers.Add(achiever1);
            kudo1.Congrats_Messages.Add(wish1);
            achiever1.My_Achievements.Add(kudo1);


            context.Kudos.Add(kudo1);
            context.Users.Add(achiever1);
            context.Users.Add(user2);
            context.SaveChanges();

         
        }
    }
}