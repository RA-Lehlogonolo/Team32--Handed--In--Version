using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VillageBoard.Migrations
{
    public partial class alltableswithnofk2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Set_Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Health_Inspection_Statuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Health_Inspection_Statuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Health_Inspection_Type",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Health_Inspection_Type", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Item_Types",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item_Types", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Maintainence_Request_Statuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maintainence_Request_Statuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Meal_types",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meal_types", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Meals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Menu_Types",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu_Types", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Payment_Types",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment_Types", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product_Type",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product_Type", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Residence_Type",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Residence_Type", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Room_Inspection",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Curtains = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Curtain_Rail_Hooks = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Globes = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Light_Switches = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Desk = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Chair = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Wardrobe_Doors = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Mattress = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Wall_Sockets = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Room_Door = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Door_Lock = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Mirror = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Ceiling = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Walls = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Floor = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Other = table.Column<string>(type: "nvarchar(225)", maxLength: 225, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Room_Inspection", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Room_Statuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Room_Statuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Contact_Number = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Physical_Address = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Time_Slots",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Start_Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End_Time = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Time_Slots", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Visitation_Application_Statuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Decsription = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitation_Application_Statuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Years",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Years", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dates");

            migrationBuilder.DropTable(
                name: "Health_Inspection_Statuses");

            migrationBuilder.DropTable(
                name: "Health_Inspection_Type");

            migrationBuilder.DropTable(
                name: "Item_Types");

            migrationBuilder.DropTable(
                name: "Maintainence_Request_Statuses");

            migrationBuilder.DropTable(
                name: "Meal_types");

            migrationBuilder.DropTable(
                name: "Meals");

            migrationBuilder.DropTable(
                name: "Menu_Types");

            migrationBuilder.DropTable(
                name: "Payment_Types");

            migrationBuilder.DropTable(
                name: "Product_Type");

            migrationBuilder.DropTable(
                name: "Residence_Type");

            migrationBuilder.DropTable(
                name: "Room_Inspection");

            migrationBuilder.DropTable(
                name: "Room_Statuses");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "Time_Slots");

            migrationBuilder.DropTable(
                name: "Visitation_Application_Statuses");

            migrationBuilder.DropTable(
                name: "Years");
        }
    }
}
