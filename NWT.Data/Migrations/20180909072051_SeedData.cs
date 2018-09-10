using Microsoft.EntityFrameworkCore.Migrations;
using NWT.Data.Properties;

namespace NWT.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(Resources.SeedData_Up);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(Resources.SeedData_Down);
        }
    }
}
