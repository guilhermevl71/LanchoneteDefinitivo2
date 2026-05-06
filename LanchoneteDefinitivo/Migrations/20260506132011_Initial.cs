using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchoneteDefinitivo.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemPedidos_Clientes_Clienteid",
                table: "ItemPedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemPedidos_Pedidos_Pedidoid",
                table: "ItemPedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Clientes_Clienteid",
                table: "Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_ItemPedidos_Clienteid",
                table: "ItemPedidos");

            migrationBuilder.RenameColumn(
                name: "Clienteid",
                table: "Pedidos",
                newName: "ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Pedidos_Clienteid",
                table: "Pedidos",
                newName: "IX_Pedidos_ClienteId");

            migrationBuilder.RenameColumn(
                name: "Pedidoid",
                table: "ItemPedidos",
                newName: "PedidoId");

            migrationBuilder.RenameColumn(
                name: "Clienteid",
                table: "ItemPedidos",
                newName: "Quantidade");

            migrationBuilder.RenameIndex(
                name: "IX_ItemPedidos_Pedidoid",
                table: "ItemPedidos",
                newName: "IX_ItemPedidos_PedidoId");

            migrationBuilder.AddColumn<decimal>(
                name: "PrecoUnitario",
                table: "ItemPedidos",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "ProdutoId",
                table: "ItemPedidos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ItemPedidos_ProdutoId",
                table: "ItemPedidos",
                column: "ProdutoId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemPedidos_Pedidos_PedidoId",
                table: "ItemPedidos",
                column: "PedidoId",
                principalTable: "Pedidos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemPedidos_Produtos_ProdutoId",
                table: "ItemPedidos",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Clientes_ClienteId",
                table: "Pedidos",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemPedidos_Pedidos_PedidoId",
                table: "ItemPedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemPedidos_Produtos_ProdutoId",
                table: "ItemPedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Clientes_ClienteId",
                table: "Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_ItemPedidos_ProdutoId",
                table: "ItemPedidos");

            migrationBuilder.DropColumn(
                name: "PrecoUnitario",
                table: "ItemPedidos");

            migrationBuilder.DropColumn(
                name: "ProdutoId",
                table: "ItemPedidos");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "Pedidos",
                newName: "Clienteid");

            migrationBuilder.RenameIndex(
                name: "IX_Pedidos_ClienteId",
                table: "Pedidos",
                newName: "IX_Pedidos_Clienteid");

            migrationBuilder.RenameColumn(
                name: "PedidoId",
                table: "ItemPedidos",
                newName: "Pedidoid");

            migrationBuilder.RenameColumn(
                name: "Quantidade",
                table: "ItemPedidos",
                newName: "Clienteid");

            migrationBuilder.RenameIndex(
                name: "IX_ItemPedidos_PedidoId",
                table: "ItemPedidos",
                newName: "IX_ItemPedidos_Pedidoid");

            migrationBuilder.CreateIndex(
                name: "IX_ItemPedidos_Clienteid",
                table: "ItemPedidos",
                column: "Clienteid");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemPedidos_Clientes_Clienteid",
                table: "ItemPedidos",
                column: "Clienteid",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemPedidos_Pedidos_Pedidoid",
                table: "ItemPedidos",
                column: "Pedidoid",
                principalTable: "Pedidos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Clientes_Clienteid",
                table: "Pedidos",
                column: "Clienteid",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
