using Microsoft.EntityFrameworkCore.Migrations;

namespace KLADobj.WebService.Migrations
{
    public partial class Intial : Migration
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
                values: new object[] { 1L, "Московская область, г. Домодедово, вблизи д. Истомиха, территория \"Домодедовское кладбище\"", null, null, "Домодедовское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 103L, "деревня Спас-Купля", null, null, "Спас-Купля кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 102L, "деревня Сосенки", null, null, "Сосенское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 101L, "деревня Середнево", null, null, "Середневское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 100L, "село Свитино", null, null, "Свитино кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 99L, "деревня Сатино-Русское", null, null, "Сатино-Русское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 98L, "деревня Сальково", null, null, "Сальково кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 97L, "деревня Саларьево, дом 9", null, null, "Саларьевское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 96L, "деревня Руднево", null, null, "Руднево кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 95L, "поселение Сосенское, в районе Николо-Хованского кладбища, уч. № 27", null, null, "Николо-Хованское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 94L, "деревня Рождественно", null, null, "Рождественно кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 93L, "улица Войтовича, вл. 31А", null, null, "Рогожское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 92L, "в районе д. Десна", null, null, "Ракитки кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 91L, "Олонецкий проезд, дом 4, корпус 2", null, null, "Раевское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 90L, "деревня Раево, строение 1", null, null, "Раево кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 89L, "Дроболитейный переулок, дом 3, строение 1", null, null, "Пятницкое кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 88L, "деревня Пыхтино", null, null, "Пыхтинское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 87L, "деревня Пучково", null, null, "Пучково кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 73L, "Лужнецкий проезд, вл. 2", null, null, "Новодевичье кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 74L, "Шипиловский проезд, вл. 20", null, null, "Ореховское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 75L, "Староорловская улица", null, null, "Орловское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 76L, "Прудовой проезд, вл. 11", null, null, "Останкинское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 77L, "вблизи с. Остафьево", null, null, "Остафьево кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 78L, "г. Московский", null, null, "Передельцевское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 104L, "деревня Станиславль", null, null, "Станиславское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 79L, "Московская область, Солнечногорский район, с.п. Луневское, д. Перепечино", null, null, "Перепечинское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 81L, "Кетчерская улица, вл. 20", null, null, "Перовское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 82L, "деревня Песье", null, null, "Песье кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 83L, "улица Подольских Курсантов, вл. 24", null, null, "Покровское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 84L, "деревня Поповка", null, null, "Поповка кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 85L, "улица Преображенский вал, вл. 17А", null, null, "Преображенское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 86L, "деревня Прокшино", null, null, "Прокшинское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 80L, "92 километр Московской Кольцевой Автодороги", null, null, "Перловское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 72L, "улица Сущевский вал, вл. 19", null, null, "Миусское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 105L, "Дмитровское шоссе, владение 124А", null, null, "Старо-Марковское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 107L, "дер. Товарищево", null, null, "Товарищево-1 кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 138L, "Дмитровское шоссе, владение 162", null, null, "Виноградово кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 137L, "д. Былово", null, null, "Былово-1 кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 136L, "г. Щербинка, ул. Весенняя", null, null, "Барыши кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 135L, "п. Краснопахорское, вблизи д. Подосинки", null, null, "Троицкое городское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 134L, "Московская обл., Одинцовский р-н", null, null, "Ястребковское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 133L, "пос. ДСК \"Мичуринец\"", null, null, "Переделкинское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 132L, "деревня Большое Покровское", null, null, "Большое Покровское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 131L, "Проектируемый проезд № 5363, Черкизовское кладбище, дом 1 ", null, null, "Черкизовское (северное) кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 130L, "Рябиновая ул., д. 24 стр.1", null, null, "Троекуровское трупохранилище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 129L, "ул. Сергея Макеева, вл. 10", null, null, "Ваганьковское (Армянский участок) кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 128L, "дер. Ямонтово", null, null, "Ивановское (п.Сосенское) кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 127L, "село Никольское", null, null, "Никольское (п.Вороновское) кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 126L, "1-я Муравская улица. вл. 39", null, null, "Рождественское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 125L, "Большая Черкизовская ул., вл. 15", null, null, "Черкизовское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 124L, "Московская область, Балашихинский район, г. Балашиха, мкр-н Салтыковка, ул. Окольная владение 4", null, null, "Николо-Архангельский крематорий" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 123L, "кладбище Хованское, стр.1", null, null, "Хованский крематорий" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 122L, "Московская область, Красногорский район, Пятницкое шоссе, 6-й км", null, null, "Митинский крематорий" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 108L, "Рябиновая улица, вл. 24", null, null, "Троекуровское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 109L, "улица Твардовского, вл. 12, корпус 3", null, null, "Троице-Лыковское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 110L, "поселок Филимонки", null, null, "Филимонковское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 111L, "деревня Хатминки", null, null, "Хатминки кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 112L, "Новосходненское шоссе, вл. 1", null, null, "Химкинское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 113L, "поселение \"Мосрентген\", 21-й км Киевского ш.", null, null, "Хованское (Центральное) кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 106L, "1-й Дорожный проезд, вл. 10", null, null, "Старо-Покровское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 114L, "поселение \"Мосрентген\", 21-й км Киевского ш.", null, null, "Хованское (Северное) кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 116L, "Южное Бутово, по улице Южнобутовской", null, null, "Черневское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 117L, "деревня Чириково", null, null, "Чириково кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 118L, "поселок Щапово", null, null, "Щапово кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 119L, "деревня Юдановка", null, null, "Юдановка кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 120L, "Новоясеневский проспект, вл. 42", null, null, "Ясеневское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 121L, "деревня Яковлево", null, null, "Яковлевское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 115L, "поселение Сосенское, Хованское Западное кладбище", null, null, "Хованское (Западное) кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 71L, "деревня Кленово", null, null, "Кленово кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 70L, "Зеленоград, Проезд N 4921, дом 3, строение 1, 2", null, null, "Зеленоградское (Центральное) кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 69L, "Донская площадь, владение 1", null, null, "Донское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 32L, "Краснобогатырская улица, вл. 81", null, null, "Богородское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 31L, "деревня Богородское", null, null, "Богородское (д. Богородское) кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 30L, "деревня Белоусово", null, null, "Белоусово кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 29L, "Ярославское шоссе, владение 52", null, null, "Бабушкинское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 28L, "деревня Анкудиново", null, null, "Анкудиново кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 27L, "85-й км МКАД", null, null, "Алтуфьевское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 26L, "Проспект Мира, владение 132", null, null, "Алексеевское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 25L, "г. Зеленоград, промзона «Алабушево»", null, null, "Алабушевское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 24L, "деревня Лукошкино", null, null, "Лукошкино кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 23L, "Московская область, Мытищинский район, юго-западная часть городского поселения Мытищи, 83-й км МКАД", null, null, "Лианозовское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 22L, "д. Летово", null, null, "Летовское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 21L, "1-я улица Леонова, вл. 8", null, null, "Леоновское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 20L, "поселок Рублево", null, null, "Рублевское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 19L, "улица Академика Скрябина, вл. 19", null, null, "Кузьминское (мусульманское) кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 18L, "улица Академика Скрябина, вл. 19", null, null, "Кузьминское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 17L, "деревня Кузнецово", null, null, "Кузнецово кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 16L, "деревня Кувекино", null, null, "Кувекинское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 2L, "деревня Жохово", null, null, "Жохово кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 3L, "улица Николая Сироткина", null, null, "Захарьинское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 4L, "Зеленоград, Проезд N 710, дом 19 стр. 1, 3, 4", null, null, "Зеленоградское (Северное) кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 5L, "поселок Зосимова пустынь", null, null, "Зосимова пустынь кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 6L, "улица Сталеваров, владение 6, стр. 1,2,3,4,5,6", null, null, "Ивановское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 7L, "деревня Изварино", null, null, "Изваринское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 33L, "село Богоявление", null, null, "Богоявление кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 8L, "вблизи с. Ознобишино", null, null, "Ознобишино кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 10L, "Большой Калитниковский проезд, вл. 11", null, null, "Калитниковское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 11L, "1-й квартал Капотня, 1-й Капотнинский проезд", null, null, "Капотненское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 12L, "Старокачаловская улица, владение 8", null, null, "Качаловское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 13L, "деревня Клоково", null, null, "Клоково кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 14L, "улица Деловая, вл. 21", null, null, "Котляковское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 15L, "село Красное", null, null, "Красное кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 9L, "д. Исаково", null, null, "Исаково кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 34L, "Наличная ул., вл. 1", null, null, "Введенское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 35L, "деревня Большое Свинорье", null, null, "Большое Свинорье кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 36L, "Борисовские Пруды улица, вл. 4", null, null, "Борисовское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 55L, "4-й Рощинский проезд, вл. 30", null, null, "Даниловское (Центральное) кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 56L, "2-й Рощинский проезд, вл. 10", null, null, "Даниловское (мусульманское) кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 57L, "дер. Девятское", null, null, "Девятское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 58L, "Московская область, г. Долгопрудный, Лихачевский проезд", null, null, "Долгопрудненское (Центральное) кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 59L, "Рябиновая улица, вл. 20", null, null, "Кунцевское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 60L, "Ставропольская улица, вл. 74А", null, null, "Люблинское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 54L, "деревня Губцево", null, null, "Губцево кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 61L, "деревня Маврино", null, null, "Маврино кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 63L, "Зеленоград, Московский проспект", null, null, "Никольское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 64L, "Московская область, Подольский район, сельское поселение Стрелковское, 29 км автодороги М-2 \"Крым\", Щербинский проезд", null, null, "Щербинское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 65L, "Московская область, Балашихинский район, с. Никольско-Архангельское ", null, null, "Николо-Архангельское (Центральное), Николо-Архангельское (Восточное) кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 66L, "поселение Сосенское, в районе Николо-Хованского кладбища", null, null, "Николо-Хованское-1 кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 67L, "дер. Новогромово", null, null, "Новогромово кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 68L, "Московская область, Красногорский муниципальный район, сельское поселение Отрадненское, Пятницкое шоссе, 6-й км", null, null, "Митинское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 62L, "Заповедная улица, владение 7А", null, null, "Медведковское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 139L, "д. Романцево", null, null, "Романцево кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 53L, "Курганская улица, вл. 11", null, null, "Гольяновское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 51L, "Озерная улица, вл. 47, корпус 3, 4, 5, 6, 7, 8", null, null, "Востряковское (Северное) кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 37L, "улица Краснополянская, вл. 18", null, null, "Бусиновское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 38L, "Южное Бутово, 36-й км Курской ж/д", null, null, "Бутовское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 39L, "село Былово", null, null, "Былово кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 40L, "ул. Сергея Макеева, вл. 15", null, null, "Ваганьковское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 41L, "Головинское шоссе, вл. 13", null, null, "Головинское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 42L, "деревня Варварино", null, null, "Варварино кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 52L, "Измайловский проезд, владение 30", null, null, "Измайловское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 43L, "деревня Васюнино", null, null, "Васюнино кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 45L, "Московская область, г. Долгопрудный, Лихачевский проспект", null, null, "Долгопрудненское (Южное) кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 46L, "Юности улица, дом 17", null, null, "Вешняковское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 47L, "Станционная улица, дом 8А", null, null, "Владыкинское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 48L, "вблизи с. Вороново", null, null, "Вороново кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 49L, "деревня Ворсино", null, null, "Ворсино кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 50L, "Озерная улица, вл. 47, корпус 3, 4, 5, 6, 7, 8", null, null, "Востряковское (Центральное) кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 44L, "поселок Ватутинки", null, null, "Ватутинское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 140L, "Боровское шоссе, проектируемый проезд № 634", null, null, "Востряковское (Южное) иудейское кладбище" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KLADobjs");
        }
    }
}
