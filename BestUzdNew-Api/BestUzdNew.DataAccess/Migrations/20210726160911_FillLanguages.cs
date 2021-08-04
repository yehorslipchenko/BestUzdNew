using Microsoft.EntityFrameworkCore.Migrations;

namespace BestUzdNew.DataAccess.Migrations
{
    public partial class FillLanguages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($@"
                INSERT INTO Language(Name, ShortName, ImageSrc)
                VALUES (N'Русский', N'Rus', '')

                INSERT INTO Language(Name, ShortName, ImageSrc)
                VALUES (N'English', N'Eng', '')
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
