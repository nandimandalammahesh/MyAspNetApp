using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyAspNetApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "4m_data",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Time_Stamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Pid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupplierName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Partcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Partname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModelDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SourcingApproval = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManufacturingApproval = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProcurementApproval = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SafetyApproval = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequiredApproval = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Applicable = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SelectedDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChangeDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SelectedSub = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BeforeChangeRemark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AfterChangeRemark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Initiatorid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Initiatormail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Initiatordept = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_4m_data", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "4m_data");
        }
    }
}
