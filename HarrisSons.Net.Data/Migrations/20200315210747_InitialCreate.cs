using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HarrisSons.Net.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblAddress",
                columns: table => new
                {
                    AddressID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AddressLine1 = table.Column<string>(nullable: true),
                    AddressLine2 = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: false),
                    State = table.Column<string>(nullable: false),
                    Country = table.Column<string>(nullable: false),
                    PostalCode = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAddress", x => x.AddressID);
                });

            migrationBuilder.CreateTable(
                name: "tblDepartment",
                columns: table => new
                {
                    DepartmentID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    GroupName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblDepartment", x => x.DepartmentID);
                });

            migrationBuilder.CreateTable(
                name: "tblPayRate",
                columns: table => new
                {
                    PayRateID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Rank = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPayRate", x => x.PayRateID);
                });

            migrationBuilder.CreateTable(
                name: "tblBusinessContact",
                columns: table => new
                {
                    BusinessContactID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EmailAddress = table.Column<string>(nullable: false),
                    Telephone = table.Column<string>(nullable: false),
                    BusinessTelephone = table.Column<string>(nullable: false),
                    AddressID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblBusinessContact", x => x.BusinessContactID);
                    table.ForeignKey(
                        name: "FK_tblBusinessContact_tblAddress_AddressID",
                        column: x => x.AddressID,
                        principalTable: "tblAddress",
                        principalColumn: "AddressID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblPersonalContact",
                columns: table => new
                {
                    PersonalContactID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EmailAddress = table.Column<string>(nullable: false),
                    Telephone = table.Column<string>(nullable: false),
                    HomeTelephone = table.Column<string>(nullable: false),
                    AddressID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPersonalContact", x => x.PersonalContactID);
                    table.ForeignKey(
                        name: "FK_tblPersonalContact_tblAddress_AddressID",
                        column: x => x.AddressID,
                        principalTable: "tblAddress",
                        principalColumn: "AddressID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblPosition",
                columns: table => new
                {
                    PositionID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    DepartmentID = table.Column<int>(nullable: false),
                    PayRateID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPosition", x => x.PositionID);
                    table.ForeignKey(
                        name: "FK_tblPosition_tblDepartment_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "tblDepartment",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblPosition_tblPayRate_PayRateID",
                        column: x => x.PayRateID,
                        principalTable: "tblPayRate",
                        principalColumn: "PayRateID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblClient",
                columns: table => new
                {
                    ClientID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    BirthDate = table.Column<DateTime>(type: "date", nullable: false),
                    FirstContactDate = table.Column<DateTime>(type: "date", nullable: true),
                    LastContactDate = table.Column<DateTime>(type: "date", nullable: true),
                    PersonalContactID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblClient", x => x.ClientID);
                    table.ForeignKey(
                        name: "FK_tblClient_tblPersonalContact_PersonalContactID",
                        column: x => x.PersonalContactID,
                        principalTable: "tblPersonalContact",
                        principalColumn: "PersonalContactID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblEmployee",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    BirthDate = table.Column<DateTime>(type: "date", nullable: false),
                    NationalInsuranceNumber = table.Column<string>(nullable: false),
                    HireDate = table.Column<DateTime>(type: "date", nullable: false),
                    PositionID = table.Column<int>(nullable: false),
                    BusinessContactID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEmployee", x => x.EmployeeID);
                    table.ForeignKey(
                        name: "FK_tblEmployee_tblBusinessContact_BusinessContactID",
                        column: x => x.BusinessContactID,
                        principalTable: "tblBusinessContact",
                        principalColumn: "BusinessContactID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblEmployee_tblPosition_PositionID",
                        column: x => x.PositionID,
                        principalTable: "tblPosition",
                        principalColumn: "PositionID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblBusinessContact_AddressID",
                table: "tblBusinessContact",
                column: "AddressID");

            migrationBuilder.CreateIndex(
                name: "IX_tblClient_PersonalContactID",
                table: "tblClient",
                column: "PersonalContactID");

            migrationBuilder.CreateIndex(
                name: "IX_tblEmployee_BusinessContactID",
                table: "tblEmployee",
                column: "BusinessContactID");

            migrationBuilder.CreateIndex(
                name: "IX_tblEmployee_PositionID",
                table: "tblEmployee",
                column: "PositionID");

            migrationBuilder.CreateIndex(
                name: "IX_tblPersonalContact_AddressID",
                table: "tblPersonalContact",
                column: "AddressID");

            migrationBuilder.CreateIndex(
                name: "IX_tblPosition_DepartmentID",
                table: "tblPosition",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_tblPosition_PayRateID",
                table: "tblPosition",
                column: "PayRateID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblClient");

            migrationBuilder.DropTable(
                name: "tblEmployee");

            migrationBuilder.DropTable(
                name: "tblPersonalContact");

            migrationBuilder.DropTable(
                name: "tblBusinessContact");

            migrationBuilder.DropTable(
                name: "tblPosition");

            migrationBuilder.DropTable(
                name: "tblAddress");

            migrationBuilder.DropTable(
                name: "tblDepartment");

            migrationBuilder.DropTable(
                name: "tblPayRate");
        }
    }
}
