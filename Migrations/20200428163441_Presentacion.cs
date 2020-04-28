using Microsoft.EntityFrameworkCore.Migrations;

namespace Sintagri.Migrations
{
    public partial class Presentacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agricolas",
                columns: table => new
                {
                    ID_Agricola = table.Column<int>(type: "int", nullable: false),
                    Nombre_Fantasia = table.Column<string>(maxLength: 150, nullable: false),
                    RUT_Empresa = table.Column<string>(maxLength: 25, nullable: false),
                    Correo = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agricolas", x => x.ID_Agricola);
                });

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
                    Id_Cultivo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Especie = table.Column<string>(nullable: true),
                    Tipo = table.Column<string>(maxLength: 20, nullable: true),
                    Variedad = table.Column<string>(maxLength: 50, nullable: true),
                    Profundidad_Raiz_Minima = table.Column<decimal>(type: "decimal(8,3)", nullable: false),
                    Profundidad_Raiz_Maxima = table.Column<decimal>(type: "decimal(10,7)", nullable: false),
                    Dias_Minimos_Cosecha = table.Column<int>(nullable: false),
                    Dias_Maximos_Cosecha = table.Column<int>(nullable: false),
                    Semillera = table.Column<string>(maxLength: 100, nullable: true),
                    Formato = table.Column<short>(type: "smallint", nullable: false),
                    Plantinera = table.Column<string>(maxLength: 50, nullable: true),
                    Prueba = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cultivos", x => x.Id_Cultivo);
                });

            migrationBuilder.CreateTable(
                name: "Enfermedades",
                columns: table => new
                {
                    ID_Enfermedad = table.Column<int>(type: "int", nullable: false),
                    Nombre_Comun = table.Column<string>(maxLength: 100, nullable: true),
                    Nombre_Cientifico = table.Column<string>(maxLength: 100, nullable: true),
                    Epoca_Aparicion = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enfermedades", x => x.ID_Enfermedad);
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
                name: "Insumo",
                columns: table => new
                {
                    ID_Insumo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Comercial = table.Column<string>(maxLength: 100, nullable: false),
                    Presentacion = table.Column<byte>(type: "tinyint", nullable: false),
                    Costo_Neto = table.Column<int>(type: "int", nullable: false),
                    Costo_Total = table.Column<int>(type: "int", nullable: false),
                    Manofacturera = table.Column<string>(maxLength: 100, nullable: true),
                    Proveedor = table.Column<string>(maxLength: 100, nullable: true),
                    Prioridad = table.Column<int>(nullable: false),
                    Subprioridad = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    Tipo_Formulacion = table.Column<byte>(type: "tinyint", nullable: true),
                    Etiqueta = table.Column<string>(maxLength: 100, nullable: true),
                    RegistroSAG = table.Column<int>(type: "int", nullable: true),
                    Modo_Accion = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Insumo", x => x.ID_Insumo);
                });

            migrationBuilder.CreateTable(
                name: "Plagas",
                columns: table => new
                {
                    dkjghyoijr = table.Column<int>(type: "int", nullable: false),
                    Nombre_Comun = table.Column<string>(maxLength: 100, nullable: true),
                    Nombre_Cientifico = table.Column<string>(maxLength: 100, nullable: true),
                    Epoca_Aparicion = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plagas", x => x.dkjghyoijr);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    ID_Rol = table.Column<int>(type: "int", nullable: false),
                    Nombre_Rol = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.ID_Rol);
                });

            migrationBuilder.CreateTable(
                name: "Contactos_Telefonicos",
                columns: table => new
                {
                    ID_Contactos = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numero_Telefonico = table.Column<string>(maxLength: 25, nullable: true),
                    ID_Agricola = table.Column<long>(nullable: false),
                    AgricolaID_Agricola = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contactos_Telefonicos", x => x.ID_Contactos);
                    table.ForeignKey(
                        name: "FK_Contactos_Telefonicos_Agricolas_AgricolaID_Agricola",
                        column: x => x.AgricolaID_Agricola,
                        principalTable: "Agricolas",
                        principalColumn: "ID_Agricola",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Inventarios",
                columns: table => new
                {
                    ID_Inventario = table.Column<int>(type: "int", nullable: false),
                    AgricolaID_Agricola = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventarios", x => x.ID_Inventario);
                    table.ForeignKey(
                        name: "FK_Inventarios_Agricolas_AgricolaID_Agricola",
                        column: x => x.AgricolaID_Agricola,
                        principalTable: "Agricolas",
                        principalColumn: "ID_Agricola",
                        onDelete: ReferentialAction.Cascade);
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
                    Id_Agua = table.Column<int>(nullable: false),
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
                name: "Unidad_Agricola",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(maxLength: 35, nullable: false),
                    Superficie = table.Column<decimal>(type: "decimal(15,3)", nullable: false),
                    Agricola_ID = table.Column<int>(nullable: false),
                    Empresa_PropietariaID_Agricola = table.Column<int>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    Predio_PertenencienteID = table.Column<int>(nullable: true),
                    Potrero_pertenecienteID = table.Column<int>(nullable: true),
                    SectorID = table.Column<int>(nullable: true),
                    Cultivo_ActualId_Cultivo = table.Column<int>(nullable: true),
                    Origen_RiegoId_Agua = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unidad_Agricola", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Unidad_Agricola_Unidad_Agricola_Predio_PertenencienteID",
                        column: x => x.Predio_PertenencienteID,
                        principalTable: "Unidad_Agricola",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Unidad_Agricola_Unidad_Agricola_Potrero_pertenecienteID",
                        column: x => x.Potrero_pertenecienteID,
                        principalTable: "Unidad_Agricola",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Unidad_Agricola_Agricolas_Empresa_PropietariaID_Agricola",
                        column: x => x.Empresa_PropietariaID_Agricola,
                        principalTable: "Agricolas",
                        principalColumn: "ID_Agricola",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Unidad_Agricola_Cultivos_Cultivo_ActualId_Cultivo",
                        column: x => x.Cultivo_ActualId_Cultivo,
                        principalTable: "Cultivos",
                        principalColumn: "Id_Cultivo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Unidad_Agricola_Aguas_Origen_RiegoId_Agua",
                        column: x => x.Origen_RiegoId_Agua,
                        principalTable: "Aguas",
                        principalColumn: "Id_Agua",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Unidad_Agricola_Unidad_Agricola_SectorID",
                        column: x => x.SectorID,
                        principalTable: "Unidad_Agricola",
                        principalColumn: "ID",
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
                        name: "FK_Ingredientes_Activos_Insumo_InsumoID_Insumo",
                        column: x => x.InsumoID_Insumo,
                        principalTable: "Insumo",
                        principalColumn: "ID_Insumo",
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
                    ID_Insumo = table.Column<int>(nullable: false),
                    FertilizanteID_Insumo = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Propiedades_Fertilizantes", x => x.Id_PFQ);
                    table.ForeignKey(
                        name: "FK_Propiedades_Fertilizantes_Insumo_FertilizanteID_Insumo",
                        column: x => x.FertilizanteID_Insumo,
                        principalTable: "Insumo",
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
                    ID_Insumo = table.Column<int>(nullable: false),
                    FitosanitarioID_Insumo = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Propiedades_Fitosanitarios", x => x.Id_PFQ);
                    table.ForeignKey(
                        name: "FK_Propiedades_Fitosanitarios_Insumo_FitosanitarioID_Insumo",
                        column: x => x.FitosanitarioID_Insumo,
                        principalTable: "Insumo",
                        principalColumn: "ID_Insumo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    RUT_Trabajador = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(maxLength: 100, nullable: false),
                    Apellido_Paterno = table.Column<string>(maxLength: 30, nullable: false),
                    Apellido_Materno = table.Column<string>(maxLength: 30, nullable: false),
                    Direccion = table.Column<string>(maxLength: 200, nullable: true),
                    Comuna = table.Column<string>(maxLength: 100, nullable: true),
                    Region = table.Column<string>(maxLength: 100, nullable: true),
                    Nacionalidad = table.Column<string>(maxLength: 150, nullable: true),
                    Numero_Contacto_Principal = table.Column<string>(maxLength: 20, nullable: true),
                    Numero_Contacto_Emergencia = table.Column<string>(maxLength: 20, nullable: true),
                    Correo = table.Column<string>(maxLength: 50, nullable: true),
                    RolID_Rol = table.Column<int>(nullable: true),
                    AgricolaID_Agricola = table.Column<int>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    Agricola_PertenencienteID_Agricola = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => x.RUT_Trabajador);
                    table.ForeignKey(
                        name: "FK_Persona_Agricolas_Agricola_PertenencienteID_Agricola",
                        column: x => x.Agricola_PertenencienteID_Agricola,
                        principalTable: "Agricolas",
                        principalColumn: "ID_Agricola",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Persona_Agricolas_AgricolaID_Agricola",
                        column: x => x.AgricolaID_Agricola,
                        principalTable: "Agricolas",
                        principalColumn: "ID_Agricola",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Persona_Roles_RolID_Rol",
                        column: x => x.RolID_Rol,
                        principalTable: "Roles",
                        principalColumn: "ID_Rol",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Productos_En_Inventario",
                columns: table => new
                {
                    ID_Inventario = table.Column<long>(nullable: false),
                    ID_Insumo = table.Column<long>(nullable: false),
                    InventarioID_Inventario = table.Column<int>(nullable: true),
                    InsumoID_Insumo = table.Column<int>(nullable: true),
                    Cantidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos_En_Inventario", x => new { x.ID_Inventario, x.ID_Insumo });
                    table.ForeignKey(
                        name: "FK_Productos_En_Inventario_Insumo_InsumoID_Insumo",
                        column: x => x.InsumoID_Insumo,
                        principalTable: "Insumo",
                        principalColumn: "ID_Insumo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Productos_En_Inventario_Inventarios_InventarioID_Inventario",
                        column: x => x.InventarioID_Inventario,
                        principalTable: "Inventarios",
                        principalColumn: "ID_Inventario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contactos_Telefonicos_AgricolaID_Agricola",
                table: "Contactos_Telefonicos",
                column: "AgricolaID_Agricola");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredientes_Activos_InsumoID_Insumo",
                table: "Ingredientes_Activos",
                column: "InsumoID_Insumo");

            migrationBuilder.CreateIndex(
                name: "IX_Inventarios_AgricolaID_Agricola",
                table: "Inventarios",
                column: "AgricolaID_Agricola");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_Agricola_PertenencienteID_Agricola",
                table: "Persona",
                column: "Agricola_PertenencienteID_Agricola");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_AgricolaID_Agricola",
                table: "Persona",
                column: "AgricolaID_Agricola");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_RolID_Rol",
                table: "Persona",
                column: "RolID_Rol");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_En_Inventario_InsumoID_Insumo",
                table: "Productos_En_Inventario",
                column: "InsumoID_Insumo");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_En_Inventario_InventarioID_Inventario",
                table: "Productos_En_Inventario",
                column: "InventarioID_Inventario");

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
                name: "IX_Unidad_Agricola_Predio_PertenencienteID",
                table: "Unidad_Agricola",
                column: "Predio_PertenencienteID");

            migrationBuilder.CreateIndex(
                name: "IX_Unidad_Agricola_Potrero_pertenecienteID",
                table: "Unidad_Agricola",
                column: "Potrero_pertenecienteID");

            migrationBuilder.CreateIndex(
                name: "IX_Unidad_Agricola_Empresa_PropietariaID_Agricola",
                table: "Unidad_Agricola",
                column: "Empresa_PropietariaID_Agricola");

            migrationBuilder.CreateIndex(
                name: "IX_Unidad_Agricola_Cultivo_ActualId_Cultivo",
                table: "Unidad_Agricola",
                column: "Cultivo_ActualId_Cultivo");

            migrationBuilder.CreateIndex(
                name: "IX_Unidad_Agricola_Origen_RiegoId_Agua",
                table: "Unidad_Agricola",
                column: "Origen_RiegoId_Agua");

            migrationBuilder.CreateIndex(
                name: "IX_Unidad_Agricola_SectorID",
                table: "Unidad_Agricola",
                column: "SectorID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contactos_Telefonicos");

            migrationBuilder.DropTable(
                name: "Enfermedades");

            migrationBuilder.DropTable(
                name: "Formulaciones");

            migrationBuilder.DropTable(
                name: "Ingredientes_Activos");

            migrationBuilder.DropTable(
                name: "Persona");

            migrationBuilder.DropTable(
                name: "Plagas");

            migrationBuilder.DropTable(
                name: "Productos_En_Inventario");

            migrationBuilder.DropTable(
                name: "Propiedades_Agua");

            migrationBuilder.DropTable(
                name: "Propiedades_Fertilizantes");

            migrationBuilder.DropTable(
                name: "Propiedades_Fitosanitarios");

            migrationBuilder.DropTable(
                name: "Unidad_Agricola");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Inventarios");

            migrationBuilder.DropTable(
                name: "Insumo");

            migrationBuilder.DropTable(
                name: "Cultivos");

            migrationBuilder.DropTable(
                name: "Aguas");

            migrationBuilder.DropTable(
                name: "Agricolas");
        }
    }
}
