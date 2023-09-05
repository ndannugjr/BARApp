using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BAR.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateActivityHeader : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "ActivityHeader",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "ActivityHeader",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "LastUpdatedBy",
                table: "ActivityHeader",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedDate",
                table: "ActivityHeader",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "PostedDate",
                table: "ActivityHeader",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "ActivityHeader");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "ActivityHeader");

            migrationBuilder.DropColumn(
                name: "LastUpdatedBy",
                table: "ActivityHeader");

            migrationBuilder.DropColumn(
                name: "LastUpdatedDate",
                table: "ActivityHeader");

            migrationBuilder.DropColumn(
                name: "PostedDate",
                table: "ActivityHeader");
        }
    }
}
