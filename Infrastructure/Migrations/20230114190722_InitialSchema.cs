using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(90)", maxLength: 90, nullable: false),
                    StreetAddress = table.Column<string>(type: "character varying(90)", maxLength: 90, nullable: false),
                    City = table.Column<string>(type: "character varying(90)", maxLength: 90, nullable: false),
                    State = table.Column<string>(type: "character varying(2)", maxLength: 2, nullable: false),
                    ZipCode = table.Column<string>(type: "character varying(5)", maxLength: 5, nullable: false),
                    Phone = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    Notes = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Latitude = table.Column<double>(type: "double precision", nullable: false),
                    Longitude = table.Column<double>(type: "double precision", nullable: false),
                    Distance = table.Column<double>(type: "double precision", nullable: false),
                    DirectionsUri = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "City", "DirectionsUri", "Distance", "Latitude", "Longitude", "Name", "Notes", "Phone", "State", "StreetAddress", "ZipCode" },
                values: new object[,]
                {
                    { 1, "Portland", null, 0.0, 43.683100000000003, -70.289929999999998, "Back Bay Superette", "Ask at Checkout", "2077475754", "ME", "1037 Forest Ave", "04103" },
                    { 2, "Portland", null, 0.0, 43.657060000000001, -70.248819999999995, "Casco Bay Lines", "Ask at Ferry Terminal ticket counter", "2077747871", "ME", "56 Commercial Street", "04101" },
                    { 3, "Cliff Island", null, 0.0, 43.694400000000002, -70.109089999999995, "Cliff Island Store & Cafe", "Open June 24- Sept 5 \nAsk at Checkout", "2077662312", "ME", "11 Wharf Rd", "04019" },
                    { 4, "Portland", null, 0.0, 43.686199999999999, -70.292810000000003, "Cumberland Farms", "Ask at Checkout", "2077979927", "ME", "1136 Forest Ave", "04103" },
                    { 5, "Portland", null, 0.0, 43.651409999999998, -70.268630000000002, "Cumberland Farms", "Ask at Checkout", "2078749528", "ME", "49 Pine St", "04102" },
                    { 6, "Portland", null, 0.0, 43.686583800000001, -70.268517500000002, "Cumberland Farms", "Ask at Checkout", "2077808032", "ME", "801 Washington Ave", "04103" },
                    { 7, "Portland", null, 0.0, 43.668931299999997, -70.301337000000004, "Cumberland Farms", "Ask at Checkout", "2077737792", "ME", "512 Woodfords St", "04103" },
                    { 8, "Portland", null, 0.0, 43.666674399999998, -70.276269999999997, "CVS", "Ask at Checkout", "2077721928", "ME", "449 Forest Ave.", "04101" },
                    { 9, "Portland", null, 0.0, 43.658794499999999, -70.297687499999995, "CVS", "Ask at Checkout", "2077743636", "ME", "1406 Congress St", "04102" },
                    { 10, "Portland", null, 0.0, 43.703988899999999, -70.288760100000005, "CVS", "Checkout & Drive Thru", "2077973393", "ME", "111 Auburn St", "04103" },
                    { 11, "Portland", null, 0.0, 43.6558846, -70.260373000000001, "CVS", "Ask at Checkout", "2077744525", "ME", "510 Congress St", "04102" },
                    { 12, "Portland", null, 0.0, 43.687002300000003, -70.259357499999993, "Eldridge Lumber & Hardware", "Ask at Checkout", "2077703004", "ME", "145 Presumpscot St", "04103" },
                    { 13, "Falmouth", null, 0.0, 43.734770099999999, -70.296048799999994, "Hannaford", "Customer Service/ Checkout/ To-Go", "2078780050", "ME", "65 Gray Rd", "04105" },
                    { 14, "Westbrook", null, 0.0, 43.675995800000003, -70.355133899999998, "Hannaford", "Customer Service/ Checkout/ To-Go", "2078544631", "ME", "7 Hannaford Dr", "04092" },
                    { 15, "South Portland", null, 0.0, 43.637839700000001, -70.2503399, "Hannaford", "Customer Service/ Checkout/ To-Go", "2077997359", "ME", "50 Cottage Rd", "04106" },
                    { 16, "Portland", null, 0.0, 43.663645099999997, -70.268522300000001, "Hannaford", "Customer Service/ Checkout/ To-Go", "2077915965", "ME", "295 Forest Ave", "04101" },
                    { 17, "Portland", null, 0.0, 43.701788200000003, -70.319492299999993, "Hannaford", "Customer Service/ Checkout/ To-Go", "2078780191", "ME", "787 Riverside St", "04103" },
                    { 18, "South Portland", null, 0.0, 43.633817399999998, -70.329078499999994, "Hannaford", "Customer Service/ Checkout/ To-Go", "2077612729", "ME", "415 Philbrook Ave", "04106" },
                    { 19, "Peaks Island", null, 0.0, 43.656719500000001, -70.197916699999993, "Hannigan's Market", "Ask at Checkout", "2077662351", "ME", "75 Island Ave", "04108" },
                    { 20, "Portland", null, 0.0, 43.652640599999998, -70.280329800000004, "Maine Hardware", "Ask at Checkout", "2077735604", "ME", "274 Saint John St", "04102" },
                    { 21, "Westbrook", null, 0.0, 43.680179099999997, -70.330726400000003, "Market Basket", "Customer Service/ Checkout", "2074642100", "ME", "207 Larrabee Rd", "04092" },
                    { 22, "Portland", null, 0.0, 43.696506100000001, -70.306728800000002, "Moran's Market", "Ask at Checkout", "2077976674", "ME", "1576 Forest Ave", "04103" },
                    { 23, "Portland", null, 0.0, 43.661100900000001, -70.252392400000005, "Portland food co-op", "Ask at Checkout", "2078051599", "ME", "290 Congress St", "04101" },
                    { 24, "Portland", null, 0.0, 43.651562400000003, -70.267805100000004, "Rosemont Market", "Ask at Checkout", "2076994181", "ME", "40 Pine St", "04102" },
                    { 25, "Portland", null, 0.0, 43.666695199999999, -70.246613999999994, "Rosemont Market", "Ask at Checkout", "2077737888", "ME", "88 Congress St", "04101" },
                    { 26, "Portland", null, 0.0, 43.668681900000003, -70.302214699999993, "Rosemont Market", "Ask at Checkout", "2077748129", "ME", "580 Brighton Ave", "04102" },
                    { 27, "Portland", null, 0.0, 43.652340899999999, -70.280264599999995, "Save-A-Lot", "Ask at Checkout", "2077720622", "ME", "268 St John St", "04102" },
                    { 28, "Portland", null, 0.0, 43.703631999999999, -70.288659999999993, "Shaw's", "Ask at Checkout/Instacart", "2077974304", "ME", "91 Auburn St", "04103" },
                    { 29, "Portland", null, 0.0, 43.658065399999998, -70.296376899999998, "Shaw's", "Ask at Checkout/Instacart", "2077747661", "ME", "1364 Congress St", "04102" },
                    { 30, "South Portland", null, 0.0, 43.636472499999996, -70.255871099999993, "Shaw's", "Ask at Checkout/Instacart", "2077998149", "ME", "180 Waterman Drive", "04106" },
                    { 31, "Westbrook", null, 0.0, 43.679414199999997, -70.330899200000005, "Shaw's", "Ask at Checkout/Instacart", "2078579229", "ME", "31 Main St", "04092" },
                    { 32, "Falmouth", null, 0.0, 43.7243438, -70.2298337, "Shaw's", "Ask at Checkout/Instacart", "2077816581", "ME", "251 US RT 1", "04105" },
                    { 33, "Scarborough", null, 0.0, 43.620249100000002, -70.350367000000006, "Shaw's", "Ask at Checkout/Instacart", "2078832443", "ME", "417 Payne Rd", "04074" },
                    { 34, "Portland", null, 0.0, 43.663312300000001, -70.258410100000006, "Whole Foods", "Ask at Checkout/Curbside/ Amazon", "2077747711", "ME", "2 Somerset St", "04101" },
                    { 35, "Portland", null, 0.0, 43.661100900000001, -70.252392400000005, "Walgreens", "Ask at Checkout", "2077740344", "ME", "290 Congress St", "04101" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Locations");
        }
    }
}
