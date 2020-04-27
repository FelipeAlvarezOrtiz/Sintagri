using Microsoft.EntityFrameworkCore.Migrations;

namespace Sintagri.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aguas",
                columns: table => new
                {
                    Id_Agua = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Origen = table.Column<int>(nullable: false),
                    Nombre = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aguas", x => x.Id_Agua);
                });

            migrationBuilder.CreateTable(
                name: "Cultivos",
                columns: table => new
                {
                    IdCultivo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Especie = table.Column<int>(nullable: false),
                    Tipo = table.Column<int>(nullable: false),
                    Variedad = table.Column<string>(maxLength: 50, nullable: true),
                    Profundidad_Raiz_Minima = table.Column<float>(type: "decimal(8,3)", nullable: false),
                    Profundidad_Raiz_Maxima = table.Column<float>(type: "decimal(8,3)", nullable: false),
                    Dias_Minimos_Cosecha = table.Column<int>(nullable: false),
                    Dias_Maximos_Cosecha = table.Column<int>(nullable: false),
                    Semillera = table.Column<string>(maxLength: 100, nullable: true),
                    Formato = table.Column<short>(type: "smallint", nullable: false),
                    Proveedor = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cultivos", x => x.IdCultivo);
                });

            migrationBuilder.CreateTable(
                name: "Fertilizantes",
                columns: table => new
                {
                    ID_Insumo = table.Column<int>(type: "int", nullable: false),
                    Presentacion = table.Column<byte>(type: "tinyint", nullable: false),
                    Costo_Neto = table.Column<int>(type: "int", nullable: false),
                    Costo_Total = table.Column<int>(type: "int", nullable: false),
                    Manofacturera = table.Column<string>(maxLength: 100, nullable: true),
                    Proveedor = table.Column<string>(maxLength: 100, nullable: true),
                    Tipo_Formulacion = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fertilizantes", x => x.ID_Insumo);
                });

            migrationBuilder.CreateTable(
                name: "Fitosanitarios",
                columns: table => new
                {
                    ID_Insumo = table.Column<int>(type: "int", nullable: false),
                    Presentacion = table.Column<byte>(type: "tinyint", nullable: false),
                    Costo_Neto = table.Column<int>(type: "int", nullable: false),
                    Costo_Total = table.Column<int>(type: "int", nullable: false),
                    Manofacturera = table.Column<string>(maxLength: 100, nullable: true),
                    Proveedor = table.Column<string>(maxLength: 100, nullable: true),
                    Prioridad = table.Column<int>(type: "int", nullable: false),
                    Etiqueta = table.Column<string>(maxLength: 100, nullable: true),
                    RegistroSAG = table.Column<int>(type: "int", nullable: false),
                    Modo_Accion = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fitosanitarios", x => x.ID_Insumo);
                });

            migrationBuilder.CreateTable(
                name: "Formulaciones",
                columns: table => new
                {
                    Id_Formulacion = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Formulacion = table.Column<string>(maxLength: 50, nullable: false),
                    Sub_Prioridad = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formulaciones", x => x.Id_Formulacion);
                });

            migrationBuilder.CreateTable(
                name: "Predios",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Predios", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Propiedades_Agua",
                columns: table => new
                {
                    Id_PFQ = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(maxLength: 50, nullable: true),
                    Valor = table.Column<float>(nullable: false),
                    Unidad_Medida = table.Column<string>(maxLength: 10, nullable: true),
                    Categoria = table.Column<string>(maxLength: 35, nullable: true),
                    AguaId_Agua = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Propiedades_Agua", x => x.Id_PFQ);
                    table.ForeignKey(
                        name: "FK_Propiedades_Agua_Aguas_AguaId_Agua",
                        column: x => x.AguaId_Agua,
                        principalTable: "Aguas",
                        principalColumn: "Id_Agua",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Propiedades_Fertilizantes",
                columns: table => new
                {
                    Id_PFQ = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(maxLength: 50, nullable: true),
                    Valor = table.Column<float>(nullable: false),
                    Unidad_Medida = table.Column<string>(maxLength: 10, nullable: true),
                    Categoria = table.Column<string>(maxLength: 35, nullable: true),
                    ID_Insumo = table.Column<long>(nullable: false),
                    FertilizanteID_Insumo = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Propiedades_Fertilizantes", x => x.Id_PFQ);
                    table.ForeignKey(
                        name: "FK_Propiedades_Fertilizantes_Fertilizantes_FertilizanteID_Insumo",
                        column: x => x.FertilizanteID_Insumo,
                        principalTable: "Fertilizantes",
                        principalColumn: "ID_Insumo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ingredientes_Activos",
                columns: table => new
                {
                    Id_Ingrediente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Ingrediente = table.Column<string>(maxLength: 100, nullable: false),
                    Grupo_Quimico = table.Column<string>(maxLength: 100, nullable: false),
                    Concentracion = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    Dependencia = table.Column<int>(type: "int", nullable: false),
                    ID_Insumo = table.Column<long>(nullable: false),
                    InsumoID_Insumo = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredientes_Activos", x => x.Id_Ingrediente);
                    table.ForeignKey(
                        name: "FK_Ingredientes_Activos_Fitosanitarios_InsumoID_Insumo",
                        column: x => x.InsumoID_Insumo,
                        principalTable: "Fitosanitarios",
                        principalColumn: "ID_Insumo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Propiedades_Fitosanitarios",
                columns: table => new
                {
                    Id_PFQ = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(maxLength: 50, nullable: true),
                    Valor = table.Column<float>(nullable: false),
                    Unidad_Medida = table.Column<string>(maxLength: 10, nullable: true),
                    Categoria = table.Column<string>(maxLength: 35, nullable: true),
                    FitosanitarioID_Insumo = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Propiedades_Fitosanitarios", x => x.Id_PFQ);
                    table.ForeignKey(
                        name: "FK_Propiedades_Fitosanitarios_Fitosanitarios_FitosanitarioID_Insumo",
                        column: x => x.FitosanitarioID_Insumo,
                        principalTable: "Fitosanitarios",
                        principalColumn: "ID_Insumo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Potreros",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false),
                    Predio_PertenencienteID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Potreros", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Potreros_Predios_Predio_PertenencienteID",
                        column: x => x.Predio_PertenencienteID,
                        principalTable: "Predios",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sectores",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false),
                    Potrero_pertenecienteID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sectores", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Sectores_Potreros_Potrero_pertenecienteID",
                        column: x => x.Potrero_pertenecienteID,
                        principalTable: "Potreros",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Valvulas",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false),
                    SectorID = table.Column<long>(nullable: true),
                    Cultivo_ActualIdCultivo = table.Column<int>(nullable: true),
                    Origen_RiegoId_Agua = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Valvulas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Valvulas_Cultivos_Cultivo_ActualIdCultivo",
                        column: x => x.Cultivo_ActualIdCultivo,
                        principalTable: "Cultivos",
                        principalColumn: "IdCultivo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Valvulas_Aguas_Origen_RiegoId_Agua",
                        column: x => x.Origen_RiegoId_Agua,
                        principalTable: "Aguas",
                        principalColumn: "Id_Agua",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Valvulas_Sectores_SectorID",
                        column: x => x.SectorID,
                        principalTable: "Sectores",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ingredientes_Activos_InsumoID_Insumo",
                table: "Ingredientes_Activos",
                column: "InsumoID_Insumo");

            migrationBuilder.CreateIndex(
                name: "IX_Potreros_Predio_PertenencienteID",
                table: "Potreros",
                column: "Predio_PertenencienteID");

            migrationBuilder.CreateIndex(
                name: "IX_Propiedades_Agua_AguaId_Agua",
                table: "Propiedades_Agua",
                column: "AguaId_Agua");

            migrationBuilder.CreateIndex(
                name: "IX_Propiedades_Fertilizantes_FertilizanteID_Insumo",
                table: "Propiedades_Fertilizantes",
                column: "FertilizanteID_Insumo");

            migrationBuilder.CreateIndex(
                name: "IX_Propiedades_Fitosanitarios_FitosanitarioID_Insumo",
                table: "Propiedades_Fitosanitarios",
                column: "FitosanitarioID_Insumo");

            migrationBuilder.CreateIndex(
                name: "IX_Sectores_Potrero_pertenecienteID",
                table: "Sectores",
                column: "Potrero_pertenecienteID");

            migrationBuilder.CreateIndex(
                name: "IX_Valvulas_Cultivo_ActualIdCultivo",
                table: "Valvulas",
                column: "Cultivo_ActualIdCultivo");

            migrationBuilder.CreateIndex(
                name: "IX_Valvulas_Origen_RiegoId_Agua",
                table: "Valvulas",
                column: "Origen_RiegoId_Agua");

            migrationBuilder.CreateIndex(
                name: "IX_Valvulas_SectorID",
                table: "Valvulas",
                column: "SectorID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Formulaciones");

            migrationBuilder.DropTable(
                name: "Ingredientes_Activos");

            migrationBuilder.DropTable(
                name: "Propiedades_Agua");

            migrationBuilder.DropTable(
                name: "Propiedades_Fertilizantes");

            migrationBuilder.DropTable(
                name: "Propiedades_Fitosanitarios");

            migrationBuilder.DropTable(
                name: "Valvulas");

            migrationBuilder.DropTable(
                name: "Fertilizantes");

            migrationBuilder.DropTable(
                name: "Fitosanitarios");

            migrationBuilder.DropTable(
                name: "Cultivos");

            migrationBuilder.DropTable(
                name: "Aguas");

            migrationBuilder.DropTable(
                name: "Sectores");

            migrationBuilder.DropTable(
                name: "Potreros");

            migrationBuilder.DropTable(
                name: "Predios");
        }
    }
}
