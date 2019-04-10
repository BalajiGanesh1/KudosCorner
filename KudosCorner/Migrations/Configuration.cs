namespace KudosCorner.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using KudosCorner.Models;
    using System.Collections.Generic;
    

    internal sealed class Configuration : DbMigrationsConfiguration<KudosCorner.DAL.OfficeContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            //ContextKey = "KudosCorner.DAL.OfficeContext";
        }

        protected override void Seed(KudosCorner.DAL.OfficeContext context)
        {
           


            var kudos = new List<Kudo>
            {

            new Kudo{Image_Link="https://images.unsplash.com/photo-1504257365157-1496a50d48f2?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&w=1000&q=80",Description="Alexander blah blah blah",Title="Alexander Rocks"},
            new Kudo{Image_Link="https://images.unsplash.com/photo-1504257365157-1496a50d48f2?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&w=1000&q=80",Description="Alonso  blah blah blah",Title="Alonso Rocks"},
            new Kudo{Image_Link="https://images.unsplash.com/photo-1504257365157-1496a50d48f2?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&w=1000&q=80",Description="Anand  blah blah blah",Title="Anand wins grandmaster tournament"}

            };

            kudos.ForEach(s => context.Kudos.AddOrUpdate(p=>p.Description,s));
            context.SaveChanges();


            var users = new List<PsiogUser>
            {
              new PsiogUser{PsiogUserID=1050,UserName="Superman",EMail="Superman@gmail.com"},
              new PsiogUser{PsiogUserID=4022,UserName="Spiderman",EMail="Spiderman@gmail.com"}

            };
            /*foreach (PsiogUser user in users)
                {
                    var UserInDataBase = context.PsiogUsers.Where(
                    s =>
                       s.PsiogUserID == user.PsiogUserID).SingleOrDefault();
                       if(UserInDataBase==null)
                       {
                          context.PsiogUsers.Add(user);
                       }
  

                }*/
            users.ForEach(s => context.PsiogUsers.AddOrUpdate(p => p.UserName, s));
            context.SaveChanges();

            var wishes = new List<Wish>
            {
            new Wish{
                       PsiogUserID =users.Single(s=>s.UserName=="Superman").PsiogUserID,
                       KudoID =kudos.Single(s=>s.Description=="Alexander").KudoID,
                       Message ="Wow well done"
                    },
            new Wish{
                       PsiogUserID =users.Single(s=>s.UserName=="Superman").PsiogUserID,
                       KudoID =kudos.Single(s=>s.Description=="Alonso").KudoID,
                       Message ="Great job!"
                    },
            new Wish{
                        PsiogUserID =users.Single(s=>s.UserName=="Superman").PsiogUserID,
                        KudoID =kudos.Single(s=>s.Description=="Alexander").KudoID,
                        Message ="Fantastic bro"
                    },
            new Wish{
                        PsiogUserID =users.Single(s=>s.UserName=="Spiderman").PsiogUserID,
                        KudoID =kudos.Single(s=>s.Description=="Alonso").KudoID,
                        Message ="Proud of You!"
                    },
            new Wish{
                        PsiogUserID =users.Single(s=>s.UserName=="Spiderman").PsiogUserID,
                        KudoID =kudos.Single(s=>s.Description=="Alexander").KudoID,
                        Message ="Congratulations!!!!!"
                    },
            new Wish{
                        PsiogUserID =users.Single(s=>s.UserName=="Spiderman").PsiogUserID,
                        KudoID =kudos.Single(s=>s.Description=="Alonso").KudoID,
                        Message ="Super bro"
                    },
            new Wish{
                        PsiogUserID =users.Single(s=>s.UserName=="Spiderman").PsiogUserID,
                        KudoID =kudos.Single(s=>s.Description=="Anand").KudoID,
                        Message ="Wow!"
                    },


            };
            wishes.ForEach(s => context.Wishes.AddOrUpdate(p => p.Message, s));
            context.SaveChanges();
            }
        }
}
