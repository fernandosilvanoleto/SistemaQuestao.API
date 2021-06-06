using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaQuestao.Infrastructure.Migrations
{
    public partial class AddColumnAreaDisciplinaMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StatusAreaDisciplina",
                table: "AreaDisciplinas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StatusAreaDisciplina",
                table: "AreaDisciplinas");
        }
    }
}
