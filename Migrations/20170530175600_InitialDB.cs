using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Vega.Migrations
{
    public partial class InitialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Feature",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feature", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Makes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Country = table.Column<string>(maxLength: 64, nullable: false),
                    Name = table.Column<string>(maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Makes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Models",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BoreAndStroke = table.Column<string>(maxLength: 32, nullable: true),
                    Carburettor = table.Column<string>(maxLength: 64, nullable: true),
                    ClutchType = table.Column<string>(maxLength: 128, nullable: true),
                    CompressionRatio = table.Column<string>(maxLength: 16, nullable: true),
                    Displacement = table.Column<int>(nullable: false),
                    EngineType = table.Column<string>(maxLength: 128, nullable: false),
                    FinalDrive = table.Column<string>(maxLength: 16, nullable: false),
                    Frame = table.Column<string>(maxLength: 128, nullable: true),
                    FrontBrake = table.Column<string>(maxLength: 128, nullable: true),
                    FrontSuspension = table.Column<string>(maxLength: 128, nullable: true),
                    FrontTyre = table.Column<string>(maxLength: 32, nullable: false),
                    FuelCapacity = table.Column<double>(nullable: false),
                    FuelConsumption = table.Column<string>(maxLength: 16, nullable: true),
                    GroundClearance = table.Column<double>(nullable: true),
                    Height = table.Column<double>(nullable: true),
                    Ignition = table.Column<string>(maxLength: 32, nullable: true),
                    ImageUrl = table.Column<string>(maxLength: 256, nullable: true),
                    Length = table.Column<double>(nullable: true),
                    Lubrication = table.Column<string>(maxLength: 32, nullable: true),
                    MakeId = table.Column<int>(nullable: false),
                    MaxPower = table.Column<string>(maxLength: 50, nullable: false),
                    MaxTorque = table.Column<string>(maxLength: 50, nullable: false),
                    Name = table.Column<string>(maxLength: 64, nullable: false),
                    RearBrake = table.Column<string>(maxLength: 128, nullable: true),
                    RearSuspension = table.Column<string>(maxLength: 256, nullable: true),
                    RearTyre = table.Column<string>(maxLength: 32, nullable: false),
                    SeatHeight = table.Column<double>(nullable: true),
                    Starter = table.Column<string>(maxLength: 16, nullable: false),
                    Transmission = table.Column<string>(maxLength: 32, nullable: false),
                    WetWeight = table.Column<double>(nullable: false),
                    WheelBase = table.Column<double>(nullable: true),
                    Width = table.Column<double>(nullable: true),
                    Year = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Models_Makes_MakeId",
                        column: x => x.MakeId,
                        principalTable: "Makes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ModelFeature",
                columns: table => new
                {
                    ModelId = table.Column<int>(nullable: false),
                    FeatureId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModelFeature", x => new { x.ModelId, x.FeatureId });
                    table.ForeignKey(
                        name: "FK_ModelFeature_Feature_FeatureId",
                        column: x => x.FeatureId,
                        principalTable: "Feature",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModelFeature_Models_ModelId",
                        column: x => x.ModelId,
                        principalTable: "Models",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Models_MakeId",
                table: "Models",
                column: "MakeId");

            migrationBuilder.CreateIndex(
                name: "IX_ModelFeature_FeatureId",
                table: "ModelFeature",
                column: "FeatureId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ModelFeature");

            migrationBuilder.DropTable(
                name: "Feature");

            migrationBuilder.DropTable(
                name: "Models");

            migrationBuilder.DropTable(
                name: "Makes");
        }
    }
}
