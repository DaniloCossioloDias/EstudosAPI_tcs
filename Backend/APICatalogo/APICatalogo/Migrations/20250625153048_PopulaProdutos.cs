using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    /// <inheritdoc />
    public partial class PopulaProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO PRODUTOS(NOME, DESCRICAO, PRECO, IMAGEMURL, ESTOQUE, DATACADASTRO, CATEGORIAID) VALUES('Coca','Coca gelada',5.45,'coca.jpg',20,now(),1)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM PRODUTOS");
        }
    }
}
