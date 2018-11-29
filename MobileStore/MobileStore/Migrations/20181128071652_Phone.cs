using Microsoft.EntityFrameworkCore.Migrations;

namespace MobileStore.Migrations
{
    public partial class Phone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageDetail1",
                table: "Phones",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageDetail2",
                table: "Phones",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageDetail3",
                table: "Phones",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LongDescription",
                table: "Phones",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageDetail1",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "ImageDetail2",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "ImageDetail3",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "LongDescription",
                table: "Phones");
        }
    }
}
