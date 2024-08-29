using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Questions_NET.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class name1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "InterviewName",
                table: "Interviews",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InterviewName",
                table: "Interviews");
        }
    }
}
