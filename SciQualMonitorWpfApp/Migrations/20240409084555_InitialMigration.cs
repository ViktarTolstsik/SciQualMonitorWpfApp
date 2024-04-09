using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SciQualMonitorWpfApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Advisers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Surname = table.Column<string>(type: "TEXT", nullable: false),
                    Patronym = table.Column<string>(type: "TEXT", nullable: false),
                    AcademicDegree = table.Column<string>(type: "TEXT", nullable: false),
                    Specialty = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advisers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Graduates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Surname = table.Column<string>(type: "TEXT", nullable: false),
                    Patronym = table.Column<string>(type: "TEXT", nullable: false),
                    DateOfBirth = table.Column<int>(type: "INTEGER", maxLength: 4, nullable: false),
                    Gender = table.Column<string>(type: "TEXT", nullable: false),
                    IsForeigner = table.Column<bool>(type: "INTEGER", nullable: false),
                    ForeignCountry = table.Column<string>(type: "TEXT", nullable: false),
                    ForeignCommentary = table.Column<string>(type: "TEXT", nullable: false),
                    BIPGraduateType = table.Column<string>(type: "TEXT", nullable: false),
                    BIPAdmissionYear = table.Column<int>(type: "INTEGER", maxLength: 4, nullable: false),
                    BIPContractYear = table.Column<int>(type: "INTEGER", maxLength: 4, nullable: false),
                    BIPThesisTheme = table.Column<string>(type: "TEXT", nullable: false),
                    BIPSpecialty = table.Column<string>(type: "TEXT", nullable: false),
                    BIPStudyingForm = table.Column<string>(type: "TEXT", nullable: false),
                    BIPDepartment = table.Column<string>(type: "TEXT", nullable: false),
                    GraguationYear = table.Column<int>(type: "INTEGER", maxLength: 4, nullable: false),
                    InGraduationYear = table.Column<string>(type: "TEXT", nullable: false),
                    ThesisDefenceYear = table.Column<int>(type: "INTEGER", maxLength: 4, nullable: false),
                    SciAdviserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Graduates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Graduates_Advisers_SciAdviserId",
                        column: x => x.SciAdviserId,
                        principalTable: "Advisers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GraduateId = table.Column<int>(type: "INTEGER", nullable: false),
                    YearOneArticles = table.Column<int>(type: "INTEGER", nullable: false),
                    YearTwoArticles = table.Column<int>(type: "INTEGER", nullable: false),
                    YearThreeArticles = table.Column<int>(type: "INTEGER", nullable: false),
                    YearFourArticles = table.Column<int>(type: "INTEGER", nullable: false),
                    YearFiveArticles = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Articles_Graduates_GraduateId",
                        column: x => x.GraduateId,
                        principalTable: "Graduates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Certifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GraduateId = table.Column<int>(type: "INTEGER", nullable: false),
                    CertificationResults = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Certifications_Graduates_GraduateId",
                        column: x => x.GraduateId,
                        principalTable: "Graduates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Expulsions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GraduateId = table.Column<int>(type: "INTEGER", nullable: false),
                    ExpulsionYear = table.Column<int>(type: "INTEGER", maxLength: 4, nullable: false),
                    ExpulsionReason = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expulsions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Expulsions_Graduates_GraduateId",
                        column: x => x.GraduateId,
                        principalTable: "Graduates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Graduations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GraduateId = table.Column<int>(type: "INTEGER", nullable: false),
                    GraduationInstitutionTitle = table.Column<string>(type: "TEXT", nullable: false),
                    GraduationYear = table.Column<int>(type: "INTEGER", maxLength: 4, nullable: false),
                    GraduationSpecialty = table.Column<string>(type: "TEXT", nullable: false),
                    GraduationQualification = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Graduations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Graduations_Graduates_GraduateId",
                        column: x => x.GraduateId,
                        principalTable: "Graduates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Interruptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GraduateId = table.Column<int>(type: "INTEGER", nullable: false),
                    InterruptionYear = table.Column<int>(type: "INTEGER", maxLength: 4, nullable: false),
                    InterruptionReason = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interruptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Interruptions_Graduates_GraduateId",
                        column: x => x.GraduateId,
                        principalTable: "Graduates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MastersDegrees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GraduateId = table.Column<int>(type: "INTEGER", nullable: false),
                    MastersDegreeYear = table.Column<int>(type: "INTEGER", maxLength: 4, nullable: false),
                    MastersThesisTheme = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MastersDegrees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MastersDegrees_Graduates_GraduateId",
                        column: x => x.GraduateId,
                        principalTable: "Graduates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Papers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GraduateId = table.Column<int>(type: "INTEGER", nullable: false),
                    MonoCount = table.Column<int>(type: "INTEGER", nullable: false),
                    ActCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Papers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Papers_Graduates_GraduateId",
                        column: x => x.GraduateId,
                        principalTable: "Graduates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Restorations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GraduateId = table.Column<int>(type: "INTEGER", nullable: false),
                    RestorationYear = table.Column<int>(type: "INTEGER", maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restorations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Restorations_Graduates_GraduateId",
                        column: x => x.GraduateId,
                        principalTable: "Graduates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Theses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GraduateId = table.Column<int>(type: "INTEGER", nullable: false),
                    YearOneTheses = table.Column<int>(type: "INTEGER", nullable: false),
                    YearTwoTheses = table.Column<int>(type: "INTEGER", nullable: false),
                    YearThreeTheses = table.Column<int>(type: "INTEGER", nullable: false),
                    YearFourTheses = table.Column<int>(type: "INTEGER", nullable: false),
                    YearFiveTheses = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Theses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Theses_Graduates_GraduateId",
                        column: x => x.GraduateId,
                        principalTable: "Graduates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transfers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GraduateId = table.Column<int>(type: "INTEGER", nullable: false),
                    TransferInfo = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transfers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transfers_Graduates_GraduateId",
                        column: x => x.GraduateId,
                        principalTable: "Graduates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_GraduateId",
                table: "Articles",
                column: "GraduateId");

            migrationBuilder.CreateIndex(
                name: "IX_Certifications_GraduateId",
                table: "Certifications",
                column: "GraduateId");

            migrationBuilder.CreateIndex(
                name: "IX_Expulsions_GraduateId",
                table: "Expulsions",
                column: "GraduateId");

            migrationBuilder.CreateIndex(
                name: "IX_Graduates_SciAdviserId",
                table: "Graduates",
                column: "SciAdviserId");

            migrationBuilder.CreateIndex(
                name: "IX_Graduations_GraduateId",
                table: "Graduations",
                column: "GraduateId");

            migrationBuilder.CreateIndex(
                name: "IX_Interruptions_GraduateId",
                table: "Interruptions",
                column: "GraduateId");

            migrationBuilder.CreateIndex(
                name: "IX_MastersDegrees_GraduateId",
                table: "MastersDegrees",
                column: "GraduateId");

            migrationBuilder.CreateIndex(
                name: "IX_Papers_GraduateId",
                table: "Papers",
                column: "GraduateId");

            migrationBuilder.CreateIndex(
                name: "IX_Restorations_GraduateId",
                table: "Restorations",
                column: "GraduateId");

            migrationBuilder.CreateIndex(
                name: "IX_Theses_GraduateId",
                table: "Theses",
                column: "GraduateId");

            migrationBuilder.CreateIndex(
                name: "IX_Transfers_GraduateId",
                table: "Transfers",
                column: "GraduateId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Certifications");

            migrationBuilder.DropTable(
                name: "Expulsions");

            migrationBuilder.DropTable(
                name: "Graduations");

            migrationBuilder.DropTable(
                name: "Interruptions");

            migrationBuilder.DropTable(
                name: "MastersDegrees");

            migrationBuilder.DropTable(
                name: "Papers");

            migrationBuilder.DropTable(
                name: "Restorations");

            migrationBuilder.DropTable(
                name: "Theses");

            migrationBuilder.DropTable(
                name: "Transfers");

            migrationBuilder.DropTable(
                name: "Graduates");

            migrationBuilder.DropTable(
                name: "Advisers");
        }
    }
}
