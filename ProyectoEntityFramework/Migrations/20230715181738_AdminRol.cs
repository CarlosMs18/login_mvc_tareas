using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoEntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class AdminRol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"              
                    IF NOT EXISTS(SELECT Id FROM AspNetRoles where Id= 'a4431cae-f94d-48dd-8273-85a9b3df3ccb')
                    BEGIN 
                    INSERT AspNetRoles (Id, [Name], [NormalizedName])
                    VALUES ('a4431cae-f94d-48dd-8273-85a9b3df3ccb','admin','ADMIN');
                    END
             ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE AspNetRoles WHERE Id = 'a4431cae-f94d-48dd-8273-85a9b3df3ccb'");
        }
    }
}
