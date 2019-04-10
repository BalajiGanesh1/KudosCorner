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
       /* protected override void Seed(OfficeContext context)
        {
            var wishes = new List<Wish>
            {
            new Wish{UserID=1050,KudoID=1,Message="Wow well done"},
            new Wish{UserID=1050,KudoID=1,Message="Good job buddy"},
            new Wish{UserID=1050,KudoID=2,Message="Fantastic!!!"},
            new Wish{UserID=4022,KudoID=2,Message="Great man!!!"},
            new Wish{UserID=4022,KudoID=3,Message="Keep it up!!"},

            };
            wishes.ForEach(s => context.Wishes.Add(s));


            var kudos = new List<Kudo>
            {
            new Kudo{Image_Link="https://images.unsplash.com/photo-1504257365157-1496a50d48f2?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&w=1000&q=80",Description="Alexander",Title="Alexander Rocks"},
            new Kudo{Image_Link="https://images.unsplash.com/photo-1504257365157-1496a50d48f2?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&w=1000&q=80",Description="Alonso",Title="Alonso Rocks"},
            new Kudo{Image_Link="https://images.unsplash.com/photo-1504257365157-1496a50d48f2?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&w=1000&q=80",Description="Anand",Title="Anand wins grandmaster tournament"}

            };

            kudos.ForEach(s => context.Kudos.Add(s));
            context.SaveChanges();

            var users = new List<PsiogUser>
            {
            //new PsiogUser{ID=1050,UserName="Superman",EMail="Superman@gmail.com"},
            //new PsiogUser{ID=4022,UserName="Spiderman",EMail="Spiderman@gmail.com"}

            };
            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();*/

            /* var wishes = new List<Wish>
             {
             new Wish{UserID=1050,KudoID=1,Message="Wow well done"},
             new Wish{UserID=1050,KudoID=1,Message="Good job buddy"},
             new Wish{UserID=1050,KudoID=2,Message="Fantastic!!!"},
             new Wish{UserID=4022,KudoID=2,Message="Great man!!!"},
             new Wish{UserID=4022,KudoID=3,Message="Keep it up!!"},

             };
             wishes.ForEach(s => context.Wishes.Add(s));
             context.SaveChanges();
             */
             

        
    }
}