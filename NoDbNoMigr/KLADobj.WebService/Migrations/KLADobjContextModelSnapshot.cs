﻿// <auto-generated />
using KLADobj.InfrastructureServices.Gateways.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KLADobj.WebService.Migrations
{
    [DbContext(typeof(KLADobjContext))]
    partial class KLADobjContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("KLADobj.DomainObjects.kladobj", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("ChillType")
                        .HasColumnType("TEXT");

                    b.Property<string>("Free")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("KLADobjs");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Address = "Московская область, г. Домодедово, вблизи д. Истомиха, территория \"Домодедовское кладбище\"",
                            Name = "Домодедовское кладбище"
                        },
                        new
                        {
                            Id = 2L,
                            Address = "деревня Жохово",
                            Name = "Жохово кладбище"
                        },
                        new
                        {
                            Id = 3L,
                            Address = "улица Николая Сироткина",
                            Name = "Захарьинское кладбище"
                        },
                        new
                        {
                            Id = 4L,
                            Address = "Зеленоград, Проезд N 710, дом 19 стр. 1, 3, 4",
                            Name = "Зеленоградское (Северное) кладбище"
                        },
                        new
                        {
                            Id = 5L,
                            Address = "поселок Зосимова пустынь",
                            Name = "Зосимова пустынь кладбище"
                        },
                        new
                        {
                            Id = 6L,
                            Address = "улица Сталеваров, владение 6, стр. 1,2,3,4,5,6",
                            Name = "Ивановское кладбище"
                        },
                        new
                        {
                            Id = 7L,
                            Address = "деревня Изварино",
                            Name = "Изваринское кладбище"
                        },
                        new
                        {
                            Id = 8L,
                            Address = "вблизи с. Ознобишино",
                            Name = "Ознобишино кладбище"
                        },
                        new
                        {
                            Id = 9L,
                            Address = "д. Исаково",
                            Name = "Исаково кладбище"
                        },
                        new
                        {
                            Id = 10L,
                            Address = "Большой Калитниковский проезд, вл. 11",
                            Name = "Калитниковское кладбище"
                        },
                        new
                        {
                            Id = 11L,
                            Address = "1-й квартал Капотня, 1-й Капотнинский проезд",
                            Name = "Капотненское кладбище"
                        },
                        new
                        {
                            Id = 12L,
                            Address = "Старокачаловская улица, владение 8",
                            Name = "Качаловское кладбище"
                        },
                        new
                        {
                            Id = 13L,
                            Address = "деревня Клоково",
                            Name = "Клоково кладбище"
                        },
                        new
                        {
                            Id = 14L,
                            Address = "улица Деловая, вл. 21",
                            Name = "Котляковское кладбище"
                        },
                        new
                        {
                            Id = 15L,
                            Address = "село Красное",
                            Name = "Красное кладбище"
                        },
                        new
                        {
                            Id = 16L,
                            Address = "деревня Кувекино",
                            Name = "Кувекинское кладбище"
                        },
                        new
                        {
                            Id = 17L,
                            Address = "деревня Кузнецово",
                            Name = "Кузнецово кладбище"
                        },
                        new
                        {
                            Id = 18L,
                            Address = "улица Академика Скрябина, вл. 19",
                            Name = "Кузьминское кладбище"
                        },
                        new
                        {
                            Id = 19L,
                            Address = "улица Академика Скрябина, вл. 19",
                            Name = "Кузьминское (мусульманское) кладбище"
                        },
                        new
                        {
                            Id = 20L,
                            Address = "поселок Рублево",
                            Name = "Рублевское кладбище"
                        },
                        new
                        {
                            Id = 21L,
                            Address = "1-я улица Леонова, вл. 8",
                            Name = "Леоновское кладбище"
                        },
                        new
                        {
                            Id = 22L,
                            Address = "д. Летово",
                            Name = "Летовское кладбище"
                        },
                        new
                        {
                            Id = 23L,
                            Address = "Московская область, Мытищинский район, юго-западная часть городского поселения Мытищи, 83-й км МКАД",
                            Name = "Лианозовское кладбище"
                        },
                        new
                        {
                            Id = 24L,
                            Address = "деревня Лукошкино",
                            Name = "Лукошкино кладбище"
                        },
                        new
                        {
                            Id = 25L,
                            Address = "г. Зеленоград, промзона «Алабушево»",
                            Name = "Алабушевское кладбище"
                        },
                        new
                        {
                            Id = 26L,
                            Address = "Проспект Мира, владение 132",
                            Name = "Алексеевское кладбище"
                        },
                        new
                        {
                            Id = 27L,
                            Address = "85-й км МКАД",
                            Name = "Алтуфьевское кладбище"
                        },
                        new
                        {
                            Id = 28L,
                            Address = "деревня Анкудиново",
                            Name = "Анкудиново кладбище"
                        },
                        new
                        {
                            Id = 29L,
                            Address = "Ярославское шоссе, владение 52",
                            Name = "Бабушкинское кладбище"
                        },
                        new
                        {
                            Id = 30L,
                            Address = "деревня Белоусово",
                            Name = "Белоусово кладбище"
                        },
                        new
                        {
                            Id = 31L,
                            Address = "деревня Богородское",
                            Name = "Богородское (д. Богородское) кладбище"
                        },
                        new
                        {
                            Id = 32L,
                            Address = "Краснобогатырская улица, вл. 81",
                            Name = "Богородское кладбище"
                        },
                        new
                        {
                            Id = 33L,
                            Address = "село Богоявление",
                            Name = "Богоявление кладбище"
                        },
                        new
                        {
                            Id = 34L,
                            Address = "Наличная ул., вл. 1",
                            Name = "Введенское кладбище"
                        },
                        new
                        {
                            Id = 35L,
                            Address = "деревня Большое Свинорье",
                            Name = "Большое Свинорье кладбище"
                        },
                        new
                        {
                            Id = 36L,
                            Address = "Борисовские Пруды улица, вл. 4",
                            Name = "Борисовское кладбище"
                        },
                        new
                        {
                            Id = 37L,
                            Address = "улица Краснополянская, вл. 18",
                            Name = "Бусиновское кладбище"
                        },
                        new
                        {
                            Id = 38L,
                            Address = "Южное Бутово, 36-й км Курской ж/д",
                            Name = "Бутовское кладбище"
                        },
                        new
                        {
                            Id = 39L,
                            Address = "село Былово",
                            Name = "Былово кладбище"
                        },
                        new
                        {
                            Id = 40L,
                            Address = "ул. Сергея Макеева, вл. 15",
                            Name = "Ваганьковское кладбище"
                        },
                        new
                        {
                            Id = 41L,
                            Address = "Головинское шоссе, вл. 13",
                            Name = "Головинское кладбище"
                        },
                        new
                        {
                            Id = 42L,
                            Address = "деревня Варварино",
                            Name = "Варварино кладбище"
                        },
                        new
                        {
                            Id = 43L,
                            Address = "деревня Васюнино",
                            Name = "Васюнино кладбище"
                        },
                        new
                        {
                            Id = 44L,
                            Address = "поселок Ватутинки",
                            Name = "Ватутинское кладбище"
                        },
                        new
                        {
                            Id = 45L,
                            Address = "Московская область, г. Долгопрудный, Лихачевский проспект",
                            Name = "Долгопрудненское (Южное) кладбище"
                        },
                        new
                        {
                            Id = 46L,
                            Address = "Юности улица, дом 17",
                            Name = "Вешняковское кладбище"
                        },
                        new
                        {
                            Id = 47L,
                            Address = "Станционная улица, дом 8А",
                            Name = "Владыкинское кладбище"
                        },
                        new
                        {
                            Id = 48L,
                            Address = "вблизи с. Вороново",
                            Name = "Вороново кладбище"
                        },
                        new
                        {
                            Id = 49L,
                            Address = "деревня Ворсино",
                            Name = "Ворсино кладбище"
                        },
                        new
                        {
                            Id = 50L,
                            Address = "Озерная улица, вл. 47, корпус 3, 4, 5, 6, 7, 8",
                            Name = "Востряковское (Центральное) кладбище"
                        },
                        new
                        {
                            Id = 51L,
                            Address = "Озерная улица, вл. 47, корпус 3, 4, 5, 6, 7, 8",
                            Name = "Востряковское (Северное) кладбище"
                        },
                        new
                        {
                            Id = 52L,
                            Address = "Измайловский проезд, владение 30",
                            Name = "Измайловское кладбище"
                        },
                        new
                        {
                            Id = 53L,
                            Address = "Курганская улица, вл. 11",
                            Name = "Гольяновское кладбище"
                        },
                        new
                        {
                            Id = 54L,
                            Address = "деревня Губцево",
                            Name = "Губцево кладбище"
                        },
                        new
                        {
                            Id = 55L,
                            Address = "4-й Рощинский проезд, вл. 30",
                            Name = "Даниловское (Центральное) кладбище"
                        },
                        new
                        {
                            Id = 56L,
                            Address = "2-й Рощинский проезд, вл. 10",
                            Name = "Даниловское (мусульманское) кладбище"
                        },
                        new
                        {
                            Id = 57L,
                            Address = "дер. Девятское",
                            Name = "Девятское кладбище"
                        },
                        new
                        {
                            Id = 58L,
                            Address = "Московская область, г. Долгопрудный, Лихачевский проезд",
                            Name = "Долгопрудненское (Центральное) кладбище"
                        },
                        new
                        {
                            Id = 59L,
                            Address = "Рябиновая улица, вл. 20",
                            Name = "Кунцевское кладбище"
                        },
                        new
                        {
                            Id = 60L,
                            Address = "Ставропольская улица, вл. 74А",
                            Name = "Люблинское кладбище"
                        },
                        new
                        {
                            Id = 61L,
                            Address = "деревня Маврино",
                            Name = "Маврино кладбище"
                        },
                        new
                        {
                            Id = 62L,
                            Address = "Заповедная улица, владение 7А",
                            Name = "Медведковское кладбище"
                        },
                        new
                        {
                            Id = 63L,
                            Address = "Зеленоград, Московский проспект",
                            Name = "Никольское кладбище"
                        },
                        new
                        {
                            Id = 64L,
                            Address = "Московская область, Подольский район, сельское поселение Стрелковское, 29 км автодороги М-2 \"Крым\", Щербинский проезд",
                            Name = "Щербинское кладбище"
                        },
                        new
                        {
                            Id = 65L,
                            Address = "Московская область, Балашихинский район, с. Никольско-Архангельское ",
                            Name = "Николо-Архангельское (Центральное), Николо-Архангельское (Восточное) кладбище"
                        },
                        new
                        {
                            Id = 66L,
                            Address = "поселение Сосенское, в районе Николо-Хованского кладбища",
                            Name = "Николо-Хованское-1 кладбище"
                        },
                        new
                        {
                            Id = 67L,
                            Address = "дер. Новогромово",
                            Name = "Новогромово кладбище"
                        },
                        new
                        {
                            Id = 68L,
                            Address = "Московская область, Красногорский муниципальный район, сельское поселение Отрадненское, Пятницкое шоссе, 6-й км",
                            Name = "Митинское кладбище"
                        },
                        new
                        {
                            Id = 69L,
                            Address = "Донская площадь, владение 1",
                            Name = "Донское кладбище"
                        },
                        new
                        {
                            Id = 70L,
                            Address = "Зеленоград, Проезд N 4921, дом 3, строение 1, 2",
                            Name = "Зеленоградское (Центральное) кладбище"
                        },
                        new
                        {
                            Id = 71L,
                            Address = "деревня Кленово",
                            Name = "Кленово кладбище"
                        },
                        new
                        {
                            Id = 72L,
                            Address = "улица Сущевский вал, вл. 19",
                            Name = "Миусское кладбище"
                        },
                        new
                        {
                            Id = 73L,
                            Address = "Лужнецкий проезд, вл. 2",
                            Name = "Новодевичье кладбище"
                        },
                        new
                        {
                            Id = 74L,
                            Address = "Шипиловский проезд, вл. 20",
                            Name = "Ореховское кладбище"
                        },
                        new
                        {
                            Id = 75L,
                            Address = "Староорловская улица",
                            Name = "Орловское кладбище"
                        },
                        new
                        {
                            Id = 76L,
                            Address = "Прудовой проезд, вл. 11",
                            Name = "Останкинское кладбище"
                        },
                        new
                        {
                            Id = 77L,
                            Address = "вблизи с. Остафьево",
                            Name = "Остафьево кладбище"
                        },
                        new
                        {
                            Id = 78L,
                            Address = "г. Московский",
                            Name = "Передельцевское кладбище"
                        },
                        new
                        {
                            Id = 79L,
                            Address = "Московская область, Солнечногорский район, с.п. Луневское, д. Перепечино",
                            Name = "Перепечинское кладбище"
                        },
                        new
                        {
                            Id = 80L,
                            Address = "92 километр Московской Кольцевой Автодороги",
                            Name = "Перловское кладбище"
                        },
                        new
                        {
                            Id = 81L,
                            Address = "Кетчерская улица, вл. 20",
                            Name = "Перовское кладбище"
                        },
                        new
                        {
                            Id = 82L,
                            Address = "деревня Песье",
                            Name = "Песье кладбище"
                        },
                        new
                        {
                            Id = 83L,
                            Address = "улица Подольских Курсантов, вл. 24",
                            Name = "Покровское кладбище"
                        },
                        new
                        {
                            Id = 84L,
                            Address = "деревня Поповка",
                            Name = "Поповка кладбище"
                        },
                        new
                        {
                            Id = 85L,
                            Address = "улица Преображенский вал, вл. 17А",
                            Name = "Преображенское кладбище"
                        },
                        new
                        {
                            Id = 86L,
                            Address = "деревня Прокшино",
                            Name = "Прокшинское кладбище"
                        },
                        new
                        {
                            Id = 87L,
                            Address = "деревня Пучково",
                            Name = "Пучково кладбище"
                        },
                        new
                        {
                            Id = 88L,
                            Address = "деревня Пыхтино",
                            Name = "Пыхтинское кладбище"
                        },
                        new
                        {
                            Id = 89L,
                            Address = "Дроболитейный переулок, дом 3, строение 1",
                            Name = "Пятницкое кладбище"
                        },
                        new
                        {
                            Id = 90L,
                            Address = "деревня Раево, строение 1",
                            Name = "Раево кладбище"
                        },
                        new
                        {
                            Id = 91L,
                            Address = "Олонецкий проезд, дом 4, корпус 2",
                            Name = "Раевское кладбище"
                        },
                        new
                        {
                            Id = 92L,
                            Address = "в районе д. Десна",
                            Name = "Ракитки кладбище"
                        },
                        new
                        {
                            Id = 93L,
                            Address = "улица Войтовича, вл. 31А",
                            Name = "Рогожское кладбище"
                        },
                        new
                        {
                            Id = 94L,
                            Address = "деревня Рождественно",
                            Name = "Рождественно кладбище"
                        },
                        new
                        {
                            Id = 95L,
                            Address = "поселение Сосенское, в районе Николо-Хованского кладбища, уч. № 27",
                            Name = "Николо-Хованское кладбище"
                        },
                        new
                        {
                            Id = 96L,
                            Address = "деревня Руднево",
                            Name = "Руднево кладбище"
                        },
                        new
                        {
                            Id = 97L,
                            Address = "деревня Саларьево, дом 9",
                            Name = "Саларьевское кладбище"
                        },
                        new
                        {
                            Id = 98L,
                            Address = "деревня Сальково",
                            Name = "Сальково кладбище"
                        },
                        new
                        {
                            Id = 99L,
                            Address = "деревня Сатино-Русское",
                            Name = "Сатино-Русское кладбище"
                        },
                        new
                        {
                            Id = 100L,
                            Address = "село Свитино",
                            Name = "Свитино кладбище"
                        },
                        new
                        {
                            Id = 101L,
                            Address = "деревня Середнево",
                            Name = "Середневское кладбище"
                        },
                        new
                        {
                            Id = 102L,
                            Address = "деревня Сосенки",
                            Name = "Сосенское кладбище"
                        },
                        new
                        {
                            Id = 103L,
                            Address = "деревня Спас-Купля",
                            Name = "Спас-Купля кладбище"
                        },
                        new
                        {
                            Id = 104L,
                            Address = "деревня Станиславль",
                            Name = "Станиславское кладбище"
                        },
                        new
                        {
                            Id = 105L,
                            Address = "Дмитровское шоссе, владение 124А",
                            Name = "Старо-Марковское кладбище"
                        },
                        new
                        {
                            Id = 106L,
                            Address = "1-й Дорожный проезд, вл. 10",
                            Name = "Старо-Покровское кладбище"
                        },
                        new
                        {
                            Id = 107L,
                            Address = "дер. Товарищево",
                            Name = "Товарищево-1 кладбище"
                        },
                        new
                        {
                            Id = 108L,
                            Address = "Рябиновая улица, вл. 24",
                            Name = "Троекуровское кладбище"
                        },
                        new
                        {
                            Id = 109L,
                            Address = "улица Твардовского, вл. 12, корпус 3",
                            Name = "Троице-Лыковское кладбище"
                        },
                        new
                        {
                            Id = 110L,
                            Address = "поселок Филимонки",
                            Name = "Филимонковское кладбище"
                        },
                        new
                        {
                            Id = 111L,
                            Address = "деревня Хатминки",
                            Name = "Хатминки кладбище"
                        },
                        new
                        {
                            Id = 112L,
                            Address = "Новосходненское шоссе, вл. 1",
                            Name = "Химкинское кладбище"
                        },
                        new
                        {
                            Id = 113L,
                            Address = "поселение \"Мосрентген\", 21-й км Киевского ш.",
                            Name = "Хованское (Центральное) кладбище"
                        },
                        new
                        {
                            Id = 114L,
                            Address = "поселение \"Мосрентген\", 21-й км Киевского ш.",
                            Name = "Хованское (Северное) кладбище"
                        },
                        new
                        {
                            Id = 115L,
                            Address = "поселение Сосенское, Хованское Западное кладбище",
                            Name = "Хованское (Западное) кладбище"
                        },
                        new
                        {
                            Id = 116L,
                            Address = "Южное Бутово, по улице Южнобутовской",
                            Name = "Черневское кладбище"
                        },
                        new
                        {
                            Id = 117L,
                            Address = "деревня Чириково",
                            Name = "Чириково кладбище"
                        },
                        new
                        {
                            Id = 118L,
                            Address = "поселок Щапово",
                            Name = "Щапово кладбище"
                        },
                        new
                        {
                            Id = 119L,
                            Address = "деревня Юдановка",
                            Name = "Юдановка кладбище"
                        },
                        new
                        {
                            Id = 120L,
                            Address = "Новоясеневский проспект, вл. 42",
                            Name = "Ясеневское кладбище"
                        },
                        new
                        {
                            Id = 121L,
                            Address = "деревня Яковлево",
                            Name = "Яковлевское кладбище"
                        },
                        new
                        {
                            Id = 122L,
                            Address = "Московская область, Красногорский район, Пятницкое шоссе, 6-й км",
                            Name = "Митинский крематорий"
                        },
                        new
                        {
                            Id = 123L,
                            Address = "кладбище Хованское, стр.1",
                            Name = "Хованский крематорий"
                        },
                        new
                        {
                            Id = 124L,
                            Address = "Московская область, Балашихинский район, г. Балашиха, мкр-н Салтыковка, ул. Окольная владение 4",
                            Name = "Николо-Архангельский крематорий"
                        },
                        new
                        {
                            Id = 125L,
                            Address = "Большая Черкизовская ул., вл. 15",
                            Name = "Черкизовское кладбище"
                        },
                        new
                        {
                            Id = 126L,
                            Address = "1-я Муравская улица. вл. 39",
                            Name = "Рождественское кладбище"
                        },
                        new
                        {
                            Id = 127L,
                            Address = "село Никольское",
                            Name = "Никольское (п.Вороновское) кладбище"
                        },
                        new
                        {
                            Id = 128L,
                            Address = "дер. Ямонтово",
                            Name = "Ивановское (п.Сосенское) кладбище"
                        },
                        new
                        {
                            Id = 129L,
                            Address = "ул. Сергея Макеева, вл. 10",
                            Name = "Ваганьковское (Армянский участок) кладбище"
                        },
                        new
                        {
                            Id = 130L,
                            Address = "Рябиновая ул., д. 24 стр.1",
                            Name = "Троекуровское трупохранилище"
                        },
                        new
                        {
                            Id = 131L,
                            Address = "Проектируемый проезд № 5363, Черкизовское кладбище, дом 1 ",
                            Name = "Черкизовское (северное) кладбище"
                        },
                        new
                        {
                            Id = 132L,
                            Address = "деревня Большое Покровское",
                            Name = "Большое Покровское кладбище"
                        },
                        new
                        {
                            Id = 133L,
                            Address = "пос. ДСК \"Мичуринец\"",
                            Name = "Переделкинское кладбище"
                        },
                        new
                        {
                            Id = 134L,
                            Address = "Московская обл., Одинцовский р-н",
                            Name = "Ястребковское кладбище"
                        },
                        new
                        {
                            Id = 135L,
                            Address = "п. Краснопахорское, вблизи д. Подосинки",
                            Name = "Троицкое городское кладбище"
                        },
                        new
                        {
                            Id = 136L,
                            Address = "г. Щербинка, ул. Весенняя",
                            Name = "Барыши кладбище"
                        },
                        new
                        {
                            Id = 137L,
                            Address = "д. Былово",
                            Name = "Былово-1 кладбище"
                        },
                        new
                        {
                            Id = 138L,
                            Address = "Дмитровское шоссе, владение 162",
                            Name = "Виноградово кладбище"
                        },
                        new
                        {
                            Id = 139L,
                            Address = "д. Романцево",
                            Name = "Романцево кладбище"
                        },
                        new
                        {
                            Id = 140L,
                            Address = "Боровское шоссе, проектируемый проезд № 634",
                            Name = "Востряковское (Южное) иудейское кладбище"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
