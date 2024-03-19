using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopManagement.Infrastructure.EFCore.Migrations
{
    /// <inheritdoc />
    public partial class initruyfu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Addres",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Application",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "BazarTeteri",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "GhabeliatTabdilMogodiKochak",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "HadForosh",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "HadKharid",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Information",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "KarmozdBazarToman",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "KifPolEkhtesasi",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "NaghdBaresi",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PayePoly",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PoshtibaniShabake",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "SystemDaramadZayi",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Tasvie",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TedadKarmand",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TolSarafi",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "TwoLogin",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "hadAksarZamanHoviat",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "noSarafi",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Addres",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Application",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "BazarTeteri",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "GhabeliatTabdilMogodiKochak",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "HadForosh",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "HadKharid",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Information",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "KarmozdBazarToman",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "KifPolEkhtesasi",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "NaghdBaresi",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "PayePoly",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "PoshtibaniShabake",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SystemDaramadZayi",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Tasvie",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "TedadKarmand",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "TolSarafi",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "TwoLogin",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Url",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "hadAksarZamanHoviat",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "noSarafi",
                table: "Products");
        }
    }
}
