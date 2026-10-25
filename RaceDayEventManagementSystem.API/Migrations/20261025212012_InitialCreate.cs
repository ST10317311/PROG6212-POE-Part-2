using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RaceDayEventManagementSystem.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    categoryID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    categoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    categoryDistance = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: true),
                    categoryEntryFee = table.Column<int>(type: "int", nullable: false),
                    categoryMaxParticipants = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.categoryID);
                });

            migrationBuilder.CreateTable(
                name: "Entries",
                columns: table => new
                {
                    entryID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    participantID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    eventID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    entryDate = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entries", x => x.entryID);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    eventID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    eventName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    eventTypeID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    eventLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    eventStartTime = table.Column<TimeOnly>(type: "time", nullable: true),
                    eventEndTime = table.Column<TimeOnly>(type: "time", nullable: true),
                    organiserID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.eventID);
                });

            migrationBuilder.CreateTable(
                name: "EventTypes",
                columns: table => new
                {
                    eventTypeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    eventTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    eventTypeDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventTypes", x => x.eventTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Organisers",
                columns: table => new
                {
                    organiserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    organiserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    organiserSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    organiserAge = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    organiserEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    organiserPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organisers", x => x.organiserID);
                });

            migrationBuilder.CreateTable(
                name: "Participants",
                columns: table => new
                {
                    participantID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    participantName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    participantSurname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    participantBirthDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    participantGender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    participantCountryOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    participantPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    participantEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    participantPassword = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participants", x => x.participantID);
                });

            migrationBuilder.CreateTable(
                name: "Results",
                columns: table => new
                {
                    resultID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    entryID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    startTime = table.Column<TimeOnly>(type: "time", nullable: true),
                    endTime = table.Column<TimeOnly>(type: "time", nullable: true),
                    position = table.Column<int>(type: "int", nullable: true),
                    resultAverageSpeed = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: true),
                    resultStatus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Results", x => x.resultID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Entries");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "EventTypes");

            migrationBuilder.DropTable(
                name: "Organisers");

            migrationBuilder.DropTable(
                name: "Participants");

            migrationBuilder.DropTable(
                name: "Results");
        }
    }
}
