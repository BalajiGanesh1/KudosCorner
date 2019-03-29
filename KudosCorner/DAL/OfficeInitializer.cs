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
            var kudos = new List<Kudo>
            {
            new Kudo{Image_Link="https://images.unsplash.com/photo-1504257365157-1496a50d48f2?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&w=1000&q=80",Description="Alexander",Title="Alexander Rocks"},
            new Kudo{Image_Link="https://images.unsplash.com/photo-1504257365157-1496a50d48f2?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&w=1000&q=80",Description="Alonso",Title="Alonso Rocks"},
            new Kudo{Image_Link="https://images.unsplash.com/photo-1504257365157-1496a50d48f2?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&w=1000&q=80",Description="Anand",Title="Anand wins grandmaster tournamentt"}
           
            };  

            kudos.ForEach(s => context.Kudos.Add(s));
            context.SaveChanges();

            var users = new List<User>
            {
            new User{ID=1050,UserName="Superman",EMail="Superman@gmail.com"},
            new User{ID=4022,UserName="Spiderman",EMail="Spiderman@gmail.com"}
           
            };
            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();

          /*  var wishes = new List<Wish>
            {
            new Wish{UserID=1,CourseID=1050,Grade=Grade.A},
            new Wish{UserID=1,CourseID=4022,Grade=Grade.C},
            new Wish{UserID=1,CourseID=4041,Grade=Grade.B},
            new Wish{UserID=2,CourseID=1045,Grade=Grade.B},
            new Wish{UserID=2,CourseID=3141,Grade=Grade.F},
            
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
            */

        }
    }
}