using Microsoft.EntityFrameworkCore.Migrations;

namespace SimpleCRM.Data.Migrations
{
    public partial class CampaignTableUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CampaignMonth",
                table: "Campaigns",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CampaignYear",
                table: "Campaigns",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CampaignMonth",
                table: "Campaigns");

            migrationBuilder.DropColumn(
                name: "CampaignYear",
                table: "Campaigns");
        }
    }
}
