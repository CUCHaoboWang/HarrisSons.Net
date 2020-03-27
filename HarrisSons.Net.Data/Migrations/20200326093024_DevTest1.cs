using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace HarrisSons.Net.Data.Migrations
{
    public partial class DevTest1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string createPersonalContactView = "CREATE VIEW `vwPersonalContact` AS " +
                "SELECT client.ClientID, client.FirstName, client.LastName, client.BirthDate, client.FirstContactDate AS ContactDate, contact.EmailAddress, contact.Telephone, contact.HomeTelephone " +
                "FROM HarrisSonsDB.tblClient AS client JOIN " +
                "HarrisSonsDB.tblPersonalContact AS contact ON client.PersonalContactID = contact.PersonalContactID; ";

            string createPersonalContactDetailView = "CREATE VIEW `vwPersonalContactDetail` AS " +
                "SELECT client.ClientID, client.FirstName, client.LastName, client.BirthDate, client.FirstContactDate AS ContactDate, contact.EmailAddress, contact.Telephone, contact.HomeTelephone, " + 
                "address.AddressLine1, address.AddressLine2, address.City, address.State, address.Country, address.PostalCode " +
                "FROM HarrisSonsDB.tblClient AS client JOIN " +
                "HarrisSonsDB.tblPersonalContact AS contact ON client.PersonalContactID = contact.PersonalContactID JOIN " +
                "HarrisSonsDB.tblAddress AS address ON contact.AddressID = address.AddressID;";

            string createBusinessContactView = "CREATE VIEW `vwBusinessContact` AS " +
                "SELECT employee.EmployeeID, employee.FirstName, employee.LastName, employee.BirthDate, employee.HireDate, position.Name AS Position, department.Name AS Department, " +
                "contact.EmailAddress, contact.Telephone, contact.BusinessTelephone " +
                "FROM HarrisSonsDB.tblEmployee AS employee JOIN " +
                "HarrisSonsDB.tblBusinessContact AS contact ON employee.BusinessContactID = contact.BusinessContactID JOIN " +
                "HarrisSonsDB.tblPosition AS position ON employee.PositionID = position.PositionID JOIN " +
                "HarrisSonsDB.tblDepartment AS department ON position.DepartmentID = department.DepartmentID;";

            string createBusinessContactDetailView = "CREATE VIEW `vwBusinessContactDetail` AS " +
                "SELECT employee.EmployeeID, employee.FirstName, employee.LastName, employee.BirthDate, employee.HireDate, position.Name AS Position, department.Name AS Department, " +
                "contact.EmailAddress, contact.Telephone, contact.BusinessTelephone, " +
                "address.AddressLine1, address.AddressLine2, address.City, address.State, address.Country, address.PostalCode " +
                "FROM HarrisSonsDB.tblEmployee AS employee JOIN " +
                "HarrisSonsDB.tblBusinessContact AS contact ON employee.BusinessContactID = contact.BusinessContactID JOIN " +
                "HarrisSonsDB.tblAddress AS address ON contact.AddressID = address.AddressID JOIN " + 
                "HarrisSonsDB.tblPosition AS position ON employee.PositionID = position.PositionID JOIN " +
                "HarrisSonsDB.tblDepartment AS department ON position.DepartmentID = department.DepartmentID;";

            migrationBuilder.Sql(createPersonalContactView);
            migrationBuilder.Sql(createPersonalContactDetailView);
            migrationBuilder.Sql(createBusinessContactView);
            migrationBuilder.Sql(createBusinessContactDetailView);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string dropPersonalContactView = "DROP VIEW `HarrisSonsDB`.`vwPersonalContact`;";
            string dropPersonalContactDetailView = "DROP VIEW `HarrisSonsDB`.`vwPersonalContactDetail`;";
            string dropBusinessContactView = "DROP VIEW `HarrisSonsDB`.`vwBusinessContact`;";
            string dropBusinessContactDetailView = "DROP VIEW `HarrisSonsDB`.`vwBusinessContactDetail`;";

            migrationBuilder.Sql(dropPersonalContactView);
            migrationBuilder.Sql(dropPersonalContactDetailView);
            migrationBuilder.Sql(dropBusinessContactView);
            migrationBuilder.Sql(dropBusinessContactDetailView);
        }
    }
}
