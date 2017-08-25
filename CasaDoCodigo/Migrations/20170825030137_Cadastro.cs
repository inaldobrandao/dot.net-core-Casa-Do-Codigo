using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CasaDoCodigo.Migrations
{
    public partial class Cadastro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Bairro",
                table: "Pedidos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CEP",
                table: "Pedidos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Complemento",
                table: "Pedidos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Pedidos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Endereco",
                table: "Pedidos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Municipio",
                table: "Pedidos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Pedidos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "Pedidos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UF",
                table: "Pedidos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bairro",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "CEP",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "Complemento",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "Endereco",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "Municipio",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "UF",
                table: "Pedidos");
        }
    }
}
