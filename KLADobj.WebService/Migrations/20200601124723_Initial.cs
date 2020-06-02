using Microsoft.EntityFrameworkCore.Migrations;

namespace KLADobj.WebService.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KLADobjs",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    ChillType = table.Column<string>(nullable: true),
                    Free = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KLADobjs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 1L, "город Москва, Манежная улица, дом 2-10, сооружение 1", "бесплатный", "действует", "Стационарный общественный туалет № 123" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 2L, "город Москва, Большая Садовая улица, дом 16, сооружение 1", "бесплатный", "действует", "Стационарный общественный туалет № 45" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 3L, "город Москва, улица Земляной Вал, дом 1/4, строение 1", "бесплатный", "действует", "Стационарный общественный туалет № 13" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 4L, "город Москва, Марксистская улица, дом 2, строение 2", "бесплатный", "действует", "Стационарный общественный туалет № 85" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KLADobjs");
        }
    }
}
