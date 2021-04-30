using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppXyrilleFirstSem.Web.Infrastructures.Domain.Data;

namespace WebAppXyrilleFirstSem.Web.Areas.Manage.Controllers
{
    public class DataInitController : Controller
    {
        private readonly DefaultDbContext _context;
        public DataInitController(DefaultDbContext context)
        {
            _context = context;
        }
        [HttpGet, Route("manage/data-init/execute")]
        public IActionResult DataInit()
        {
            #region Users(15 Records)
            if (this._context.Users.Count() < 1)
            {

                //1
                this._context.Users.Add(
                        new Infrastructures.Domain.Models.User()
                        {

                            Id = Guid.Parse("760be32a-efa7-4609-ba67-c665b2d421a0"),
                            FirstName = "Cd",
                            LastName = "Casupanan",
                            FullName = "CD Casupanan",
                            UserName = "cdbcasupanan",
                            EmailAddress = "cdbcasupanan@gmail.com",
                            Password = "123456789",
                            PhoneNumber = "123456789",
                            IsPublished = true,
                            UserStatus = Infrastructures.Domain.Enums.UserStatus.Active,
                            LoginRetries = 0,
                            Gender = Infrastructures.Domain.Enums.Gender.Male,
                            LoginStatus = Infrastructures.Domain.Enums.LoginStatus.Active,
                            Address = "Dinalupihan",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });

                //2
                this._context.Users.Add(
                        new Infrastructures.Domain.Models.User()
                        {

                            Id = Guid.Parse("045eb3d0-e601-43a6-a798-cac4b63065e0"),
                            FirstName = "Xyrille",
                            LastName = "Mamalateo",
                            FullName = "Xyrille Mamalateo",
                            UserName = "XyAnn",
                            EmailAddress = "Xyrille@gmail.com",
                            Password = "123456789",
                            PhoneNumber = "123456789",
                            IsPublished = true,
                            UserStatus = Infrastructures.Domain.Enums.UserStatus.Active,  
                            LoginRetries = 0,
                            Gender = Infrastructures.Domain.Enums.Gender.Female,
                            LoginStatus = Infrastructures.Domain.Enums.LoginStatus.Active,
                            Address = "Dinalupihan",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });

                //3
                this._context.Users.Add(
                        new Infrastructures.Domain.Models.User()
                        {

                            Id = Guid.Parse("9e67a70d-8591-4905-a32f-6581674ad74f"),
                            FirstName = "Joy",
                            LastName = "Flores",
                            FullName = "Joy Flores",
                            UserName = "JoyJoy",
                            EmailAddress = "Joy@gmail.com",
                            Password = "123456789",
                            PhoneNumber = "123456789",
                            IsPublished = true,
                            UserStatus = Infrastructures.Domain.Enums.UserStatus.Active,
                            LoginRetries = 0,
                            Gender = Infrastructures.Domain.Enums.Gender.Female,
                            LoginStatus = Infrastructures.Domain.Enums.LoginStatus.Active,
                            Address = "Dinalupihan",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });

                //4
                this._context.Users.Add(
                        new Infrastructures.Domain.Models.User()
                        {

                            Id = Guid.Parse("b1dcfc79-9116-4fa7-bf1c-9056ce3afa2c"),
                            FirstName = "Arwin",
                            LastName = "Tolentino",
                            FullName = "Arwin Tolentino",
                            UserName = "Arwin02",
                            EmailAddress = "Arwin@gmail.com",
                            Password = "123456789",
                            PhoneNumber = "123456789",
                            IsPublished = true,
                            UserStatus = Infrastructures.Domain.Enums.UserStatus.Active,
                            LoginRetries = 0,
                            Gender = Infrastructures.Domain.Enums.Gender.Male,
                            LoginStatus = Infrastructures.Domain.Enums.LoginStatus.Active,
                            Address = "Dinalupihan",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });

                //5
                this._context.Users.Add(
                        new Infrastructures.Domain.Models.User()
                        {

                            Id = Guid.Parse("e65217b1-dfd1-4c35-a9d1-bfac7855fdb6"),
                            FirstName = "Allan",
                            LastName = "Chavez",
                            FullName = "Allan Chavez",
                            UserName = "Allan",
                            EmailAddress = "Allan@gmail.com",
                            Password = "123456789",
                            PhoneNumber = "123456789",
                            IsPublished = true,
                            UserStatus = Infrastructures.Domain.Enums.UserStatus.Active,
                            LoginRetries = 0,
                            Gender = Infrastructures.Domain.Enums.Gender.Male,
                            LoginStatus = Infrastructures.Domain.Enums.LoginStatus.Active,
                            Address = "Dinalupihan",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });


                //6
                this._context.Users.Add(
                        new Infrastructures.Domain.Models.User()
                        {

                            Id = Guid.Parse("e5daef25-c0e9-4ad3-b850-9987edd692d6"),
                            FirstName = "Luisa",
                            LastName = "Reyes",
                            FullName = "Luisa Kathrina Reyes",
                            UserName = "LuisaKath",
                            EmailAddress = "Luisa@gmail.com",
                            Password = "123456789",
                            PhoneNumber = "123456789",
                            IsPublished = true,
                            UserStatus = Infrastructures.Domain.Enums.UserStatus.Active,
                            LoginRetries = 0,
                            Gender = Infrastructures.Domain.Enums.Gender.Female,
                            LoginStatus = Infrastructures.Domain.Enums.LoginStatus.Active,
                            Address = "Dinalupihan",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });


                //7
                this._context.Users.Add(
                        new Infrastructures.Domain.Models.User()
                        {

                            Id = Guid.Parse("06c0c4a1-20f2-4dd0-86a4-6344f3c9a0df"),
                            FirstName = "Larich",
                            LastName = "Morales",
                            FullName = "Larich Morales",
                            UserName = "Larich01",
                            EmailAddress = "larich@gmail.com",
                            Password = "123456789",
                            PhoneNumber = "123456789",
                            IsPublished = true,
                            UserStatus = Infrastructures.Domain.Enums.UserStatus.Active,
                            LoginRetries = 0,
                            Gender = Infrastructures.Domain.Enums.Gender.Female,
                            LoginStatus = Infrastructures.Domain.Enums.LoginStatus.Active,
                            Address = "Dinalupihan",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });


                //8
                this._context.Users.Add(
                        new Infrastructures.Domain.Models.User()
                        {

                            Id = Guid.Parse("f304533c-c31a-4050-930e-bc05a1f49c6c"),
                            FirstName = "Jane",
                            LastName = "Ticar",
                            FullName = "Jane Ticar",
                            UserName = "Jane02",
                            EmailAddress = "jane@gmail.com",
                            Password = "123456789",
                            PhoneNumber = "123456789",
                            IsPublished = true,
                            UserStatus = Infrastructures.Domain.Enums.UserStatus.Active,
                            LoginRetries = 0,
                            Gender = Infrastructures.Domain.Enums.Gender.Female,
                            LoginStatus = Infrastructures.Domain.Enums.LoginStatus.Active,
                            Address = "Dinalupihan",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });


                //9
                this._context.Users.Add(
                        new Infrastructures.Domain.Models.User()
                        {

                            Id = Guid.Parse("4337265c-30c7-46e7-acce-4eb125602bfe"),
                            FirstName = "Wesley",
                            LastName = "SA",
                            FullName = "Wesley SA",
                            UserName = "Wesley03",
                            EmailAddress = "Wesley@gmail.com",
                            Password = "123456789",
                            PhoneNumber = "123456789",
                            IsPublished = true,
                            UserStatus = Infrastructures.Domain.Enums.UserStatus.Active,
                            LoginRetries = 0,
                            Gender = Infrastructures.Domain.Enums.Gender.Male,
                            LoginStatus = Infrastructures.Domain.Enums.LoginStatus.Active,
                            Address = "Dinalupihan",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });


                //10
                this._context.Users.Add(
                        new Infrastructures.Domain.Models.User()
                        {

                            Id = Guid.Parse("f5a96d61-99b3-4410-a2cd-035a70b06ad0"),
                            FirstName = "Reniel ",
                            LastName = "David",
                            FullName = "Reniel David",
                            UserName = "Reniel04",
                            EmailAddress = "Reniel@gmail.com",
                            Password = "123456789",
                            PhoneNumber = "123456789",
                            IsPublished = true,
                            UserStatus = Infrastructures.Domain.Enums.UserStatus.Active,
                            LoginRetries = 0,
                            Gender = Infrastructures.Domain.Enums.Gender.Male,
                            LoginStatus = Infrastructures.Domain.Enums.LoginStatus.Active,
                            Address = "Dinalupihan",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });


                //11
                this._context.Users.Add(
                        new Infrastructures.Domain.Models.User()
                        {

                            Id = Guid.Parse("40a468e3-37f9-4921-bd27-a0e6b83d35e0"),
                            FirstName = "Jhon Cedric",
                            LastName = "Romano",
                            FullName = "Jhon Cedric Romano",
                            UserName = "Jhon06",
                            EmailAddress = "Jhon@gmail.com",
                            Password = "123456789",
                            PhoneNumber = "123456789",
                            IsPublished = true,
                            UserStatus = Infrastructures.Domain.Enums.UserStatus.Active,
                            LoginRetries = 0,
                            Gender = Infrastructures.Domain.Enums.Gender.Male,
                            LoginStatus = Infrastructures.Domain.Enums.LoginStatus.Active,
                            Address = "Dinalupihan",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });


                //12
                this._context.Users.Add(
                        new Infrastructures.Domain.Models.User()
                        {

                            Id = Guid.Parse("46f3f0a0-9d0b-418e-a23c-205c3066fa36"),
                            FirstName = "Elmo",
                            LastName = "Cahilo",
                            FullName = "Elmo Cahilo",
                            UserName = "Elmo07",
                            EmailAddress = "Elmo@gmail.com",
                            Password = "123456789",
                            PhoneNumber = "123456789",
                            IsPublished = true,
                            UserStatus = Infrastructures.Domain.Enums.UserStatus.Active,
                            LoginRetries = 0,
                            Gender = Infrastructures.Domain.Enums.Gender.Male,
                            LoginStatus = Infrastructures.Domain.Enums.LoginStatus.Active,
                            Address = "Dinalupihan",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });


                //13
                this._context.Users.Add(
                        new Infrastructures.Domain.Models.User()
                        {

                            Id = Guid.Parse("818d1f76-5917-4d5f-8c2b-9131337ac785"),
                            FirstName = "Jake Renzo",
                            LastName = "Carlos",
                            FullName = "Jake Renzo Carlos",
                            UserName = "Jake08",
                            EmailAddress = "Jake@gmail.com",
                            Password = "123456789",
                            PhoneNumber = "123456789",
                            IsPublished = true,
                            UserStatus = Infrastructures.Domain.Enums.UserStatus.Active,
                            LoginRetries = 0,
                            Gender = Infrastructures.Domain.Enums.Gender.Male,
                            LoginStatus = Infrastructures.Domain.Enums.LoginStatus.Active,
                            Address = "Dinalupihan",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });


                //14
                this._context.Users.Add(
                        new Infrastructures.Domain.Models.User()
                        {

                            Id = Guid.Parse("803c0574-0df3-481e-813f-5673f8fe5d6b"),
                            FirstName = "Christian",
                            LastName = "Cruz",
                            FullName = "Christian Cruz",
                            UserName = "Christian09",
                            EmailAddress = "Christian@gmail.com",
                            Password = "123456789",
                            PhoneNumber = "123456789",
                            IsPublished = true,
                            UserStatus = Infrastructures.Domain.Enums.UserStatus.Active,
                            LoginRetries = 0,
                            Gender = Infrastructures.Domain.Enums.Gender.Male,
                            LoginStatus = Infrastructures.Domain.Enums.LoginStatus.Active,
                            Address = "Dinalupihan",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });


                //15
                this._context.Users.Add(
                        new Infrastructures.Domain.Models.User()
                        {

                            Id = Guid.Parse("ac7883a2-4d94-450f-896a-5dd2f72061d7"),
                            FirstName = "MAMA",
                            LastName = "KO",
                            FullName = "MAMA KO",
                            UserName = "MAMA00",
                            EmailAddress = "mama@gmail.com",
                            Password = "123456789",
                            PhoneNumber = "123456789",
                            IsPublished = true,
                            UserStatus = Infrastructures.Domain.Enums.UserStatus.Active,
                            LoginRetries = 0,
                            Gender = Infrastructures.Domain.Enums.Gender.Female,
                            LoginStatus = Infrastructures.Domain.Enums.LoginStatus.Active,
                            Address = "Dinalupihan",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });
            }
            #endregion


            #region UserRole(15 Records)
            if (this._context.UserRoles.Count() < 1)
            {

                //1
                this._context.UserRoles.Add(
                        new Infrastructures.Domain.Models.UserRole()
                        {

                            Id = Guid.Parse("ddbe6a59-8faa-4c0a-85ad-20e9bcbca067"),
                            UserId = Guid.Parse("760be32a-efa7-4609-ba67-c665b2d421a0"),

                            Role = Infrastructures.Domain.Enums.Role.User,
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,

                        });

                //2
                this._context.UserRoles.Add(
                        new Infrastructures.Domain.Models.UserRole()
                        {

                            Id = Guid.Parse("4c596d7f-260b-4057-bd43-b97c9069c929"),
                            UserId = Guid.Parse("045eb3d0-e601-43a6-a798-cac4b63065e0"),
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,
                            Role = Infrastructures.Domain.Enums.Role.User,




                        });

                //3
                //2
                this._context.UserRoles.Add(
                        new Infrastructures.Domain.Models.UserRole()
                        {
                            Id = Guid.Parse("50b9c48e-4ad8-4c08-b921-7f43c2157b82"),
                            UserId = Guid.Parse("9e67a70d-8591-4905-a32f-6581674ad74f"),
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,
                            Role = Infrastructures.Domain.Enums.Role.User,

                        });

                //4
                this._context.UserRoles.Add(
                         new Infrastructures.Domain.Models.UserRole()
                         {

                             Id = Guid.Parse("eae98ee4-07ca-483e-a725-55821fbd82a9"),
                             UserId = Guid.Parse("b1dcfc79-9116-4fa7-bf1c-9056ce3afa2c"),
                             CreatedAt = DateTime.UtcNow,
                             UpdatedAt = DateTime.UtcNow,
                             Role = Infrastructures.Domain.Enums.Role.User,

                         });

                //5
                this._context.UserRoles.Add(
                         new Infrastructures.Domain.Models.UserRole()
                         {

                             Id = Guid.Parse("b910ad99-616c-4d02-9af3-d9c9fb7d7c0f"),
                             UserId = Guid.Parse("e65217b1-dfd1-4c35-a9d1-bfac7855fdb6"),
                             CreatedAt = DateTime.UtcNow,
                             UpdatedAt = DateTime.UtcNow,
                             Role = Infrastructures.Domain.Enums.Role.User,

                         });


                //6
                this._context.UserRoles.Add(
                         new Infrastructures.Domain.Models.UserRole()
                         {
                             Id = Guid.Parse("eb7b5492-6f6d-41a2-858f-0f96f6d2880c"),
                             UserId = Guid.Parse("e5daef25-c0e9-4ad3-b850-9987edd692d6"),
                             CreatedAt = DateTime.UtcNow,
                             UpdatedAt = DateTime.UtcNow,
                             Role = Infrastructures.Domain.Enums.Role.User,

                         });


                //7
                this._context.UserRoles.Add(
                         new Infrastructures.Domain.Models.UserRole()
                         {

                         


                             Id = Guid.Parse("ee0cc3ba-37c8-4aba-b3ba-e5c39270a9c1"),
                             UserId = Guid.Parse("06c0c4a1-20f2-4dd0-86a4-6344f3c9a0df"),
                             CreatedAt = DateTime.UtcNow,
                             UpdatedAt = DateTime.UtcNow,
                             Role = Infrastructures.Domain.Enums.Role.User,


                         });


                //8
                this._context.UserRoles.Add(
                        new Infrastructures.Domain.Models.UserRole()
                        {

    
                            Id = Guid.Parse("417ea373-6a44-42a8-9dad-4fc8ab76ed11"),
                            UserId = Guid.Parse("f304533c-c31a-4050-930e-bc05a1f49c6c"),
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,
                            Role = Infrastructures.Domain.Enums.Role.User,
                        });


                //9
                this._context.UserRoles.Add(
                      new Infrastructures.Domain.Models.UserRole()
                      {

                         
                          Id = Guid.Parse("2cdf8e2a-455d-443b-9bbe-1129a2842b2c"),
                          UserId = Guid.Parse("4337265c-30c7-46e7-acce-4eb125602bfe"),
                          CreatedAt = DateTime.UtcNow,
                          UpdatedAt = DateTime.UtcNow,
                          Role = Infrastructures.Domain.Enums.Role.User,


                      });


                //10
                this._context.UserRoles.Add(
                     new Infrastructures.Domain.Models.UserRole()
                     {
                         Id = Guid.Parse("819b71af-585e-4912-9855-c1b41d8a7152"),
                         UserId = Guid.Parse("f5a96d61-99b3-4410-a2cd-035a70b06ad0"),
                         CreatedAt = DateTime.UtcNow,
                         UpdatedAt = DateTime.UtcNow,
                         Role = Infrastructures.Domain.Enums.Role.User,

                     });


                //11
                this._context.UserRoles.Add(
                   new Infrastructures.Domain.Models.UserRole()
                   {
                       Id = Guid.Parse("710e4799-bd48-4f5f-9e3f-60d28869c3f4"),
                       UserId = Guid.Parse("40a468e3-37f9-4921-bd27-a0e6b83d35e0"),
                       CreatedAt = DateTime.UtcNow,
                       UpdatedAt = DateTime.UtcNow,
                       Role = Infrastructures.Domain.Enums.Role.User,

                   });


                //12
                this._context.UserRoles.Add(
                   new Infrastructures.Domain.Models.UserRole()
                   {
                       Id = Guid.Parse("068c3962-9d58-4619-9a06-9b620dd443ee"),
                       UserId = Guid.Parse("46f3f0a0-9d0b-418e-a23c-205c3066fa36"),
                       CreatedAt = DateTime.UtcNow,
                       UpdatedAt = DateTime.UtcNow,
                       Role = Infrastructures.Domain.Enums.Role.User,


                   });


                //13
                this._context.UserRoles.Add(
                    new Infrastructures.Domain.Models.UserRole()
                    {

                        Id = Guid.Parse("5c525682-50b6-4df5-bd9a-a6f4a416e794"),
                        UserId = Guid.Parse("818d1f76-5917-4d5f-8c2b-9131337ac785"),
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        Role = Infrastructures.Domain.Enums.Role.User,



                    });


                //14
                this._context.UserRoles.Add(
                    new Infrastructures.Domain.Models.UserRole()
                    {

                        
                        Id = Guid.Parse("0d4a3e3b-cea2-46d0-a900-bf767c89ee34"),
                        UserId = Guid.Parse("803c0574-0df3-481e-813f-5673f8fe5d6b"),
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        Role = Infrastructures.Domain.Enums.Role.User,

                    });


                //15
                this._context.UserRoles.Add(
                    new Infrastructures.Domain.Models.UserRole()
                    {

                        Id = Guid.Parse("bd811377-4123-48c3-98e1-c5b2715a2842"),
                        UserId = Guid.Parse("ac7883a2-4d94-450f-896a-5dd2f72061d7"),
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        Role = Infrastructures.Domain.Enums.Role.User,
                    });
            }
            #endregion

            #region Author(15 Records)
            if (this._context.Authors.Count() < 1)
            {

                //1
                this._context.Authors.Add(
                        new Infrastructures.Domain.Models.Author()
                        {

                            Id = Guid.Parse("a209fc2a-cbae-4ebc-acb7-2673eb3cb3a5"),
                            ResearchId = Guid.Parse("54058afb-b60c-430f-915b-61a98feac82a"),
                            UserId = Guid.Parse("760be32a-efa7-4609-ba67-c665b2d421a0"),
                            Name = "CD Casupanan",
                            IsPublished = true,
                            AuthorStatus = Infrastructures.Domain.Enums.AuthorStatus.Active,
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });

                //2
                this._context.Authors.Add(
                        new Infrastructures.Domain.Models.Author()
                        {

                            Id = Guid.Parse("c49f9d1e-16ad-485c-870e-23e0ef091525"),
                            ResearchId = Guid.Parse("e87e08f4-3326-4c57-8158-bba51f0d4e3e"),
                            UserId = Guid.Parse(" 045eb3d0-e601-43a6-a798-cac4b63065e0"),
                            Name = "Xyrille Mamalateo",
                            IsPublished = true,
                            AuthorStatus = Infrastructures.Domain.Enums.AuthorStatus.Active,
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });

                //3
                this._context.Authors.Add(
                        new Infrastructures.Domain.Models.Author()
                        {

                            Id = Guid.Parse("98ab3f66-5594-4be8-9689-40e4db8cb0cb"),
                            ResearchId = Guid.Parse("d80810c0-5f4d-4a89-96a0-457aae5802a1"),
                            UserId = Guid.Parse("9e67a70d-8591-4905-a32f-6581674ad74f"),
                            Name = "Joy Flores",
                            IsPublished = true,
                            AuthorStatus = Infrastructures.Domain.Enums.AuthorStatus.Active,
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,



                        });

                //4
                this._context.Authors.Add(
                        new Infrastructures.Domain.Models.Author()
                        {

                            Id = Guid.Parse("ef9f60fe-41b7-47cf-a039-c6b0cb8f8daf"),
                            ResearchId = Guid.Parse("11f06c86-3868-46ae-abff-99fb07212ff1"),
                            UserId = Guid.Parse("b1dcfc79-9116-4fa7-bf1c-9056ce3afa2c"),
                            Name = "Arwin Tolentino",
                            IsPublished = true,
                            AuthorStatus = Infrastructures.Domain.Enums.AuthorStatus.Active,
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });

                //5
                this._context.Authors.Add(
                        new Infrastructures.Domain.Models.Author()
                        {

                            Id = Guid.Parse("bbbe3442-78e7-49e7-b9bf-dec85942ce25"),
                            ResearchId = Guid.Parse(" d6539917-3730-4c69-ac84-7215e74fa212"),
                            UserId = Guid.Parse("e65217b1-dfd1-4c35-a9d1-bfac7855fdb6"),
                            Name = "Allan Chavez",
                            IsPublished = true,
                            AuthorStatus = Infrastructures.Domain.Enums.AuthorStatus.Active,
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });

                //6
                this._context.Authors.Add(
                        new Infrastructures.Domain.Models.Author()
                        {

                            Id = Guid.Parse("2b24bba7-c207-459d-b0b5-7360bef40ae2"),
                            ResearchId = Guid.Parse("155deaeb-7c82-412b-8fc0-bf900c7cce69"),
                            UserId = Guid.Parse("e5daef25-c0e9-4ad3-b850-9987edd692d6"),
                            Name = "Luisa Kathrina Reyes",
                            IsPublished = true,
                            AuthorStatus = Infrastructures.Domain.Enums.AuthorStatus.Active,
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });

                //7
                this._context.Authors.Add(
                        new Infrastructures.Domain.Models.Author()
                        {

                            Id = Guid.Parse("a3964eeb-6641-4f78-9930-f200fe77a08b"),
                            ResearchId = Guid.Parse("41f3e0a4-c890-49ca-8d0d-6e83ec175c19"),
                            UserId = Guid.Parse("06c0c4a1-20f2-4dd0-86a4-6344f3c9a0df"),
                            Name = "Larich Morales",
                            IsPublished = true,
                            AuthorStatus = Infrastructures.Domain.Enums.AuthorStatus.Active,
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });

                //8
                this._context.Authors.Add(
                        new Infrastructures.Domain.Models.Author()
                        {

                            Id = Guid.Parse("2881f179-97a1-4387-88bf-cb123f5f5317"),
                            ResearchId = Guid.Parse("a55bc92f-175f-49d3-8710-afd7914a0020"),
                            UserId = Guid.Parse("f304533c-c31a-4050-930e-bc05a1f49c6c"),
                            Name = "Jane Ticar",
                            IsPublished = true,
                            AuthorStatus = Infrastructures.Domain.Enums.AuthorStatus.Active,
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });

                //9
                this._context.Authors.Add(
                        new Infrastructures.Domain.Models.Author()
                        {

                            Id = Guid.Parse("cd096ff5-6719-4c96-bc01-9b2d467d2b96"),
                            ResearchId = Guid.Parse("71a26e12-c4db-4d72-ab0c-6fc4e21a2a1f"),
                            UserId = Guid.Parse("4337265c-30c7-46e7-acce-4eb125602bfe"),
                            Name = "Wesley SA",
                            IsPublished = true,
                            AuthorStatus = Infrastructures.Domain.Enums.AuthorStatus.Active,
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });

                //10
                this._context.Authors.Add(
                        new Infrastructures.Domain.Models.Author()
                        {

                            Id = Guid.Parse("cdfd46e0-5383-42b8-b53d-e522061f8348"),
                            ResearchId = Guid.Parse("2f7ac734-a784-4a63-bf0e-f6557bbff618"),
                            UserId = Guid.Parse("f5a96d61-99b3-4410-a2cd-035a70b06ad0"),
                            Name = "Reniel David",
                            IsPublished = true,
                            AuthorStatus = Infrastructures.Domain.Enums.AuthorStatus.Active,
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });

                //11
                this._context.Authors.Add(
                        new Infrastructures.Domain.Models.Author()
                        {

                            Id = Guid.Parse("d434f808-3f7a-48f4-97e3-57555f13384c"),
                            ResearchId = Guid.Parse("b899fac8-c326-4ecd-980b-6feee235012f"),
                            UserId = Guid.Parse("40a468e3-37f9-4921-bd27-a0e6b83d35e0"),
                            Name = "Jhon Cedric Romano",
                            IsPublished = true,
                            AuthorStatus = Infrastructures.Domain.Enums.AuthorStatus.Active,
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });

                //12
                this._context.Authors.Add(
                        new Infrastructures.Domain.Models.Author()
                        {

                            Id = Guid.Parse("78f58bab-0ba6-4d39-a83d-759023f2f59f"),
                            ResearchId = Guid.Parse("d9d57977-b7cd-44fd-a145-612378f347b4"),
                            UserId = Guid.Parse("46f3f0a0-9d0b-418e-a23c-205c3066fa36"),
                            Name = "Elmo Cahilo",
                            IsPublished = true,
                            AuthorStatus = Infrastructures.Domain.Enums.AuthorStatus.Active,
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,



                        });

                //13
                this._context.Authors.Add(
                        new Infrastructures.Domain.Models.Author()
                        {

                            Id = Guid.Parse("ba7e0509-060f-4334-86c0-c11b6af049ea"),
                            ResearchId = Guid.Parse("d75eaa81-bb08-4bef-a235-b81a471127eb"),
                            UserId = Guid.Parse("818d1f76-5917-4d5f-8c2b-9131337ac785"),
                            Name = "Jake Renzo Carlos",
                            IsPublished = true,
                            AuthorStatus = Infrastructures.Domain.Enums.AuthorStatus.Active,
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });

                //14
                this._context.Authors.Add(
                        new Infrastructures.Domain.Models.Author()
                        {

                            Id = Guid.Parse("967e82f0-f38e-4a95-8071-5b92e16f0afa"),
                            ResearchId = Guid.Parse("1be0d018-351c-4ea7-8721-9aaae265e276"),
                            UserId = Guid.Parse("803c0574-0df3-481e-813f-5673f8fe5d6b"),
                            Name = "Christian Cruz",
                            IsPublished = true,
                            AuthorStatus = Infrastructures.Domain.Enums.AuthorStatus.Active,
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,



                        });

                //15
                this._context.Authors.Add(
                        new Infrastructures.Domain.Models.Author()
                        {

                            Id = Guid.Parse("7e78ca67-b3ba-4077-a4ee-3069e8d62d57"),
                            ResearchId = Guid.Parse("5253ae80-8f2f-409e-8a94-7c375bdceeaa"),
                            UserId = Guid.Parse("ac7883a2-4d94-450f-896a-5dd2f72061d7"),
                            Name = "MAMA KO",
                            IsPublished = true,
                            AuthorStatus = Infrastructures.Domain.Enums.AuthorStatus.Active,
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,



                        });
            }
            #endregion

            #region Research(15 Records)
            if (this._context.Researches.Count() < 1)
            {

                //1
                this._context.Researches.Add(
                        new Infrastructures.Domain.Models.Research()
                        {

                            Id = Guid.Parse("54058afb-b60c-430f-915b-61a98feac82a"),
                            AuthorId = Guid.Parse("a209fc2a-cbae-4ebc-acb7-2673eb3cb3a5"),
                            Title = "Video Game Addiction and College Performance Among Males: Results from a 1 Year Longitudinal Study",
                            Content = "“This study explored the pattern of video game usage and video game addiction among male college students and examined how video game addiction was related to expectations of college engagement, college grade point average (GPA), and on-campus drug and alcohol violations. Participants were 477 male, first year students at a liberal arts college. In the week before the start of classes, participants were given two surveys: one of expected college engagement, and the second of video game usage, including a measure of video game addiction. Results suggested that video game addiction is (a) negatively correlated with expected college engagement, (b) negatively correlated with college GPA, even when controlling for high school GPA, and (c) negatively correlated with drug and alcohol violations that occurred during the first year in college. Results are discussed in terms of implications for male students’ engagement and success in college, and in terms of the construct validity of video game addiction.”",
                            Description = "This study explored the pattern of video game usage and video game addiction among male college students and examined how video game addiction was related to expectations of college engagement, college grade point average (GPA), and on-campus drug and alcohol violations.",
                            ResearchStatus = Infrastructures.Domain.Enums.ResearchStatus.Available,
                            IsPublished = true,
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });

                //2
                this._context.Researches.Add(
                        new Infrastructures.Domain.Models.Research()
                        {

                            Id = Guid.Parse("e87e08f4-3326-4c57-8158-bba51f0d4e3e"),
                            AuthorId = Guid.Parse("c49f9d1e-16ad-485c-870e-23e0ef091525"),
                            Title = "Study Skills and their Correlation with Academic Satisfaction and Achievement among Medical and Pharmacy Students in Kermanshah University of Medical Sciences (2013)",
                            Content = "Introduction: Study skills and students’ satisfaction with their performance positively affect their academic achievement. The current research was carried out to investigate the correlation of study skills with academic achievement among the medical and pharmacy students in 2013." +
                            "Methods: This descriptive-analytical study was conducted on 148 students of basic medical sciences and pharmacy through convenience sampling. Data were collected by a valid and reliable questionnaire, consisting of two sections: Demographic information and questions about daily study hours, study skills in six domains, and students’ satisfaction with study skills. Collected data sets were analyzed by SPSS-16 software" +
                            "Results: In total, 10.9% of students were reported to have favorable study skills. The minimum score was found for preparation for examination domain. Also, a significantly positive correlation was observed between students’ study skills and their Grade Point Average (GPA) of previous term (P=0.001, r=0.269) and satisfaction with study skills (P=0.001, r=0.493)." +
                            "Results: In total, 10.9% of students were reported to have favorable study skills. The minimum score was found for preparation for examination domain. Also, a significantly positive correlation was observed between students’ study skills and their Grade Point Average (GPA) of previous term (P=0.001, r=0.269) and satisfaction with study skills (P=0.001, r=0.493)." +
                            "",
                            Description = "“Introduction: Study skills and students’ satisfaction with their performance positively affect their academic achievement. The current research was carried out to investigate the correlation of study skills with academic achievement among the medical and pharmacy students in 2013.",
                            ResearchStatus = Infrastructures.Domain.Enums.ResearchStatus.Available,
                            IsPublished = true,
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });

                //3
                this._context.Researches.Add(
                        new Infrastructures.Domain.Models.Research()
                        {

                            Id = Guid.Parse("d80810c0-5f4d-4a89-96a0-457aae5802a1"),
                            AuthorId = Guid.Parse("98ab3f66-5594-4be8-9689-40e4db8cb0cb"),
                            Title = "The Sandra Bland story: How social media has exposed the harsh reality of police brutality",
                            Content = "This quantitative research study was conducted to illustrate the relationship(s) between social media use and its effect on police brutality awareness. In 2015, social media was used to assist in revealing an act of impulsive police brutality on an adult black woman in Waller County, Texas. This act was one of a few examples of a substantial number of law enforcement officers around the United States and other countries that are abusing their power by using excessive force against citizens without penalty. The study found there is a relationship between social media use and its impact on police brutality. The study also found that social media gave a voice to people who may have feared isolation and/or negative consequences against police brutality. Over 100 undergraduates at Bowie State University in Maryland completed a survey questionnaire instrument. The instrument consisted of 10; of which 2 were directly related to the hypothesis. The author’s result of data analyses presented that there is a significant relationship between independent and dependent variables.",
                            Description = "“This quantitative research study was conducted to illustrate the relationship(s) between social media use and its effect on police brutality awareness.",
                            ResearchStatus = Infrastructures.Domain.Enums.ResearchStatus.Available,
                            IsPublished = true,
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });

                //4
                this._context.Researches.Add(
                        new Infrastructures.Domain.Models.Research()
                        {

                            Id = Guid.Parse("11f06c86-3868-46ae-abff-99fb07212ff1"),
                            AuthorId = Guid.Parse("ef9f60fe-41b7-47cf-a039-c6b0cb8f8daf"),
                            Title = "An Examination of Concussion Injury Rates in Various Models of Football Helmets in NCAA Football Athletes",
                            Content = "While newer, advanced helmet models have been designed with the intentions of decreasing concussions, very little research exists on injury rates in various football helmets at the collegiate level. The aim of this study was to examine concussion injury rates in various models of football helmets in collegiate football athletes. In addition, to compare injury rates of newer, advanced football helmets to older, traditional helmets among collegiate football athletes, a total of 209 concussions and 563,701 AEs (athlete-exposures) Among 2,107 collegiate football athletes in seven helmet models were included in the analyses. Concussion injury rates revealed that the Riddell Revolution® had the highest rate of 0.41 concussions per 1,000 AEs. The Schutt ION 4D TM helmet had the lowest rate of 0.25 concussions per 1,000 AEs. These newer helmet models did not significantly differ from one another (P=0.74), however all models significantly differed from the older, traditional helmet model (P<0.001). The findings of this study suggest that concussion rates do not differ between newer and more advanced helmet models. More importantly, there are currently no helmets available to prevent concussions from occurring in football athletes.",
                            Description = "While newer, advanced helmet models have been designed with the intentions of decreasing concussions, very little research exists on injury rates in various football helmets at the collegiate level.",
                            ResearchStatus = Infrastructures.Domain.Enums.ResearchStatus.Available,
                            IsPublished = true,
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });

                //5
                this._context.Researches.Add(
                        new Infrastructures.Domain.Models.Research()
                        {

                            Id = Guid.Parse("d6539917-3730-4c69-ac84-7215e74fa212"),
                            AuthorId = Guid.Parse("bbbe3442-78e7-49e7-b9bf-dec85942ce25"),
                            Title = "Diet and obesity in Los Angeles County 2007–2012: Is there a measurable effect of the 2008 “Fast-Food Ban”?",
                            Content = "We evaluate the impact of the “Los Angeles Fast-Food Ban”, a zoning regulation that has restricted opening/remodeling of standalone fast-food restaurants in South Los Angeles since 2008. Food retail permits issued after the ban are more often for small food/convenience stores and less often for larger restaurants not part of a chain in South Los Angeles compared to other areas; there are no significant differences in the share of new fast-food chain outlets, other chain restaurants, or large food markets. About 10% of food outlets are new since the regulation, but there is little evidence that the composition has changed differentially across areas. Data from the California Health Interview Survey show that fast-food consumption and overweight/obesity rates have increased from 2007 to 2011/2012 in all areas. The increase in the combined prevalence of overweight and obesity since the ban has been significantly larger in South Los Angeles than elsewhere. A positive development has been a drop in soft drink consumption since 2007, but that drop is of similar magnitude in all areas.",
                            Description = "We evaluate the impact of the “Los Angeles Fast-Food Ban”, a zoning regulation that has restricted opening/remodeling of standalone fast-food restaurants in South Los Angeles since 2008. ",
                            ResearchStatus = Infrastructures.Domain.Enums.ResearchStatus.Available,
                            IsPublished = true,
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });

                //6
                this._context.Researches.Add(
                        new Infrastructures.Domain.Models.Research()
                        {

                            Id = Guid.Parse("155deaeb-7c82-412b-8fc0-bf900c7cce69"),
                            AuthorId = Guid.Parse("2b24bba7-c207-459d-b0b5-7360bef40ae2"),
                            Title = "The Relationship Between Cell Phone Use and Academic Performance in a Sample of U.S. College Students",
                            Content = "The cell phone is ever-present on college campuses and is frequently used in settings where learning occurs. This study assessed the relationship between cell phone use and actual college grade point average (GPA) after controlling for known predictors. As such, 536 undergraduate students from 82 self-reported majors at a large, public university were sampled. A hierarchical regression (R2 = .449) demonstrated that cell phone use was significantly (p < .001) and negatively (β = −.164) related to actual college GPA after controlling for demographic variables, self-efficacy for self-regulated learning, self-efficacy for academic achievement, and actual high school GPA, which were all significant predictors (p < .05). Thus, after controlling for other established predictors, increased cell phone use was associated with decreased academic performance. Although more research is needed to identify the underlying mechanisms, findings suggest a need to sensitize students and educators about the potential academic risks associated with high-frequency cell phone use.",
                            Description = "The cell phone is ever-present on college campuses and is frequently used in settings where learning occurs.",
                            ResearchStatus = Infrastructures.Domain.Enums.ResearchStatus.Available,
                            IsPublished = true,
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });

                //7
                this._context.Researches.Add(
                        new Infrastructures.Domain.Models.Research()
                        {

                            Id = Guid.Parse("41f3e0a4-c890-49ca-8d0d-6e83ec175c19"),
                            AuthorId = Guid.Parse("a3964eeb-6641-4f78-9930-f200fe77a08b"),
                            Title = "Social comparisons on social media: The impact of Facebook on young women’s body image concerns and mood",
                            Content = "The present study experimentally investigated the effect of Facebook usage on women’s mood and body image, whether these effects differ from an online fashion magazine, and whether appearance comparison tendency moderates any of these effects. Female participants (N = 112) were randomly assigned to spend 10 min browsing their Facebook account, a magazine website, or an appearance-neutral control website before completing state measures of mood, body dissatisfaction, and appearance discrepancies (weight-related, and face, hair, and skin-related). Participants also completed a trait measure of appearance comparison tendency. Participants who spent time on Facebook reported being in a more negative mood than those who spent time on the control website. Furthermore, women high in appearance comparison tendency reported more facial, hair, and skin-related discrepancies after Facebook exposure than exposure to the control website. Given its popularity, more research is needed to better understand the impact that Facebook has on appearance concerns.",
                            Description = "The present study experimentally investigated the effect of Facebook usage on women’s mood and body image, whether these effects differ from an online fashion magazine, and whether appearance comparison tendency moderates any of these effects.",
                            ResearchStatus = Infrastructures.Domain.Enums.ResearchStatus.Available,
                            IsPublished = true,
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });

                //8
                this._context.Researches.Add(
                        new Infrastructures.Domain.Models.Research()
                        {

                            Id = Guid.Parse("a55bc92f-175f-49d3-8710-afd7914a0020"),
                            AuthorId = Guid.Parse("2881f179-97a1-4387-88bf-cb123f5f5317"),
                            Title = "The Process of Adapting a Universal Dating Abuse Prevention Program to Adolescents Exposed to Domestic Violence",
                            Content = "Adolescents exposed to domestic violence are at increased risk of dating abuse, yet no evaluated dating abuse prevention programs have been designed specifically for this high-risk population. This article describes the process of adapting Families for Safe Dates (FSD), an evidenced-based universal dating abuse prevention program, to this high-risk population, including conducting 12 focus groups and 107 interviews with the target audience. FSD includes six booklets of dating abuse prevention information, and activities for parents and adolescents to do together at home. We adapted FSD for mothers who were victims of domestic violence, but who no longer lived with the abuser, to do with their adolescents who had been exposed to the violence. Through the adaptation process, we learned that families liked the program structure and valued being offered the program and that some of our initial assumptions about this population were incorrect. We identified practices and beliefs of mother victims and attributes of these adolescents that might increase their risk of dating abuse that we had not previously considered. In addition, we learned that some of the content of the original program generated negative family interactions for some. The findings demonstrate the utility of using a careful process to adapt evidence-based interventions (EBIs) to cultural sub-groups, particularly the importance of obtaining feedback on the program from the target audience. Others can follow this process to adapt EBIs to groups other than the ones for which the original EBI was designed.",
                            Description = "Adolescents exposed to domestic violence are at increased risk of dating abuse, yet no evaluated dating abuse prevention programs have been designed specifically for this high-risk population.",
                            ResearchStatus = Infrastructures.Domain.Enums.ResearchStatus.Available,
                            IsPublished = true,
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });

                //9
                this._context.Researches.Add(
                        new Infrastructures.Domain.Models.Research()
                        {

                            Id = Guid.Parse("71a26e12-c4db-4d72-ab0c-6fc4e21a2a1f"),
                            AuthorId = Guid.Parse("cd096ff5-6719-4c96-bc01-9b2d467d2b96"),
                            Title = "Children’s consumption behavior in response to food product placements in movies",
                            Content = "Almost all research on the effects of product placements on children has focused on brand attitudes or behavioral intentions. Drawing on the important difference between attitudes or behavioral intentions on the one hand and actual behavior on the other, this paper tests the effects of brand placements on children’s food consumption. Children from 6 to 14 years old were exposed to an excerpt of the popular movie Alvin and the Chipmunks, including placements for the product Cheese Balls. Three versions were created: one without placements, one with moderate placement frequency, and one with high placement frequency. Results showed that exposure to high-frequency product placements exerted a significant effect on snack consumption, but no effect on brand or product attitudes. These effects were independent of children’s ages. The findings are of great importance to consumer behavior scholars, nutrition experts, and policy regulators.",
                            Description = "Almost all research on the effects of product placements on children has focused on brand attitudes or behavioral intentions.",
                            ResearchStatus = Infrastructures.Domain.Enums.ResearchStatus.Available,
                            IsPublished = true,
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });

                //10
                this._context.Researches.Add(
                        new Infrastructures.Domain.Models.Research()
                        {

                            Id = Guid.Parse("2f7ac734-a784-4a63-bf0e-f6557bbff618"),
                            AuthorId = Guid.Parse("cdfd46e0-5383-42b8-b53d-e522061f8348"),
                            Title = "Looks and Lies: The Role of Physical Attractiveness in Online Dating Self-Presentation and Deception",
                            Content = "This study examines the role of online daters’ physical attractiveness in their profile self-presentation and, in particular, their use of deception. Sixty-nine online daters identified the deceptions in their online dating profiles and had their photograph taken in the lab. Independent judges rated the online daters’ physical attractiveness. Results show that the lower online daters’ attractiveness, the more likely they were to enhance their profile photographs and lie about their physical descriptors (height, weight, age). The association between attractiveness and deception did not extend to profile elements unrelated to their physical appearance (e.g., income, occupation), suggesting that their deceptions were limited and strategic. Results are discussed in terms of (a) evolutionary theories about the importance of physical attractiveness in the dating realm and (b) the technological affordances that allow online daters to engage in selective self-presentation.",
                            Description = "This study examines the role of online daters’ physical attractiveness in their profile self-presentation and, in particular, their use of deception.",
                            ResearchStatus = Infrastructures.Domain.Enums.ResearchStatus.Available,
                            IsPublished = true,
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });

                //11
                this._context.Researches.Add(
                        new Infrastructures.Domain.Models.Research()
                        {

                            Id = Guid.Parse("b899fac8-c326-4ecd-980b-6feee235012f"),
                            AuthorId = Guid.Parse("d434f808-3f7a-48f4-97e3-57555f13384c"),
                            Title = "An Analysis of Yukon Delta Salmon Management ",
                            Content = "An Analysis of Yukon Delta Salmon Management Rita Asgeirsson, Western Washington University The broad range of Pacific Alaskan salmon has resulted in the creation of a complex and multiorganizational system of management that includes the state of Alaska, various federa departments, a Congressionally-mandated fishery council, and a number of commercial and nongovernmental fish organizations." +
                            "In the Bering Sea salmon are caught by the commercial groundfish fleet as by -catch. On the Yukon River salmon are commercially and traditionally  harvested for both economic and cultural sustenance by the Yup’ik residents of the Yukon Delta.Declining salmon populations has driven scientific research which considers the effects ofBering Sea salmon by -catch. My research findings indicate that Bering Sea fisheries occur where juvenile salmon mature, directly impacting Yukon River salmon populations.Further,the research reflects that although Yukon salmon populations have plummeted,  a recent effort was made to open the northern Bering Sea, which includes the Yukon River coastal shelf, to deep - sea commercial fishing"
                             + "By researching the relationship of policy to cultural salmon dependence, it becomes evident that Alaskan salmon - tribes are excluded from salmon management and decision - making.Legalresearch reflects that three basic federal Indian concepts – inherent rights, Indian Country, and tribal right of occupancy – emerge as potential foundations that may allow Alaskan salmontribes to begin sharing legal responsibility over salmon. "
                             + "Yukon River salmon are an international and anadromous species that require multiorganizational management. My research reflects that current management favors the Bering Sea commercial fishing industry, despite data indicating Bering Sea fisheries impact Yukon salmon populations and an overall downward trend in Yukon salmon populations.",
                             Description = "Fisheries management related to Bering Sea fisheries and Yukon River salmon populations",
                            ResearchStatus = Infrastructures.Domain.Enums.ResearchStatus.Available,
                            IsPublished = true,
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });

                //12
                this._context.Researches.Add(
                        new Infrastructures.Domain.Models.Research()
                        {

                            Id = Guid.Parse("d9d57977-b7cd-44fd-a145-612378f347b4"),
                            AuthorId = Guid.Parse("78f58bab-0ba6-4d39-a83d-759023f2f59f"),
                            Title = " Using GIS Site Suitability Analysis to Study Adaptability and Evolution of Life: Locating Springs in Mantle Units of Ophiolites",
                            Content = "Using GIS Site Suitability Analysis to Study Adaptability and Evolution of Life: Locating Springs in Mantle Units of Ophiolites Alexandrea Bowman, GIS is a powerful tool that can be used to locate springs sourced in ophiolites. The unique features associated with these springs include a reducing subsurface environment reacting at low temperatures producing high pH, Ca - rich formation fluids with high dissolved hydrogen and methane.Because of their unique chemical characteristics, these areas are often associated with microbes and are thought to be similar to the features that enabled life to evolve on Earth. Locating and sampling these springs could offer a deeper look into Earth's deep biosphere and the history of life on Earth.Springs have tradiitionally been located using expensive and time consuming field techniques. Field work can be dangerous.The goal of this study was to develop a model that could locate these unique geological features without first going into the field, thus University of Rhode Island"  
                            +"saving time, money and reducing the risks associated with remote field localities. A GIS site suitability analysis works by overlaying existing geo - referenced data into a computer program and adding the different data sets after assigning a numerical value to the important fields.For this project, I used surface and ground water maps, geologic maps, a soil map, and a fault map for four counties in Northern California.The model has demonstrated that it is possible to use this time of model and apply it to a complex geologic area to produce a usable field map for future field work. ",
                            Description = "BioGeoChemistry and Computer modelling",
                            ResearchStatus = Infrastructures.Domain.Enums.ResearchStatus.Available,
                            IsPublished = true,
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });

                //13
                this._context.Researches.Add(
                        new Infrastructures.Domain.Models.Research()
                        {

                            Id = Guid.Parse("d75eaa81-bb08-4bef-a235-b81a471127eb"),
                            AuthorId = Guid.Parse("ba7e0509-060f-4334-86c0-c11b6af049ea"),
                            Title = "Characterization of Iron Deposition in Recombinant Heteropolymer Ferritins",
                            Content = "Characterization of Iron Deposition in Recombinant Heteropolymer Ferritins Deneen Cole, Dr.Fadi Bou - Abdallah, SUNY Potsdam(NY, USA), Dr.Paolo Arosio, University of Brescia(Italy), Dr.Sonia Levi, Vita - Salute San Raffaele University(Italy) "
                            + "Ferritin is a ubiquitous iron storage and detoxification protein found highly conserved in species  from bacteria to plants to humans. In mammals, ferritin is composed of two functionallyand genetically distinct subunit types, H (heavy, ~21,000 Da) and L (light, ~19,000 Da) subunits  which co-assemble in various ratios with tissue specific distribution to form a shell-like protein. The H-subunit is responsible for the fast conversion of Fe(II) to Fe(III) by dioxygen (or H2O2)  whereas the L-subunit is thought to contribute to the nucleation of the iron core. In the present  work, we investigated the iron oxidation and deposition mechanism in two recombinant  heteropolymers ferritin samples of ~20H:4L (termed H/L) and ~22L:2H (termed L/H) ratios. "
                            + "Data indicates that iron oxidation occurs mainly on the H-subunit with a stoichiometry of 2Fe(II):1O2, suggesting formation of H2O2. The H/L sample completely regenerates its  ferroxidase activity within a short period of time suggesting rapid movement of Fe(III) from the  ferroxidase center to the cavity to form the mineral core, consistent with the role of L-chain in  facilitating iron turn-over at the ferroxidase center of the H-subunit. In L/H, Fe(II) oxidation and mineralization appears to occur by two simultaneous pathways at all levels of iron additions: a  ferroxidation pathway with a 2Fe(II)/1O2 ratio and a mineralization pathway with a 4Fe(II)/1O2 resulting in an average net stoichiometry of ~3Fe(II)/1O2. These results illustrate how recombinant heteropolymer ferritins control iron and oxygen toxicity  while providing a safe reservoir for reversible uptake and release of iron for use by the cell.",
                            Description = "Chemistry",
                            ResearchStatus = Infrastructures.Domain.Enums.ResearchStatus.Available,
                            IsPublished = true,
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });

                //14
                this._context.Researches.Add(
                        new Infrastructures.Domain.Models.Research()
                        {

                            Id = Guid.Parse("1be0d018-351c-4ea7-8721-9aaae265e276"),
                            AuthorId = Guid.Parse("967e82f0-f38e-4a95-8071-5b92e16f0afa"),
                            Title = "An Assessment of Oral Health on the Pine Ridge Indian Reservation",
                            Content = "An Assessment of Oral Health on the Pine Ridge Indian Reservation Joaquin R Gallegos,Terry Batliner,DDS,MBA,John T Brinton,MS,Dallas M Daniels,RDH,BS,Anne Wilson,DDS,MS,Maxine Janis,MPH,RDH,Kimberly E Lind,MPH,Deborah HGlueck,PhD,Judith Albino,PhD.Centers for American Indian and Alaska Native Health, University of Colorado, ColoradoSchool of Public Health" 
                            + "We assessed the oral health of the Pine Ridge Oglala Lakota people, described a new oral health " +
                                "assessment tool for Indigenous people, and suggested ways to improve Native oral health.The" +
                                "Check Up Study team of dentist and dental hygienists performed examinations of teeth and oral" +
                                "soft tissue for a convenience sample of 292 adults and children.Screening personnel counted the" +
                                "number of decayed, filled, sealed and total teeth, used probes to measure periodontal disease, and " +
                                "screened for oral lesions.Half of adults had 27 or fewer teeth.Sixteen percent of adults had at" +
                                "least one tooth with a pocket depth > 6mm.Participants had higher numbers of decayed teeth " + 
                                "(p<0.0001), and lower numbers of filled teeth (p<0.0001) than those reflected in Indian Health" + 
                                "Service cross-tribe aggregated data from 1999. Amongst Lakota people of Pine Ridge, our study" +
                                "documented a high prevalence of caries and periodontal disease, numerous people with missing" +
                                "teeth, and many unmet dental needs.Future studies of oral health related behaviors, and access to" +
                                "oral health care are needed to explain the dental, periodontal, and soft tissue problems that" +
                                "adversely affect the Oglala Lakota.",
                            Description = "Oral Health",
                            ResearchStatus = Infrastructures.Domain.Enums.ResearchStatus.Available,
                            IsPublished = true,
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });

                //15
                this._context.Researches.Add(
                        new Infrastructures.Domain.Models.Research()
                        {

                            Id = Guid.Parse("5253ae80-8f2f-409e-8a94-7c375bdceeaa"),
                            AuthorId = Guid.Parse(" 7e78ca67-b3ba-4077-a4ee-3069e8d62d57"),
                            Title = "The Citrus Solution: Phase II",
                            Content = "The purpose of this experiment was to test the effectiveness of composite filters made from" +
                                    "citrus peels and citrus pectin along with charcoal and sand on removing heavy metal pollutants"+
                                    "from the waters of Tar Creek.A toxicity test was also done before and after filtration using" +
                                    "Daphnia magna. Charcoal and sand were used as filtrates to decrease the TDS and neutralize the" +
                                    "pH of the water after filtration.Daphnia magna were used as toxicity test before and after"+
                                    "filtration."+
                                    "It was hypothesized that the composite filters(citrus + sand + charcoal) will decrease the heavy"+
                                    "metal concentration, neutralize the pH, and decrease the TDS after filtration.It was also"+
                                    "hypothesized that a higher percentage of Daphnia magna will survive in the filtered water as"+
                                    "compared to the unfiltered water."+
                                    "Water samples were collected from four different sites at Tar Creek.Each water sample went" +
                                    "through four different citrus filters plus one control(sand +charcoal). All the citrus filters" +
                                    "decreased the heavy metal concentration after filtration.All of the filters neutralized the pH.The" +
                                    "citrus peel filters for Site 4 were the only filters to have a pH of 7 after filtration.Only 25 % of" +
                                    "the citrus filters decreased the TDS after filtration, while 50 % of the control filters decreased the" +
                                    "TDS after filtration. A higher percentage of Daphnia magna survived after filtration.The orange" +
                                    "peel had the overall highest survival of Daphnia after filtration. The correlation observed before" +
                                    "and after filtration was cadmium was most toxic to Daphnia magna",
                            Description = "Utilizing citrus pectin and citrus peels as filtrates for heavy metal pollutantsfound in a Superfund Site and the effects on Daphnia magna before and after filtration.School: Grove High School",
                            ResearchStatus = Infrastructures.Domain.Enums.ResearchStatus.Available,
                            IsPublished = true,
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });
            }
                #endregion
                this._context.SaveChanges();
            return Ok("Ok");
        }
    }
}