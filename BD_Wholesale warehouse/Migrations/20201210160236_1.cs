using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BD_Wholesale_warehouse.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Warehouse",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Receipt_date = table.Column<DateTime>(nullable: false),
                    Order_date = table.Column<DateTime>(nullable: false),
                    Departure_date = table.Column<DateTime>(nullable: false),
                    ProductID = table.Column<long>(nullable: false),
                    SupplierID = table.Column<long>(nullable: false),
                    CustomerID = table.Column<long>(nullable: false),
                    Delivery_method = table.Column<string>(nullable: true),
                    Volume = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    StaffID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouse", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<long>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Addres = table.Column<string>(nullable: true),
                    Phone_number = table.Column<int>(nullable: false),
                    ProductID1 = table.Column<long>(nullable: false),
                    ProductID2 = table.Column<long>(nullable: false),
                    ProductID3 = table.Column<long>(nullable: false),
                    WarehouseID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Customers_Warehouse_WarehouseID",
                        column: x => x.WarehouseID,
                        principalTable: "Warehouse",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Staff_ID = table.Column<long>(nullable: false),
                    Full_name = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    Adress = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Passport_data = table.Column<string>(nullable: true),
                    PositionID = table.Column<long>(nullable: false),
                    WarehouseID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Staff_Warehouse_WarehouseID",
                        column: x => x.WarehouseID,
                        principalTable: "Warehouse",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierID = table.Column<long>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Addres = table.Column<string>(nullable: true),
                    Phone_number = table.Column<int>(nullable: false),
                    ProductID1 = table.Column<long>(nullable: false),
                    ProductID2 = table.Column<long>(nullable: false),
                    ProductID3 = table.Column<long>(nullable: false),
                    WarehouseID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Suppliers_Warehouse_WarehouseID",
                        column: x => x.WarehouseID,
                        principalTable: "Warehouse",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PositionID = table.Column<long>(nullable: false),
                    Job_title = table.Column<string>(nullable: true),
                    Salary = table.Column<int>(nullable: false),
                    Duties = table.Column<string>(nullable: true),
                    Demands = table.Column<string>(nullable: true),
                    StaffID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Positions_Staff_StaffID",
                        column: x => x.StaffID,
                        principalTable: "Staff",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Product_ID = table.Column<long>(nullable: false),
                    Product_typeID = table.Column<long>(nullable: false),
                    Manufacturer = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Storage_conditions = table.Column<string>(nullable: true),
                    Packaging = table.Column<string>(nullable: true),
                    Shelf_life = table.Column<DateTime>(nullable: false),
                    CustomersID = table.Column<long>(nullable: true),
                    CustomersID1 = table.Column<long>(nullable: true),
                    CustomersID2 = table.Column<long>(nullable: true),
                    SuppliersID = table.Column<long>(nullable: true),
                    SuppliersID1 = table.Column<long>(nullable: true),
                    SuppliersID2 = table.Column<long>(nullable: true),
                    WarehouseID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Product_Customers_CustomersID",
                        column: x => x.CustomersID,
                        principalTable: "Customers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_Customers_CustomersID1",
                        column: x => x.CustomersID1,
                        principalTable: "Customers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_Customers_CustomersID2",
                        column: x => x.CustomersID2,
                        principalTable: "Customers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_Suppliers_SuppliersID",
                        column: x => x.SuppliersID,
                        principalTable: "Suppliers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_Suppliers_SuppliersID1",
                        column: x => x.SuppliersID1,
                        principalTable: "Suppliers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_Suppliers_SuppliersID2",
                        column: x => x.SuppliersID2,
                        principalTable: "Suppliers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_Warehouse_WarehouseID",
                        column: x => x.WarehouseID,
                        principalTable: "Warehouse",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Product_type",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Product_type_ID = table.Column<long>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Features = table.Column<string>(nullable: true),
                    ProductID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product_type", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Product_type_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_WarehouseID",
                table: "Customers",
                column: "WarehouseID");

            migrationBuilder.CreateIndex(
                name: "IX_Positions_StaffID",
                table: "Positions",
                column: "StaffID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CustomersID",
                table: "Product",
                column: "CustomersID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CustomersID1",
                table: "Product",
                column: "CustomersID1");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CustomersID2",
                table: "Product",
                column: "CustomersID2");

            migrationBuilder.CreateIndex(
                name: "IX_Product_SuppliersID",
                table: "Product",
                column: "SuppliersID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_SuppliersID1",
                table: "Product",
                column: "SuppliersID1");

            migrationBuilder.CreateIndex(
                name: "IX_Product_SuppliersID2",
                table: "Product",
                column: "SuppliersID2");

            migrationBuilder.CreateIndex(
                name: "IX_Product_WarehouseID",
                table: "Product",
                column: "WarehouseID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_type_ProductID",
                table: "Product_type",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_WarehouseID",
                table: "Staff",
                column: "WarehouseID");

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_WarehouseID",
                table: "Suppliers",
                column: "WarehouseID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "Product_type");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "Warehouse");
        }
    }
}
