using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Await_DotNet_PrototypeVersion_2.Migrations
{
    /// <inheritdoc />
    public partial class addNewCompanyColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "AspNetUsers");

        }
    }
}
