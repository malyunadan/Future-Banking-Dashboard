using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FutureBankingDashboard.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CleanStart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Economy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Income = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Expenses = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Economy", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Funding",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicationUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequiredCo2Score = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funding", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recommendations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recommendations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sustainability",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Co2Score = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MonthlyEmission = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GreenEnergiPercentage = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sustainability", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Economy",
                columns: new[] { "Id", "Balance", "CompanyId", "Expenses", "Income" },
                values: new object[,]
                {
                    { 1, 40000m, 1, 80000m, 120000m },
                    { 2, 45000m, 1, 85000m, 130000m },
                    { 3, 43000m, 1, 82000m, 125000m },
                    { 4, 50000m, 1, 90000m, 140000m },
                    { 5, 55000m, 1, 95000m, 150000m }
                });

            migrationBuilder.InsertData(
                table: "Funding",
                columns: new[] { "Id", "ApplicationUrl", "Description", "RequiredCo2Score", "Title" },
                values: new object[,]
                {
                    { 1, "https://example.com/omstillingspulje", "Støtte til virksomheder der reducerer CO2‑udledning.", "C", "Grøn Omstillingspulje" },
                    { 2, "https://example.com/energi", "Tilskud til energieffektive løsninger.", "B", "Energiforbedringsstøtte" },
                    { 3, "https://example.com/digital", "Funding til digitale grønne projekter.", "B", "Digital Grøn Innovation" },
                    { 4, "https://example.com/smv", "Støtte til små og mellemstore virksomheder.", "D", "SMV Grøn" },
                    { 5, "https://example.com/eu", "EU‑tilskud til klimaprojekter.", "A", "EU KlimaFond" }
                });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CompanyId", "Priority", "Text" },
                values: new object[,]
                {
                    { 1, 1, 1, "Reducer energiforbruget i produktionen." },
                    { 2, 1, 2, "Skift til grønne leverandører." },
                    { 3, 1, 3, "Invester i solceller." },
                    { 4, 1, 2, "Optimer transportlogistik." },
                    { 5, 1, 1, "Implementér CO2‑overvågning." }
                });

            migrationBuilder.InsertData(
                table: "Sustainability",
                columns: new[] { "Id", "Co2Score", "CompanyId", "GreenEnergiPercentage", "MonthlyEmission" },
                values: new object[,]
                {
                    { 1, "D", 1, 35, 1400m },
                    { 2, "C", 1, 38, 1350m },
                    { 3, "C", 1, 40, 1300m },
                    { 4, "B", 1, 43, 1250m },
                    { 5, "B", 1, 45, 1200m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Economy");

            migrationBuilder.DropTable(
                name: "Funding");

            migrationBuilder.DropTable(
                name: "Recommendations");

            migrationBuilder.DropTable(
                name: "Sustainability");
        }
    }
}
