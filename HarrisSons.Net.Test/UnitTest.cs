using Bogus;
using HarrisSons.Net.Data;
using HarrisSons.Net.Data.Tools;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace HarrisSons.Net.Test
{
    public class UnitTest
    {
        private DbContextOptionsBuilder<HarrisSonsDbContext> builder = new DbContextOptionsBuilder<HarrisSonsDbContext>()
            .EnableSensitiveDataLogging()
            .UseInMemoryDatabase(Guid.NewGuid().ToString());
        private Faker faker = new Faker("en");

        [Fact]
        public void CanAddAddress()
        {
            // Arrange
            using (var context = new HarrisSonsDbContext(builder.Options))
            {
                // Act
                context.Addresses.Add(
                    new Address
                    {
                        AddressID = 1,
                        AddressLine1 = faker.Address.SecondaryAddress(),
                        AddressLine2 = faker.Address.StreetAddress(),
                        City = faker.Address.City(),
                        State = faker.Address.State(),
                        Country = faker.Address.County(),
                        PostalCode = faker.Address.ZipCode(),
                    }
                );
                context.SaveChanges();

                // Assert
                Assert.Equal(1, context.Addresses.Count());
                Assert.Equal(1, context.Addresses.Single().AddressID);
            }
        }
    }
}
