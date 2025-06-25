using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    /// <inheritdoc />
    public partial class PopulaCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO CATEGORIAS(NOME, IMAGEMURL) VALUES('BEBIDAS', 'BEBIDAS.JPG')");
            mb.Sql("INSERT INTO CATEGORIAS(NOME, IMAGEMURL) VALUES('LANCHES', 'LANCHES.JPG')");
            mb.Sql("INSERT INTO CATEGORIAS(NOME, IMAGEMURL) VALUES('SALADAS', 'SALADAS.JPG')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM CATEGORIAS");
        }
    }
}
