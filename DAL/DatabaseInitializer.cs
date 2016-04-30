using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
   
        public class DatabaseInitializer : DropCreateDatabaseIfModelChanges<DataBaseContext>
        {
            protected override void Seed(DataBaseContext context)
            {
               

                context.SaveChanges();

                // Persons
                context.Persons.Add(new Person()
                {
                    Firstname = "1@eesti.ee",
                    Lastname = "1@eesti.ee",
                    Age = 21,
                    BirthDate = Convert.ToDateTime("01/20/1995"),
                    Gender = Convert.ToChar("M"),
                    Address = "Pirni 4",
                    Email = "imreteras@gmail.com",
                    TelNr = "53012313",
                    EducationLevel = "GCSE",
                    Story = "Õpin hetkel 2. aasat IT Kolledžis ja sooviksin leida erialast tööd,"+
                    "st mingit infothehnoloogiaga seotud eriala, nt veebiarendus, java arendus, .NET jne, "+
                    "või mingeid muid IT'ga seonduvaid erialasid. Meeldib õppida uusi ja erinevaid IT valdkondi. "+
                    " Meeldib lahendada keerukaid ülesandeid ja sel puhul luua erinevaid lahendusi probleemide lahenduseks. "
                });

                context.SaveChanges();

                


            /*
                context.Translations.Add(new Translation()
                {
                    Value = "<h1>ASP.NET on suurepärane!</h1>",
                    Culture = "et",
                    MultiLangString = article.ArticleHeadline
                });

                context.Translations.Add(new Translation()
                {
                    Value =
                        "<p class=\"lead\">ASP.NET on tasuta veebiraamistik suurepäraste veebide arendamiseks kasutades HTML-i, CSS-i, ja JavaScript-i.<br/>" +
                        "Demona on siin lihtne Kontaktirakendus - logi sisse ja salvesta enda kontakte</p>",
                    Culture = "et",
                    MultiLangString = article.ArticleBody
                });
                context.SaveChanges();



                context.ContactTypes.Add(new ContactType()
                {
                    ContactTypeName = new MultiLangString("Skype", "en", "Skype", "ContactType.0")
                });
                context.ContactTypes.Add(new ContactType()
                {
                    ContactTypeName = new MultiLangString("Email", "en", "Email", "ContactType.0")
                });
                context.ContactTypes.Add(new ContactType()
                {
                    ContactTypeName = new MultiLangString("Phone", "en", "Phone", "ContactType.0")
                });

                context.SaveChanges();

                //articleHeadLine = "<h1>ASP.NET</h1>";
                //articleBody =
                //    "<p class=\"lead\">ASP.NET on tasuta veebiraamistik suurepäraste veebide arendamiseks kasutades HTML-i, CSS-i, ja JavaScript-i.</p>";
                //article.ArticleHeadline = new MultiLangString(articleHeadLine, "et", articleHeadLine);
                //article.ArticleBody = new MultiLangString(articleBody, "et", articleBody);
                //context.Articles.Attach(article);
                //context.SaveChanges();
                */
                base.Seed(context);
            }
        }
    }
//}

