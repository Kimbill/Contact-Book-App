using ContactBook.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ContactBook.Data
{
    public class Seeder
    {
        public async static Task SeedData(RoleManager<IdentityRole> roleManager, UserManager<AppUser> userManager, ContactBookContext context)
        {
            try
            {
                var dirDb = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);


                await context.Database.EnsureCreatedAsync();
                if (!context.Users.Any())
                {
                    List<string> roles = new() { "Admin", "Regular" };
                    foreach (var role in roles)
                    {
                        await roleManager.CreateAsync(new IdentityRole { Name = role });
                    }



                    List<AppUser> users = new()
                    {
                     new AppUser
                     {
                         FirstName = "Ayo",
                         LastName = "Thomas",
                         Email = "daj@gmail.com",
                         UserName = "jjgh",
                         PhoneNumber = "080479379494"
                     },
                     new AppUser
                     {
                         FirstName = "Charles",
                         LastName = "Pearl",
                         Email = "chaley@gmail.com",
                         UserName = "Annie",
                         PhoneNumber = "080743979494"
                     },
                     new AppUser
                     {
                         FirstName = "Glenna",
                         LastName = "Waters",
                         Email = "glennawaters@roughies.com",
                         UserName = "Mcdaniel",
                         PhoneNumber = "+1 (848) 443-2870"
                     },
                     new AppUser
                     {
                         FirstName = "Vonda",
                         LastName = "Ramsey",
                         Email = "vondaramsey@roughies.com",
                         UserName = "Michael",
                         PhoneNumber = "+1 (828) 400-3241"
                     },
                     new AppUser
                     {
                         FirstName = "Mollie",
                         LastName = "Hewitt",
                         Email = "molliehewitt@roughies.com",
                         UserName = "Coleen",
                         PhoneNumber = "+1 (835) 549-2103"
                     },
                     new AppUser
                     {
                         FirstName = "Reyna",
                         LastName = "Chavez",
                         Email = "reynachavez@roughies.com",
                         UserName = "Cooper",
                         PhoneNumber = "+1 (958) 505-2869",
                     },
                     new AppUser
                     {
                         FirstName = "Ramona",
                         LastName = "Hines",
                         Email = "ramonahines@roughies.com",
                         UserName = "Amy",
                         PhoneNumber = "+1 (813) 579-2259",
                     },
                     new AppUser
                     {
                         FirstName = "Damon",
                         LastName = "Dash",
                         Email = "damonahines@roughies.com",
                         UserName = "Damondash",
                         PhoneNumber = "+1 (813) 539-2159",
                     },
                     new AppUser
                     {
                         FirstName = "Reed",
                         LastName = "Keller",
                         Email = "reedkeller@roughies.com",
                         UserName = "Sheena",
                         PhoneNumber = "+1 (959) 586-2171"
                     },
                     new AppUser
                     {
                         FirstName = "Pierce",
                         LastName = "Wilkerson",
                         Email = "piercewilkerson@roughies.com",
                         UserName = "Jan",
                         PhoneNumber = "+1 (800) 472-3639"
                     },
                     new AppUser
                     {
                         FirstName = "Pierre",
                         LastName = "Boznian",
                         Email = "pierreboz@roughies.com",
                         UserName = "BozPierre",
                         PhoneNumber = "+1 (860) 412-3629"
                     },
                     new AppUser
                     {
                         FirstName = "Mikavel",
                         LastName = "Wilkers",
                         Email = "mikavelwilker@roughies.com",
                         UserName = "Mikawil",
                         PhoneNumber = "+1 (814) 467-3639"
                     },
                     new AppUser
                     {
                         FirstName = "Savage",
                         LastName = "Langley",
                         Email = "savagelangley@roughies.com",
                         UserName = "Tonya",
                         PhoneNumber = "+1 (833) 567-3506"
                     },
                     new AppUser
                     {
                         FirstName = "Crawford",
                         LastName = "Vaughan",
                         Email = "crawfordvaughan@roughies.com",
                         UserName = "Jannie",
                         PhoneNumber = "+1 (821) 550-2612"
                     },
                     new AppUser
                     {
                         FirstName = "Gordon",
                         LastName = "Brennan",
                         Email = "gordonbrennan@roughies.com",
                         UserName = "William",
                         PhoneNumber = "+1 (864) 589-2150"
                     },
                     new AppUser
                     {
                         FirstName = "Walton",
                         LastName = "Holland",
                         Email = "waltonholland@roughies.com",
                         UserName = "Nell",
                         PhoneNumber = "+1 (952) 439-2584"
                     },
                     new AppUser
                     {
                         FirstName = "Jody",
                         LastName = "Dawson",
                         Email = "jodydawson@roughies.com",
                         UserName = "Kinney",
                         PhoneNumber = "+1 (919) 590-2619"
                     },
                     new AppUser
                     {
                         FirstName = "Burris",
                         LastName = "Carver",
                         Email = "burriscarver@roughies.com",
                         UserName = "Osborn",
                         PhoneNumber = "+1 (858) 578-2987"
                     },
                     new AppUser
                     {
                         FirstName = "Valeria",
                         LastName = "Meyers",
                         Email = "valeriameyers@roughies.com",
                         UserName = "Ashley",
                         PhoneNumber = "+1 (941) 475-3205"
                     },
                     new AppUser
                     {
                         FirstName = "Terrie",
                         LastName = "French",
                         Email = "terriefrench@roughies.com",
                         UserName = "Knight",
                         PhoneNumber = "+1 (961) 469-2281"
                     },
                     new AppUser
                     {
                         FirstName = "Mindy",
                         LastName = "Hopkins",
                         Email = "mindyhopkins@roughies.com",
                         UserName = "Rachel",
                         PhoneNumber = "+1 (927) 431-2553"
                     },
                     new AppUser
                     {
                         FirstName = "Key",
                         LastName = "Wilcox",
                         Email = "keywilcox@roughies.com",
                         UserName = "Geneva",
                         PhoneNumber = "+1 (874) 473-3137"
                     },
                     new AppUser
                     {
                         FirstName = "Margret",
                         LastName = "Goodwin",
                         Email = "margretgoodwin@roughies.com",
                         UserName = "Mckenzie",
                         PhoneNumber = "+1 (981) 465-3439",
                     }
                    };


                foreach (var user in users)
                    {
                        await userManager.CreateAsync(user, "P@ssw0rd");
                        if (user == users[0])
                        {
                            await userManager.AddToRoleAsync(user, "Admin");
                        }
                        else
                        {
                            await userManager.AddToRoleAsync(user, "Regular");
                        }

                    }

                }
            }
            catch (Exception Ex)
            {

                Console.WriteLine(Ex.Message); ;
            }
        }
    }
}
