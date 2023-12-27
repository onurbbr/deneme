using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SporcialAPI.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HealthInformations",
                columns: table => new
                {
                    HealthInformationId = table.Column<Guid>(type: "uuid", nullable: false),
                    BMI = table.Column<float>(type: "real", nullable: false),
                    StepCount = table.Column<int>(type: "integer", nullable: false),
                    ScreenTime = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthInformations", x => x.HealthInformationId);
                });

            migrationBuilder.CreateTable(
                name: "UserActivities",
                columns: table => new
                {
                    ActivityId = table.Column<Guid>(type: "uuid", nullable: false),
                    ActivityType = table.Column<string>(type: "text", nullable: true),
                    ActivityDuration = table.Column<int>(type: "integer", nullable: true),
                    ActivityDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserActivities", x => x.ActivityId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserEmail = table.Column<string>(type: "text", nullable: false),
                    UserPassword = table.Column<string>(type: "text", nullable: false),
                    UserName = table.Column<string>(type: "text", nullable: false),
                    UserSurname = table.Column<string>(type: "text", nullable: false),
                    UserBirthDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UserLocation = table.Column<string>(type: "text", nullable: false),
                    UserHeight = table.Column<int>(type: "integer", nullable: false),
                    UserWeight = table.Column<int>(type: "integer", nullable: false),
                    UserProfilePhoto = table.Column<string>(type: "text", nullable: true),
                    UserAgreement = table.Column<bool>(type: "boolean", nullable: false),
                    HealthAgreement = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HealthInformations");

            migrationBuilder.DropTable(
                name: "UserActivities");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
