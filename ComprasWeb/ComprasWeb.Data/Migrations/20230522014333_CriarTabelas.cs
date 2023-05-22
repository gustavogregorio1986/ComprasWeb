using Microsoft.EntityFrameworkCore.Migrations;

namespace ComprasWeb.Data.Migrations
{
    public partial class CriarTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_Usuario",
                columns: table => new
                {
                    IdUser = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Perfil = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Usuario", x => x.IdUser);
                });

            migrationBuilder.CreateTable(
                name: "tb_Cliente",
                columns: table => new
                {
                    IdCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCliente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailCliente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sexo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_Usuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Cliente", x => x.IdCliente);
                    table.ForeignKey(
                        name: "FK_tb_Cliente_tb_Usuario_Id_Usuario",
                        column: x => x.Id_Usuario,
                        principalTable: "tb_Usuario",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_Vendedor",
                columns: table => new
                {
                    Idvendedor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeVendedor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailVendedor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_Usuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Vendedor", x => x.Idvendedor);
                    table.ForeignKey(
                        name: "FK_tb_Vendedor_tb_Usuario_Id_Usuario",
                        column: x => x.Id_Usuario,
                        principalTable: "tb_Usuario",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_Endereco",
                columns: table => new
                {
                    IdEnmdereco = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logradouro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Complemwnto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Uf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cep = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_Cliente = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Endereco", x => x.IdEnmdereco);
                    table.ForeignKey(
                        name: "FK_tb_Endereco_tb_Cliente_Id_Cliente",
                        column: x => x.Id_Cliente,
                        principalTable: "tb_Cliente",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_Loja",
                columns: table => new
                {
                    IdLoja = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeLoja = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClienteIdCliente = table.Column<int>(type: "int", nullable: true),
                    Id_Cliente = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Loja", x => x.IdLoja);
                    table.ForeignKey(
                        name: "FK_tb_Loja_tb_Cliente_ClienteIdCliente",
                        column: x => x.ClienteIdCliente,
                        principalTable: "tb_Cliente",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tb_Produto",
                columns: table => new
                {
                    IdProduto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeProduto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_Loja = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Produto", x => x.IdProduto);
                    table.ForeignKey(
                        name: "FK_tb_Produto_tb_Loja_Id_Loja",
                        column: x => x.Id_Loja,
                        principalTable: "tb_Loja",
                        principalColumn: "IdLoja",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_Pagamento",
                columns: table => new
                {
                    IdPagamento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Preco = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    Id_Produto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Pagamento", x => x.IdPagamento);
                    table.ForeignKey(
                        name: "FK_tb_Pagamento_tb_Produto_Id_Produto",
                        column: x => x.Id_Produto,
                        principalTable: "tb_Produto",
                        principalColumn: "IdProduto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_Cliente_Id_Usuario",
                table: "tb_Cliente",
                column: "Id_Usuario");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Endereco_Id_Cliente",
                table: "tb_Endereco",
                column: "Id_Cliente");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Loja_ClienteIdCliente",
                table: "tb_Loja",
                column: "ClienteIdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Pagamento_Id_Produto",
                table: "tb_Pagamento",
                column: "Id_Produto");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Produto_Id_Loja",
                table: "tb_Produto",
                column: "Id_Loja");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Vendedor_Id_Usuario",
                table: "tb_Vendedor",
                column: "Id_Usuario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_Endereco");

            migrationBuilder.DropTable(
                name: "tb_Pagamento");

            migrationBuilder.DropTable(
                name: "tb_Vendedor");

            migrationBuilder.DropTable(
                name: "tb_Produto");

            migrationBuilder.DropTable(
                name: "tb_Loja");

            migrationBuilder.DropTable(
                name: "tb_Cliente");

            migrationBuilder.DropTable(
                name: "tb_Usuario");
        }
    }
}
