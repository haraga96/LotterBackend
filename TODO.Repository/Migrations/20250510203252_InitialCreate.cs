using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TODO.Repository.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Todos",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Content = table.Column<string>(type: "TEXT", nullable: false),
                    CreationTime = table.Column<long>(type: "INTEGER", nullable: false),
                    DueDate = table.Column<long>(type: "INTEGER", nullable: false),
                    Status = table.Column<string>(type: "TEXT", nullable: false),
                    Type = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Todos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "Content", "CreationTime", "DueDate", "Status", "Title", "Type" },
                values: new object[,]
                {
                    { "08c37970-cdcb-11eb-b8bc-0242ac130003", "user 32566 awaiting 10.30$ payout", 1622374526379L, 1622539365375L, "Active", "User awaiting win payout", "Wins" },
                    { "0d3e9c82-cdcb-11eb-b8bc-0242ac130003", "user 45422 awaiting 15$ payout", 1542111235544L, 1622539355849L, "Done", "User awaiting win payout", "Wins" },
                    { "124f703e-cdcb-11eb-b8bc-0242ac130003", "draw 897644 awaiting draw result", 1622375111971L, 1622539347152L, "Active", "Super enaloto awaiting Draw Result", "Results" },
                    { "6f4c1ba5-7927-478b-bf43-48af79af56d8", "draw 23232 awaiting draw result", 1622375111971L, 1622375125381L, "Active", "EuroJackpot awaiting Draw Result", "Results" },
                    { "bdff234c-33d3-447f-80ee-84e43a23f01d", "withdraw id 5452 awaiting approval", 1542111235544L, 1622539315287L, "Active", "User Withdraw pending", "Withdraw" },
                    { "bdff234c-33d3-447f-80ee-84e43a33f014", "user 34332 awaiting 15$ payout", 1542111235544L, 1622374526340L, "Done", "User awaiting win payout", "Wins" },
                    { "bdff234c-33d3-447f-80ee-84e43a33f01d", "draw 12345 awaiting draw result", 1542111235544L, 1622374526379L, "Active", "MegaMillions awaiting Draw Result", "Results" },
                    { "ec65203f-42374-4ac1-9b4b-579e5c40b09b", "withdraw id 23443 awaiting approval", 1622374526379L, 1622539324959L, "Active", "User Withdraw pending", "Withdraw" },
                    { "ec65203f-4c74-4ac1-9b4b-572e2c40b03b", "user 234787 awaiting 1000.40$ payout", 1622374526379L, 1622374714232L, "Active", "User awaiting win payout", "Wins" },
                    { "ec65203f-4c74-4ac1-9b4b-572e5c40b03b", "user 32566 awaiting 10.30$ payout", 1622374526379L, 1622374714232L, "Active", "User awaiting win payout", "Wins" },
                    { "ec65203f-4c74-4ac1-9b4b-579e5c40b09b", "draw 23232 awaiting draw result", 1622374526379L, 1622374714232L, "Active", "EuroJackpot awaiting Draw Result", "Results" },
                    { "f234f5cb-6ec0-4475-aa32-b6ebf9ab42ad", "withdraw id 127888 awaiting approval", 1622374714232L, 1622539336894L, "Done", "User Withdraw pending", "Withdraw" },
                    { "f234f5cb-6ec0-4475-bb32-b6ebf9ab42ad", "draw 56345 awaiting draw result", 1622374714232L, 1622375111971L, "Done", "Powerball awaiting Draw Result", "Results" },
                    { "ffd17a42-cdca-11eb-b8bc-0242ac130003", "user 675553 awaiting 1000.40$ payout", 1622374526379L, 1622539372100L, "Active", "User awaiting win payout", "Wins" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Todos");
        }
    }
}
