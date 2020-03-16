using Bogus;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HarrisSons.Net.Data.Tools
{
    public class DbInitializer
    {
        public static void Initialize()
        {
            var context = new HarrisSonsDbContext();
            context.Database.EnsureCreated();
            var faker = new Faker("en");

            if (!context.PayRates.Any())
            {
                for (int i = 1; i <= 8; i++)
                {
                    context.PayRates.Add(
                        new PayRate
                        {
                            Rank = i
                        }
                    );
                }
            }
            context.SaveChanges();

            if (!context.Departments.Any())
            {
                context.Departments.AddRange(
                    new Department
                    {
                        Name = "Software Engineering",
                        GroupName = "Research and Development"
                    },
                    new Department
                    {
                        Name = "Web Design",
                        GroupName = "Research and Development"
                    },
                    new Department
                    {
                        Name = "Sales",
                        GroupName = "Sales and Marketing"
                    },
                    new Department
                    {
                        Name = "Marketing",
                        GroupName = "Sales and Marketing"
                    },
                    new Department
                    {
                        Name = "Human Resources",
                        GroupName = "Executive General and Administration"
                    },
                    new Department
                    {
                        Name = "Finance",
                        GroupName = "Executive General and Administration"
                    },
                    new Department
                    {
                        Name = "Information Services",
                        GroupName = "Executive General and Administration"
                    },
                    new Department
                    {
                        Name = "Document Control",
                        GroupName = "Quality Assurance"
                    },
                    new Department
                    {
                        Name = "Quality Assurance",
                        GroupName = "Quality Assurance"
                    },
                    new Department
                    {
                        Name = "Executive",
                        GroupName = "Executive General and Administration"
                    }
                );
            }
            context.SaveChanges();

            if (!context.Positions.Any())
            {
                context.Positions.AddRange(
                    new Position
                    {
                        Name = "Chief Executive Officer",
                        DepartmentID = context.Departments.FirstOrDefault(d => d.Name == "Executive").DepartmentID,
                        PayRateID = context.PayRates.FirstOrDefault(p => p.Rank == 8).PayRateID
                    },
                    new Position
                    {
                        Name = "Vice President of Engineering",
                        DepartmentID = context.Departments.FirstOrDefault(d => d.Name == "Software Engineering").DepartmentID,
                        PayRateID = context.PayRates.FirstOrDefault(p => p.Rank == 7).PayRateID
                    },
                    new Position
                    {
                        Name = "Engineering Manager",
                        DepartmentID = context.Departments.FirstOrDefault(d => d.Name == "Software Engineering").DepartmentID,
                        PayRateID = context.PayRates.FirstOrDefault(p => p.Rank == 7).PayRateID
                    },
                    new Position
                    {
                        Name = "Software Engineer",
                        DepartmentID = context.Departments.FirstOrDefault(d => d.Name == "Software Engineering").DepartmentID,
                        PayRateID = context.PayRates.FirstOrDefault(p => p.Rank == 6).PayRateID
                    },
                    new Position
                    {
                        Name = "Infrastructure Technician",
                        DepartmentID = context.Departments.FirstOrDefault(d => d.Name == "Software Engineering").DepartmentID,
                        PayRateID = context.PayRates.FirstOrDefault(p => p.Rank == 6).PayRateID
                    },
                    new Position
                    {
                        Name = "Network Administrator",
                        DepartmentID = context.Departments.FirstOrDefault(d => d.Name == "Software Engineering").DepartmentID,
                        PayRateID = context.PayRates.FirstOrDefault(p => p.Rank == 6).PayRateID
                    },
                    new Position
                    {
                        Name = "Database Administrator",
                        DepartmentID = context.Departments.FirstOrDefault(d => d.Name == "Software Engineering").DepartmentID,
                        PayRateID = context.PayRates.FirstOrDefault(p => p.Rank == 6).PayRateID
                    },
                    new Position
                    {
                        Name = "Senior Web Designer",
                        DepartmentID = context.Departments.FirstOrDefault(d => d.Name == "Web Design").DepartmentID,
                        PayRateID = context.PayRates.FirstOrDefault(p => p.Rank == 5).PayRateID
                    },
                    new Position
                    {
                        Name = "Associate Web Designer",
                        DepartmentID = context.Departments.FirstOrDefault(d => d.Name == "Web Design").DepartmentID,
                        PayRateID = context.PayRates.FirstOrDefault(p => p.Rank == 4).PayRateID
                    },
                    new Position
                    {
                        Name = "Marketing Manager",
                        DepartmentID = context.Departments.FirstOrDefault(d => d.Name == "Marketing").DepartmentID,
                        PayRateID = context.PayRates.FirstOrDefault(p => p.Rank == 5).PayRateID
                    },
                    new Position
                    {
                        Name = "Marketing Specialist",
                        DepartmentID = context.Departments.FirstOrDefault(d => d.Name == "Marketing").DepartmentID,
                        PayRateID = context.PayRates.FirstOrDefault(p => p.Rank == 4).PayRateID
                    },
                    new Position
                    {
                        Name = "Marketing Assistant",
                        DepartmentID = context.Departments.FirstOrDefault(d => d.Name == "Marketing").DepartmentID,
                        PayRateID = context.PayRates.FirstOrDefault(p => p.Rank == 3).PayRateID
                    },
                    new Position
                    {
                        Name = "Sales Manager",
                        DepartmentID = context.Departments.FirstOrDefault(d => d.Name == "Sales").DepartmentID,
                        PayRateID = context.PayRates.FirstOrDefault(p => p.Rank == 4).PayRateID
                    },
                    new Position
                    {
                        Name = "Sales Representative",
                        DepartmentID = context.Departments.FirstOrDefault(d => d.Name == "Sales").DepartmentID,
                        PayRateID = context.PayRates.FirstOrDefault(p => p.Rank == 3).PayRateID
                    },
                    new Position
                    {
                        Name = "Document Control Manager",
                        DepartmentID = context.Departments.FirstOrDefault(d => d.Name == "Document Control").DepartmentID,
                        PayRateID = context.PayRates.FirstOrDefault(p => p.Rank == 4).PayRateID
                    },
                    new Position
                    {
                        Name = "Document Control Assistant",
                        DepartmentID = context.Departments.FirstOrDefault(d => d.Name == "Document Control").DepartmentID,
                        PayRateID = context.PayRates.FirstOrDefault(p => p.Rank == 3).PayRateID
                    },
                    new Position
                    {
                        Name = "Quality Assurance Manager",
                        DepartmentID = context.Departments.FirstOrDefault(d => d.Name == "Quality Assurance").DepartmentID,
                        PayRateID = context.PayRates.FirstOrDefault(p => p.Rank == 4).PayRateID
                    },
                    new Position
                    {
                        Name = "Quality Assurance Technician",
                        DepartmentID = context.Departments.FirstOrDefault(d => d.Name == "Quality Assurance").DepartmentID,
                        PayRateID = context.PayRates.FirstOrDefault(p => p.Rank == 3).PayRateID
                    },
                    new Position
                    {
                        Name = "Information Services Manager",
                        DepartmentID = context.Departments.FirstOrDefault(d => d.Name == "Information Services").DepartmentID,
                        PayRateID = context.PayRates.FirstOrDefault(p => p.Rank == 5).PayRateID
                    },
                    new Position
                    {
                        Name = "Human Resource Manager",
                        DepartmentID = context.Departments.FirstOrDefault(d => d.Name == "Human Resources").DepartmentID,
                        PayRateID = context.PayRates.FirstOrDefault(p => p.Rank == 5).PayRateID
                    },
                    new Position
                    {
                        Name = "Human Resource Administrator",
                        DepartmentID = context.Departments.FirstOrDefault(d => d.Name == "Human Resources").DepartmentID,
                        PayRateID = context.PayRates.FirstOrDefault(p => p.Rank == 4).PayRateID
                    },
                    new Position
                    {
                        Name = "Chief Financial Officer",
                        DepartmentID = context.Departments.FirstOrDefault(d => d.Name == "Finance").DepartmentID,
                        PayRateID = context.PayRates.FirstOrDefault(p => p.Rank == 6).PayRateID
                    },
                    new Position
                    {
                        Name = "Finance Manager",
                        DepartmentID = context.Departments.FirstOrDefault(d => d.Name == "Finance").DepartmentID,
                        PayRateID = context.PayRates.FirstOrDefault(p => p.Rank == 5).PayRateID
                    },
                    new Position
                    {
                        Name = "Accountant",
                        DepartmentID = context.Departments.FirstOrDefault(d => d.Name == "Finance").DepartmentID,
                        PayRateID = context.PayRates.FirstOrDefault(p => p.Rank == 4).PayRateID
                    }
                );
            }
            context.SaveChanges();

            if (!context.Addresses.Any())
            {
                for (int i = 1; i <= 64; i++)
                {
                    context.Addresses.Add(
                        new Address
                        {
                            AddressLine1 = faker.Address.SecondaryAddress(),
                            AddressLine2 = faker.Address.StreetAddress(),
                            City = faker.Address.City(),
                            State = faker.Address.State(),
                            Country = faker.Address.County(),
                            PostalCode = faker.Address.ZipCode(),
                        }
                    );
                }
            }
            context.SaveChanges();

            if (!context.BusinessContacts.Any())
            {
                for (int i = 1; i <= context.Addresses.Count()/2; i++)
                {
                    context.BusinessContacts.Add(
                    new BusinessContact
                    {
                        EmailAddress = faker.Internet.Email(),
                        Telephone = faker.Phone.PhoneNumber(),
                        BusinessTelephone = faker.Phone.PhoneNumber(),
                        AddressID = i
                    }
                );
                }
            }
            context.SaveChanges();

            if (!context.PersonalContacts.Any())
            {
                for (int i = context.Addresses.Count()/2 + 1; i <= context.Addresses.Count(); i++)
                {
                    context.PersonalContacts.Add(
                        new PersonalContact
                        {
                            EmailAddress = faker.Internet.Email(),
                            Telephone = faker.Phone.PhoneNumber(),
                            HomeTelephone = faker.Phone.PhoneNumber(),
                            AddressID = i
                        }
                    );
                }
            }
            context.SaveChanges();

            if (!context.Employees.Any())
            {
                List<int> positions = context.Positions.Select(i => i.PositionID).ToList();
                int SoftwareEngineer = context.Positions.FirstOrDefault(i => i.Name == "Software Engineer").PositionID;
                int SalesRepresentative = context.Positions.FirstOrDefault(i => i.Name == "Sales Representative").PositionID;
                int WebDesigner = context.Positions.FirstOrDefault(i => i.Name == "Associate Web Designer").PositionID;
                int Accountant = context.Positions.FirstOrDefault(i => i.Name == "Accountant").PositionID;
                for (int i = 0; i < 2; i++)
                {
                    positions.Add(SoftwareEngineer);
                    positions.Add(WebDesigner);
                    positions.Add(SalesRepresentative);
                    positions.Add(Accountant);
                }

                for (int i = 1; i <= context.Addresses.Count()/2; i++)
                {
                    int position = faker.PickRandom<int>(positions);
                    positions.Remove(position);

                    context.Employees.Add(
                        new Employee
                        {
                            FirstName = faker.Name.FirstName(),
                            LastName = faker.Name.LastName(),
                            BirthDate = faker.Date.Between(new DateTime(1960, 1, 1), new DateTime(2000, 1, 1)),
                            NationalInsuranceNumber = faker.Internet.Mac(),
                            HireDate = faker.Date.Between(new DateTime(2010, 1, 1), new DateTime(2020, 1, 1)),
                            PositionID = position,
                            BusinessContactID = i
                        }
                    );
                }
            }
            context.SaveChanges();

            if (!context.Clients.Any())
            {
                for (int i = 1; i <= context.Addresses.Count()/2; i++)
                {
                    context.Clients.Add(
                        new Client
                        {
                            FirstName = faker.Name.FirstName(),
                            LastName = faker.Name.LastName(),
                            BirthDate = faker.Date.Between(new DateTime(1940, 1, 1), new DateTime(2000, 1, 1)),
                            FirstContactDate = faker.Date.Between(new DateTime(2010, 1, 1), new DateTime(2020, 1, 1)),
                            LastContactDate = null,
                            PersonalContactID = i
                        }
                    );
                }
            }
            context.SaveChanges();
        }
    }
}
