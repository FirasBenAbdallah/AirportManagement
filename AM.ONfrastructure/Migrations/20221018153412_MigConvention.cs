using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.INfrastructure.Migrations
{
    public partial class MigConvention : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flights_MyPlanes_PlaneFk",
                table: "Flights");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyPlanes",
                table: "MyPlanes");

            migrationBuilder.RenameTable(
                name: "MyPlanes",
                newName: "MyPlane");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyPlane",
                table: "MyPlane",
                column: "PlaneId");

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_MyPlane_PlaneFk",
                table: "Flights",
                column: "PlaneFk",
                principalTable: "MyPlane",
                principalColumn: "PlaneId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flights_MyPlane_PlaneFk",
                table: "Flights");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyPlane",
                table: "MyPlane");

            migrationBuilder.RenameTable(
                name: "MyPlane",
                newName: "MyPlanes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyPlanes",
                table: "MyPlanes",
                column: "PlaneId");

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_MyPlanes_PlaneFk",
                table: "Flights",
                column: "PlaneFk",
                principalTable: "MyPlanes",
                principalColumn: "PlaneId");
        }
    }
}
