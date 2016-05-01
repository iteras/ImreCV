using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using DAL.Repositories;
using Domain;

namespace DAL
{
   
        public class DatabaseInitializer : DropCreateDatabaseIfModelChanges<DataBaseContext>
        {
            protected override void Seed(DataBaseContext context)
            {

                
                

                Person imreTeras = new Person()
                {
                    PersonId = 0,
                    Firstname = "Imre",
                    Lastname = "Teras",
                    Age = 21,
                    BirthDate = Convert.ToDateTime("01/20/1995"),
                    Gender = Convert.ToChar("M"),
                    Address = "Pirni 4",
                    Email = "imreteras@gmail.com",
                    TelNr = "53012313",
                    EducationLevel = "GCSE",
                    Story = "Õpin hetkel 2. aasat IT Kolledžis ja sooviksin leida erialast tööd," +
                    "st mingit infothehnoloogiaga seotud eriala, nt veebiarendus, java arendus, .NET jne, " +
                    "või mingeid muid IT'ga seonduvaid erialasid. Meeldib õppida uusi ja erinevaid IT valdkondi. " +
                    " Meeldib lahendada keerukaid ülesandeid ja sel puhul luua erinevaid lahendusi probleemide lahenduseks. "

                };


                // Persons
                context.Persons.Add(imreTeras);

                context.SaveChanges();
                Person person = context.Persons.FirstOrDefault(a => a.PersonId == 0);
                

            context.ComputerSkills.Add(new ComputerSkill()
                {
                    PersonId = 0,
                    Person = imreTeras,
                    ComputerSkillId = 0,
                    ModerateSkills = ".NET, ASP.NET, Git, ASP.NET MVC Adobe Acrobat, C#, Hyper-V, Internet Explorer, Java, Linux, Mozilla, Firefox, MySQL, PHP,SQL",
                    NewbieSkills = "MS Access, Adobe Photoshop, C, Cisco,iOS, JavaScript, MathCAD, MS Outlook, Python, TCP/IPv4, TCP / IPv6, Windows Server 2012, Wordpress, XML",
                    SpecialistSkills = "CSS, Gmail, Google Chrome, HTML, MS Excel, MS PowerPoint, MS Word, OpenOffice, Windows XP, Windows NT/2000, Windows Vista/7, Windows 10"
                });

                context.SaveChanges();

                context.Educations.Add(new Education()
                {
                    PersonId = 0,
                    Person = imreTeras,
                    Name = "Keskharidus",
                    From = Convert.ToDateTime("09/01/2011"),
                    Until = Convert.ToDateTime("06/21/2014"),
                    Information = "Keskharidus omandatud",
                    SchoolName = "Võru Kreutzwaldi Gümnaasium"          
                });

                context.SaveChanges();

            context.Educations.Add(new Education()
            {
                PersonId = 0,
                Person = imreTeras,
                Name = "Süsteemide arendus ",
                From = Convert.ToDateTime("09/01/2014"),
                Until = Convert.ToDateTime("08/30/2017"),
                Information = "Õppinud siiani algteadmisi Javas, HTML'is, CSS'is, JavaScript'is ja MySqli's. Veel ka .NET ja ASP.NET ning natukene ka Unity5.",
                SchoolName = "Eesti Infotehnoloogia Kolledž"
            });

            context.SaveChanges();

            context.Expectations.Add(new Expectation()
                {
                    PersonId = 0,
                    Person = imreTeras,
                    DesiredJob = "arvutihooldaja, arvutitehnik, IT Spetsialist, programmeerija, tarkvara arendaja, tarkvara testija, tugiisik(IT)",
                    DesiredJobTime = "Osaline tööaeg, täistööaeg, erialane praktika, töö kooli kõrvalt, projektipõhine/vabakutseline, tähtajaline/hooajaline/ajutine töö, täistööaeg vahetustega",
                    Location = "Harjumaa / Tallinn",
                    PreferedJob = "Infotehnoloogia alane",
                    ExpectationId = 0
                });

                context.SaveChanges();

                context.Jobs.Add(new Job()
                {
                    PersonId = 0,
                    Person = imreTeras,
                    Company = "Meeskond OÜ",
                    From = Convert.ToDateTime("05/01/2014"),
                    Until = Convert.ToDateTime("05/1/2016"),
                    JobExplanation = "Turvamees, pileti kontroll, piirivalve, valve, patrull",
                    JobName = "Turvatöötaja",
                    PurposeOfLeaving = " - töötan veel",
                    StillWorking = true,
                    JobId = 0
                });
                context.SaveChanges();

                context.Jobs.Add(new Job()
                {
                    PersonId = 0,
                    Person = imreTeras,
                    Company = "Safety & Security OÜ",
                    From = Convert.ToDateTime("05/01/2014"),
                    Until = Convert.ToDateTime("05/1/2016"),
                    JobExplanation = "Liikluse reguleerimine suurürituste ajal, liikluse reguleerimine meeskonnas, parkimise korraldamine",
                    JobName = "Liiklusreguleerija",
                    PurposeOfLeaving = " - töötan veel",
                    StillWorking = true,
                    JobId = 1
                });
                context.SaveChanges();

                context.Jobs.Add(new Job()
                {
                    PersonId = 0,
                    Person = imreTeras,
                    Company = "Ritco OÜ",
                    From = Convert.ToDateTime("06/01/2012"),
                    Until = Convert.ToDateTime("08/1/2012"),
                    JobExplanation = "Pakkisin jalanõusid ja kontrollisin, et tooted poleks defektiga",
                    JobName = "Pakkija ja kvaliteedi inspektor",
                    PurposeOfLeaving = "Suve lõpp, kooli algus, suvetööperioodi lõpp",
                    StillWorking = false,
                    JobId = 2
                });

                context.SaveChanges();

                context.Jobs.Add(new Job()
                {
                    PersonId = 0,
                    Person = imreTeras,
                    Company = "Ritco OÜ",
                    From = Convert.ToDateTime("06/01/2011"),
                    Until = Convert.ToDateTime("08/1/2011"),
                    JobExplanation = "Pakkisin jalanõusid ja kontrollisin, et tooted poleks defektiga",
                    JobName = "Pakkija ja kvaliteedi inspektor",
                    PurposeOfLeaving = "Suve lõpp, kooli algus, suvetööperioodi lõpp",
                    StillWorking = false,
                    JobId = 3
                });

                context.Jobs.Add(new Job()
                {
                    PersonId = 0,
                    Person = imreTeras,
                    Company = "ESPAK AS",
                    From = Convert.ToDateTime("07/01/2013"),
                    Until = Convert.ToDateTime("08/1/2013"),
                    JobExplanation = "laotööline, laotöötaja, varustasin poodi toodetega, andsin kaupa välja, võtsin kaupa vastu",
                    JobName = "Laotöötaja",
                    PurposeOfLeaving = "töölepingu lõpp, tööajaks 1 kuu, et asendada haiguslehel olnud töötajat",
                    StillWorking = false,
                    JobId = 4
                });

                context.SaveChanges();

                context.Languages.Add(new Language()
                {
                    PersonId = 0,
                    Person = imreTeras,
                    Name = "Inglise keel",
                    Communication = "C1, väga hea",
                    LanguageId = 0,
                    Listening = "C1, väga hea",
                    Presentation = "C1, väga hea",
                    Reading = "C1, väga hea",
                    Writing = "C1, väga hea"
                });

                context.SaveChanges();

                context.Languages.Add(new Language()
                {
                    PersonId = 0,
                    Person = imreTeras,
                    Name = "Prantsuse keel",
                    Communication = "A2, vähene",
                    LanguageId = 1,
                    Listening = "A2, vähene",
                    Presentation = "A2, vähene",
                    Reading = "A1, napp",
                    Writing = "A1, napp"
                });

                context.SaveChanges();
                
                context.PersonAttributes.Add(new PersonAttribute()
                {
                    PersonId = 0,
                    Person = imreTeras,
                    Interrest = "Võrkpall, rulatamine, lumelauatamine, jooksmine, tarkvaraarendus, veebiarendus",
                    PersonAttributeId = 0,
                    Personality = "Kiire õppija, ei anna raskete ülesannet puhul alla, sihikindel, meeldib tegeleda keeruliste ülesannetega",
                    StrongSides = "Järjekindel, sihikindel, ei anna alla, proovin erinevaid lahendusi ja lähenemisi",
                    TouchNeedingSides = "Mitte üle mõtlemine"
                });
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

