using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Volunteer_management_system.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applications_Opportunities_OpportunitiesID",
                table: "Applications");

            migrationBuilder.DropIndex(
                name: "IX_Applications_OpportunitiesID",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "OpportunitiesID",
                table: "Applications");

            migrationBuilder.AlterColumn<string>(
                name: "OpportunityID",
                table: "Applications",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_OpportunityID",
                table: "Applications",
                column: "OpportunityID");

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_Opportunities_OpportunityID",
                table: "Applications",
                column: "OpportunityID",
                principalTable: "Opportunities",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applications_Opportunities_OpportunityID",
                table: "Applications");

            migrationBuilder.DropIndex(
                name: "IX_Applications_OpportunityID",
                table: "Applications");

            migrationBuilder.AlterColumn<string>(
                name: "OpportunityID",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "OpportunitiesID",
                table: "Applications",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Applications_OpportunitiesID",
                table: "Applications",
                column: "OpportunitiesID");

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_Opportunities_OpportunitiesID",
                table: "Applications",
                column: "OpportunitiesID",
                principalTable: "Opportunities",
                principalColumn: "ID");
        }
    }
}
