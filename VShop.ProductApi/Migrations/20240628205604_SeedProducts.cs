using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VShop.ProductApi.Migrations
{
    /// <inheritdoc />
    public partial class SeedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Products (Name, Price, Description, Stock, ImageURL, CategoryId) VALUES ('Notebook', '2599', 'Notebook Dell', 10, 'notebook.jpg', 1)");
            migrationBuilder.Sql("INSERT INTO Products (Name, Price, Description, Stock, ImageURL, CategoryId) VALUES ('Camiseta', '59.99', 'Camiseta básica', 40, 'camiseta.jpg', 2)");
            migrationBuilder.Sql("INSERT INTO Products (Name, Price, Description, Stock, ImageURL, CategoryId) VALUES ('Livro', '59.99', 'Agatha Christie', 5, 'livro.jpg', 3)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Products WHERE Name = 'Notebook'");
            migrationBuilder.Sql("DELETE FROM Products WHERE Name = 'Camiseta'");
            migrationBuilder.Sql("DELETE FROM Products WHERE Name = 'Livro'");
        }
    }
}
