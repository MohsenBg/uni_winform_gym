using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GymApp.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    Birthdate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    NationalId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Attendances",
                columns: table => new
                {
                    AttendanceId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Action = table.Column<string>(type: "TEXT", nullable: true),
                    ActionTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendances", x => x.AttendanceId);
                    table.ForeignKey(
                        name: "FK_Attendances_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Subscriptions",
                columns: table => new
                {
                    SubscriptionId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SessionCount = table.Column<int>(type: "INTEGER", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriptions", x => x.SubscriptionId);
                    table.ForeignKey(
                        name: "FK_Subscriptions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Address", "Birthdate", "FirstName", "LastName", "NationalId", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "ایران, رشت, خیابان گلسار, کوچه سرو, پلاک 13", new DateTime(1970, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "سارا", "موسوی", "6176326762", "09000000001" },
                    { 2, "ایران, کرمانشاه, خیابان معلم, کوچه بهار, پلاک 19", new DateTime(1967, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "فاطمه", "احمدی", "4594496887", "09000000002" },
                    { 3, "ایران, مشهد, خیابان امام رضا, کوچه نور, پلاک 34", new DateTime(2003, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "فاطمه", "احمدی", "2949728127", "09000000003" },
                    { 4, "ایران, قم, خیابان انقلاب, کوچه نور, پلاک 7", new DateTime(1978, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "احسان", "جعفری", "6876817685", "09000000004" },
                    { 5, "ایران, اصفهان, خیابان چهارباغ, کوچه مهر, پلاک 23", new DateTime(1989, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "علی", "شریعتی", "5139915261", "09000000005" },
                    { 6, "ایران, اهواز, خیابان طالقانی, کوچه یاس, پلاک 27", new DateTime(2000, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "فاطمه", "حسینی", "1260052399", "09000000006" },
                    { 7, "ایران, اصفهان, خیابان چهارباغ, کوچه مهر, پلاک 23", new DateTime(1960, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "محمد", "جعفری", "7300447510", "09000000007" },
                    { 8, "ایران, شیراز, خیابان زند, کوچه گل, پلاک 9", new DateTime(1980, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "زهرا", "کریمی", "9076074255", "09000000008" },
                    { 9, "ایران, کرمانشاه, خیابان معلم, کوچه بهار, پلاک 19", new DateTime(1982, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "زهرا", "بهرامی", "4199961570", "09000000009" },
                    { 10, "ایران, قم, خیابان انقلاب, کوچه نور, پلاک 7", new DateTime(1976, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "سارا", "احمدی", "8899297325", "09000000010" },
                    { 11, "ایران, شیراز, خیابان زند, کوچه گل, پلاک 9", new DateTime(1999, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "احسان", "شریعتی", "9784636707", "09000000011" },
                    { 12, "ایران, اهواز, خیابان طالقانی, کوچه یاس, پلاک 27", new DateTime(1993, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "نرگس", "شریعتی", "8865869395", "09000000012" },
                    { 13, "ایران, شیراز, خیابان زند, کوچه گل, پلاک 9", new DateTime(1968, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "احسان", "علوی", "5192039413", "09000000013" },
                    { 14, "ایران, اهواز, خیابان طالقانی, کوچه یاس, پلاک 27", new DateTime(1996, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "مریم", "احمدی", "4147980800", "09000000014" },
                    { 15, "ایران, اهواز, خیابان طالقانی, کوچه یاس, پلاک 27", new DateTime(1969, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "سارا", "کریمی", "1259604356", "09000000015" },
                    { 16, "ایران, کرمانشاه, خیابان معلم, کوچه بهار, پلاک 19", new DateTime(1963, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "حسین", "جعفری", "1088037423", "09000000016" },
                    { 17, "ایران, تهران, خیابان ولیعصر, کوچه بهار, پلاک 12", new DateTime(1992, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "فاطمه", "حسینی", "8064980133", "09000000017" },
                    { 18, "ایران, رشت, خیابان گلسار, کوچه سرو, پلاک 13", new DateTime(1968, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "حسین", "حسینی", "2647428691", "09000000018" },
                    { 19, "ایران, قم, خیابان انقلاب, کوچه نور, پلاک 7", new DateTime(1965, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "فاطمه", "بهرامی", "1068853166", "09000000019" },
                    { 20, "ایران, شیراز, خیابان زند, کوچه گل, پلاک 9", new DateTime(1996, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "نرگس", "کریمی", "6450887925", "09000000020" },
                    { 21, "ایران, شیراز, خیابان زند, کوچه گل, پلاک 9", new DateTime(1970, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "علی", "احمدی", "9152941241", "09000000021" },
                    { 22, "ایران, اصفهان, خیابان چهارباغ, کوچه مهر, پلاک 23", new DateTime(1971, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "رضا", "شریعتی", "2918295559", "09000000022" },
                    { 23, "ایران, مشهد, خیابان امام رضا, کوچه نور, پلاک 34", new DateTime(1966, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "فاطمه", "قاسمی", "6478892733", "09000000023" },
                    { 24, "ایران, قم, خیابان انقلاب, کوچه نور, پلاک 7", new DateTime(1987, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "احسان", "بهرامی", "4713133998", "09000000024" },
                    { 25, "ایران, کرمانشاه, خیابان معلم, کوچه بهار, پلاک 19", new DateTime(1976, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "محمد", "بهرامی", "1689093496", "09000000025" },
                    { 26, "ایران, کرج, خیابان درختی, کوچه بهار, پلاک 3", new DateTime(1974, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "محمد", "قاسمی", "4302019402", "09000000026" },
                    { 27, "ایران, اصفهان, خیابان چهارباغ, کوچه مهر, پلاک 23", new DateTime(1990, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "حسین", "حسینی", "2356083801", "09000000027" },
                    { 28, "ایران, اهواز, خیابان طالقانی, کوچه یاس, پلاک 27", new DateTime(1987, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "احسان", "قاسمی", "6214076046", "09000000028" },
                    { 29, "ایران, مشهد, خیابان امام رضا, کوچه نور, پلاک 34", new DateTime(1978, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "حسین", "قاسمی", "8374230779", "09000000029" },
                    { 30, "ایران, رشت, خیابان گلسار, کوچه سرو, پلاک 13", new DateTime(1976, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "رضا", "حسینی", "8397757164", "09000000030" },
                    { 31, "ایران, تبریز, خیابان آزادی, کوچه نصر, پلاک 15", new DateTime(1991, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "حسین", "احمدی", "2957925440", "09000000031" },
                    { 32, "ایران, کرمانشاه, خیابان معلم, کوچه بهار, پلاک 19", new DateTime(1962, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "علی", "احمدی", "1361702639", "09000000032" },
                    { 33, "ایران, تهران, خیابان ولیعصر, کوچه بهار, پلاک 12", new DateTime(1977, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "محمد", "جعفری", "5229315154", "09000000033" },
                    { 34, "ایران, تبریز, خیابان آزادی, کوچه نصر, پلاک 15", new DateTime(1963, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "احسان", "بهرامی", "4063866518", "09000000034" },
                    { 35, "ایران, رشت, خیابان گلسار, کوچه سرو, پلاک 13", new DateTime(1990, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "نرگس", "موسوی", "5645819595", "09000000035" },
                    { 36, "ایران, قم, خیابان انقلاب, کوچه نور, پلاک 7", new DateTime(1987, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "زهرا", "احمدی", "2671396349", "09000000036" },
                    { 37, "ایران, کرمانشاه, خیابان معلم, کوچه بهار, پلاک 19", new DateTime(1994, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "حسین", "موسوی", "4538394422", "09000000037" },
                    { 38, "ایران, کرج, خیابان درختی, کوچه بهار, پلاک 3", new DateTime(1980, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "احسان", "قاسمی", "1316407264", "09000000038" },
                    { 39, "ایران, اصفهان, خیابان چهارباغ, کوچه مهر, پلاک 23", new DateTime(1976, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "فاطمه", "علوی", "9513252813", "09000000039" },
                    { 40, "ایران, رشت, خیابان گلسار, کوچه سرو, پلاک 13", new DateTime(1994, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "علی", "احمدی", "6994803127", "09000000040" },
                    { 41, "ایران, رشت, خیابان گلسار, کوچه سرو, پلاک 13", new DateTime(1960, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "محمد", "موسوی", "1646490890", "09000000041" },
                    { 42, "ایران, تبریز, خیابان آزادی, کوچه نصر, پلاک 15", new DateTime(1988, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "مریم", "بهرامی", "5007883454", "09000000042" },
                    { 43, "ایران, تهران, خیابان ولیعصر, کوچه بهار, پلاک 12", new DateTime(1994, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "سارا", "بهرامی", "9092011407", "09000000043" },
                    { 44, "ایران, رشت, خیابان گلسار, کوچه سرو, پلاک 13", new DateTime(1962, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "نرگس", "حسینی", "7155249184", "09000000044" },
                    { 45, "ایران, اصفهان, خیابان چهارباغ, کوچه مهر, پلاک 23", new DateTime(1995, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "محمد", "احمدی", "1237120992", "09000000045" },
                    { 46, "ایران, قم, خیابان انقلاب, کوچه نور, پلاک 7", new DateTime(1990, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "رضا", "احمدی", "4731065432", "09000000046" },
                    { 47, "ایران, تبریز, خیابان آزادی, کوچه نصر, پلاک 15", new DateTime(1999, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "نرگس", "بهرامی", "7914381562", "09000000047" },
                    { 48, "ایران, شیراز, خیابان زند, کوچه گل, پلاک 9", new DateTime(1968, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "نرگس", "جعفری", "4136960659", "09000000048" },
                    { 49, "ایران, تهران, خیابان ولیعصر, کوچه بهار, پلاک 12", new DateTime(1985, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "احسان", "احمدی", "8066278732", "09000000049" },
                    { 50, "ایران, تهران, خیابان ولیعصر, کوچه بهار, پلاک 12", new DateTime(1997, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "مریم", "بهرامی", "8560522817", "09000000050" }
                });

            migrationBuilder.InsertData(
                table: "Attendances",
                columns: new[] { "AttendanceId", "Action", "ActionTime", "UserId" },
                values: new object[,]
                {
                    { 1, "ورود", new DateTime(2024, 8, 6, 12, 33, 45, 673, DateTimeKind.Local).AddTicks(5110), 3 },
                    { 2, "خروج", new DateTime(2024, 8, 6, 16, 33, 45, 673, DateTimeKind.Local).AddTicks(5110), 3 },
                    { 3, "ورود", new DateTime(2024, 7, 13, 13, 33, 45, 673, DateTimeKind.Local).AddTicks(5126), 3 },
                    { 4, "خروج", new DateTime(2024, 7, 13, 16, 33, 45, 673, DateTimeKind.Local).AddTicks(5126), 3 },
                    { 5, "ورود", new DateTime(2024, 7, 29, 12, 33, 45, 673, DateTimeKind.Local).AddTicks(5135), 3 },
                    { 6, "خروج", new DateTime(2024, 7, 29, 13, 33, 45, 673, DateTimeKind.Local).AddTicks(5135), 3 },
                    { 7, "ورود", new DateTime(2024, 7, 25, 15, 33, 45, 673, DateTimeKind.Local).AddTicks(5146), 3 },
                    { 8, "خروج", new DateTime(2024, 7, 25, 18, 33, 45, 673, DateTimeKind.Local).AddTicks(5146), 3 },
                    { 9, "ورود", new DateTime(2024, 7, 11, 15, 33, 45, 673, DateTimeKind.Local).AddTicks(5155), 3 },
                    { 10, "خروج", new DateTime(2024, 7, 11, 18, 33, 45, 673, DateTimeKind.Local).AddTicks(5155), 3 },
                    { 11, "ورود", new DateTime(2024, 7, 29, 14, 33, 45, 673, DateTimeKind.Local).AddTicks(5167), 3 },
                    { 12, "خروج", new DateTime(2024, 7, 29, 17, 33, 45, 673, DateTimeKind.Local).AddTicks(5167), 3 },
                    { 13, "ورود", new DateTime(2024, 7, 14, 11, 33, 45, 673, DateTimeKind.Local).AddTicks(5176), 39 },
                    { 14, "خروج", new DateTime(2024, 7, 14, 14, 33, 45, 673, DateTimeKind.Local).AddTicks(5176), 39 },
                    { 15, "ورود", new DateTime(2024, 8, 6, 10, 33, 45, 673, DateTimeKind.Local).AddTicks(5186), 39 },
                    { 16, "خروج", new DateTime(2024, 8, 6, 15, 33, 45, 673, DateTimeKind.Local).AddTicks(5186), 39 },
                    { 17, "ورود", new DateTime(2024, 7, 30, 10, 33, 45, 673, DateTimeKind.Local).AddTicks(5194), 39 },
                    { 18, "خروج", new DateTime(2024, 7, 30, 15, 33, 45, 673, DateTimeKind.Local).AddTicks(5194), 39 },
                    { 19, "ورود", new DateTime(2024, 8, 7, 15, 33, 45, 673, DateTimeKind.Local).AddTicks(5205), 39 },
                    { 20, "خروج", new DateTime(2024, 8, 7, 19, 33, 45, 673, DateTimeKind.Local).AddTicks(5205), 39 },
                    { 21, "ورود", new DateTime(2024, 7, 31, 10, 33, 45, 673, DateTimeKind.Local).AddTicks(5215), 39 },
                    { 22, "خروج", new DateTime(2024, 7, 31, 12, 33, 45, 673, DateTimeKind.Local).AddTicks(5215), 39 },
                    { 23, "ورود", new DateTime(2024, 8, 2, 14, 33, 45, 673, DateTimeKind.Local).AddTicks(5223), 39 },
                    { 24, "خروج", new DateTime(2024, 8, 2, 19, 33, 45, 673, DateTimeKind.Local).AddTicks(5223), 39 },
                    { 25, "ورود", new DateTime(2024, 7, 18, 14, 33, 45, 673, DateTimeKind.Local).AddTicks(5233), 39 },
                    { 26, "خروج", new DateTime(2024, 7, 18, 15, 33, 45, 673, DateTimeKind.Local).AddTicks(5233), 39 },
                    { 27, "ورود", new DateTime(2024, 8, 5, 12, 33, 45, 673, DateTimeKind.Local).AddTicks(5242), 39 },
                    { 28, "خروج", new DateTime(2024, 8, 5, 14, 33, 45, 673, DateTimeKind.Local).AddTicks(5242), 39 },
                    { 29, "ورود", new DateTime(2024, 7, 27, 11, 33, 45, 673, DateTimeKind.Local).AddTicks(5252), 20 },
                    { 30, "خروج", new DateTime(2024, 7, 27, 14, 33, 45, 673, DateTimeKind.Local).AddTicks(5252), 20 },
                    { 31, "ورود", new DateTime(2024, 8, 1, 10, 33, 45, 673, DateTimeKind.Local).AddTicks(5261), 20 },
                    { 32, "خروج", new DateTime(2024, 8, 1, 11, 33, 45, 673, DateTimeKind.Local).AddTicks(5261), 20 },
                    { 33, "ورود", new DateTime(2024, 7, 29, 11, 33, 45, 673, DateTimeKind.Local).AddTicks(5269), 20 },
                    { 34, "خروج", new DateTime(2024, 7, 29, 15, 33, 45, 673, DateTimeKind.Local).AddTicks(5269), 20 },
                    { 35, "ورود", new DateTime(2024, 7, 17, 11, 33, 45, 673, DateTimeKind.Local).AddTicks(5281), 20 },
                    { 36, "خروج", new DateTime(2024, 7, 17, 14, 33, 45, 673, DateTimeKind.Local).AddTicks(5281), 20 },
                    { 37, "ورود", new DateTime(2024, 8, 6, 14, 33, 45, 673, DateTimeKind.Local).AddTicks(5289), 20 },
                    { 38, "خروج", new DateTime(2024, 8, 6, 15, 33, 45, 673, DateTimeKind.Local).AddTicks(5289), 20 },
                    { 39, "ورود", new DateTime(2024, 7, 15, 10, 33, 45, 673, DateTimeKind.Local).AddTicks(5299), 20 },
                    { 40, "خروج", new DateTime(2024, 7, 15, 12, 33, 45, 673, DateTimeKind.Local).AddTicks(5299), 20 },
                    { 41, "ورود", new DateTime(2024, 7, 19, 12, 33, 45, 673, DateTimeKind.Local).AddTicks(5308), 2 },
                    { 42, "خروج", new DateTime(2024, 7, 19, 17, 33, 45, 673, DateTimeKind.Local).AddTicks(5308), 2 },
                    { 43, "ورود", new DateTime(2024, 8, 9, 14, 33, 45, 673, DateTimeKind.Local).AddTicks(5317), 2 },
                    { 44, "خروج", new DateTime(2024, 8, 9, 19, 33, 45, 673, DateTimeKind.Local).AddTicks(5317), 2 },
                    { 45, "ورود", new DateTime(2024, 7, 26, 14, 33, 45, 673, DateTimeKind.Local).AddTicks(5327), 2 },
                    { 46, "خروج", new DateTime(2024, 7, 26, 17, 33, 45, 673, DateTimeKind.Local).AddTicks(5327), 2 },
                    { 47, "ورود", new DateTime(2024, 7, 26, 15, 33, 45, 673, DateTimeKind.Local).AddTicks(5335), 2 },
                    { 48, "خروج", new DateTime(2024, 7, 26, 20, 33, 45, 673, DateTimeKind.Local).AddTicks(5335), 2 },
                    { 49, "ورود", new DateTime(2024, 7, 31, 12, 33, 45, 673, DateTimeKind.Local).AddTicks(5345), 2 },
                    { 50, "خروج", new DateTime(2024, 7, 31, 17, 33, 45, 673, DateTimeKind.Local).AddTicks(5345), 2 },
                    { 51, "ورود", new DateTime(2024, 8, 6, 13, 33, 45, 673, DateTimeKind.Local).AddTicks(5354), 2 },
                    { 52, "خروج", new DateTime(2024, 8, 6, 15, 33, 45, 673, DateTimeKind.Local).AddTicks(5354), 2 },
                    { 53, "ورود", new DateTime(2024, 7, 26, 10, 33, 45, 673, DateTimeKind.Local).AddTicks(5362), 2 },
                    { 54, "خروج", new DateTime(2024, 7, 26, 11, 33, 45, 673, DateTimeKind.Local).AddTicks(5362), 2 },
                    { 55, "ورود", new DateTime(2024, 7, 16, 14, 33, 45, 673, DateTimeKind.Local).AddTicks(5372), 2 },
                    { 56, "خروج", new DateTime(2024, 7, 16, 15, 33, 45, 673, DateTimeKind.Local).AddTicks(5372), 2 },
                    { 57, "ورود", new DateTime(2024, 7, 23, 14, 33, 45, 673, DateTimeKind.Local).AddTicks(5381), 11 },
                    { 58, "خروج", new DateTime(2024, 7, 23, 15, 33, 45, 673, DateTimeKind.Local).AddTicks(5381), 11 },
                    { 59, "ورود", new DateTime(2024, 7, 26, 11, 33, 45, 673, DateTimeKind.Local).AddTicks(5391), 11 },
                    { 60, "خروج", new DateTime(2024, 7, 26, 15, 33, 45, 673, DateTimeKind.Local).AddTicks(5391), 11 },
                    { 61, "ورود", new DateTime(2024, 7, 31, 13, 33, 45, 673, DateTimeKind.Local).AddTicks(5399), 11 },
                    { 62, "خروج", new DateTime(2024, 7, 31, 14, 33, 45, 673, DateTimeKind.Local).AddTicks(5399), 11 },
                    { 63, "ورود", new DateTime(2024, 7, 16, 14, 33, 45, 673, DateTimeKind.Local).AddTicks(5408), 11 },
                    { 64, "خروج", new DateTime(2024, 7, 16, 19, 33, 45, 673, DateTimeKind.Local).AddTicks(5408), 11 },
                    { 65, "ورود", new DateTime(2024, 7, 15, 12, 33, 45, 673, DateTimeKind.Local).AddTicks(5418), 11 },
                    { 66, "خروج", new DateTime(2024, 7, 15, 17, 33, 45, 673, DateTimeKind.Local).AddTicks(5418), 11 },
                    { 67, "ورود", new DateTime(2024, 7, 16, 13, 33, 45, 673, DateTimeKind.Local).AddTicks(5428), 11 },
                    { 68, "خروج", new DateTime(2024, 7, 16, 15, 33, 45, 673, DateTimeKind.Local).AddTicks(5428), 11 },
                    { 69, "ورود", new DateTime(2024, 8, 1, 14, 33, 45, 673, DateTimeKind.Local).AddTicks(5438), 11 },
                    { 70, "خروج", new DateTime(2024, 8, 1, 18, 33, 45, 673, DateTimeKind.Local).AddTicks(5438), 11 },
                    { 71, "ورود", new DateTime(2024, 7, 11, 13, 33, 45, 673, DateTimeKind.Local).AddTicks(5447), 11 },
                    { 72, "خروج", new DateTime(2024, 7, 11, 18, 33, 45, 673, DateTimeKind.Local).AddTicks(5447), 11 },
                    { 73, "ورود", new DateTime(2024, 7, 29, 13, 33, 45, 673, DateTimeKind.Local).AddTicks(5457), 37 },
                    { 74, "خروج", new DateTime(2024, 7, 29, 17, 33, 45, 673, DateTimeKind.Local).AddTicks(5457), 37 },
                    { 75, "ورود", new DateTime(2024, 7, 25, 13, 33, 45, 673, DateTimeKind.Local).AddTicks(5466), 37 },
                    { 76, "خروج", new DateTime(2024, 7, 25, 17, 33, 45, 673, DateTimeKind.Local).AddTicks(5466), 37 },
                    { 77, "ورود", new DateTime(2024, 7, 16, 11, 33, 45, 673, DateTimeKind.Local).AddTicks(5474), 37 },
                    { 78, "خروج", new DateTime(2024, 7, 16, 12, 33, 45, 673, DateTimeKind.Local).AddTicks(5474), 37 },
                    { 79, "ورود", new DateTime(2024, 8, 6, 11, 33, 45, 673, DateTimeKind.Local).AddTicks(5484), 37 },
                    { 80, "خروج", new DateTime(2024, 8, 6, 16, 33, 45, 673, DateTimeKind.Local).AddTicks(5484), 37 },
                    { 81, "ورود", new DateTime(2024, 7, 12, 12, 33, 45, 673, DateTimeKind.Local).AddTicks(5492), 37 },
                    { 82, "خروج", new DateTime(2024, 7, 12, 13, 33, 45, 673, DateTimeKind.Local).AddTicks(5492), 37 },
                    { 83, "ورود", new DateTime(2024, 7, 16, 15, 33, 45, 673, DateTimeKind.Local).AddTicks(5502), 37 },
                    { 84, "خروج", new DateTime(2024, 7, 16, 19, 33, 45, 673, DateTimeKind.Local).AddTicks(5502), 37 },
                    { 85, "ورود", new DateTime(2024, 8, 6, 10, 33, 45, 673, DateTimeKind.Local).AddTicks(5510), 37 },
                    { 86, "خروج", new DateTime(2024, 8, 6, 13, 33, 45, 673, DateTimeKind.Local).AddTicks(5510), 37 },
                    { 87, "ورود", new DateTime(2024, 7, 14, 11, 33, 45, 673, DateTimeKind.Local).AddTicks(5520), 4 },
                    { 88, "خروج", new DateTime(2024, 7, 14, 13, 33, 45, 673, DateTimeKind.Local).AddTicks(5520), 4 },
                    { 89, "ورود", new DateTime(2024, 8, 3, 13, 33, 45, 673, DateTimeKind.Local).AddTicks(5529), 4 },
                    { 90, "خروج", new DateTime(2024, 8, 3, 14, 33, 45, 673, DateTimeKind.Local).AddTicks(5529), 4 },
                    { 91, "ورود", new DateTime(2024, 7, 23, 11, 33, 45, 673, DateTimeKind.Local).AddTicks(5538), 4 },
                    { 92, "خروج", new DateTime(2024, 7, 23, 15, 33, 45, 673, DateTimeKind.Local).AddTicks(5538), 4 },
                    { 93, "ورود", new DateTime(2024, 7, 23, 11, 33, 45, 673, DateTimeKind.Local).AddTicks(5547), 4 },
                    { 94, "خروج", new DateTime(2024, 7, 23, 14, 33, 45, 673, DateTimeKind.Local).AddTicks(5547), 4 },
                    { 95, "ورود", new DateTime(2024, 8, 2, 13, 33, 45, 673, DateTimeKind.Local).AddTicks(5556), 4 },
                    { 96, "خروج", new DateTime(2024, 8, 2, 14, 33, 45, 673, DateTimeKind.Local).AddTicks(5556), 4 },
                    { 97, "ورود", new DateTime(2024, 7, 13, 13, 33, 45, 673, DateTimeKind.Local).AddTicks(5565), 4 },
                    { 98, "خروج", new DateTime(2024, 7, 13, 17, 33, 45, 673, DateTimeKind.Local).AddTicks(5565), 4 },
                    { 99, "ورود", new DateTime(2024, 7, 11, 10, 33, 45, 673, DateTimeKind.Local).AddTicks(5582), 4 },
                    { 100, "خروج", new DateTime(2024, 7, 11, 13, 33, 45, 673, DateTimeKind.Local).AddTicks(5582), 4 },
                    { 101, "ورود", new DateTime(2024, 7, 30, 10, 33, 45, 673, DateTimeKind.Local).AddTicks(5592), 4 },
                    { 102, "خروج", new DateTime(2024, 7, 30, 12, 33, 45, 673, DateTimeKind.Local).AddTicks(5592), 4 },
                    { 103, "ورود", new DateTime(2024, 8, 2, 12, 33, 45, 673, DateTimeKind.Local).AddTicks(5601), 4 },
                    { 104, "خروج", new DateTime(2024, 8, 2, 17, 33, 45, 673, DateTimeKind.Local).AddTicks(5601), 4 },
                    { 105, "ورود", new DateTime(2024, 7, 29, 13, 33, 45, 673, DateTimeKind.Local).AddTicks(5610), 23 },
                    { 106, "خروج", new DateTime(2024, 7, 29, 17, 33, 45, 673, DateTimeKind.Local).AddTicks(5610), 23 },
                    { 107, "ورود", new DateTime(2024, 7, 18, 11, 33, 45, 673, DateTimeKind.Local).AddTicks(5619), 23 },
                    { 108, "خروج", new DateTime(2024, 7, 18, 12, 33, 45, 673, DateTimeKind.Local).AddTicks(5619), 23 },
                    { 109, "ورود", new DateTime(2024, 8, 6, 14, 33, 45, 673, DateTimeKind.Local).AddTicks(5628), 23 },
                    { 110, "خروج", new DateTime(2024, 8, 6, 16, 33, 45, 673, DateTimeKind.Local).AddTicks(5628), 23 },
                    { 111, "ورود", new DateTime(2024, 8, 1, 10, 33, 45, 673, DateTimeKind.Local).AddTicks(5638), 23 },
                    { 112, "خروج", new DateTime(2024, 8, 1, 13, 33, 45, 673, DateTimeKind.Local).AddTicks(5638), 23 },
                    { 113, "ورود", new DateTime(2024, 8, 3, 12, 33, 45, 673, DateTimeKind.Local).AddTicks(5646), 23 },
                    { 114, "خروج", new DateTime(2024, 8, 3, 16, 33, 45, 673, DateTimeKind.Local).AddTicks(5646), 23 },
                    { 115, "ورود", new DateTime(2024, 7, 18, 15, 33, 45, 673, DateTimeKind.Local).AddTicks(5655), 23 },
                    { 116, "خروج", new DateTime(2024, 7, 18, 18, 33, 45, 673, DateTimeKind.Local).AddTicks(5655), 23 },
                    { 117, "ورود", new DateTime(2024, 7, 23, 15, 33, 45, 673, DateTimeKind.Local).AddTicks(5665), 33 },
                    { 118, "خروج", new DateTime(2024, 7, 23, 17, 33, 45, 673, DateTimeKind.Local).AddTicks(5665), 33 },
                    { 119, "ورود", new DateTime(2024, 7, 19, 13, 33, 45, 673, DateTimeKind.Local).AddTicks(5674), 33 },
                    { 120, "خروج", new DateTime(2024, 7, 19, 17, 33, 45, 673, DateTimeKind.Local).AddTicks(5674), 33 },
                    { 121, "ورود", new DateTime(2024, 7, 22, 15, 33, 45, 673, DateTimeKind.Local).AddTicks(5683), 33 },
                    { 122, "خروج", new DateTime(2024, 7, 22, 19, 33, 45, 673, DateTimeKind.Local).AddTicks(5683), 33 },
                    { 123, "ورود", new DateTime(2024, 7, 31, 15, 33, 45, 673, DateTimeKind.Local).AddTicks(5692), 33 },
                    { 124, "خروج", new DateTime(2024, 7, 31, 18, 33, 45, 673, DateTimeKind.Local).AddTicks(5692), 33 },
                    { 125, "ورود", new DateTime(2024, 7, 22, 11, 33, 45, 673, DateTimeKind.Local).AddTicks(5701), 33 },
                    { 126, "خروج", new DateTime(2024, 7, 22, 13, 33, 45, 673, DateTimeKind.Local).AddTicks(5701), 33 },
                    { 127, "ورود", new DateTime(2024, 7, 30, 15, 33, 45, 673, DateTimeKind.Local).AddTicks(5710), 33 },
                    { 128, "خروج", new DateTime(2024, 7, 30, 16, 33, 45, 673, DateTimeKind.Local).AddTicks(5710), 33 },
                    { 129, "ورود", new DateTime(2024, 7, 22, 13, 33, 45, 673, DateTimeKind.Local).AddTicks(5719), 33 },
                    { 130, "خروج", new DateTime(2024, 7, 22, 15, 33, 45, 673, DateTimeKind.Local).AddTicks(5719), 33 },
                    { 131, "ورود", new DateTime(2024, 7, 25, 12, 33, 45, 673, DateTimeKind.Local).AddTicks(5731), 25 },
                    { 132, "خروج", new DateTime(2024, 7, 25, 17, 33, 45, 673, DateTimeKind.Local).AddTicks(5731), 25 },
                    { 133, "ورود", new DateTime(2024, 7, 11, 13, 33, 45, 673, DateTimeKind.Local).AddTicks(5740), 25 },
                    { 134, "خروج", new DateTime(2024, 7, 11, 17, 33, 45, 673, DateTimeKind.Local).AddTicks(5740), 25 },
                    { 135, "ورود", new DateTime(2024, 7, 18, 13, 33, 45, 673, DateTimeKind.Local).AddTicks(5748), 25 },
                    { 136, "خروج", new DateTime(2024, 7, 18, 16, 33, 45, 673, DateTimeKind.Local).AddTicks(5748), 25 },
                    { 137, "ورود", new DateTime(2024, 7, 21, 14, 33, 45, 673, DateTimeKind.Local).AddTicks(5758), 25 },
                    { 138, "خروج", new DateTime(2024, 7, 21, 17, 33, 45, 673, DateTimeKind.Local).AddTicks(5758), 25 },
                    { 139, "ورود", new DateTime(2024, 7, 17, 14, 33, 45, 673, DateTimeKind.Local).AddTicks(5767), 25 },
                    { 140, "خروج", new DateTime(2024, 7, 17, 17, 33, 45, 673, DateTimeKind.Local).AddTicks(5767), 25 },
                    { 141, "ورود", new DateTime(2024, 7, 22, 10, 33, 45, 673, DateTimeKind.Local).AddTicks(5776), 25 },
                    { 142, "خروج", new DateTime(2024, 7, 22, 14, 33, 45, 673, DateTimeKind.Local).AddTicks(5776), 25 },
                    { 143, "ورود", new DateTime(2024, 8, 7, 14, 33, 45, 673, DateTimeKind.Local).AddTicks(5785), 25 },
                    { 144, "خروج", new DateTime(2024, 8, 7, 16, 33, 45, 673, DateTimeKind.Local).AddTicks(5785), 25 },
                    { 145, "ورود", new DateTime(2024, 7, 14, 11, 33, 45, 673, DateTimeKind.Local).AddTicks(5793), 25 },
                    { 146, "خروج", new DateTime(2024, 7, 14, 13, 33, 45, 673, DateTimeKind.Local).AddTicks(5793), 25 },
                    { 147, "ورود", new DateTime(2024, 7, 13, 10, 33, 45, 673, DateTimeKind.Local).AddTicks(5803), 25 },
                    { 148, "خروج", new DateTime(2024, 7, 13, 13, 33, 45, 673, DateTimeKind.Local).AddTicks(5803), 25 },
                    { 149, "ورود", new DateTime(2024, 7, 13, 11, 33, 45, 673, DateTimeKind.Local).AddTicks(5812), 8 },
                    { 150, "خروج", new DateTime(2024, 7, 13, 13, 33, 45, 673, DateTimeKind.Local).AddTicks(5812), 8 },
                    { 151, "ورود", new DateTime(2024, 8, 7, 11, 33, 45, 673, DateTimeKind.Local).AddTicks(5822), 8 },
                    { 152, "خروج", new DateTime(2024, 8, 7, 12, 33, 45, 673, DateTimeKind.Local).AddTicks(5822), 8 },
                    { 153, "ورود", new DateTime(2024, 8, 1, 12, 33, 45, 673, DateTimeKind.Local).AddTicks(5830), 8 },
                    { 154, "خروج", new DateTime(2024, 8, 1, 13, 33, 45, 673, DateTimeKind.Local).AddTicks(5830), 8 },
                    { 155, "ورود", new DateTime(2024, 7, 25, 14, 33, 45, 673, DateTimeKind.Local).AddTicks(5839), 8 },
                    { 156, "خروج", new DateTime(2024, 7, 25, 18, 33, 45, 673, DateTimeKind.Local).AddTicks(5839), 8 },
                    { 157, "ورود", new DateTime(2024, 8, 5, 14, 33, 45, 673, DateTimeKind.Local).AddTicks(5848), 8 },
                    { 158, "خروج", new DateTime(2024, 8, 5, 16, 33, 45, 673, DateTimeKind.Local).AddTicks(5848), 8 },
                    { 159, "ورود", new DateTime(2024, 7, 16, 13, 33, 45, 673, DateTimeKind.Local).AddTicks(5858), 16 },
                    { 160, "خروج", new DateTime(2024, 7, 16, 18, 33, 45, 673, DateTimeKind.Local).AddTicks(5858), 16 },
                    { 161, "ورود", new DateTime(2024, 8, 3, 13, 33, 45, 673, DateTimeKind.Local).AddTicks(5867), 16 },
                    { 162, "خروج", new DateTime(2024, 8, 3, 14, 33, 45, 673, DateTimeKind.Local).AddTicks(5867), 16 },
                    { 163, "ورود", new DateTime(2024, 7, 22, 10, 33, 45, 673, DateTimeKind.Local).AddTicks(5876), 16 },
                    { 164, "خروج", new DateTime(2024, 7, 22, 14, 33, 45, 673, DateTimeKind.Local).AddTicks(5876), 16 },
                    { 165, "ورود", new DateTime(2024, 7, 14, 11, 33, 45, 673, DateTimeKind.Local).AddTicks(5885), 16 },
                    { 166, "خروج", new DateTime(2024, 7, 14, 13, 33, 45, 673, DateTimeKind.Local).AddTicks(5885), 16 },
                    { 167, "ورود", new DateTime(2024, 8, 4, 14, 33, 45, 673, DateTimeKind.Local).AddTicks(5894), 16 },
                    { 168, "خروج", new DateTime(2024, 8, 4, 19, 33, 45, 673, DateTimeKind.Local).AddTicks(5894), 16 },
                    { 169, "ورود", new DateTime(2024, 8, 8, 10, 33, 45, 673, DateTimeKind.Local).AddTicks(5903), 16 },
                    { 170, "خروج", new DateTime(2024, 8, 8, 15, 33, 45, 673, DateTimeKind.Local).AddTicks(5903), 16 },
                    { 171, "ورود", new DateTime(2024, 8, 7, 15, 33, 45, 673, DateTimeKind.Local).AddTicks(5913), 21 },
                    { 172, "خروج", new DateTime(2024, 8, 7, 17, 33, 45, 673, DateTimeKind.Local).AddTicks(5913), 21 },
                    { 173, "ورود", new DateTime(2024, 8, 4, 10, 33, 45, 673, DateTimeKind.Local).AddTicks(5921), 21 },
                    { 174, "خروج", new DateTime(2024, 8, 4, 15, 33, 45, 673, DateTimeKind.Local).AddTicks(5921), 21 },
                    { 175, "ورود", new DateTime(2024, 7, 14, 14, 33, 45, 673, DateTimeKind.Local).AddTicks(5930), 21 },
                    { 176, "خروج", new DateTime(2024, 7, 14, 17, 33, 45, 673, DateTimeKind.Local).AddTicks(5930), 21 },
                    { 177, "ورود", new DateTime(2024, 7, 26, 14, 33, 45, 673, DateTimeKind.Local).AddTicks(5940), 21 },
                    { 178, "خروج", new DateTime(2024, 7, 26, 16, 33, 45, 673, DateTimeKind.Local).AddTicks(5940), 21 },
                    { 179, "ورود", new DateTime(2024, 8, 9, 10, 33, 45, 673, DateTimeKind.Local).AddTicks(5948), 21 },
                    { 180, "خروج", new DateTime(2024, 8, 9, 11, 33, 45, 673, DateTimeKind.Local).AddTicks(5948), 21 },
                    { 181, "ورود", new DateTime(2024, 7, 20, 10, 33, 45, 673, DateTimeKind.Local).AddTicks(5958), 21 },
                    { 182, "خروج", new DateTime(2024, 7, 20, 12, 33, 45, 673, DateTimeKind.Local).AddTicks(5958), 21 },
                    { 183, "ورود", new DateTime(2024, 7, 24, 12, 33, 45, 673, DateTimeKind.Local).AddTicks(5966), 21 },
                    { 184, "خروج", new DateTime(2024, 7, 24, 17, 33, 45, 673, DateTimeKind.Local).AddTicks(5966), 21 }
                });

            migrationBuilder.InsertData(
                table: "Subscriptions",
                columns: new[] { "SubscriptionId", "ExpirationDate", "SessionCount", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 3, 9, 4, 33, 45, 673, DateTimeKind.Local).AddTicks(4176), 16, 1 },
                    { 2, new DateTime(2025, 7, 9, 4, 33, 45, 673, DateTimeKind.Local).AddTicks(4209), 18, 2 },
                    { 3, new DateTime(2025, 7, 9, 4, 33, 45, 673, DateTimeKind.Local).AddTicks(4218), 15, 3 },
                    { 4, new DateTime(2025, 5, 9, 4, 33, 45, 673, DateTimeKind.Local).AddTicks(4377), 19, 4 },
                    { 5, new DateTime(2024, 10, 9, 4, 33, 45, 673, DateTimeKind.Local).AddTicks(4386), 13, 5 },
                    { 6, new DateTime(2024, 12, 9, 4, 33, 45, 673, DateTimeKind.Local).AddTicks(4398), 20, 6 },
                    { 7, new DateTime(2025, 1, 9, 4, 33, 45, 673, DateTimeKind.Local).AddTicks(4406), 18, 7 },
                    { 8, new DateTime(2025, 4, 9, 4, 33, 45, 673, DateTimeKind.Local).AddTicks(4414), 17, 8 },
                    { 9, new DateTime(2025, 8, 9, 4, 33, 45, 673, DateTimeKind.Local).AddTicks(4421), 20, 9 },
                    { 10, new DateTime(2025, 6, 9, 4, 33, 45, 673, DateTimeKind.Local).AddTicks(4430), 14, 10 },
                    { 11, new DateTime(2025, 7, 9, 4, 33, 45, 673, DateTimeKind.Local).AddTicks(4439), 10, 11 },
                    { 12, new DateTime(2025, 3, 9, 4, 33, 45, 673, DateTimeKind.Local).AddTicks(4446), 14, 12 },
                    { 13, new DateTime(2024, 12, 9, 4, 33, 45, 673, DateTimeKind.Local).AddTicks(4453), 10, 13 },
                    { 14, new DateTime(2024, 12, 9, 4, 33, 45, 673, DateTimeKind.Local).AddTicks(4461), 20, 14 },
                    { 15, new DateTime(2024, 10, 9, 4, 33, 45, 673, DateTimeKind.Local).AddTicks(4469), 15, 15 },
                    { 16, new DateTime(2024, 11, 9, 4, 33, 45, 673, DateTimeKind.Local).AddTicks(4476), 18, 16 },
                    { 17, new DateTime(2024, 12, 9, 4, 33, 45, 673, DateTimeKind.Local).AddTicks(4485), 13, 17 },
                    { 18, new DateTime(2024, 12, 9, 4, 33, 45, 673, DateTimeKind.Local).AddTicks(4494), 10, 18 },
                    { 19, new DateTime(2025, 5, 9, 4, 33, 45, 673, DateTimeKind.Local).AddTicks(4501), 12, 19 },
                    { 20, new DateTime(2025, 3, 9, 4, 33, 45, 673, DateTimeKind.Local).AddTicks(4509), 17, 20 },
                    { 21, new DateTime(2025, 6, 9, 4, 33, 45, 673, DateTimeKind.Local).AddTicks(4517), 10, 21 },
                    { 22, new DateTime(2025, 3, 9, 4, 33, 45, 673, DateTimeKind.Local).AddTicks(4524), 16, 22 },
                    { 23, new DateTime(2024, 9, 9, 4, 33, 45, 673, DateTimeKind.Local).AddTicks(4532), 17, 23 },
                    { 24, new DateTime(2025, 7, 9, 4, 33, 45, 673, DateTimeKind.Local).AddTicks(4540), 19, 24 },
                    { 25, new DateTime(2024, 9, 9, 4, 33, 45, 673, DateTimeKind.Local).AddTicks(4548), 15, 25 },
                    { 26, new DateTime(2025, 6, 9, 4, 33, 45, 673, DateTimeKind.Local).AddTicks(4555), 19, 26 },
                    { 27, new DateTime(2024, 9, 9, 4, 33, 45, 673, DateTimeKind.Local).AddTicks(4562), 11, 27 },
                    { 28, new DateTime(2024, 12, 9, 4, 33, 45, 673, DateTimeKind.Local).AddTicks(4571), 19, 28 },
                    { 29, new DateTime(2025, 4, 9, 4, 33, 45, 673, DateTimeKind.Local).AddTicks(4578), 12, 29 },
                    { 30, new DateTime(2025, 5, 9, 4, 33, 45, 673, DateTimeKind.Local).AddTicks(4585), 14, 30 },
                    { 31, new DateTime(2025, 7, 9, 4, 33, 45, 673, DateTimeKind.Local).AddTicks(4594), 16, 31 },
                    { 32, new DateTime(2024, 12, 9, 4, 33, 45, 673, DateTimeKind.Local).AddTicks(4601), 15, 32 },
                    { 33, new DateTime(2024, 9, 9, 4, 33, 45, 673, DateTimeKind.Local).AddTicks(4608), 18, 33 },
                    { 34, new DateTime(2025, 4, 9, 4, 33, 45, 673, DateTimeKind.Local).AddTicks(4618), 19, 34 },
                    { 35, new DateTime(2025, 3, 9, 4, 33, 45, 673, DateTimeKind.Local).AddTicks(4626), 16, 35 },
                    { 36, new DateTime(2024, 10, 9, 4, 33, 45, 673, DateTimeKind.Local).AddTicks(4633), 16, 36 },
                    { 37, new DateTime(2025, 5, 9, 4, 33, 45, 673, DateTimeKind.Local).AddTicks(4642), 20, 37 },
                    { 38, new DateTime(2025, 5, 9, 4, 33, 45, 673, DateTimeKind.Local).AddTicks(4649), 19, 38 },
                    { 39, new DateTime(2025, 3, 9, 4, 33, 45, 673, DateTimeKind.Local).AddTicks(4656), 10, 39 },
                    { 40, new DateTime(2024, 12, 9, 4, 33, 45, 673, DateTimeKind.Local).AddTicks(4665), 14, 40 },
                    { 41, new DateTime(2025, 6, 9, 4, 33, 45, 673, DateTimeKind.Local).AddTicks(4672), 17, 41 },
                    { 42, new DateTime(2025, 3, 9, 4, 33, 45, 673, DateTimeKind.Local).AddTicks(4679), 10, 42 },
                    { 43, new DateTime(2025, 7, 9, 4, 33, 45, 673, DateTimeKind.Local).AddTicks(4688), 16, 43 },
                    { 44, new DateTime(2024, 12, 9, 4, 33, 45, 673, DateTimeKind.Local).AddTicks(4695), 15, 44 },
                    { 45, new DateTime(2024, 12, 9, 4, 33, 45, 673, DateTimeKind.Local).AddTicks(4702), 12, 45 },
                    { 46, new DateTime(2025, 1, 9, 4, 33, 45, 673, DateTimeKind.Local).AddTicks(4711), 19, 46 },
                    { 47, new DateTime(2025, 5, 9, 4, 33, 45, 673, DateTimeKind.Local).AddTicks(4718), 14, 47 },
                    { 48, new DateTime(2025, 8, 9, 4, 33, 45, 673, DateTimeKind.Local).AddTicks(4725), 19, 48 },
                    { 49, new DateTime(2025, 5, 9, 4, 33, 45, 673, DateTimeKind.Local).AddTicks(4734), 10, 49 },
                    { 50, new DateTime(2025, 2, 9, 4, 33, 45, 673, DateTimeKind.Local).AddTicks(4741), 20, 50 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_UserId",
                table: "Attendances",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_UserId",
                table: "Subscriptions",
                column: "UserId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attendances");

            migrationBuilder.DropTable(
                name: "Subscriptions");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
