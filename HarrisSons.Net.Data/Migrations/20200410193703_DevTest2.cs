using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HarrisSons.Net.Data.Migrations
{
    public partial class DevTest2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string spAddAddress = @"CREATE DEFINER=`admin`@`%` PROCEDURE `spAddAddress`(address1 VARCHAR(255), address2 VARCHAR(255), city VARCHAR(255), state VARCHAR(255), country VARCHAR(255), postalcode VARCHAR(255))
                BEGIN
                INSERT INTO `HarrisSonsDB`.`tblAddress`
                (`AddressID`,
                `AddressLine1`,
                `AddressLine2`,
                `City`,
                `State`,
                `Country`,
                `PostalCode`)
                VALUES
                (null, address1, address2, city, state, country, postalcode);
                END";

            string spAddBusinessContact = @"CREATE DEFINER=`admin`@`%` PROCEDURE `spAddBusinessContact`(IN firstname VARCHAR(255), lastname VARCHAR(255), birthdate VARCHAR(255), 
                positionid INT, departmentid INT, emailaddress VARCHAR(255), telephone VARCHAR(255), businesstelephone VARCHAR(255),
                address1 VARCHAR(255), address2 VARCHAR(255), city VARCHAR(255), state VARCHAR(255), country VARCHAR(255), postalcode VARCHAR(255))
                BEGIN
                DECLARE AddressID INT UNSIGNED;
                DECLARE ContactID INT UNSIGNED;

                START TRANSACTION;
                INSERT INTO `HarrisSonsDB`.`tblAddress`
                (`AddressID`, `AddressLine1`, `AddressLine2`, `City`, `State`, `Country`, `PostalCode`)
                VALUES (null, address1, address2, city, state, country, postalcode);
                SELECT last_insert_id() INTO AddressID;

                INSERT INTO `HarrisSonsDB`.`tblBusinessContact`
                (`BusinessContactID`, `EmailAddress`, `Telephone`, `BusinessTelephone`, `AddressID`)
                VALUES (null, emailaddress, telephone, businesstelephone, AddressID);
                SELECT last_insert_id() INTO ContactID;

                INSERT INTO `HarrisSonsDB`.`tblEmployee`
                (`EmployeeID`, `FirstName`, `LastName`, `BirthDate`, `NationalInsuranceNumber`, `HireDate`, `PositionID`, `BusinessContactID`)
                VALUES (null, firstname, lastname, birthdate, '5f:f1:65:8e:22:46', now(), positionid, ContactID);
                COMMIT;
                END";

            string spAddPersonalContact = @"CREATE DEFINER=`admin`@`%` PROCEDURE `spAddPersonalContact`(IN firstname VARCHAR(255), lastname VARCHAR(255), birthdate VARCHAR(255), emailaddress VARCHAR(255), telephone VARCHAR(255), hometelephone VARCHAR(255),
                address1 VARCHAR(255), address2 VARCHAR(255), city VARCHAR(255), state VARCHAR(255), country VARCHAR(255), postalcode VARCHAR(255))
                BEGIN
                DECLARE AddressID INT UNSIGNED;
                DECLARE ContactID INT UNSIGNED;

                START TRANSACTION;
                INSERT INTO `HarrisSonsDB`.`tblAddress`
                (`AddressID`, `AddressLine1`, `AddressLine2`, `City`, `State`, `Country`, `PostalCode`)
                VALUES (null, address1, address2, city, state, country, postalcode);
                SELECT last_insert_id() INTO AddressID;

                INSERT INTO `HarrisSonsDB`.`tblPersonalContact`
                (`PersonalContactID`, `EmailAddress`, `Telephone`, `HomeTelephone`, `AddressID`)
                VALUES
                (null, emailaddress, telephone, hometelephone, AddressID);
                SELECT last_insert_id() INTO ContactID;

                INSERT INTO `HarrisSonsDB`.`tblClient`
                (`ClientID`, `FirstName`, `LastName`, `BirthDate`, `FirstContactDate`, `LastContactDate`, `PersonalContactID`)
                VALUES (null, firstname, lastname, birthdate, now(), null, ContactID);
                COMMIT;
                END";

            string spDeleteAddress = @"CREATE DEFINER=`admin`@`%` PROCEDURE `spDeleteAddress`(IN id int)
                BEGIN
                DELETE FROM `HarrisSonsDB`.`tblAddress`
                WHERE AddressID = id;
                END";

            string spGetAllAddress = @"CREATE DEFINER=`admin`@`%` PROCEDURE `spGetAllAddress`()
                BEGIN
                SELECT * FROM HarrisSonsDB.tblAddress;
                END";

            string spGetAllPosition = @"CREATE DEFINER=`admin`@`%` PROCEDURE `spGetAllPosition`()
                BEGIN
                SELECT * FROM HarrisSonsDB.vwPosition ORDER BY PositionID;
                END";

            string spGetAllViewBusinessContactDetail = @"CREATE DEFINER=`admin`@`%` PROCEDURE `spGetAllViewBusinessContactDetail`()
                BEGIN
                SELECT * FROM HarrisSonsDB.vwBusinessContactDetail ORDER BY EmployeeID;
                END";

            string spGetAllViewPersonalContactDetail = @"CREATE DEFINER=`admin`@`%` PROCEDURE `spGetAllViewPersonalContactDetail`()
                BEGIN
                SELECT * FROM HarrisSonsDB.vwPersonalContactDetail ORDER BY ClientID;
                END";

            string spGetBusinessAddressID = "CREATE DEFINER=`admin`@`%` PROCEDURE `spGetBusinessAddressID`(IN id INT) " + 
                "BEGIN " + 
                "SELECT AddressID FROM HarrisSonsDB.tblAddress " + 
                "WHERE AddressID = (SELECT AddressID FROM HarrisSonsDB.tblBusinessContact WHERE BusinessContactID = (SELECT BusinessContactID FROM HarrisSonsDB.tblEmployee WHERE EmployeeID = id));" + 
                "END";

            string spGetPersonalAddressID = "CREATE DEFINER=`admin`@`%` PROCEDURE `spGetPersonalAddressID`(IN id INT) " + 
                "BEGIN " + 
                "SELECT AddressID FROM HarrisSonsDB.tblAddress " + 
                "WHERE AddressID = (SELECT AddressID FROM HarrisSonsDB.tblPersonalContact  WHERE PersonalContactID = (SELECT PersonalContactID FROM HarrisSonsDB.tblClient WHERE ClientID = id)); " + 
                "END";

            string spSearchBusinessContact = @"CREATE DEFINER=`admin`@`%` PROCEDURE `spSearchBusinessContact`(IN text VARCHAR(255))
                BEGIN
                SELECT * FROM HarrisSonsDB.vwBusinessContactDetail 
                WHERE FirstName LIKE CONCAT(""%"",text,""%"") OR LastName LIKE CONCAT(""%"",text,""%"") OR EmailAddress LIKE CONCAT(""%"",text,""%"")
                OR BirthDate LIKE CONCAT(""%"",text,""%"") OR HireDate LIKE CONCAT(""%"",text,""%"")
                OR Position LIKE CONCAT(""%"",text,""%"") OR Department LIKE CONCAT(""%"",text,""%"") OR Telephone LIKE CONCAT(""%"",text,""%"") 
                OR BusinessTelephone LIKE CONCAT(""%"",text,""%"") OR AddressLine1 LIKE CONCAT(""%"",text,""%"")OR AddressLine2 LIKE CONCAT(""%"",text,""%"") 
                OR City LIKE CONCAT(""%"",text,""%"") OR State LIKE CONCAT(""%"",text,""%"") OR Country LIKE CONCAT(""%"",text,""%"") OR PostalCode LIKE CONCAT(""%"",text,""%"");
                END";

            string spSearchPersonalContact = @"CREATE DEFINER=`admin`@`%` PROCEDURE `spSearchPersonalContact`(IN text VARCHAR(255))
                BEGIN
                SELECT * FROM HarrisSonsDB.vwPersonalContactDetail 
                WHERE FirstName LIKE CONCAT(""%"",text,""%"") OR LastName LIKE CONCAT(""%"",text,""%"") OR EmailAddress LIKE CONCAT(""%"",text,""%"") OR BirthDate LIKE CONCAT(""%"",text,""%"")
                OR Telephone LIKE CONCAT(""%"",text,""%"") OR HomeTelephone LIKE CONCAT(""%"",text,""%"") OR AddressLine1 LIKE CONCAT(""%"",text,""%"")
                OR AddressLine2 LIKE CONCAT(""%"",text,""%"") OR City LIKE CONCAT(""%"",text,""%"") OR State LIKE CONCAT(""%"",text,""%"") 
                OR Country LIKE CONCAT(""%"",text,""%"") OR PostalCode LIKE CONCAT(""%"",text,""%"");
                END";

            string spUpdateAddress = @"CREATE DEFINER=`admin`@`%` PROCEDURE `spUpdateAddress`(IN id int, address1 VARCHAR(255), address2 VARCHAR(255), city VARCHAR(255), state VARCHAR(255), country VARCHAR(255), postalcode VARCHAR(255))
                BEGIN
                UPDATE `HarrisSonsDB`.`tblAddress`
                SET
                `AddressLine1` = address1,
                `AddressLine2` = address2,
                `City` = city,
                `State` = state,
                `Country` = country,
                `PostalCode` = postalcode
                WHERE `AddressID` = id;
                END";

            string spUpdateBusinessContact = @"CREATE DEFINER=`admin`@`%` PROCEDURE `spUpdateBusinessContact`(IN id INT, IN firstname VARCHAR(255), lastname VARCHAR(255), birthdate VARCHAR(255), 
                positionid INT, departmentid INT, emailaddress VARCHAR(255), telephone VARCHAR(255), businesstelephone VARCHAR(255),
                address1 VARCHAR(255), address2 VARCHAR(255), city VARCHAR(255), state VARCHAR(255), country VARCHAR(255), postalcode VARCHAR(255))
                BEGIN
                DECLARE ConID INT UNSIGNED;
                DECLARE AddID INT UNSIGNED;

                START TRANSACTION;
                UPDATE `HarrisSonsDB`.`tblEmployee`
                SET `FirstName` = firstname, `LastName` = lastname, `BirthDate` = birthdate, `PositionID` = positionid 
                WHERE `EmployeeID` = id;
                SELECT BusinessContactID FROM `HarrisSonsDB`.`tblEmployee` WHERE EmployeeID = id INTO ConID;

                UPDATE `HarrisSonsDB`.`tblBusinessContact`
                SET `EmailAddress` = emailaddress, `Telephone` = telephone, `BusinessTelephone` = businesstelephone
                WHERE `BusinessContactID` = ConID;
                SELECT AddressID FROM `HarrisSonsDB`.`tblBusinessContact` WHERE BusinessContactID = ConID INTO AddID;

                UPDATE `HarrisSonsDB`.`tblAddress`
                SET `AddressLine1` = address1, `AddressLine2` = address2, `City` = city, `State` = state, `Country` = country, `PostalCode` = postalcode
                WHERE `AddressID` = AddID;
                COMMIT;
                END";

            string spUpdatePersonalContact = @"CREATE DEFINER=`admin`@`%` PROCEDURE `spUpdatePersonalContact`(IN id INT, IN firstname VARCHAR(255), lastname VARCHAR(255), birthdate VARCHAR(255), emailaddress VARCHAR(255), telephone VARCHAR(255), hometelephone VARCHAR(255),
                address1 VARCHAR(255), address2 VARCHAR(255), city VARCHAR(255), state VARCHAR(255), country VARCHAR(255), postalcode VARCHAR(255))
                BEGIN
                DECLARE ConID INT UNSIGNED;
                DECLARE AddID INT UNSIGNED;
 
                START TRANSACTION;
                UPDATE `HarrisSonsDB`.`tblClient`
                SET `FirstName` = firstname, `LastName` = lastname, `BirthDate` = birthdate 
                WHERE `ClientID` = id;
                SELECT PersonalContactID FROM `HarrisSonsDB`.`tblClient` WHERE ClientID = id INTO ConID;

                UPDATE `HarrisSonsDB`.`tblPersonalContact`
                SET `EmailAddress` = emailaddress, `Telephone` = telephone, `HomeTelephone` = hometelephone
                WHERE `PersonalContactID` = ConID;
                SELECT AddressID FROM `HarrisSonsDB`.`tblPersonalContact` WHERE PersonalContactID = ConID INTO AddID;

                UPDATE `HarrisSonsDB`.`tblAddress`
                SET `AddressLine1` = address1, `AddressLine2` = address2, `City` = city, `State` = state, `Country` = country, `PostalCode` = postalcode
                WHERE `AddressID` = AddID;
                COMMIT;
                END";

            migrationBuilder.Sql(spAddAddress);
            migrationBuilder.Sql(spAddBusinessContact);
            migrationBuilder.Sql(spAddPersonalContact);
            migrationBuilder.Sql(spDeleteAddress);
            migrationBuilder.Sql(spGetAllAddress);
            migrationBuilder.Sql(spGetAllPosition);
            migrationBuilder.Sql(spGetAllViewBusinessContactDetail);
            migrationBuilder.Sql(spGetAllViewPersonalContactDetail);
            migrationBuilder.Sql(spGetBusinessAddressID);
            migrationBuilder.Sql(spGetPersonalAddressID);
            migrationBuilder.Sql(spSearchBusinessContact);
            migrationBuilder.Sql(spSearchPersonalContact);
            migrationBuilder.Sql(spUpdateAddress);
            migrationBuilder.Sql(spUpdateBusinessContact);
            migrationBuilder.Sql(spUpdatePersonalContact);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string spAddAddressDrop = "DROP PROCEDURE IF EXISTS `spAddAddress` ";
            string spAddBusinessContactDrop = "DROP PROCEDURE IF EXISTS `spAddBusinessContact`";
            string spAddPersonalContactDrop = "DROP PROCEDURE IF EXISTS `spAddPersonalContact`";
            string spDeleteAddressDrop = "DROP PROCEDURE IF EXISTS `spDeleteAddress`";
            string spGetAllAddressDrop = "DROP PROCEDURE IF EXISTS `spGetAllAddress`";
            string spGetAllPositionDrop = "DROP PROCEDURE IF EXISTS `spGetAllPosition`";
            string spGetAllViewBusinessContactDetailDrop = "DROP PROCEDURE IF EXISTS `spGetAllViewBusinessContactDetail`";
            string spGetAllViewPersonalContactDetailDrop = "DROP PROCEDURE IF EXISTS `spGetAllViewPersonalContactDetail`";
            string spGetBusinessAddressIDDrop = "DROP PROCEDURE IF EXISTS `spGetBusinessAddressID`";
            string spGetPersonalAddressIDDrop = "DROP PROCEDURE IF EXISTS `spGetPersonalAddressID`";
            string spSearchBusinessContactDrop = "DROP PROCEDURE IF EXISTS `spSearchBusinessContact`";
            string spSearchPersonalContactDrop = "DROP PROCEDURE IF EXISTS `spSearchPersonalContact`";
            string spUpdateAddressDrop = "DROP PROCEDURE IF EXISTS `spUpdateAddress`";
            string spUpdateBusinessContactDrop = "DROP PROCEDURE IF EXISTS `spUpdateBusinessContact`";
            string spUpdatePersonalContactDrop = "DROP PROCEDURE IF EXISTS `spUpdatePersonalContact`";

            migrationBuilder.Sql(spAddAddressDrop);
            migrationBuilder.Sql(spAddBusinessContactDrop);
            migrationBuilder.Sql(spAddPersonalContactDrop);
            migrationBuilder.Sql(spDeleteAddressDrop);
            migrationBuilder.Sql(spGetAllAddressDrop);
            migrationBuilder.Sql(spGetAllPositionDrop);
            migrationBuilder.Sql(spGetAllViewBusinessContactDetailDrop);
            migrationBuilder.Sql(spGetAllViewPersonalContactDetailDrop);
            migrationBuilder.Sql(spGetBusinessAddressIDDrop);
            migrationBuilder.Sql(spGetPersonalAddressIDDrop);
            migrationBuilder.Sql(spSearchBusinessContactDrop);
            migrationBuilder.Sql(spSearchPersonalContactDrop);
            migrationBuilder.Sql(spUpdateAddressDrop);
            migrationBuilder.Sql(spUpdateBusinessContactDrop);
            migrationBuilder.Sql(spUpdatePersonalContactDrop);
        }
    }
}
