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
                    Location = table.Column<string>(nullable: true),
                    PaidService = table.Column<string>(nullable: true),
                    CloseFlag = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KLADobjs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 1L, "действует", "город Москва, Манежная улица, дом 2-10, сооружение 1", "Стационарный общественный туалет № 123", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 177L, "действует", "город Москва, 9-я Парковая улица, дом 18", "Стационарный общественный туалет № 17", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 178L, "действует", "город Москва, Измайловский проспект, владение 60, строение 1", "Стационарный общественный туалет № 195", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 179L, "действует", "город Москва, Измайловская площадь, дом 1, строение 2", "Стационарный общественный туалет № 191", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 180L, "действует", "город Москва, проспект Андропова, дом 30, корпус 2", "Стационарный общественный туалет № 141", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 181L, "действует", "город Москва, Ярославское шоссе, дом 50", "Стационарный общественный туалет № 204", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 182L, "действует", "город Москва, Анадырский проезд, дом 64", "Стационарный общественный туалет № 192", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 183L, "действует", "город Москва, проспект Мира, дом 109, строение 1", "Стационарный общественный туалет № 91", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 184L, "действует", "город Москва, проспект Мира, дом 93", "Стационарный общественный туалет № 177", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 185L, "действует", "город Москва, 1-я Останкинская улица, дом 55Д", "Стационарный общественный туалет № 96", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 186L, "действует", "город Москва, проспект Мира, дом 119, строение 609", "Стационарный общественный туалет № 99", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 187L, "действует", "город Москва, улица Народного Ополчения, дом 20А", "Стационарный общественный туалет № 51", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 188L, "действует", "город Москва, Туристская улица, дом 8, строение 1", "Стационарный общественный туалет № 185", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 189L, "действует", "город Москва, Профсоюзная улица, дом 19", "Стационарный общественный туалет № 5", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 190L, "действует", "город Москва, Нагорный бульвар, дом 7", "Стационарный общественный туалет № 117", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 191L, "действует", "город Москва, улица Адмирала Лазарева, владение 17, строение 3", "Стационарный общественный туалет № 26", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 192L, "действует", "Рябиновая улица, владение 46, строение 17", "Стационарный общественный туалет № 188", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 193L, "действует", "город Москва, улица Наташи Ковшовой, дом 6А", "Стационарный общественный туалет № 143", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 207L, "действует", "город Москва, улица Крымский Вал, дом 9, строение 46", "Стационарный общественный туалет строение №46 (парк Горького)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 206L, "действует", "город Москва, улица Крымский Вал, дом 9, строение 55", "Стационарный общественный туалет строение №55 (парк Горького)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 205L, "действует", "город Москва, улица Крымский Вал, дом 9, строение 56", "Стационарный общественный туалет строение №56 (парк Горького)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 204L, "действует", "город Москва, улица Крымский Вал, дом 9, строение 47", "Стационарный общественный туалет строение №47 (парк Горького)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 203L, "действует", "город Москва, улица Крымский Вал, дом 9, строение 53", "Стационарный общественный туалет строение №53 (парк Горького)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 202L, "действует", "город Москва, улица Крымский Вал, дом 9, строение 6", "Стационарный общественный туалет строение №6 (парк Горького)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 176L, "действует", "город Москва, улица 9 Мая, дом 8А", "Стационарный общественный туалет № 92", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 201L, "действует", "город Москва, улица Воронцовские Пруды, дом 2, строение 1", "Стационарный общественный туалет № 1 (Воронцовский парк)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 199L, "действует", "город Москва, улица Крымский Вал, дом 10", "Стационарный общественный туалет женский № 2 (Музеон)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 198L, "действует", "город Москва, улица Крымский Вал, дом 10", "Стационарный общественный туалет мужской № 2 (Музеон)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 197L, "действует", "город Москва, 3-й Голутвинский переулок, дом 10, строение 1", "Стационарный общественный туалет женский № 1 (Музеон)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 196L, "действует", "город Москва, 3-й Голутвинский переулок, дом 10, строение 1", "Стационарный общественный туалет мужской № 1 (Музеон)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 195L, "действует", "город Москва, улица Свободы, дом 56, строение 1", "Стационарный общественный туалет № 2 (МПК Северное Тушино)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 194L, "действует", "город Москва, улица 26-ти Бакинских Комиссаров, дом 7, корпус 6", "Стационарный общественный туалет № 24", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 200L, "действует", "город Москва, улица Крымский Вал, дом 10", "Стационарный общественный туалет № 3 (Музеон)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 208L, "действует", "город Москва, улица Крымский Вал, дом 9, строение 74", "Туалет, душевая возле теннисного корта (парк Горького)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 175L, "закрыт", "город Москва, Рязанский проспект, дом 75Б, сооружение 1", "Стационарный общественный туалет № 159", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 173L, "действует", "улица Академика Скрябина, дом 19, строение 18", "Стационарный общественный туалет № 194", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 142L, "действует", "город Москва, Осенний бульвар, дом 14", "Стационарный общественный туалет № 131", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 143L, "действует", "город Москва, улица Ивана Франко, дом 12Б", "Стационарный общественный туалет № 73", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 144L, "действует", "город Москва, улица Барклая, дом 7, корпус 1", "Стационарный общественный туалет № 83", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 145L, "действует", "город Москва, улица Матросская Тишина, дом 14, строение 2", "Стационарный общественный туалет № 2", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 146L, "закрыт", "город Москва, улица Солянка, дом 16", "Стационарный общественный туалет № 33", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 147L, "действует", "город Москва, Ангарская улица, дом 42, строение 2", "Стационарный общественный туалет № 211", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 148L, "действует", "город Москва, Вятская улица, дом 39, строение 2", "Стационарный общественный туалет № 173", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 149L, "закрыт", "город Москва, Новопетровская улица, дом 6А", "Стационарный общественный туалет № 97", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 150L, "закрыт", "город Москва, Театральная аллея, дом 1, строение 1", "Стационарный общественный туалет № 163", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 151L, "действует", "город Москва, Бескудниковский бульвар, дом 36, корпус 4, строение 1", "Стационарный общественный туалет № 22", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 152L, "действует", "город Москва, Дубнинская улица, дом 12, сооружение 1", "Стационарный общественный туалет № 205", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 153L, "действует", "город Москва, Ленинградское шоссе, дом 112/1, сооружение 1", "Стационарный общественный туалет № 203", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 154L, "действует", "город Москва, Михалковская улица, дом 2, строение 2", "Стационарный общественный туалет № 21", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 155L, "действует", "город Москва, Беговая аллея, дом 3", "Стационарный общественный туалет № 28", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 156L, "действует", "г. Зеленоград, улица Панфилова, дом 13, строение 1", "Стационарный общественный туалет № 216", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 157L, "действует", "город Москва, улица Петровка, дом 30/7", "Стационарный общественный туалет № 46", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 158L, "действует", "город Москва, Большой Черкасский переулок, дом 13, строение 3", "Стационарный общественный туалет № 128", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 172L, "действует", "город Москва, Зеленодольская улица, дом 43", "Стационарный общественный туалет № 150", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 171L, "действует", "город Москва, Краснодарская улица, дом 51, сооружение 1", "Стационарный общественный туалет № 139", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 170L, "действует", "город Москва, улица Мичуринский Проспект, Олимпийская Деревня, дом 4, корпус 2", "Стационарный общественный туалет № 27", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 169L, "действует", "город Москва, Голубинская улица, владение 5, строение 2", "Стационарный общественный туалет № 214", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 168L, "действует", "город Москва, улица Гарибальди, дом 3, сооружение 1", "Стационарный общественный туалет № 136", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 167L, "действует", "город Москва, Бутырская улица, дом 82А", "Стационарный общественный туалет № 176", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 174L, "действует", "город Москва, Люблинская улица, дом 4, сооружение 1", "Стационарный общественный туалет № 155", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 166L, "действует", "город Москва, Рижский проезд, дом 6, корпус 1", "Стационарный общественный туалет № 181", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 164L, "действует", "город Москва, 1-й проезд Марьиной Рощи, дом 16", "Стационарный общественный туалет № 168", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 163L, "действует", "город Москва, Ереванская улица, дом 17А", "Стационарный общественный туалет № 109", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 162L, "закрыт", "город Москва, Электродная улица, дом 1А", "Стационарный общественный туалет № 130", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 161L, "действует", "город Москва, Люблинская улица, дом 50, строение 1", "Стационарный общественный туалет № 142", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 160L, "действует", "город Москва, Конюшковская улица, владение 29, строение 1", "Стационарный общественный туалет № 132", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 159L, "действует", "город Москва, Моховая улица, дом 10, строение 8", "Стационарный общественный туалет № 122", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 165L, "действует", "город Москва, Анадырский проезд, дом 8, строение 1", "Стационарный общественный туалет № 193", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 141L, "действует", "город Москва, улица Барклая, дом 20А", "Стационарный общественный туалет № 121", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 209L, "действует", "город Москва, улица Крымский Вал, дом 9, строение 42", "Стационарный общественный туалет строение №42 (парк Горького)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 211L, "действует", "город Москва, улица Крымский Вал, дом 9, строение 58", "Стационарный общественный туалет строение №58 (парк Горького)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 247L, "действует", "город Москва, аллея Большого Круга, владение 1, сооружение 3", "Стационарный общественный туалет № 4 (Измайловский ПКиО)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 248L, "действует", "город Москва, Майский просек, владение 4, строение 1", "Стационарный общественный туалет № 1 (ПКиО Сокольники)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 249L, "действует", "город Москва, Песочная аллея, владение 2, строение 1", "Стационарный общественный туалет № 7 (ПКиО Сокольники)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 250L, "действует", "город Москва, Старая Басманная улица, дом 15, строение 21", "Стационарный общественный туалет № 1 (Сад имени Баумана)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 251L, "действует", "9-я Парковая улица, владение 1 (напротив)", "Стационарный общественный туалет № 1", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 252L, "действует", "город Москва, улица Юности, дом 2", "Стационарный общественный туалет № 7", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 253L, "действует", "город Москва, улица Красного Маяка, дом 28", "Стационарный общественный туалет № 8", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 254L, "действует", "Старобитцевская улица, дом 23", "Стационарный общественный туалет № 9", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 255L, "действует", "36-й километр Московской Кольцевой Автодороги", "Стационарный общественный туалет № 10", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 256L, "действует", "36-й километр Московской Кольцевой Автодороги", "Стационарный общественный туалет № 11", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 257L, "закрыт", "город Москва, улица Дубки, дом 6, строение 2", "Стационарный общественный туалет № 2 (ПКиО Лианозовский)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 258L, "действует", "город Москва, улица Удальцова, владение 18А", "Стационарный общественный туалет №189 (Парк 50-летия Октября, ПКиО Фили)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 259L, "действует", "город Москва, Большая Семёновская улица, дом 50, строение 2", "Стационарный общественный туалет № 221", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 260L, "закрыт", "город Москва, Большая Черкизовская улица, дом 3, корпус 1, сооружение 1", "Стационарный общественный туалет № 222", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 261L, "закрыт", "город Москва, улица Подольских Курсантов, дом 24Б, строение 1", "Стационарный общественный туалет № 223", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 262L, "действует", "город Москва, Новопесчаная улица, дом 12, строение 4", "Стационарный общественный туалет № 224", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 263L, "действует", "город Москва, улица Плющиха, дом 57, строение 4", "Стационарный общественный туалет № 225", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 277L, "действует", "город Москва, аллея Жемчуговой, владение 2, строение 4", "Стационарный общественный туалет № 3 (Парк у прудов «Радуга»)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 276L, "действует", "город Москва, аллея Жемчуговой, владение 2, строение 5", "Стационарный общественный туалет № 2 (Парк у прудов «Радуга»)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 275L, "действует", "город Москва, аллея Жемчуговой, владение 2, строение 3", "Стационарный общественный туалет № 1 (Парк у прудов «Радуга»)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 274L, "действует", "город Москва, Волгоградский проспект, владение 168Д, строение 10", "Стационарный общественный туалет (Московская усадьба Деда Мороза)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 273L, "действует", "город Москва, Таганская улица, дом 15А, строение 1", "Стационарный общественный туалет (детская территория ПКиО Таганский)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 272L, "действует", "город Москва, улица Варварка, домовладение 6, строение 1", "Стационарный общественный туалет № 5", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 246L, "действует", "город Москва, Измайловский проспект, владение 1, строение 1", "Стационарный общественный туалет № 1 (Измайловский ПКиО)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 271L, "действует", "город Москва, улица Варварка, домовладение 6, строение 1", "Стационарный общественный туалет № 4", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 269L, "действует", "город Москва, улица Варварка, домовладение 6, строение 1", "Стационарный общественный туалет № 2", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 268L, "действует", "город Москва, улица Варварка, домовладение 6, строение 1", "Стационарный общественный туалет № 1", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 267L, "действует", "город Москва, Дольская улица, дом 1, строение 36", "Стационарный общественный туалет №4 (Усадьба Царицыно)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 266L, "действует", "город Москва, Митьковский проезд, дом 4", "Стационарный общественный туалет № 9 (ПКиО Сокольники)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 265L, "закрыт", "город Москва, улица Хамовнический Вал, дом 24, строение 3", "Стационарный общественный туалет 225", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 264L, "действует", "город Москва, Красноказарменная улица, дом 1, строение 6", "Стационарный общественный туалет №214", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 270L, "действует", "город Москва, улица Варварка, домовладение 6, строение 1", "Стационарный общественный туалет № 3", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 210L, "действует", "город Москва, улица Крымский Вал, дом 9, строение 57", "Туалет у пожарной части (парк Горького)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 245L, "действует", "город Москва, улица Крымский Вал, дом 9, строение 4", "Стационарный общественный туалет строение №4 (парк Горького)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 243L, "действует", "город Москва, площадь Победы, дом 3А", "Стационарный общественный туалет № 1 (парк Победы на Поклонной горе)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 212L, "действует", "город Москва, улица Крымский Вал, дом 9, строение 53", "Туалет рядом с лодочным прокатом Голицынского пруда (парк Горького)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 213L, "действует", "город Москва, улица Крымский Вал, дом 9, строение 39", "Стационарный общественный туалет строение №39 (парк Горького)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 214L, "действует", "город Москва, улица Крымский Вал, дом 9, строение 64", "Туалет в спортивном павильоне (парк Горького)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 215L, "действует", "город Москва, Народный проспект, владение 1, строение 3", "Стационарный общественный туалет № 2 (Измайловский ПКиО)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 216L, "действует", "город Москва, Народный проспект, владение 10, строение 1", "Стационарный общественный туалет № 3 (Измайловский ПКиО)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 217L, "действует", "город Москва, аллея Большого Круга, владение 3, строение 4", "Стационарный общественный туалет № 5 (Измайловский ПКиО)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 218L, "действует", "город Москва, Большая Филёвская улица, дом 24", "Стационарный общественный туалет (ПКиО Фили)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 219L, "действует", "город Москва, Майский просек, владение 2А, строение 1", "Стационарный общественный туалет № 2 (ПКиО Сокольники)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 220L, "действует", "город Москва, 3-й Лучевой просек, владение 6, строение 1", "Стационарный общественный туалет № 3 (ПКиО Сокольники)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 221L, "действует", "город Москва, 5-й Лучевой просек, владение 4, строение 1", "Стационарный общественный туалет № 4 (ПКиО Сокольники)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 222L, "действует", "город Москва, 5-й Лучевой просек, владение 5, строение 1", "Стационарный общественный туалет № 5 (ПКиО Сокольники)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 223L, "действует", "город Москва, 5-й Лучевой просек, дом 12, строение 1", "Стационарный общественный туалет № 6 (ПКиО Сокольники)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 224L, "действует", "город Москва, Песочная аллея, владение 9, строение 1", "Стационарный общественный туалет № 8 (ПКиО Сокольники)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 225L, "действует", "город Москва, Угличская улица, владение 13, строение 12", "Стационарный общественный туалет (ПКиО Лианозовский)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 226L, "действует", "город Москва, улица Менжинского, дом 6, строение 4", "Стационарный общественный туалет № 1 (ПКиО Бабушкинский)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 227L, "действует", "город Москва, Кузьминский парк, дом 1, строение 3", "Стационарный общественный туалет (ПКиО Кузьминки)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 228L, "действует", "город Москва, Старая Басманная улица, дом 15, строение Б/Н", "Стационарный общественный туалет № 2 (Сад имени Баумана)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 242L, "закрыт", "город Москва, Большая Грузинская улица, дом 1, строение 109", "Стационарный общественный туалет № 3 (Московский Зоопарк)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 241L, "действует", "город Москва, Большая Грузинская улица, дом 1, строение 1", "Стационарный общественный туалет № 1 (Московский Зоопарк)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 240L, "действует", "город Москва, улица Тюрина, дом 1, строение 3", "Стационарный общественный туалет № 3 (Усадьба Царицыно)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 239L, "действует", "город Москва, Дольская улица, дом 1, строение 35", "Стационарный общественный туалет № 2 (Усадьба Царицыно)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 238L, "действует", "город Москва, Дольская улица, дом 10, строение 6", "Стационарный общественный туалет № 1 (Усадьба Царицыно)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 237L, "действует", "город Москва, проспект Андропова, дом 39, строение 14", "Стационарный общественный туалет (Усадьба Коломенское)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 244L, "действует", "город Москва, площадь Победы, дом 3Г", "Стационарный общественный туалет № 2 (парк Победы на Поклонной горе)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 236L, "действует", "город Москва, Большая Грузинская улица, дом 8, строение 59", "Стационарный общественный туалет № 5 (Московский Зоопарк)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 234L, "действует", "город Москва, Большая Грузинская улица, дом 1, строение 5", "Стационарный общественный туалет № 2 (Московский Зоопарк)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 233L, "закрыт", "город Москва, Тихая улица, дом 23", "Стационарный общественный туалет (Усадьба Люблино)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 232L, "действует", "город Москва, улица Лазо, дом 7, строение 4", "Стационарный общественный туалет (ПКиО Перовский)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 231L, "действует", "город Москва, улица Свободы, дом 56А, строение 1", "Стационарный общественный туалет № 1 (МПК Северное Тушино)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 230L, "действует", "город Москва, Таганская улица, дом 40, строение 4А", "Стационарный общественный туалет (ПКиО Таганский)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 229L, "действует", "город Москва, Старая Басманная улица, дом 15, строение Б/Н", "Стационарный общественный туалет № 4 (Сад имени Баумана)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 235L, "действует", "город Москва, Большая Грузинская улица, дом 8, строение 26", "Стационарный общественный туалет № 4 (Московский Зоопарк)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 278L, "действует", "город Москва, Дольская улица, дом 1, строение 37", "Стационарный общественный туалет №5 (Усадьба Царицыно)", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 140L, "действует", "город Москва, Усачёва улица, дом 1А, строение 2", "Стационарный общественный туалет № 8", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 138L, "действует", "город Москва, Красная площадь, дом 1, сооружение 1", "Стационарный общественный туалет № 126", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 37L, "действует", "город Москва, улица Кржижановского, дом 27", "Стационарный общественный туалет № 137", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 38L, "действует", "город Москва, улица Паустовского, дом 8, корпус 1", "Стационарный общественный туалет № 213", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 39L, "действует", "город Москва, улица Нагатинская, дом 25, строение 2", "Стационарный общественный туалет № 140", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 40L, "действует", "город Москва, Полярная улица, дом 10, строение 3", "Стационарный общественный туалет № 207", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 41L, "действует", "город Москва, улица Лётчика Бабушкина, дом 30А", "Стационарный общественный туалет № 206", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 42L, "закрыт", "город Москва, Широкая улица, дом 14А", "Стационарный общественный туалет № 212", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 43L, "действует", "город Москва, проспект Мира, дом 123Д", "Стационарный общественный туалет № 20", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 44L, "действует", "город Москва, улица Академика Курчатова, дом 2", "Стационарный общественный туалет № 36", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 45L, "действует", "город Москва, улица Долгова, дом 1, строение 5", "Стационарный общественный туалет № 100", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 46L, "действует", "город Москва, Химкинский бульвар, дом 16, строение 6", "Стационарный общественный туалет № 200", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 47L, "действует", "город Москва, улица Маршала Бирюзова, дом 12", "Стационарный общественный туалет № 29", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 48L, "действует", "город Зеленоград, корпус 1446, строение 8", "Стационарный общественный туалет № 218", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 49L, "действует", "город Москва, город Зеленоград, Привокзальная площадь, строение 7", "Стационарный общественный туалет № 219", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 50L, "действует", "город Москва, Кремлёвский проезд, дом 1, сооружение 1", "Стационарный общественный туалет № 11", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 51L, "действует", "город Москва, Большая Грузинская улица, дом 13А, строение 1", "Стационарный общественный туалет № 43", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 52L, "действует", "город Москва, улица Серафимовича, дом 5/16", "Стационарный общественный туалет № 88", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 53L, "действует", "город Москва, Садовая-Черногрязская улица, дом 5/9", "Стационарный общественный туалет № 14", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 67L, "действует", "бульвар Маршала Рокоссовского, дом 31", "Стационарный общественный туалет № 90", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 66L, "действует", "Зелёный проспект, дом 105", "Стационарный общественный туалет № 125", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 65L, "действует", "город Москва, 1-й переулок Тружеников, дом 8", "Стационарный общественный туалет № 198", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 64L, "действует", "Гостиничный проезд, владение 14", "Стационарный общественный туалет № 34", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 63L, "действует", "город Москва, улица Плещеева, дом 1А", "Стационарный общественный туалет № 210", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 62L, "действует", "город Москва, улица Крымский Вал, дом 10Б", "Стационарный общественный туалет № 32", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 36L, "действует", "город Москва, бульвар Генерала Карбышева, дом 15А", "Стационарный общественный туалет № 187", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 61L, "действует", "город Москва, проспект Вернадского, владение 105Б", "Стационарный общественный туалет № 116", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 59L, "действует", "город Москва, Малая Филёвская улица, дом 11, сооружение 2", "Стационарный общественный туалет № 78", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 58L, "действует", "город Москва, Ленинский проспект, дом 43", "Стационарный общественный туалет № 7", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 57L, "закрыт", "город Москва, Ленинский проспект, дом 88, строение 2", "Стационарный общественный туалет № 135", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 56L, "действует", "город Москва, Ленинский проспект, дом 39Б", "Стационарный общественный туалет № 152", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 55L, "действует", "город Москва, улица Шверника, дом 13, корпус 1, строение 1", "Стационарный общественный туалет № 146", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 54L, "действует", "город Москва, Новослободская улица, дом 73/68, строение 5", "Стационарный общественный туалет № 164", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 60L, "действует", "город Москва, улица Горбунова, дом 3, строение 3", "Стационарный общественный туалет № 65", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 68L, "действует", "город Москва, улица Сретенка, дом 27, строение 3", "Стационарный общественный туалет № 199", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 35L, "действует", "город Москва, Карамышевская набережная, дом 36", "Стационарный общественный туалет № 186", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 33L, "действует", "город Москва, 1-я Останкинская улица, дом 1Б", "Стационарный общественный туалет № 95", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 2L, "действует", "город Москва, Большая Садовая улица, дом 16, сооружение 1", "Стационарный общественный туалет № 45", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 3L, "действует", "город Москва, улица Земляной Вал, дом 1/4, строение 1", "Стационарный общественный туалет № 13", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 4L, "действует", "город Москва, Марксистская улица, дом 2, строение 2", "Стационарный общественный туалет № 85", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 5L, "действует", "город Москва, Лужнецкий проезд, дом 1А, строение 2", "Стационарный общественный туалет № 70", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 6L, "действует", "город Москва, Тишинская площадь, владение 1А, сооружение 1", "Стационарный общественный туалет № 50", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 7L, "действует", "город Москва, Большой Патриарший переулок, владение 7, сооружение 1", "Стационарный общественный туалет № 40", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 8L, "действует", "город Москва, Тверской бульвар, владение 3, сооружение 1", "Стационарный общественный туалет № 133", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 9L, "действует", "город Москва, Ленинский проспект, дом 75/9", "Стационарный общественный туалет № 6", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 10L, "закрыт", "город Москва, улица Миклухо-Маклая, дом 24А", "Стационарный общественный туалет № 111", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 11L, "действует", "город Москва, Профсоюзная улица, дом 88Б", "Стационарный общественный туалет № 114", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 12L, "закрыт", "город Москва, Профсоюзная улица, дом 59А", "Стационарный общественный туалет № 115", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 13L, "действует", "улица Василия Ботылева, дом 25А", "Стационарный общественный туалет № 60", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 14L, "действует", "прч  МЖД, Белорусское, 6-й км., д. 4 ", "Стационарный общественный туалет № 87", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 15L, "действует", "город Москва, улица Маршала Неделина, дом 2", "Стационарный общественный туалет № 66", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 16L, "действует", "город Москва, Красноказарменная улица, дом 6А", "Стационарный общественный туалет № 38", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 17L, "действует", "город Москва, Авиамоторная улица, дом 41А, сооружение 1", "Стационарный общественный туалет № 127", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 18L, "действует", "город Москва, Свободный проспект, дом 2Д, строение 6", "Стационарный общественный туалет № 49", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 32L, "действует", "Проспект Мира, дом 81", "Стационарный общественный туалет № 19", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 31L, "действует", "город Москва, Полярная улица, дом 34А", "Стационарный общественный туалет № 23", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 30L, "закрыт", "город Москва, Днепропетровская улица, дом 6, сооружение 2", "Стационарный общественный туалет № 107", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 29L, "закрыт", "город Москва, 1-й Донской проезд, дом 4", "Стационарный общественный туалет № 157", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 28L, "действует", "город Москва, Нагатинская улица, дом 2, сооружение 1", "Стационарный общественный туалет № 144", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 27L, "действует", "город Москва, Россошанская улица, дом 3, корпус 1А, сооружение 1", "Стационарный общественный туалет № 103", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 34L, "действует", "город Москва, Щукинская улица, дом 40", "Стационарный общественный туалет № 37", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 26L, "действует", "город Москва, Каширское шоссе, дом 52, строение 5", "Стационарный общественный туалет № 112", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 24L, "действует", "Челябинская улица, дом 15, сооружение 4", "Стационарный общественный туалет № 57", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 23L, "действует", "город Москва, Уральская улица, дом 1, сооружение 1", "Стационарный общественный туалет № 179", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 22L, "действует", "город Москва, Первомайская улица, дом 107А", "Стационарный общественный туалет № 170", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 21L, "действует", "город Москва, Кусковская улица, дом 2, строение 1", "Стационарный общественный туалет № 82", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 20L, "действует", "город Москва, Перовская улица, дом 32, строение 1", "Стационарный общественный туалет № 118", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 19L, "действует", "город Москва, Перовская улица, дом 31", "Стационарный общественный туалет № 120", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 25L, "действует", "город Москва, Каширское шоссе, дом 42Б, строение 1", "Стационарный общественный туалет № 113", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 139L, "действует", "улица Сущёвский Вал, дом 56, строение 4", "Стационарный общественный туалет № 190", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 69L, "действует", "город Москва, Ленинградский проспект, дом 36, строение 59", "Стационарный общественный туалет № 62", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 71L, "действует", "город Москва, Тимирязевская улица, дом 56, сооружение 3", "Стационарный общественный туалет № 182", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 107L, "действует", "город Москва, Измайловский проспект, дом 61", "Стационарный общественный туалет № 161", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 108L, "действует", "город Москва, 3-я Парковая улица, дом 35", "Стационарный общественный туалет № 172", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 109L, "закрыт", "город Москва, Вешняковская улица, дом 18, строение 2", "Стационарный общественный туалет № 67", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 110L, "действует", "город Москва, Автозаводская улица, дом 13/1", "Стационарный общественный туалет № 153", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 111L, "действует", "город Москва, улица Симоновский Вал, дом 26, корпус 2", "Стационарный общественный туалет № 158", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 112L, "действует", "город Москва, Восточная улица, дом 11Б, сооружение 1", "Стационарный общественный туалет № 156", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 113L, "действует", "город Москва, улица Генерала Белова, дом 27, сооружение 2", "Стационарный общественный туалет № 106", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 114L, "закрыт", "город Москва, проспект Андропова, дом 27, сооружение 1", "Стационарный общественный туалет № 138", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 115L, "действует", "город Москва, Бирюлёвская улица, дом 9А", "Стационарный общественный туалет № 104", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 116L, "действует", "город Москва, улица Мусы Джалиля, дом 22", "Стационарный общественный туалет № 108", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 117L, "действует", "город Москва, Домодедовская улица, дом 23А", "Стационарный общественный туалет № 105", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 118L, "действует", "город Москва, Снежная улица, дом 13, корпус 3", "Стационарный общественный туалет № 201", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 119L, "закрыт", "город Москва, Инженерная улица, дом 1Б", "Стационарный общественный туалет № 208", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 120L, "действует", "город Москва, улица Адмирала Лазарева, владение 17, строение 2", "Стационарный общественный туалет № 102", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 121L, "действует", "город Москва, Ленинский проспект, дом 64/2", "Стационарный общественный туалет № 30", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 122L, "действует", "город Москва, Ленинский проспект, дом 41А", "Стационарный общественный туалет № 151", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 123L, "действует", "город Москва, Минская улица, дом 16Б", "Стационарный общественный туалет № 9", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 137L, "действует", "площадь Юности, дом 2, строение 3", "Стационарный общественный туалет № 220", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 136L, "действует", "город Москва, Ленинградский проспект, дом 71А", "Стационарный общественный туалет № 175", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 135L, "действует", "город Москва, Фестивальная улица, дом 8А, сооружение 1", "Стационарный общественный туалет № 202", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 134L, "действует", "город Москва, улица Нижняя Масловка, дом 10А, строение 1", "Стационарный общественный туалет № 167", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 133L, "действует", "город Москва, Беговая улица, дом 24, сооружение 3", "Стационарный общественный туалет № 53", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 132L, "действует", "город Москва, Михалковская улица, дом 28", "Стационарный общественный туалет № 183", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 106L, "действует", "город Москва, 9-я Парковая улица, дом 25", "Стационарный общественный туалет № 18", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 131L, "действует", "город Москва, Большой Толмачёвский переулок, владение 3", "Стационарный общественный туалет № 196", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 129L, "закрыт", "город Москва, Песчаная улица, дом 10, строение 13", "Стационарный общественный туалет № 174", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 128L, "действует", "Каховка ул., ст. м. \"Каховская\"", "Стационарный общественный туалет № 35", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 127L, "действует", "город Москва, улица Косыгина, владение 29", "Стационарный общественный туалет № 31", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 126L, "действует", "город Москва, Крылатская улица, дом 2, строение 22", "Стационарный общественный туалет № 12", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 125L, "действует", "город Москва, Матвеевская улица, владение 1Б", "Стационарный общественный туалет № 148", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 124L, "действует", "город Москва, Большая Дорогомиловская улица, дом 9", "Стационарный общественный туалет № 10", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 130L, "действует", "город Москва, Байкальская улица, дом 35", "Стационарный общественный туалет № 25", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 70L, "действует", "город Москва, 1-й Боткинский проезд, дом 2, строение 1", "Стационарный общественный туалет № 58", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 105L, "действует", "город Москва, 1-я Владимирская улица, дом 2А", "Стационарный общественный туалет № 41", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 103L, "действует", "город Москва, Кузьминская улица, дом 3", "Стационарный общественный туалет № 147", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 72L, "действует", "город Москва, Ленинградский проспект, дом 33, сооружение 1", "Стационарный общественный туалет № 63", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 73L, "действует", "город Москва, 2-я Песчаная улица, дом 4Б, строение 1", "Стационарный общественный туалет № 165", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 74L, "действует", "город Москва, 1-й Войковский проезд, дом 4, сооружение 1", "Стационарный общественный туалет № 180", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 75L, "действует", "город Москва, Славянский бульвар, дом 13, сооружение 7", "Стационарный общественный туалет № 69", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 76L, "закрыт", "Булатниковская улица, дом 2", "Стационарный общественный туалет № 197", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 77L, "действует", "город Москва, Измайловское шоссе, дом 69Д, сооружение 1", "Стационарный общественный туалет № 160", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 78L, "действует", "город Москва, улица Куусинена, дом 17, корпус 2", "Стационарный общественный туалет № 61", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 79L, "действует", "город Москва, Тимирязевская улица, дом 17А, строение 1", "Стационарный общественный туалет № 178", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 80L, "действует", "город Москва, город Зеленоград, корпус 900, строение 1", "Стационарный общественный туалет № 217", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 81L, "закрыт", "город Москва, Левобережная улица, дом 12А", "Стационарный общественный туалет № 209", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 82L, "действует", "город Москва, Долгоруковская улица, дом 39/6", "Стационарный общественный туалет № 54", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 83L, "действует", "город Москва, улица Покровка, дом 19", "Стационарный общественный туалет № 134", "платный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 84L, "действует", "город Москва, Миусская площадь, владение 1, сооружение 1", "Стационарный общественный туалет № 52", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 85L, "действует", "город Москва, Андроньевская площадь, дом 5", "Стационарный общественный туалет № 119", "платный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 86L, "действует", "город Москва, Верхняя Красносельская улица, владение 17, сооружение А", "Стационарный общественный туалет № 59", "платный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 87L, "действует", "город Москва, Ленинский проспект, владение 8, сооружение А", "Стационарный общественный туалет № 64", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 88L, "действует", "город Москва, Верхняя Радищевская улица, дом 22", "Стационарный общественный туалет № 84", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 102L, "действует", "город Москва, улица Трёхгорный Вал, владение 7, строение 1", "Стационарный общественный туалет № 39", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 101L, "действует", "город Москва, Мароновский переулок, дом 10", "Стационарный общественный туалет № 80", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 100L, "действует", "город Москва, 1-й Капотнинский проезд, дом 12А", "Стационарный общественный туалет № 110", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 99L, "действует", "город Москва, Южнопортовая улица, дом 22Б", "Стационарный общественный туалет № 154", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 98L, "действует", "город Москва, улица Маёвок, дом 9", "Стационарный общественный туалет № 1", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 97L, "действует", "город Москва, улица Рогожский Вал, дом 3", "Стационарный общественный туалет № 89", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 104L, "действует", "город Москва, Госпитальная площадь, дом 2А, сооружение 1", "Стационарный общественный туалет № 48", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 96L, "действует", "город Москва, Покровский бульвар, владение 10, строение 7", "Стационарный общественный туалет № 129", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 94L, "действует", "город Москва, Каширское шоссе, дом 25Б, сооружение 1", "Стационарный общественный туалет № 215", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 93L, "действует", "город Москва, Варшавское шоссе, дом 65, корпус 1", "Стационарный общественный туалет № 4", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 92L, "действует", "город Москва, Мартеновская улица, дом 25А", "Стационарный общественный туалет № 124", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 91L, "действует", "город Москва, улица Металлургов, дом 41, строение 2", "Стационарный общественный туалет № 42", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 90L, "действует", "город Москва, улица Трофимова, дом 17, сооружение 1", "Стационарный общественный туалет № 149", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 89L, "действует", "город Москва, улица Мельникова, дом 21, сооружение 1", "Стационарный общественный туалет № 71", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 95L, "действует", "город Москва, Волгоградский проспект, дом 22", "Стационарный общественный туалет № 72", "бесплатный" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "CloseFlag", "Location", "Name", "PaidService" },
                values: new object[] { 279L, "действует", "город Москва, Большая Семёновская улица, дом 20", "Стационарный общественный туалет № 226", "бесплатный" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KLADobjs");
        }
    }
}
