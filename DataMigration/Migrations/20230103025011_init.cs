using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataMigration.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "faceid");

            migrationBuilder.EnsureSchema(
                name: "db_owner");

            migrationBuilder.CreateTable(
                name: "A_TestTable",
                columns: table => new
                {
                    Char1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Int1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "acc",
                columns: table => new
                {
                    F1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    AdminID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminRoleID = table.Column<int>(type: "int", nullable: true),
                    EmployeeNO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Password = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Name = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Notes = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PowerType = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    BGID = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((10))"),
                    Code = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Ext = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Annex = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsJudge = table.Column<bool>(type: "bit", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AdminRole",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminRoleID = table.Column<int>(type: "int", nullable: false),
                    RoleName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Android_UserLoading",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Passworld = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "APEXSQL_LOG_CONNECTION_MONITOR_SESSION",
                columns: table => new
                {
                    SESSIONID = table.Column<int>(name: "SESSION_ID", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    STARTTIME = table.Column<DateTime>(name: "START_TIME", type: "datetime", nullable: true),
                    STOPTIME = table.Column<DateTime>(name: "STOP_TIME", type: "datetime", nullable: true),
                    SERVERNAME = table.Column<string>(name: "SERVER_NAME", type: "nvarchar(256)", maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__APEXSQL_LOG_CONN__34ADA24A", x => x.SESSIONID);
                });

            migrationBuilder.CreateTable(
                name: "APEXSQL_LOG_LOGIN",
                columns: table => new
                {
                    SPID = table.Column<int>(type: "int", nullable: false),
                    LOGINTIME = table.Column<DateTime>(name: "LOGIN_TIME", type: "datetime", nullable: true),
                    LOGINNAME = table.Column<string>(name: "LOGIN_NAME", type: "nvarchar(256)", maxLength: 256, nullable: true),
                    CLIENTHOST = table.Column<string>(name: "CLIENT_HOST", type: "nvarchar(256)", maxLength: 256, nullable: true),
                    APPLICATIONNAME = table.Column<string>(name: "APPLICATION_NAME", type: "nvarchar(256)", maxLength: 256, nullable: true),
                    SERVERNAME = table.Column<string>(name: "SERVER_NAME", type: "nvarchar(256)", maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "APEXSQL_LOG_STRINGS",
                columns: table => new
                {
                    COLTYPE = table.Column<int>(name: "COL_TYPE", type: "int", nullable: false),
                    COLNAME = table.Column<string>(name: "COL_NAME", type: "nvarchar(256)", maxLength: 256, nullable: false),
                    SERVERNAME = table.Column<string>(name: "SERVER_NAME", type: "nvarchar(256)", maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_APEXSQL_LOG_STRINGS", x => new { x.COLTYPE, x.COLNAME });
                });

            migrationBuilder.CreateTable(
                name: "App_UserBeforeLoding",
                columns: table => new
                {
                    AppUserBeforeLodingID = table.Column<int>(name: "App_UserBeforeLodingID", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    EmployeeName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    BGID = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_App_UserBeforeLoding", x => x.AppUserBeforeLodingID);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationDoor",
                columns: table => new
                {
                    ApplicationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeNO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ApplicationTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Notes = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    File = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    BGLedName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    BGLedNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    BGPost = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_APPLICATIONDOOR", x => x.ApplicationID);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationSignoff",
                columns: table => new
                {
                    ApplicationSignoffID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ApplicationEmployeeNO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmployeeNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ApplicationPass = table.Column<bool>(type: "bit", nullable: false),
                    ApplicationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AppointmentAddress",
                columns: table => new
                {
                    AppointmentAddressGUID = table.Column<string>(type: "varchar(36)", unicode: false, maxLength: 36, nullable: false, defaultValueSql: "(newid())"),
                    AppointmentAddressID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppointmentAddressName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentAddress", x => x.AppointmentAddressGUID);
                });

            migrationBuilder.CreateTable(
                name: "AppointmentCount",
                columns: table => new
                {
                    AppointmentCountGUID = table.Column<string>(type: "varchar(36)", unicode: false, maxLength: 36, nullable: false, defaultValueSql: "(newid())"),
                    AppointmentCountID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppointmentPeopleNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AppointmentCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentCount", x => x.AppointmentCountGUID);
                });

            migrationBuilder.CreateTable(
                name: "AppointmentDate",
                columns: table => new
                {
                    AppointmentDateGUID = table.Column<string>(type: "varchar(36)", unicode: false, maxLength: 36, nullable: false, defaultValueSql: "(newid())"),
                    AppointmentDateID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppointmentDateName = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentDate", x => x.AppointmentDateGUID);
                });

            migrationBuilder.CreateTable(
                name: "AppointmentDateTime",
                columns: table => new
                {
                    AppointmentDateTimeGUID = table.Column<string>(type: "varchar(36)", unicode: false, maxLength: 36, nullable: false, defaultValueSql: "(newid())"),
                    AppointmentDateTimeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppointmentAddressGUID = table.Column<string>(type: "varchar(36)", unicode: false, maxLength: 36, nullable: false),
                    AppointmentDateGUID = table.Column<string>(type: "varchar(36)", unicode: false, maxLength: 36, nullable: false),
                    AppointmentTimeGUID = table.Column<string>(type: "varchar(36)", unicode: false, maxLength: 36, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentDateTime", x => x.AppointmentDateTimeGUID);
                });

            migrationBuilder.CreateTable(
                name: "AppointmentLog",
                columns: table => new
                {
                    AppointmentLogID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppointmentAddressName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AppointmentDateName = table.Column<DateTime>(type: "datetime", nullable: false),
                    AppointmentTimeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AppointmentPeopleNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AppointmentStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentLog", x => x.AppointmentLogID);
                });

            migrationBuilder.CreateTable(
                name: "AppointmentPeople",
                columns: table => new
                {
                    AppointmentPeopleGUID = table.Column<string>(type: "varchar(36)", unicode: false, maxLength: 36, nullable: false, defaultValueSql: "(newid())"),
                    AppointmentPeopleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppointmentDateTimeGUID = table.Column<string>(type: "varchar(36)", unicode: false, maxLength: 36, nullable: false),
                    AppointmentPeopleNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Mã số công việc"),
                    AppointmentStatus = table.Column<int>(type: "int", nullable: false, comment: "Trạng thái cuộc hẹn: 0 đã đặt trước, 3 đã hủy")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentPeople", x => x.AppointmentPeopleGUID);
                });

            migrationBuilder.CreateTable(
                name: "AppointmentTime",
                columns: table => new
                {
                    AppointmentTimeGUID = table.Column<string>(type: "varchar(36)", unicode: false, maxLength: 36, nullable: false, defaultValueSql: "(newid())"),
                    AppointmentTimeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppointmentTimeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "\r\nTên vị trí cuộc hẹn"),
                    AppointmentTimeBeginTime = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "(getdate())", comment: "Thời gian bắt đầu thời điểm cuộc hẹn"),
                    AppointmentTimeEndTime = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "(getdate())", comment: "Thời gian kết thúc thời điểm cuộc hẹn"),
                    PeopleCount = table.Column<int>(type: "int", nullable: false, comment: "Số người"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    OrderIndex = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentTime", x => x.AppointmentTimeGUID);
                });

            migrationBuilder.CreateTable(
                name: "AppointPeople",
                columns: table => new
                {
                    AppointId = table.Column<int>(type: "int", nullable: false),
                    ApplicationNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    AuditNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    AuditName = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    AuditNote = table.Column<string>(type: "varchar(80)", unicode: false, maxLength: 80, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Area",
                columns: table => new
                {
                    AreaID = table.Column<int>(type: "int", nullable: false),
                    AreaName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AreaMeno = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ShortName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    ListIndex = table.Column<int>(type: "int", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AreaCard",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true),
                    AreaCard = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Meno = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AreaDetail",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: true),
                    AreaRegionID = table.Column<int>(type: "int", nullable: true),
                    DetailAreaName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Areafor_ImExProduct",
                columns: table => new
                {
                    AreaID = table.Column<int>(type: "int", nullable: true),
                    AreaName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    AreaNameT = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ShortName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Isdeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AreaPowerManager",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    EmpName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Position = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ExtTel = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Notes = table.Column<string>(type: "varchar(70)", unicode: false, maxLength: 70, nullable: false),
                    AreaID = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    AreaName = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    BuName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BuCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsDeleted = table.Column<int>(type: "int", nullable: true),
                    Job = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    M01 = table.Column<int>(type: "int", nullable: true),
                    M02 = table.Column<int>(type: "int", nullable: true),
                    M03 = table.Column<int>(type: "int", nullable: true),
                    M04 = table.Column<int>(type: "int", nullable: true),
                    M05 = table.Column<int>(type: "int", nullable: true),
                    M06 = table.Column<int>(type: "int", nullable: true),
                    M07 = table.Column<int>(type: "int", nullable: true),
                    M08 = table.Column<int>(type: "int", nullable: true),
                    M09 = table.Column<int>(type: "int", nullable: true),
                    M02A = table.Column<int>(type: "int", nullable: true),
                    M02B = table.Column<int>(type: "int", nullable: true),
                    M02C = table.Column<int>(type: "int", nullable: true),
                    M02D = table.Column<int>(type: "int", nullable: true),
                    M02E = table.Column<int>(type: "int", nullable: true),
                    M02F = table.Column<int>(type: "int", nullable: true),
                    M02G = table.Column<int>(type: "int", nullable: true),
                    W01 = table.Column<int>(type: "int", nullable: true),
                    W01A = table.Column<int>(type: "int", nullable: true),
                    W01B = table.Column<int>(type: "int", nullable: true),
                    W01C = table.Column<int>(type: "int", nullable: true),
                    W01D = table.Column<int>(type: "int", nullable: true),
                    W02 = table.Column<int>(type: "int", nullable: true),
                    W02A = table.Column<int>(type: "int", nullable: true),
                    W02B = table.Column<int>(type: "int", nullable: true),
                    W02C = table.Column<int>(type: "int", nullable: true),
                    W02D = table.Column<int>(type: "int", nullable: true),
                    W02E = table.Column<int>(type: "int", nullable: true),
                    W03 = table.Column<int>(type: "int", nullable: true),
                    W03A = table.Column<int>(type: "int", nullable: true),
                    W03B = table.Column<int>(type: "int", nullable: true),
                    W04 = table.Column<int>(type: "int", nullable: true),
                    W05 = table.Column<int>(type: "int", nullable: true),
                    W06 = table.Column<int>(type: "int", nullable: true),
                    W07 = table.Column<int>(type: "int", nullable: true),
                    W08 = table.Column<int>(type: "int", nullable: true),
                    W09 = table.Column<int>(type: "int", nullable: true),
                    W10 = table.Column<int>(type: "int", nullable: true),
                    W11 = table.Column<int>(type: "int", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    BGID = table.Column<int>(type: "int", nullable: false),
                    ApplicationID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AreaPowerManagerApplication",
                columns: table => new
                {
                    ApplicationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmpName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Notes = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsDeleted = table.Column<int>(type: "int", nullable: true),
                    BGID = table.Column<int>(type: "int", nullable: true),
                    Tel = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AreaPowerManagerApprove",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    EmpName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Position = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ExtTel = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Notes = table.Column<string>(type: "varchar(70)", unicode: false, maxLength: 70, nullable: false),
                    AreaID = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    AreaName = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    BuName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BuCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsDeleted = table.Column<int>(type: "int", nullable: true),
                    Job = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    M01 = table.Column<int>(type: "int", nullable: true),
                    M02 = table.Column<int>(type: "int", nullable: true),
                    M03 = table.Column<int>(type: "int", nullable: true),
                    M04 = table.Column<int>(type: "int", nullable: true),
                    M05 = table.Column<int>(type: "int", nullable: true),
                    M06 = table.Column<int>(type: "int", nullable: true),
                    M07 = table.Column<int>(type: "int", nullable: true),
                    M08 = table.Column<int>(type: "int", nullable: true),
                    M09 = table.Column<int>(type: "int", nullable: true),
                    M02A = table.Column<int>(type: "int", nullable: true),
                    M02B = table.Column<int>(type: "int", nullable: true),
                    M02C = table.Column<int>(type: "int", nullable: true),
                    M02D = table.Column<int>(type: "int", nullable: true),
                    M02E = table.Column<int>(type: "int", nullable: true),
                    M02F = table.Column<int>(type: "int", nullable: true),
                    M02G = table.Column<int>(type: "int", nullable: true),
                    W01 = table.Column<int>(type: "int", nullable: true),
                    W01A = table.Column<int>(type: "int", nullable: true),
                    W01B = table.Column<int>(type: "int", nullable: true),
                    W01C = table.Column<int>(type: "int", nullable: true),
                    W01D = table.Column<int>(type: "int", nullable: true),
                    W02 = table.Column<int>(type: "int", nullable: true),
                    W02A = table.Column<int>(type: "int", nullable: true),
                    W02B = table.Column<int>(type: "int", nullable: true),
                    W02C = table.Column<int>(type: "int", nullable: true),
                    W02D = table.Column<int>(type: "int", nullable: true),
                    W02E = table.Column<int>(type: "int", nullable: true),
                    W03 = table.Column<int>(type: "int", nullable: true),
                    W03A = table.Column<int>(type: "int", nullable: true),
                    W03B = table.Column<int>(type: "int", nullable: true),
                    W04 = table.Column<int>(type: "int", nullable: true),
                    W05 = table.Column<int>(type: "int", nullable: true),
                    W06 = table.Column<int>(type: "int", nullable: true),
                    W07 = table.Column<int>(type: "int", nullable: true),
                    W08 = table.Column<int>(type: "int", nullable: true),
                    W09 = table.Column<int>(type: "int", nullable: true),
                    W10 = table.Column<int>(type: "int", nullable: true),
                    W11 = table.Column<int>(type: "int", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    BGID = table.Column<int>(type: "int", nullable: false),
                    ApplicationID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AreaPowerManagerProc",
                columns: table => new
                {
                    ProcID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusID = table.Column<int>(type: "int", nullable: true),
                    ID = table.Column<int>(type: "int", nullable: true),
                    Act = table.Column<int>(type: "int", nullable: true),
                    Memo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    WordTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AreaPowerManagerStatus",
                columns: table => new
                {
                    StatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID = table.Column<int>(type: "int", nullable: true),
                    EmpNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmpName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Notes = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Leavel = table.Column<int>(type: "int", nullable: true),
                    Order = table.Column<int>(type: "int", nullable: true),
                    WordDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ParameterCode = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Memo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AreaPowerManagerType",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: true),
                    JurisdisctionTypeID = table.Column<int>(type: "int", nullable: true),
                    Memo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AreaRegion",
                columns: table => new
                {
                    AreaRegionID = table.Column<int>(type: "int", nullable: false),
                    AreaID = table.Column<int>(type: "int", nullable: true),
                    RegionID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AreaRegionCertificate",
                columns: table => new
                {
                    AreaRegionID = table.Column<int>(type: "int", nullable: true),
                    ID = table.Column<int>(type: "int", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true),
                    Meno = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AreaRegionHistory",
                columns: table => new
                {
                    InsertDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AreaRegionID = table.Column<int>(type: "int", nullable: true),
                    ID = table.Column<int>(type: "int", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true),
                    Meno = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AreaRegionValid",
                columns: table => new
                {
                    AreaRegionID = table.Column<int>(type: "int", nullable: true),
                    ID = table.Column<int>(type: "int", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true),
                    Meno = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AreaRegionVehiclePeriod",
                columns: table => new
                {
                    AreaRegionID = table.Column<int>(type: "int", nullable: true),
                    ID = table.Column<int>(type: "int", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true),
                    Meno = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AreaRelation",
                columns: table => new
                {
                    AreaID = table.Column<int>(type: "int", nullable: true),
                    AreaRID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AuditProcess",
                columns: table => new
                {
                    AuditID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuditPeople = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AuditResult = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AuditTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    AuditMeno = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    ID = table.Column<int>(type: "int", nullable: true),
                    FormID = table.Column<int>(type: "int", nullable: true),
                    Employee = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    leavel = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditProcess", x => x.AuditID);
                });

            migrationBuilder.CreateTable(
                name: "BG",
                columns: table => new
                {
                    BGID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BGName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsAll = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BG", x => x.BGID);
                });

            migrationBuilder.CreateTable(
                name: "BGMatch",
                columns: table => new
                {
                    BGMatchID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BGMatchName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    BGID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BGMatch", x => x.BGMatchID);
                });

            migrationBuilder.CreateTable(
                name: "BlackList",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PeopleID = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    NumberCar = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TimeBlock = table.Column<DateTime>(type: "datetime", nullable: true),
                    Memo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    EmpNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Deleted = table.Column<int>(type: "int", nullable: true),
                    TimeApplication = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Building",
                columns: table => new
                {
                    BuildingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuildingName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Building", x => x.BuildingID);
                });

            migrationBuilder.CreateTable(
                name: "byf",
                columns: table => new
                {
                    date = table.Column<DateTime>(type: "datetime", nullable: true),
                    time = table.Column<DateTime>(type: "datetime", nullable: true),
                    carlicense = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "byf_1",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: true),
                    carlicense = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    num = table.Column<int>(type: "int", nullable: true),
                    audittime = table.Column<DateTime>(type: "datetime", nullable: true),
                    isdeleted = table.Column<int>(type: "int", nullable: true),
                    cause = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "byf_2",
                columns: table => new
                {
                    carlicense = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    phone1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    phone2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "byf_3",
                columns: table => new
                {
                    carlicense = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    num = table.Column<int>(type: "int", nullable: true),
                    audittime = table.Column<DateTime>(type: "datetime", nullable: true),
                    isdeleted = table.Column<int>(type: "int", nullable: true),
                    cause = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Camera",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BGID = table.Column<int>(type: "int", nullable: true),
                    Unit = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EmpNo = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    EmpName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EmpTel = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<int>(type: "int", nullable: true),
                    NoiDung = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    TimeApplication = table.Column<DateTime>(type: "datetime", nullable: true),
                    Result = table.Column<int>(type: "int", nullable: true),
                    CheckData = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Monitor = table.Column<int>(type: "int", nullable: true),
                    Position = table.Column<int>(type: "int", nullable: true),
                    Area = table.Column<int>(type: "int", nullable: true),
                    Notes = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Camera", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CameraStatus",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: true),
                    StatusID = table.Column<int>(type: "int", nullable: true),
                    Leavel = table.Column<int>(type: "int", nullable: true),
                    Order = table.Column<int>(type: "int", nullable: true),
                    EmpNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmpName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Notes = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    WorkDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    CarID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VisitorsID = table.Column<int>(type: "int", nullable: true),
                    CarNumber = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CarType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CarColor = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CardNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    RemandTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car", x => x.CarID);
                });

            migrationBuilder.CreateTable(
                name: "car_inout_record",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: true),
                    stime = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    carno = table.Column<string>(name: "car_no", type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    place = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    sdir = table.Column<string>(name: "s_dir", type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    style = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    imagepath = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    bak = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    carnum = table.Column<string>(name: "car_num", type: "nvarchar(4000)", maxLength: 4000, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Card",
                columns: table => new
                {
                    CardID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminID = table.Column<int>(type: "int", nullable: false),
                    CardNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    SerialNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true),
                    ID = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    color = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Company = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MadeTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ControlType = table.Column<int>(type: "int", nullable: true),
                    WorkType = table.Column<int>(type: "int", nullable: true),
                    CardModelID = table.Column<int>(type: "int", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CardGUID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true, comment: "證件補辦使用，相同的CardGuID表示同一個證件的卡")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CARD", x => x.CardID);
                });

            migrationBuilder.CreateTable(
                name: "Card_Test",
                columns: table => new
                {
                    CardID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminID = table.Column<int>(type: "int", nullable: false),
                    CardNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    SerialNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true),
                    ID = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    color = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Company = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MadeTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ControlType = table.Column<int>(type: "int", nullable: true),
                    WorkType = table.Column<int>(type: "int", nullable: true),
                    CardModelID = table.Column<int>(type: "int", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CardGUID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CardAdded",
                columns: table => new
                {
                    CardAddedID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardID = table.Column<int>(type: "int", nullable: true),
                    CardAddedType = table.Column<int>(type: "int", nullable: true, comment: "1 卡損壞補辦，2卡遺失補辦"),
                    CardAddedStatus = table.Column<int>(type: "int", nullable: true, comment: "1 待收取資料，2待審核，3產生新卡"),
                    CredentialsNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Reasons = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    DeletedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    AdminID = table.Column<int>(type: "int", nullable: true),
                    IP = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MAC = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Ext = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardAdded", x => x.CardAddedID);
                });

            migrationBuilder.CreateTable(
                name: "CardBorrow",
                columns: table => new
                {
                    CardBorrowID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CardChangeHistory",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    CardNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CardID = table.Column<int>(type: "int", nullable: true),
                    CardChangeID = table.Column<int>(type: "int", nullable: true),
                    TimeChange = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CardCompanyHistory",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CardID = table.Column<int>(type: "int", nullable: true),
                    CreateID = table.Column<int>(type: "int", nullable: true),
                    CompanyID = table.Column<int>(type: "int", nullable: true),
                    CompanyName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ApplicationTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    CompanyIDnew = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CardCreateTables",
                columns: table => new
                {
                    TableName = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CardHistoryData",
                columns: table => new
                {
                    CardHistoryDataID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ECardNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    IP = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    MAC = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    DataTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    CardStatus = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Reason = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    TransferTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SwipingCadrData", x => x.CardHistoryDataID);
                });

            migrationBuilder.CreateTable(
                name: "CardModel",
                columns: table => new
                {
                    CardModelID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeID = table.Column<int>(type: "int", nullable: true),
                    ModelName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    ModelImg = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardModel", x => x.CardModelID);
                });

            migrationBuilder.CreateTable(
                name: "CardSwipe",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmpName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AreaID = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    TimeSwipe = table.Column<DateTime>(type: "datetime", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Images = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true),
                    DateSwipe = table.Column<DateTime>(type: "date", nullable: true),
                    Latitude = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Longtitude = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CardText",
                columns: table => new
                {
                    CardTextID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TextName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardText", x => x.CardTextID);
                });

            migrationBuilder.CreateTable(
                name: "CardVendor",
                columns: table => new
                {
                    CardID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID = table.Column<int>(type: "int", nullable: true),
                    CardType = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    CompanyName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CardNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AdminID = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<int>(type: "int", nullable: true),
                    WorkType = table.Column<int>(type: "int", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DateChange = table.Column<DateTime>(type: "datetime", nullable: true),
                    FileBill = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CardArea = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardVendor", x => x.CardID);
                });

            migrationBuilder.CreateTable(
                name: "CarPass",
                columns: table => new
                {
                    IDVe = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID = table.Column<int>(type: "int", nullable: true),
                    CardArea = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CompanyID = table.Column<int>(type: "int", nullable: true),
                    CarType = table.Column<int>(type: "int", nullable: true),
                    NameVN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NameCN = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IDPeople = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    IDLicer = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true),
                    CarNumber = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    CarColor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Weight = table.Column<int>(type: "int", nullable: true),
                    ImageCar = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FileAddendum = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    IsJob = table.Column<int>(type: "int", nullable: true),
                    TimeApplication = table.Column<DateTime>(type: "datetime", nullable: true),
                    InureStartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    InureEndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CardID = table.Column<int>(type: "int", nullable: true),
                    NoExecl = table.Column<int>(type: "int", nullable: true),
                    MobileNumber = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    WeightReal = table.Column<int>(type: "int", nullable: true),
                    CarTypeOther = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CapBac = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PosisionCar = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarPass", x => x.IDVe);
                });

            migrationBuilder.CreateTable(
                name: "CarPassBill",
                columns: table => new
                {
                    IDBill = table.Column<int>(type: "int", nullable: false),
                    ID = table.Column<int>(type: "int", nullable: true),
                    TypeID = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: true),
                    FileBill = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    AdminID = table.Column<int>(type: "int", nullable: true),
                    Memo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BillNumber = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarPassBill", x => x.IDBill);
                });

            migrationBuilder.CreateTable(
                name: "CarPassProc",
                columns: table => new
                {
                    ProcID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID = table.Column<int>(type: "int", nullable: true),
                    FormID = table.Column<int>(type: "int", nullable: true),
                    EmpNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmpName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Leavel = table.Column<int>(type: "int", nullable: true),
                    Sort = table.Column<int>(type: "int", nullable: true),
                    WorkDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Memo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    ParaCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    RoleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    StatusID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarPassProc", x => x.ProcID);
                });

            migrationBuilder.CreateTable(
                name: "CarPassStatus",
                columns: table => new
                {
                    StatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID = table.Column<int>(type: "int", nullable: true),
                    FormID = table.Column<int>(type: "int", nullable: true),
                    EmpNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmpName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Notes = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Leavel = table.Column<int>(type: "int", nullable: true),
                    Sort = table.Column<int>(type: "int", nullable: true),
                    WorkDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Memo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    ParaCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IP = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    RoleName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarPassStatus", x => x.StatusID);
                });

            migrationBuilder.CreateTable(
                name: "CarToStop01",
                columns: table => new
                {
                    CarCardNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CompanyName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    CarNumber = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CarBrand = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    CarType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Color = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CarTypePass",
                columns: table => new
                {
                    CarType = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsDeleted = table.Column<int>(type: "int", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarTypePass", x => x.CarType);
                });

            migrationBuilder.CreateTable(
                name: "CarVip",
                columns: table => new
                {
                    CarVipID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SerialNumber = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    EmployeeNo = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CarNumber = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CardType = table.Column<int>(type: "int", nullable: true),
                    BrushType = table.Column<int>(type: "int", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Meno = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    TelePhone = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DepartMent = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarVip", x => x.CarVipID);
                });

            migrationBuilder.CreateTable(
                name: "CarVipProc",
                columns: table => new
                {
                    ProcID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID = table.Column<int>(type: "int", nullable: true),
                    StatusID = table.Column<int>(type: "int", nullable: true),
                    WorkDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Act = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Meno = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarVipProc", x => x.ProcID);
                });

            migrationBuilder.CreateTable(
                name: "CarVipStatus",
                columns: table => new
                {
                    StatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID = table.Column<int>(type: "int", nullable: true),
                    EmployeeNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Meno = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Worktime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Leavel = table.Column<double>(type: "float", nullable: true),
                    Notes = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarVipStatus", x => x.StatusID);
                });

            migrationBuilder.CreateTable(
                name: "Certificate_Delay",
                columns: table => new
                {
                    DelayApplyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Certificate = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CertificateType = table.Column<string>(name: "Certificate_Type", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    OldExpirationDate = table.Column<DateTime>(name: "Old_ExpirationDate", type: "datetime", nullable: true),
                    NewExpirationDate = table.Column<DateTime>(name: "New_ExpirationDate", type: "datetime", nullable: true),
                    DelayDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    TableName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certificate_Delay", x => x.DelayApplyID);
                });

            migrationBuilder.CreateTable(
                name: "CertificateDB",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    AreaID = table.Column<int>(type: "int", nullable: true),
                    Area = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Date = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Nhiem = table.Column<int>(type: "int", nullable: true),
                    Sot = table.Column<int>(type: "int", nullable: true),
                    Namvien = table.Column<int>(type: "int", nullable: true),
                    Ravien = table.Column<int>(type: "int", nullable: true),
                    TheodoiKTX = table.Column<int>(type: "int", nullable: true),
                    RaKTX = table.Column<int>(type: "int", nullable: true),
                    BGid = table.Column<int>(type: "int", nullable: true),
                    DVSN = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CertificatesDelay",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ApplyPeople = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    TypeID = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    OnworkFile = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CertificatesDelay", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ChargeRecords",
                columns: table => new
                {
                    ChargeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SenderUnit = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    SenderPeople = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Receipts = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true, defaultValueSql: "((0))"),
                    Amount = table.Column<int>(type: "int", nullable: true),
                    SenderTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    Type = table.Column<int>(type: "int", nullable: true),
                    ID = table.Column<int>(type: "int", nullable: true),
                    Meno = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    AdminID = table.Column<int>(type: "int", nullable: false),
                    IsCompensation = table.Column<int>(type: "int", nullable: false),
                    Compensation = table.Column<int>(type: "int", nullable: false),
                    Bill = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    billNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    BillAmountTotal = table.Column<int>(type: "int", nullable: false),
                    CardID = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    DamageCard = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHARGERECORDS", x => x.ChargeID);
                });

            migrationBuilder.CreateTable(
                name: "CheckTemp",
                columns: table => new
                {
                    controlname = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    credentialsnumber = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    reason = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    comfromtime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CheckTime",
                columns: table => new
                {
                    MerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID = table.Column<int>(type: "int", nullable: true),
                    TimeOut = table.Column<DateTime>(type: "datetime", nullable: true),
                    TimeIn = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Chemistry_Authority_History",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorityId = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    DeparmentSNID = table.Column<int>(type: "int", nullable: true),
                    EmployeesID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EmployeesNameV = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EmployeesNameT = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ApplicationTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chemistry_Authority_History", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Chemistry_DocforMaterial",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChemistryFormID = table.Column<int>(type: "int", nullable: true),
                    MaterialID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MSDS = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    GPKinhdoanh = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TlThue = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    GpsxKinhdoanh = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    GpVanchuyen = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TucachngVanchuyen = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    XacnhanttHoachat = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ChemistryAuthority_ChangeEmail",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeesID = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Email1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Email2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ApplicationTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    EmployeesId2 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmployeesName2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ChemistryForm",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentRequitision = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MinistrySN = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DepartmentSN = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AreaID = table.Column<int>(type: "int", nullable: false),
                    DepartmentBuy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EmployeeBuy = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    PhoneofEmpBuy = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    DateOfApplication = table.Column<DateTime>(type: "datetime", nullable: true),
                    DateOfExpectedStart = table.Column<DateTime>(type: "datetime", nullable: true),
                    DateOfExpectedEnd = table.Column<DateTime>(type: "datetime", nullable: true),
                    LocationAndTech = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    StoreLocation = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Category = table.Column<int>(type: "int", nullable: true),
                    Export = table.Column<int>(type: "int", nullable: true),
                    Needtodec = table.Column<int>(type: "int", nullable: true),
                    Applicant = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FactoryGate = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true),
                    IsShow = table.Column<int>(type: "int", nullable: true),
                    Isdeleted = table.Column<int>(type: "int", nullable: true),
                    BGID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ChemistryForm",
                schema: "faceid",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentRequitision = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MinistrySN = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DepartmentSN = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AreaID = table.Column<int>(type: "int", nullable: false),
                    DepartmentBuy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EmployeeBuy = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    PhoneofEmpBuy = table.Column<int>(type: "int", nullable: true),
                    DateOfApplication = table.Column<DateTime>(type: "date", nullable: true),
                    DateOfExpectedStart = table.Column<DateTime>(type: "date", nullable: true),
                    DateOfExpectedEnd = table.Column<DateTime>(type: "date", nullable: true),
                    LocationAndTech = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    StoreLocation = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Category = table.Column<int>(type: "int", nullable: true),
                    Export = table.Column<int>(type: "int", nullable: true),
                    Needtodec = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ChemistryForm_Authority",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorityId = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    DeparmentSNID = table.Column<int>(type: "int", nullable: true),
                    EmployeesID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EmployeesNameV = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EmployeesNameT = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Isdeleted = table.Column<int>(type: "int", nullable: true),
                    AreaID = table.Column<int>(type: "int", nullable: true),
                    PositionName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsImposition = table.Column<int>(type: "int", nullable: true),
                    PosOrder = table.Column<int>(type: "int", nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChemistryForm_Authority", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Chr_EmpCardinfo",
                columns: table => new
                {
                    empno = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    cardid = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    softno = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    empmemo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Chr_EmpCardinfo_temp",
                columns: table => new
                {
                    empno = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    cardid = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    softno = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    empmemo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Chr_Employee",
                columns: table => new
                {
                    empno = table.Column<string>(name: "emp_no", type: "varchar(16)", unicode: false, maxLength: 16, nullable: false),
                    siteid = table.Column<string>(type: "varchar(16)", unicode: false, maxLength: 16, nullable: true),
                    keydate = table.Column<DateTime>(name: "key_date", type: "datetime", nullable: true),
                    empname = table.Column<string>(name: "emp_name", type: "varchar(64)", unicode: false, maxLength: 64, nullable: true),
                    sex = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    cos = table.Column<string>(type: "varchar(16)", unicode: false, maxLength: 16, nullable: true),
                    departno = table.Column<string>(name: "depart_no", type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    birthday = table.Column<DateTime>(type: "datetime", nullable: true),
                    indate = table.Column<DateTime>(name: "in_date", type: "datetime", nullable: true),
                    classno = table.Column<string>(name: "class_no", type: "varchar(16)", unicode: false, maxLength: 16, nullable: true),
                    statusno = table.Column<string>(name: "status_no", type: "varchar(16)", unicode: false, maxLength: 16, nullable: true),
                    married = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    jobsituation = table.Column<string>(name: "job_situation", type: "varchar(16)", unicode: false, maxLength: 16, nullable: true),
                    jobcode = table.Column<string>(name: "job_code", type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    levdate = table.Column<DateTime>(name: "lev_date", type: "datetime", nullable: true),
                    oldhome = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    empid = table.Column<string>(name: "emp_id", type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    lasteditdt = table.Column<DateTime>(type: "datetime", nullable: true),
                    address = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    urgtel = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    transferdate = table.Column<DateTime>(name: "transfer_date", type: "datetime", nullable: true),
                    photo = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    id = table.Column<double>(type: "float", nullable: true),
                    initsiteid = table.Column<string>(name: "init_siteid", type: "varchar(16)", unicode: false, maxLength: 16, nullable: true),
                    bgcode = table.Column<string>(name: "bg_code", type: "varchar(16)", unicode: false, maxLength: 16, nullable: true),
                    factorycode = table.Column<string>(name: "factory_code", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    emptype = table.Column<string>(name: "emp_type", type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Chr_Employee_Image",
                columns: table => new
                {
                    EmployeeNO = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    EmployeeName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Sex = table.Column<int>(type: "int", nullable: true),
                    EmpIdentity = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    InTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    OutTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsService = table.Column<int>(type: "int", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    MD5Val = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    IsImage = table.Column<int>(type: "int", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsUpImg = table.Column<int>(type: "int", nullable: true),
                    ImgUpTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    BgCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "chr_employee_switch",
                columns: table => new
                {
                    empno = table.Column<string>(name: "emp_no", type: "varchar(16)", unicode: false, maxLength: 16, nullable: false),
                    siteid = table.Column<string>(type: "varchar(16)", unicode: false, maxLength: 16, nullable: true),
                    keydate = table.Column<DateTime>(name: "key_date", type: "datetime", nullable: true),
                    empname = table.Column<string>(name: "emp_name", type: "varchar(64)", unicode: false, maxLength: 64, nullable: true),
                    sex = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    cos = table.Column<string>(type: "varchar(16)", unicode: false, maxLength: 16, nullable: true),
                    departno = table.Column<string>(name: "depart_no", type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    birthday = table.Column<DateTime>(type: "datetime", nullable: true),
                    indate = table.Column<DateTime>(name: "in_date", type: "datetime", nullable: true),
                    classno = table.Column<string>(name: "class_no", type: "varchar(16)", unicode: false, maxLength: 16, nullable: true),
                    statusno = table.Column<string>(name: "status_no", type: "varchar(16)", unicode: false, maxLength: 16, nullable: true),
                    married = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    jobsituation = table.Column<string>(name: "job_situation", type: "varchar(16)", unicode: false, maxLength: 16, nullable: true),
                    levdate = table.Column<DateTime>(name: "lev_date", type: "datetime", nullable: true),
                    oldhome = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    empid = table.Column<string>(name: "emp_id", type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    lasteditdt = table.Column<DateTime>(type: "datetime", nullable: true),
                    address = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    urgtel = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    transferdate = table.Column<DateTime>(name: "transfer_date", type: "datetime", nullable: true),
                    photo = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    id = table.Column<double>(type: "float", nullable: true),
                    initsiteid = table.Column<string>(name: "init_siteid", type: "varchar(16)", unicode: false, maxLength: 16, nullable: true),
                    bgcode = table.Column<string>(name: "bg_code", type: "varchar(16)", unicode: false, maxLength: 16, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "chr_employee_tmp",
                columns: table => new
                {
                    empno = table.Column<string>(name: "emp_no", type: "varchar(16)", unicode: false, maxLength: 16, nullable: false),
                    siteid = table.Column<string>(type: "varchar(16)", unicode: false, maxLength: 16, nullable: true),
                    keydate = table.Column<DateTime>(name: "key_date", type: "datetime", nullable: true),
                    empname = table.Column<string>(name: "emp_name", type: "varchar(64)", unicode: false, maxLength: 64, nullable: true),
                    sex = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    cos = table.Column<string>(type: "varchar(16)", unicode: false, maxLength: 16, nullable: true),
                    departno = table.Column<string>(name: "depart_no", type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    birthday = table.Column<DateTime>(type: "datetime", nullable: true),
                    indate = table.Column<DateTime>(name: "in_date", type: "datetime", nullable: true),
                    classno = table.Column<string>(name: "class_no", type: "varchar(16)", unicode: false, maxLength: 16, nullable: true),
                    statusno = table.Column<string>(name: "status_no", type: "varchar(16)", unicode: false, maxLength: 16, nullable: true),
                    married = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    jobsituation = table.Column<string>(name: "job_situation", type: "varchar(16)", unicode: false, maxLength: 16, nullable: true),
                    levdate = table.Column<DateTime>(name: "lev_date", type: "datetime", nullable: true),
                    oldhome = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    empid = table.Column<string>(name: "emp_id", type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    lasteditdt = table.Column<DateTime>(type: "datetime", nullable: true),
                    address = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    urgtel = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    transferdate = table.Column<DateTime>(name: "transfer_date", type: "datetime", nullable: true),
                    photo = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    id = table.Column<double>(type: "float", nullable: true),
                    initsiteid = table.Column<string>(name: "init_siteid", type: "varchar(16)", unicode: false, maxLength: 16, nullable: true),
                    bgcode = table.Column<string>(name: "bg_code", type: "varchar(16)", unicode: false, maxLength: 16, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Chr_employee_Transit",
                columns: table => new
                {
                    empno = table.Column<string>(name: "emp_no", type: "varchar(16)", unicode: false, maxLength: 16, nullable: false),
                    siteid = table.Column<string>(type: "varchar(16)", unicode: false, maxLength: 16, nullable: true),
                    keydate = table.Column<DateTime>(name: "key_date", type: "datetime", nullable: true),
                    empname = table.Column<string>(name: "emp_name", type: "varchar(64)", unicode: false, maxLength: 64, nullable: true),
                    sex = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    cos = table.Column<string>(type: "varchar(16)", unicode: false, maxLength: 16, nullable: true),
                    departno = table.Column<string>(name: "depart_no", type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    birthday = table.Column<DateTime>(type: "datetime", nullable: true),
                    indate = table.Column<DateTime>(name: "in_date", type: "datetime", nullable: true),
                    classno = table.Column<string>(name: "class_no", type: "varchar(16)", unicode: false, maxLength: 16, nullable: true),
                    statusno = table.Column<string>(name: "status_no", type: "varchar(16)", unicode: false, maxLength: 16, nullable: true),
                    married = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    jobsituation = table.Column<string>(name: "job_situation", type: "varchar(16)", unicode: false, maxLength: 16, nullable: true),
                    jobcode = table.Column<string>(name: "job_code", type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    levdate = table.Column<DateTime>(name: "lev_date", type: "datetime", nullable: true),
                    oldhome = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    empid = table.Column<string>(name: "emp_id", type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    lasteditdt = table.Column<DateTime>(type: "datetime", nullable: true),
                    address = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    urgtel = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    transferdate = table.Column<DateTime>(name: "transfer_date", type: "datetime", nullable: true),
                    photo = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    id = table.Column<double>(type: "float", nullable: true),
                    initsiteid = table.Column<string>(name: "init_siteid", type: "varchar(16)", unicode: false, maxLength: 16, nullable: true),
                    bgcode = table.Column<string>(name: "bg_code", type: "varchar(16)", unicode: false, maxLength: 16, nullable: true),
                    factorycode = table.Column<string>(name: "factory_code", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    emptype = table.Column<string>(name: "emp_type", type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Chr_EmployeeUpdate",
                columns: table => new
                {
                    empno = table.Column<string>(name: "emp_no", type: "varchar(16)", unicode: false, maxLength: 16, nullable: false),
                    siteid = table.Column<string>(type: "varchar(16)", unicode: false, maxLength: 16, nullable: true),
                    keydate = table.Column<DateTime>(name: "key_date", type: "datetime", nullable: true),
                    empname = table.Column<string>(name: "emp_name", type: "varchar(64)", unicode: false, maxLength: 64, nullable: true),
                    sex = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    cos = table.Column<string>(type: "varchar(16)", unicode: false, maxLength: 16, nullable: true),
                    departno = table.Column<string>(name: "depart_no", type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    birthday = table.Column<DateTime>(type: "datetime", nullable: true),
                    indate = table.Column<DateTime>(name: "in_date", type: "datetime", nullable: true),
                    classno = table.Column<string>(name: "class_no", type: "varchar(16)", unicode: false, maxLength: 16, nullable: true),
                    statusno = table.Column<string>(name: "status_no", type: "varchar(16)", unicode: false, maxLength: 16, nullable: true),
                    married = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    jobsituation = table.Column<string>(name: "job_situation", type: "varchar(16)", unicode: false, maxLength: 16, nullable: true),
                    levdate = table.Column<DateTime>(name: "lev_date", type: "datetime", nullable: true),
                    oldhome = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    empid = table.Column<string>(name: "emp_id", type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    lasteditdt = table.Column<DateTime>(type: "datetime", nullable: true),
                    address = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    urgtel = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    transferdate = table.Column<DateTime>(name: "transfer_date", type: "datetime", nullable: true),
                    photo = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    id = table.Column<double>(type: "float", nullable: true),
                    initsiteid = table.Column<string>(name: "init_siteid", type: "varchar(16)", unicode: false, maxLength: 16, nullable: true),
                    bgcode = table.Column<string>(name: "bg_code", type: "varchar(16)", unicode: false, maxLength: 16, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Chr_InFactory_Image",
                columns: table => new
                {
                    InFactoryNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    InFactoryName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    InFactoryID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    MD5Val = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    IsImage = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CivetIntentList",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmpName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AreaName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    IsDeleted = table.Column<int>(type: "int", nullable: true),
                    InsertDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeleteTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    NameSend = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BGID = table.Column<int>(type: "int", nullable: true),
                    AreaID = table.Column<int>(type: "int", nullable: true),
                    Notes = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true),
                    PhoneNumber = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    BU = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Posision = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CivetIntentList", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CivetIntentListMail",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmpName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AreaName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IsDeleted = table.Column<int>(type: "int", nullable: true),
                    InsertDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeleteTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    NameSend = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BGID = table.Column<int>(type: "int", nullable: true),
                    AreaID = table.Column<int>(type: "int", nullable: true),
                    Notes = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true),
                    PhoneNumber = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    BU = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Posision = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CivetIntentListMail", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CivetListMail",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AreaID = table.Column<int>(type: "int", nullable: true),
                    AreaName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ListMail = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CivetSendMess",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormType = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(800)", maxLength: 800, nullable: true),
                    TimeSend = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    TimeAdd = table.Column<DateTime>(type: "datetime", nullable: true),
                    EmpNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FormID = table.Column<int>(type: "int", nullable: true),
                    Url = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    IDApp = table.Column<int>(type: "int", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CMC812log",
                columns: table => new
                {
                    CMC812logID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CMC812logMsg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CMC812logCreateTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    IP = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MAC = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMC812log", x => x.CMC812logID);
                });

            migrationBuilder.CreateTable(
                name: "code",
                columns: table => new
                {
                    codeid = table.Column<string>(name: "code_id", type: "varchar(64)", unicode: false, maxLength: 64, nullable: true),
                    codedesc = table.Column<string>(name: "code_desc", type: "varchar(64)", unicode: false, maxLength: 64, nullable: true),
                    codetype = table.Column<string>(name: "code_type", type: "varchar(64)", unicode: false, maxLength: 64, nullable: true),
                    codestatus = table.Column<string>(name: "code_status", type: "varchar(64)", unicode: false, maxLength: 64, nullable: true),
                    codegroup = table.Column<string>(name: "code_group", type: "varchar(64)", unicode: false, maxLength: 64, nullable: true),
                    lasteditdt = table.Column<DateTime>(type: "datetime", nullable: true),
                    lasteditby = table.Column<string>(type: "varchar(64)", unicode: false, maxLength: 64, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ColorTypeCard",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDCard = table.Column<int>(type: "int", nullable: true),
                    TypeCard = table.Column<int>(type: "int", nullable: true),
                    ColorType = table.Column<int>(type: "int", nullable: true),
                    DateUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EmpNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    CompanyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    CompanyPhone = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CompanyAddress = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ContactPhone = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CooperationProjects = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Acknowledgment = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    File = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Responsible = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ControlTag = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    EmployeeNO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    NameAbbreviation = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true),
                    Code = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    Reason = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false, defaultValueSql: "('')"),
                    EmployeeName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    ControlStatus = table.Column<int>(type: "int", nullable: false),
                    InureStartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    InureEndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ControlMsg = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CompanyCheckingFile = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    FlowType = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.CompanyID);
                });

            migrationBuilder.CreateTable(
                name: "Construction",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitApplication = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    VendorName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true),
                    TimeApplication = table.Column<DateTime>(type: "datetime", nullable: true),
                    Area = table.Column<int>(type: "int", nullable: true),
                    Special = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    MemberAudit = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NameContrus = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Office = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Condition = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Can = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    EmpNoApp = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmpNameApp = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NotesApp = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ExtTel = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Special1 = table.Column<int>(type: "int", nullable: true),
                    Special2 = table.Column<int>(type: "int", nullable: true),
                    Special3 = table.Column<int>(type: "int", nullable: true),
                    Special4 = table.Column<int>(type: "int", nullable: true),
                    Special5 = table.Column<int>(type: "int", nullable: true),
                    Special6 = table.Column<int>(type: "int", nullable: true),
                    Special7 = table.Column<int>(type: "int", nullable: true),
                    Can1 = table.Column<int>(type: "int", nullable: true),
                    Can2 = table.Column<int>(type: "int", nullable: true),
                    Can3 = table.Column<int>(type: "int", nullable: true),
                    Can4 = table.Column<int>(type: "int", nullable: true),
                    AuditVendor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ImageAudit = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TypeCondi = table.Column<int>(type: "int", nullable: true),
                    DeffType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ImageATLD = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NoATLD = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Put1 = table.Column<int>(type: "int", nullable: true),
                    Put2 = table.Column<int>(type: "int", nullable: true),
                    Put3 = table.Column<int>(type: "int", nullable: true),
                    Put4 = table.Column<int>(type: "int", nullable: true),
                    PeoPleList = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FileBVMT = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TimeOut = table.Column<int>(type: "int", nullable: true),
                    EHSIN = table.Column<int>(type: "int", nullable: true),
                    EHSOUT = table.Column<int>(type: "int", nullable: true),
                    IsChe = table.Column<int>(type: "int", nullable: true),
                    Chemistry = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    IsMoc = table.Column<int>(type: "int", nullable: true),
                    Moc = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FileVendor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FileUnit = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Assent = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Construction", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "contolstatus_information",
                columns: table => new
                {
                    contolstatus = table.Column<int>(type: "int", nullable: true),
                    information = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ControlCar",
                columns: table => new
                {
                    ControlCarID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CredentialsNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ControlName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CarNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Reason = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CardID = table.Column<int>(type: "int", nullable: true),
                    Creator = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ControlCar", x => x.ControlCarID);
                });

            migrationBuilder.CreateTable(
                name: "ControlCarN",
                columns: table => new
                {
                    ControlCarID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CredentialsNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ControlName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CarNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Reason = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CardID = table.Column<int>(type: "int", nullable: true),
                    Creator = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ControlCarN", x => x.ControlCarID);
                });

            migrationBuilder.CreateTable(
                name: "ControlPeople",
                columns: table => new
                {
                    ControlPeopleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ControlName = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    CredentialsNumber = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Reason = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsEffective = table.Column<bool>(type: "bit", nullable: false),
                    Creator = table.Column<int>(type: "int", nullable: true),
                    Sourcetag = table.Column<string>(name: "Source_tag", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true, defaultValueSql: "('CertificateDB')"),
                    ComfromTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONTROLPEOPLE", x => x.ControlPeopleID);
                });

            migrationBuilder.CreateTable(
                name: "ControlPeopleBackup",
                columns: table => new
                {
                    ControlPeopleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ControlName = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    CredentialsNumber = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Reason = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsEffective = table.Column<bool>(type: "bit", nullable: false),
                    Creator = table.Column<int>(type: "int", nullable: true),
                    Sourcetag = table.Column<string>(name: "Source_tag", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ComfromTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ControlP__6F1719A0E93D13E2", x => x.ControlPeopleID);
                });

            migrationBuilder.CreateTable(
                name: "ControlPeopleN",
                columns: table => new
                {
                    ControlPeopleNID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ControlName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CredentialsNumber = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Reason = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsEffective = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ControlPeopleN", x => x.ControlPeopleNID);
                });

            migrationBuilder.CreateTable(
                name: "ControlRecord",
                columns: table => new
                {
                    ControlRecordID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: true),
                    EmployeeNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Action = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    ControlMsg = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ControlRecord", x => x.ControlRecordID);
                });

            migrationBuilder.CreateTable(
                name: "ContrucProc",
                columns: table => new
                {
                    ProcID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID = table.Column<int>(type: "int", nullable: true),
                    StatusID = table.Column<int>(type: "int", nullable: true),
                    FormID = table.Column<int>(type: "int", nullable: true),
                    Act = table.Column<int>(type: "int", nullable: true),
                    Memo = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    WorkTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Leavel = table.Column<int>(type: "int", nullable: true),
                    Over = table.Column<int>(type: "int", nullable: true),
                    EmpNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmpName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IP = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ContrucStatus",
                columns: table => new
                {
                    StatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID = table.Column<int>(type: "int", nullable: true),
                    FormID = table.Column<int>(type: "int", nullable: true),
                    EmpNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmpName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Notes = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Leavel = table.Column<int>(type: "int", nullable: true),
                    Over = table.Column<int>(type: "int", nullable: true),
                    Para = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    WorkDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Memo = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true),
                    Ip = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CostSign",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmpName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Notes = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Leavel = table.Column<int>(type: "int", nullable: true),
                    Sort = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<int>(type: "int", nullable: true),
                    AreaID = table.Column<int>(type: "int", nullable: true),
                    BGID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Credential_DelayNew",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Type = table.Column<int>(type: "int", nullable: true),
                    CompanyID = table.Column<int>(type: "int", nullable: true),
                    ContactPersonID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ContactDeparmentID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ContactPhoneNum = table.Column<int>(type: "int", nullable: true),
                    ApplicationTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndTimeNew = table.Column<DateTime>(type: "datetime", nullable: true),
                    DocforCredentialDelay = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Applicant = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    ContactEmail = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    OldNewTable = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CredentialContinu",
                columns: table => new
                {
                    CredentialContinuID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CredentialID = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    ApplyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Annex = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true, defaultValueSql: "('')"),
                    AdminID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CredentialContinu", x => x.CredentialContinuID);
                });

            migrationBuilder.CreateTable(
                name: "CredentialDelaynew_ListCardNum",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CredentialdelayNewID = table.Column<int>(type: "int", nullable: false),
                    CardNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CardID = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    EndTimeNew = table.Column<DateTime>(type: "datetime", nullable: true),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AreaCard = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ApplicationTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CredentialDelaynew_ListCardNum_New",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CredentialdelayNewID = table.Column<int>(type: "int", nullable: false),
                    TableType = table.Column<int>(type: "int", nullable: true),
                    CardNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CardID = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    FormType = table.Column<int>(type: "int", nullable: true),
                    EndTimeNew = table.Column<DateTime>(type: "datetime", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AreaCard = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ApplicationTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    ReceivedTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    ReceivedName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    AdminSignTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    AdminCreateCardTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    NotesForSign = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Signer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FileAttack = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CompanyOldName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CompanyNewName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AreaCardNew = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ImageFile = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ColorCard = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CredentialDelayNew_SigStatus",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CredentialDelayNewID = table.Column<int>(type: "int", nullable: false),
                    Category = table.Column<int>(type: "int", nullable: true),
                    SignerID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    LevelSigne = table.Column<double>(type: "float", nullable: true),
                    Meno = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    SignedStDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SignerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Ip = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Paracode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CustCardRecord",
                columns: table => new
                {
                    fullname = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    applyname = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    type = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: true),
                    cardno = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    ecardno = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    areaname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    machinename = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    datatime = table.Column<DateTime>(type: "datetime", nullable: false),
                    cardstatus = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    reason = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CustList",
                columns: table => new
                {
                    CustListID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VisitCustID = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Sex = table.Column<bool>(type: "bit", nullable: true),
                    Level = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Position = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Relationship = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    IsFristVisit = table.Column<bool>(type: "bit", nullable: true),
                    VisitTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    DiscussMatters = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    VisitNumber = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    RemandTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    ReturnID = table.Column<int>(type: "int", nullable: true),
                    ReturnTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    ReceiverID = table.Column<int>(type: "int", nullable: true),
                    ReceiverTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    ReceiverNo = table.Column<string>(type: "nchar(20)", fixedLength: true, maxLength: 20, nullable: true),
                    ReturnReason = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    VisitImage = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustList", x => x.CustListID);
                });

            migrationBuilder.CreateTable(
                name: "CustNotList",
                columns: table => new
                {
                    CustNotListID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VisitNotCustID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Sex = table.Column<bool>(type: "bit", nullable: true),
                    Position = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Specialty = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    DiscussItem = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    VisitNumber = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    RemandTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    ReturnID = table.Column<int>(type: "int", nullable: true),
                    ReturnTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    ReceiverID = table.Column<int>(type: "int", nullable: true),
                    ReceiverTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    ReceiverNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ReturnReason = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    VisitImage = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustNotList", x => x.CustNotListID);
                });

            migrationBuilder.CreateTable(
                name: "CustTravel",
                columns: table => new
                {
                    CustTravelID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VisitCustID = table.Column<int>(type: "int", nullable: true),
                    StartPlace = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ArrivalTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Flight = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    LeaveTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    GoBackFlight = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustTravel", x => x.CustTravelID);
                });

            migrationBuilder.CreateTable(
                name: "CustWorCredentsLastInserted",
                schema: "faceid",
                columns: table => new
                {
                    CustWorCredentsLastInsertID = table.Column<int>(type: "int", nullable: true),
                    IDLastInsert = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CustWorkCredentials",
                columns: table => new
                {
                    CustWorkCredentialsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyID = table.Column<int>(type: "int", nullable: false),
                    CardID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Sex = table.Column<bool>(type: "bit", nullable: true),
                    Birthday = table.Column<DateTime>(type: "datetime", nullable: true),
                    CensusAddress = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    NowAddress = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    CredentialsNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Phone = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmergencyContact = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmergencyContactPhone = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    WorkType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    WorkCaption = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ContactUnit = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true),
                    EmployeeNO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Signoff = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Signoff2 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    File = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    EmployeeName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ControlStatus = table.Column<int>(type: "int", nullable: false),
                    InureStartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    InureEndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ContactUnitPerson = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    ContactUnitPhone = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    ContactUnitExtension = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    AreaID = table.Column<int>(type: "int", nullable: false),
                    AreaCard = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    NameCN = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CUSTWORKCREDENTIALS", x => x.CustWorkCredentialsID);
                });

            migrationBuilder.CreateTable(
                name: "CustWorkCredentialsDelay",
                columns: table => new
                {
                    CustWorkCredentialID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PID = table.Column<int>(type: "int", nullable: true),
                    ZID = table.Column<int>(type: "int", nullable: true),
                    TypeID = table.Column<int>(type: "int", nullable: true),
                    Phone = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    ContactUnitPersonName = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    ContactPersonEmployee = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    ContactUnitPersonphone = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    ContactUnitPersonBG = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    ContactUnitExtension = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    VeNumber = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    NewAddress = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    EmergencyContact = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    Emergencyphone = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    OnWorkFile = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    IndureEndate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CompanyName = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Name = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    Sex = table.Column<int>(type: "int", nullable: true),
                    nation = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    WorkCaption = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    CredentialsNumber = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    SerialNumber = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    DelDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CustWorkHistory",
                columns: table => new
                {
                    InsertDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    CustWorkCredentialsID = table.Column<int>(type: "int", nullable: true),
                    CompanyID = table.Column<int>(type: "int", nullable: true),
                    CardID = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Sex = table.Column<bool>(type: "bit", nullable: true),
                    Birthday = table.Column<DateTime>(type: "datetime", nullable: true),
                    CensusAddress = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    NowAddress = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    CredentialsNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Phone = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmergencyContact = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmergencyContactPhone = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    WorkType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    WorkCaption = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ContactUnit = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true),
                    EmployeeNO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Signoff = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Signoff2 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    File = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    EmployeeName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ControlStatus = table.Column<int>(type: "int", nullable: false),
                    InureStartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    InureEndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ContactUnitPerson = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    ContactUnitPhone = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    ContactUnitExtension = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    AreaID = table.Column<int>(type: "int", nullable: false),
                    AreaCard = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    NameCN = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CustWorkInFactory",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateEmpNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CreateEmpName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreateBUName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ExcTel = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Mobile = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Notes = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    BGID = table.Column<int>(type: "int", nullable: true),
                    AreaID = table.Column<int>(type: "int", nullable: true),
                    ApplicationTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Memo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FileExcel = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<int>(type: "int", nullable: true),
                    EndValidTimeFirst = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CustWorkInFactory_PerSon",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustWorkInFactoryID = table.Column<int>(type: "int", nullable: true),
                    TypeID = table.Column<int>(type: "int", nullable: true),
                    ComanyID = table.Column<int>(type: "int", nullable: true),
                    WorkTypeID = table.Column<int>(type: "int", nullable: true),
                    NameVN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NameCN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AreaCard = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    PeoPleID = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    BirthDay = table.Column<DateTime>(type: "datetime", nullable: true),
                    Mobile = table.Column<string>(type: "char(20)", unicode: false, fixedLength: true, maxLength: 20, nullable: true),
                    Memo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ImagePeople = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FileAttach = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NoExcel = table.Column<int>(type: "int", nullable: true),
                    ApplicationTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    IsJob = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<int>(type: "int", nullable: true),
                    CardID = table.Column<int>(type: "int", nullable: true),
                    StartValidDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndValidDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Receipt = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NameAbeviation = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CustWorkInFactoryAdmin_Proc",
                columns: table => new
                {
                    ProcAdminID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID = table.Column<int>(type: "int", nullable: true),
                    CustInfacPersonID = table.Column<int>(type: "int", nullable: true),
                    EmpNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmpName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Leavel = table.Column<int>(type: "int", nullable: true),
                    WorkDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Memo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    RoleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Ip = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CustWorkInFactoryProc",
                columns: table => new
                {
                    ProcID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID = table.Column<int>(type: "int", nullable: true),
                    StatusID = table.Column<int>(type: "int", nullable: true),
                    FormID = table.Column<int>(type: "int", nullable: true),
                    EmpNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmpName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Leavel = table.Column<int>(type: "int", nullable: true),
                    Sort = table.Column<int>(type: "int", nullable: true),
                    WorkDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Memo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    ParaCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    RoleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Ip = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CustWorkInFactoryStatus",
                columns: table => new
                {
                    StatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID = table.Column<int>(type: "int", nullable: true),
                    FormID = table.Column<int>(type: "int", nullable: true),
                    EmpNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmpName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Notes = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Leavel = table.Column<int>(type: "int", nullable: true),
                    Sort = table.Column<int>(type: "int", nullable: true),
                    WorkDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Memo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    ParaCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    RoleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CustWorkValid",
                columns: table => new
                {
                    CustWorkCredentialsID = table.Column<int>(type: "int", nullable: true),
                    CompanyID = table.Column<int>(type: "int", nullable: true),
                    CardID = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Sex = table.Column<bool>(type: "bit", nullable: true),
                    Birthday = table.Column<DateTime>(type: "datetime", nullable: true),
                    CensusAddress = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    NowAddress = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    CredentialsNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Phone = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmergencyContact = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmergencyContactPhone = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    WorkType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    WorkCaption = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ContactUnit = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true),
                    EmployeeNO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Signoff = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Signoff2 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    File = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    EmployeeName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ControlStatus = table.Column<int>(type: "int", nullable: true),
                    InureStartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    InureEndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ContactUnitPerson = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ContactUnitPhone = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ContactUnitExtension = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AreaID = table.Column<int>(type: "int", nullable: true),
                    AreaCard = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    NameCN = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CustWorkValidNew",
                schema: "faceid",
                columns: table => new
                {
                    CustWorkCredentialsID = table.Column<int>(type: "int", nullable: true),
                    CompanyID = table.Column<int>(type: "int", nullable: true),
                    CardID = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Sex = table.Column<bool>(type: "bit", nullable: true),
                    Birthday = table.Column<DateTime>(type: "datetime", nullable: true),
                    CensusAddress = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    NowAddress = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    CredentialsNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Phone = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmergencyContact = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmergencyContactPhone = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    WorkType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    WorkCaption = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ContactUnit = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true),
                    EmployeeNO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Signoff = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Signoff2 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    File = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    EmployeeName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ControlStatus = table.Column<int>(type: "int", nullable: true),
                    InureStartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    InureEndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ContactUnitPerson = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ContactUnitPhone = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ContactUnitExtension = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AreaID = table.Column<int>(type: "int", nullable: true),
                    AreaCard = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "dbo.Chr_employee2",
                columns: table => new
                {
                    empno = table.Column<string>(name: "emp_no", type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    siteID = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    keydate = table.Column<DateTime>(name: "key_date", type: "datetime", nullable: true),
                    empname = table.Column<string>(name: "emp_name", type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    sex = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: true),
                    cos = table.Column<string>(type: "char(20)", unicode: false, fixedLength: true, maxLength: 20, nullable: true),
                    birthday = table.Column<DateTime>(type: "datetime", nullable: true),
                    indate = table.Column<DateTime>(name: "in_date", type: "datetime", nullable: true),
                    classno = table.Column<string>(name: "class_no", type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    statusno = table.Column<string>(name: "status_no", type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    married = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    jobsituation = table.Column<string>(name: "job_situation", type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    levdate = table.Column<DateTime>(name: "lev_date", type: "datetime", nullable: true),
                    oldhome = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    empid = table.Column<string>(name: "emp_id", type: "char(20)", unicode: false, fixedLength: true, maxLength: 20, nullable: true),
                    lasteditdt = table.Column<DateTime>(type: "datetime", nullable: true),
                    address = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    urgtel = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    transferdate = table.Column<DateTime>(name: "transfer_date", type: "datetime", nullable: true),
                    photo = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true),
                    ID = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    InitSiteID = table.Column<string>(name: "Init_SiteID", type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    bgcode = table.Column<string>(name: "bg_code", type: "varchar(64)", unicode: false, maxLength: 64, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "DealType",
                columns: table => new
                {
                    DealTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DealType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Meno = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DealType", x => x.DealTypeID);
                });

            migrationBuilder.CreateTable(
                name: "DefaultCardInfo",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    DepartmentID = table.Column<int>(type: "int", nullable: false),
                    DepartmentName = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: true),
                    Type = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    Information = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.DepartmentID);
                });

            migrationBuilder.CreateTable(
                name: "DepartmentAuditPerson",
                columns: table => new
                {
                    DepartmentAuditID = table.Column<int>(type: "int", nullable: false),
                    EmployeeNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    BGID = table.Column<int>(type: "int", nullable: true),
                    Notes = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Isdeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeleteTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "DietAttention",
                columns: table => new
                {
                    DietAttentionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VisitCustID = table.Column<int>(type: "int", nullable: true),
                    VegetarianFoodNum = table.Column<int>(type: "int", nullable: true),
                    Preferences = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Other = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Eat = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DietAttention", x => x.DietAttentionID);
                });

            migrationBuilder.CreateTable(
                name: "DimissionUserBeforeLoding",
                columns: table => new
                {
                    UserBeforeLodingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    EmployeeName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Notes = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    BGID = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "DoorPowerManage",
                columns: table => new
                {
                    DoorPowerManageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BGID = table.Column<int>(type: "int", nullable: true),
                    EmployeeName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EmployeeNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Position = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Bu = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Dept = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Notes = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Password = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Picture = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    EnglishPicture = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Tel = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    RePwdTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    IsFind = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    File = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    WhetherJob = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    IsOverTime = table.Column<bool>(type: "bit", nullable: false),
                    MailSendDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    InsertDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    OldApplicationID = table.Column<int>(name: "Old_Application_ID", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoorPowerManage", x => x.DoorPowerManageID);
                });

            migrationBuilder.CreateTable(
                name: "DoorPowerManageBGSetup",
                columns: table => new
                {
                    BGSetupID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BGID = table.Column<int>(type: "int", nullable: true),
                    CreateUserID = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    DelUserID = table.Column<int>(type: "int", nullable: true),
                    DelDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoorPowerManageBGSetup", x => x.BGSetupID);
                });

            migrationBuilder.CreateTable(
                name: "DoorPowerManageBGSetupItem",
                columns: table => new
                {
                    BGSetupItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PowerAdminID = table.Column<int>(type: "int", nullable: true),
                    RoleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreateUserID = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    ModifyUserID = table.Column<int>(type: "int", nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DelUserID = table.Column<int>(type: "int", nullable: true),
                    DelDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoorPowerManageBGSetupItem", x => x.BGSetupItemID);
                });

            migrationBuilder.CreateTable(
                name: "DoorPowerManageBGSignSetup",
                columns: table => new
                {
                    BGSignSetupID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BGID = table.Column<int>(type: "int", nullable: true),
                    ApplicationID = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    IsUse = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    FirstSignUserID = table.Column<int>(type: "int", nullable: true),
                    FirstSignDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    FirstStatus = table.Column<int>(type: "int", nullable: true),
                    FirstSignMeno = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoorPowerManageBGSignSetup", x => x.BGSignSetupID);
                });

            migrationBuilder.CreateTable(
                name: "DoorPowerManageModify",
                columns: table => new
                {
                    DoorPowerManageModifyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoorPowerManageID = table.Column<int>(type: "int", nullable: false),
                    ActionDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ActionAdminID = table.Column<int>(type: "int", nullable: false),
                    ActionMeno = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Files = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IP = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Mac = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoorPowerManageModify", x => x.DoorPowerManageModifyID);
                });

            migrationBuilder.CreateTable(
                name: "DoorPowerManageVer",
                columns: table => new
                {
                    DoorPowerManageVerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoorPowerManageID = table.Column<int>(type: "int", nullable: false),
                    BGID = table.Column<int>(type: "int", nullable: true),
                    EmployeeName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EmployeeNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Position = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Bu = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Dept = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Notes = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsFind = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    File = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DeleteReason = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeleteAdminID = table.Column<int>(type: "int", nullable: true),
                    FilesForDelete = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Picture = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EnglishPicture = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    WhetherJob = table.Column<bool>(type: "bit", nullable: true),
                    InsertDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    OldApplicationID = table.Column<int>(name: "Old_Application_ID", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoorPowerManageVer", x => x.DoorPowerManageVerID);
                });

            migrationBuilder.CreateTable(
                name: "DoorReplace",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmpName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Notes = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EmpNoReplace = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmpNameReplace = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NotesReplace = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Extel = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Mobi = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ExtelReplace = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    MobiReplace = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoorReplace", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DoorReplaceBG",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmpName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Notes = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EmpNoReplace = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmpNameReplace = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NotesReplace = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoorReplaceBG", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Driver",
                columns: table => new
                {
                    DriverGUID = table.Column<string>(type: "varchar(36)", unicode: false, maxLength: 36, nullable: false, defaultValueSql: "(newid())"),
                    DriverID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CredentialNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EmployeeNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PeopleType = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    DeletedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Address = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    EmployeeCardNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Driver", x => x.DriverGUID);
                });

            migrationBuilder.CreateTable(
                name: "DriverCompanyMatch",
                columns: table => new
                {
                    DriverCompanyMatchGUID = table.Column<string>(type: "varchar(36)", unicode: false, maxLength: 36, nullable: false, defaultValueSql: "(newid())"),
                    DriverCompanyMatchID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DriverID = table.Column<int>(type: "int", nullable: true),
                    CompanyID = table.Column<int>(type: "int", nullable: true),
                    MatchDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriverCompanyMatch", x => x.DriverCompanyMatchGUID);
                });

            migrationBuilder.CreateTable(
                name: "DriverVehicleMatch",
                columns: table => new
                {
                    VehicleDriverMatchGUID = table.Column<string>(type: "varchar(36)", unicode: false, maxLength: 36, nullable: false, defaultValueSql: "(newid())"),
                    DriverVehicleMatchID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DriverID = table.Column<int>(type: "int", nullable: true),
                    VehiclePermitID = table.Column<int>(type: "int", nullable: true),
                    MatchDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    DeletedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeleteMeno = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriverVehicleMatch", x => x.VehicleDriverMatchGUID);
                });

            migrationBuilder.CreateTable(
                name: "EconConfig",
                columns: table => new
                {
                    EconConfigID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminID = table.Column<int>(type: "int", nullable: false),
                    BGID = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EconConfig", x => x.EconConfigID);
                });

            migrationBuilder.CreateTable(
                name: "EhsSign",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmpName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EmpNameV = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Notes = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    BGID = table.Column<int>(type: "int", nullable: true),
                    Leave = table.Column<int>(type: "int", nullable: true),
                    Area = table.Column<int>(type: "int", nullable: true),
                    Sort = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ElectricUse",
                columns: table => new
                {
                    ElecID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID = table.Column<int>(type: "int", nullable: true),
                    UnitApplication = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NameVendor = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NameConstruc = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    TimeAplication = table.Column<DateTime>(type: "datetime", nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Area = table.Column<int>(type: "int", nullable: true),
                    Office = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ContentAction = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    EmpNoApp = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmpNameApp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NotesApp = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    BF1 = table.Column<int>(type: "int", nullable: true),
                    BF2 = table.Column<int>(type: "int", nullable: true),
                    BF3 = table.Column<int>(type: "int", nullable: true),
                    BF4 = table.Column<int>(type: "int", nullable: true),
                    BF5 = table.Column<int>(type: "int", nullable: true),
                    BF6 = table.Column<int>(type: "int", nullable: true),
                    BF7 = table.Column<int>(type: "int", nullable: true),
                    IN1 = table.Column<int>(type: "int", nullable: true),
                    IN2 = table.Column<int>(type: "int", nullable: true),
                    IN3 = table.Column<int>(type: "int", nullable: true),
                    IN4 = table.Column<int>(type: "int", nullable: true),
                    IN5 = table.Column<int>(type: "int", nullable: true),
                    IN6 = table.Column<int>(type: "int", nullable: true),
                    AF1 = table.Column<int>(type: "int", nullable: true),
                    AF2 = table.Column<int>(type: "int", nullable: true),
                    VendorAudit = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FileVendor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FacAudit = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FileFac = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Spe1 = table.Column<int>(type: "int", nullable: true),
                    Spe2 = table.Column<int>(type: "int", nullable: true),
                    Spe3 = table.Column<int>(type: "int", nullable: true),
                    Spe4 = table.Column<int>(type: "int", nullable: true),
                    Spe5 = table.Column<int>(type: "int", nullable: true),
                    Defer = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ActionMember = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FileMember = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ExtTel = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Pec = table.Column<int>(type: "int", nullable: true),
                    ATLD3 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FileClother = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FileDevices = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Assent = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Envi_EnclosedSpace",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartApplicant = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ContructorName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ProjectName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ContructionID = table.Column<int>(type: "int", nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    ActionPossition = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NameNvgsnt = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FileUploadNvgsnt = table.Column<string>(name: "FileUpload_Nvgsnt", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Mccgstc1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FileUploadMccgstc1 = table.Column<string>(name: "FileUpload_Mccgstc1", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Nvgsdvx = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FileUploadNvgsdv = table.Column<string>(name: "FileUpload_Nvgsdv", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Mccgstc2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FileUploadMccgstc2 = table.Column<string>(name: "FileUpload_Mccgstc2", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Mccatldn2gsnt = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FileUploadMccatldn2gsnt = table.Column<string>(name: "FileUpload_Mccatldn2gsnt", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AreaID = table.Column<int>(type: "int", nullable: true),
                    Ndthct = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Hangmuctn1 = table.Column<int>(type: "int", nullable: true),
                    Hangmuctn2 = table.Column<int>(type: "int", nullable: true),
                    Hangmuctn3 = table.Column<int>(type: "int", nullable: true),
                    Hangmuctn4 = table.Column<int>(type: "int", nullable: true),
                    Hangmuctn5 = table.Column<int>(type: "int", nullable: true),
                    Hangmuctn6 = table.Column<int>(type: "int", nullable: true),
                    Hangmuctn7 = table.Column<int>(type: "int", nullable: true),
                    Hangmuctn8 = table.Column<int>(type: "int", nullable: true),
                    Vttnct = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Nvtntcnt = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Truoctn1 = table.Column<int>(type: "int", nullable: true),
                    Truoctn2 = table.Column<int>(type: "int", nullable: true),
                    Truoctn3 = table.Column<int>(type: "int", nullable: true),
                    NongdoO2 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    NongdoCH4 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    NongdoH2S = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    NongdoCO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Ketluan = table.Column<int>(type: "int", nullable: true),
                    Trongtn1 = table.Column<int>(type: "int", nullable: true),
                    Trongtn2 = table.Column<int>(type: "int", nullable: true),
                    Trongtn3 = table.Column<int>(type: "int", nullable: true),
                    Trongtn4 = table.Column<int>(type: "int", nullable: true),
                    Trongtn5 = table.Column<int>(type: "int", nullable: true),
                    Trongtn6 = table.Column<int>(type: "int", nullable: true),
                    Trongtn7 = table.Column<int>(type: "int", nullable: true),
                    Trongtn8 = table.Column<int>(type: "int", nullable: true),
                    Trongtn9 = table.Column<int>(type: "int", nullable: true),
                    Trongtn10 = table.Column<int>(type: "int", nullable: true),
                    Trongtn11 = table.Column<int>(type: "int", nullable: true),
                    Sautn1 = table.Column<int>(type: "int", nullable: true),
                    Sautn2 = table.Column<int>(type: "int", nullable: true),
                    Sautn3 = table.Column<int>(type: "int", nullable: true),
                    Applicant = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ApplicationTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Quanche = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    EhsSign = table.Column<int>(type: "int", nullable: true),
                    FileVendor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FileUnit = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FileClother = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FileDevices = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Assent = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "EnviHighAction",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dvxin = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Tennhathau = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Tencongtrinh = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Madonthicong = table.Column<int>(type: "int", nullable: true),
                    Vitritacnghiep = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Starttime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Endtime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Nhanviengscuanhathau = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Anhnvgscnt = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Machungchigsthicong1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Anhmccgstc1 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Nhanviengsdvx = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Anhnvgsdvx = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Machungchigsthicong2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Anhmccgstc2 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Maccantoanld = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Anhmccatld = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    AreaID = table.Column<int>(type: "int", nullable: true),
                    Vitritoanha = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Noidungtnct = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Lapdatthietbi = table.Column<int>(type: "int", nullable: true),
                    Suachuathietbi = table.Column<int>(type: "int", nullable: true),
                    Thaydoiketcauxuong = table.Column<int>(type: "int", nullable: true),
                    Sonba = table.Column<int>(type: "int", nullable: true),
                    Khac = table.Column<int>(type: "int", nullable: true),
                    Vitritacnghiepcuthe = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Nhanvientntcnhathau = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Tieuchuan1 = table.Column<int>(type: "int", nullable: true),
                    Tieuchuan2 = table.Column<int>(type: "int", nullable: true),
                    Tieuchuan3 = table.Column<int>(type: "int", nullable: true),
                    Tieuchuan4 = table.Column<int>(type: "int", nullable: true),
                    Tieuchuan5 = table.Column<int>(type: "int", nullable: true),
                    Tieuchuan6 = table.Column<int>(type: "int", nullable: true),
                    Tieuchuan7 = table.Column<int>(type: "int", nullable: true),
                    Trongtn1 = table.Column<int>(type: "int", nullable: true),
                    Trongtn2 = table.Column<int>(type: "int", nullable: true),
                    Trongtn3 = table.Column<int>(type: "int", nullable: true),
                    Trongtn4 = table.Column<int>(type: "int", nullable: true),
                    Trongtn5 = table.Column<int>(type: "int", nullable: true),
                    Trongtn6 = table.Column<int>(type: "int", nullable: true),
                    Trongtn7 = table.Column<int>(type: "int", nullable: true),
                    Sautn1 = table.Column<int>(type: "int", nullable: true),
                    Sautn2 = table.Column<int>(type: "int", nullable: true),
                    Applicant = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ApplicationTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Quanche = table.Column<int>(type: "int", nullable: true),
                    EhsSign = table.Column<int>(type: "int", nullable: true),
                    FileUnit = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FileClother = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FileDevices = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Assent = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Exemption_Car",
                columns: table => new
                {
                    ID = table.Column<double>(type: "float", nullable: true),
                    Bgname = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CarNumber = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CarType = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CarColor = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IsDeleteD = table.Column<double>(type: "float", nullable: true),
                    DeleteDdate = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DeleteDseason = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ExpCar",
                columns: table => new
                {
                    ExpCarid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Carnumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TravelStartTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    TravelEndTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    isdeleted = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "FingerPrint",
                columns: table => new
                {
                    FingerPrintID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CredentialsNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FingerprintPicture = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    FingerprintMode = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    FingerNumber = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    DeletedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "FireEngine",
                columns: table => new
                {
                    FireID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID = table.Column<int>(type: "int", nullable: true),
                    UnitApplication = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NameVendor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NameConstruc = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    TimeAplication = table.Column<DateTime>(type: "datetime", nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Area = table.Column<int>(type: "int", nullable: true),
                    Office = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ContenAction = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    FireType1 = table.Column<int>(type: "int", nullable: true),
                    FireType2 = table.Column<int>(type: "int", nullable: true),
                    FireType3 = table.Column<int>(type: "int", nullable: true),
                    AuditVendor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ImageAudit = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    EmpNoApp = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmpNameApp = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NotesApp = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ExtTel = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    Special = table.Column<int>(type: "int", nullable: true),
                    MemberAudit = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MemberFire = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FireType4 = table.Column<int>(type: "int", nullable: true),
                    FireType5 = table.Column<int>(type: "int", nullable: true),
                    FireType6 = table.Column<int>(type: "int", nullable: true),
                    FireType7 = table.Column<int>(type: "int", nullable: true),
                    FireType8 = table.Column<int>(type: "int", nullable: true),
                    FireType9 = table.Column<int>(type: "int", nullable: true),
                    PeopleAction = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FilePeople = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Defer = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IDATLD = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ImageATLD = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    BF1 = table.Column<int>(type: "int", nullable: true),
                    BF2 = table.Column<int>(type: "int", nullable: true),
                    BF3 = table.Column<int>(type: "int", nullable: true),
                    BF4 = table.Column<int>(type: "int", nullable: true),
                    BF5 = table.Column<int>(type: "int", nullable: true),
                    BF6 = table.Column<int>(type: "int", nullable: true),
                    BF7 = table.Column<int>(type: "int", nullable: true),
                    BF8 = table.Column<int>(type: "int", nullable: true),
                    BF9 = table.Column<int>(type: "int", nullable: true),
                    BF10 = table.Column<int>(type: "int", nullable: true),
                    BF11 = table.Column<int>(type: "int", nullable: true),
                    IN1 = table.Column<int>(type: "int", nullable: true),
                    IN2 = table.Column<int>(type: "int", nullable: true),
                    IN3 = table.Column<int>(type: "int", nullable: true),
                    IN4 = table.Column<int>(type: "int", nullable: true),
                    AF1 = table.Column<int>(type: "int", nullable: true),
                    AF2 = table.Column<int>(type: "int", nullable: true),
                    AF3 = table.Column<int>(type: "int", nullable: true),
                    AF4 = table.Column<int>(type: "int", nullable: true),
                    IN5 = table.Column<int>(type: "int", nullable: true),
                    AF5 = table.Column<int>(type: "int", nullable: true),
                    AuditFile = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ATLD3 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EhsSign = table.Column<int>(type: "int", nullable: true),
                    FileVenDor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FileUnit = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Assent = table.Column<int>(type: "int", nullable: true),
                    FileClother = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FileDevices = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    SendMess = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Form",
                columns: table => new
                {
                    FormID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormType = table.Column<int>(type: "int", nullable: true),
                    FormName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FormTable = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Url = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    KeyName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Form", x => x.FormID);
                });

            migrationBuilder.CreateTable(
                name: "FormBack",
                schema: "faceid",
                columns: table => new
                {
                    FormIDback = table.Column<int>(type: "int", nullable: true),
                    FormTypeback = table.Column<int>(type: "int", nullable: true),
                    FormNameback = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FormTableback = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Urlback = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    KeyName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "FormbackTest",
                schema: "faceid",
                columns: table => new
                {
                    FormIDback = table.Column<int>(type: "int", nullable: true),
                    FormTypeback = table.Column<int>(type: "int", nullable: true),
                    FormNameback = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Formtableback = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Urlback = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    KeyNameback = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "FormStatus",
                columns: table => new
                {
                    FormStatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormID = table.Column<int>(type: "int", nullable: true),
                    ID = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    FlowImage = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Notes = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Leavel = table.Column<double>(type: "float", nullable: true),
                    FlowNum = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    WorkTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    FormMeno = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    EmployeeNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ToZC = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FORMSTATUS", x => x.FormStatusID);
                });

            migrationBuilder.CreateTable(
                name: "FormWorkProc",
                columns: table => new
                {
                    FormWorkProcID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormID = table.Column<int>(type: "int", nullable: true),
                    ID = table.Column<int>(type: "int", nullable: true),
                    FormStatusID = table.Column<int>(type: "int", nullable: true),
                    Act = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    WorkDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Meno = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FORMWORKPROC", x => x.FormWorkProcID);
                });

            migrationBuilder.CreateTable(
                name: "GoingOut",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeApplication = table.Column<DateTime>(type: "datetime", nullable: true),
                    EmpNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmpName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BU = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Destination = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    TimeOut = table.Column<DateTime>(type: "datetime", nullable: true),
                    TimeInPlan = table.Column<DateTime>(type: "datetime", nullable: true),
                    TimeInReal = table.Column<DateTime>(type: "datetime", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    EmpNoApp = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmpNameApp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NotesApp = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AreaID = table.Column<int>(type: "int", nullable: true),
                    BGID = table.Column<int>(type: "int", nullable: true),
                    AreaRegionID = table.Column<int>(type: "int", nullable: true),
                    PhoneApp = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmpPhone = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoingOut", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "gongyingshang",
                columns: table => new
                {
                    VendorCode = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    CorpName = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    NCHNName = table.Column<string>(name: "N_CHNName", type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    StatusID = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "GroupChiefExecutive",
                columns: table => new
                {
                    GroupChiefExecutiveID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BGID = table.Column<int>(type: "int", nullable: false),
                    EmployeeNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EmployeeName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Position = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    SignatureFile = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Password = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AuthorizationFile = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Notes = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupChiefExecutive", x => x.GroupChiefExecutiveID);
                });

            migrationBuilder.CreateTable(
                name: "GroupType",
                columns: table => new
                {
                    GroupTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupTypeName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    AreaGroupID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupType", x => x.GroupTypeID);
                });

            migrationBuilder.CreateTable(
                name: "HandleResult",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDTrouble = table.Column<int>(type: "int", nullable: true),
                    Memo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ContentResult = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Active = table.Column<int>(type: "int", nullable: true),
                    TimeHandle = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "HandleTrouble",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AreaID = table.Column<int>(type: "int", nullable: true),
                    ApplicationTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    EmpNoRece = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EmpNameRece = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MethodRece = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EmpNoArr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EmpNameArr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MothodArr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    ReceTime = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TroubleType = table.Column<int>(type: "int", nullable: true),
                    OtherTrouble = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TroubleContent = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Memo = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    HandNameCN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    HandNameVN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    HandExt = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    HandMobile = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    HandNotes = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Active = table.Column<int>(type: "int", nullable: true),
                    HandResult = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    HandTime = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    HandMemo = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    EmpNoApp = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EmpNameApp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    HandEmpNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TimeSend = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "HangleSign",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EmpNameCN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EmpNameVN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Notes = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsDeleted = table.Column<int>(type: "int", nullable: true),
                    AreaID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Mobile = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Ext = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Help",
                columns: table => new
                {
                    HelpID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HelpTitle = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    HelpContent = table.Column<string>(type: "varchar(6000)", unicode: false, maxLength: 6000, nullable: true),
                    Arrangement = table.Column<double>(type: "float", nullable: true, defaultValueSql: "((0))"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Help", x => x.HelpID);
                });

            migrationBuilder.CreateTable(
                name: "HGCarInfo",
                columns: table => new
                {
                    HGCarID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TranCom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IDNO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    DeleteTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HGCarInfo", x => x.HGCarID);
                });

            migrationBuilder.CreateTable(
                name: "Hinhvv",
                columns: table => new
                {
                    Test = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Hello = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "HoanCong",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormID = table.Column<int>(type: "int", nullable: true),
                    EmpNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmpName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Notes = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    WorkDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Para = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Memo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Hoisting",
                columns: table => new
                {
                    HoiID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID = table.Column<int>(type: "int", nullable: true),
                    UnitApplication = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NameVendor = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NameContruc = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    VendorAudit = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ImageAudit = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MemberAudit = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ImageMember = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ATLD2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ImageATLD2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Area = table.Column<int>(type: "int", nullable: true),
                    Office = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ContentAction = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    PositionAction = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Weight = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    NumberCar = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    NameDriver = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ImageDriving = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ImageCheck = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ImageChart = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NameTurn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NameTie = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TimeApplication = table.Column<DateTime>(type: "datetime", nullable: true),
                    EmpNoApp = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmpNameApp = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NotesApp = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ExtTel = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Special = table.Column<int>(type: "int", nullable: true),
                    BF1 = table.Column<int>(type: "int", nullable: true),
                    BF2 = table.Column<int>(type: "int", nullable: true),
                    BF3 = table.Column<int>(type: "int", nullable: true),
                    BF4 = table.Column<int>(type: "int", nullable: true),
                    BF5 = table.Column<int>(type: "int", nullable: true),
                    IN1 = table.Column<int>(type: "int", nullable: true),
                    IN2 = table.Column<int>(type: "int", nullable: true),
                    IN3 = table.Column<int>(type: "int", nullable: true),
                    IN4 = table.Column<int>(type: "int", nullable: true),
                    IN5 = table.Column<int>(type: "int", nullable: true),
                    IN6 = table.Column<int>(type: "int", nullable: true),
                    IN7 = table.Column<int>(type: "int", nullable: true),
                    IN8 = table.Column<int>(type: "int", nullable: true),
                    IN9 = table.Column<int>(type: "int", nullable: true),
                    IN10 = table.Column<int>(type: "int", nullable: true),
                    IN11 = table.Column<int>(type: "int", nullable: true),
                    AF1 = table.Column<int>(type: "int", nullable: true),
                    AF2 = table.Column<int>(type: "int", nullable: true),
                    ATLD3 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AuditFile = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EhsSign = table.Column<int>(type: "int", nullable: true),
                    FileVendor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FileUnit = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FileClother = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FileDevices = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Assent = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "HouseLayer",
                columns: table => new
                {
                    HouseLayerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegionHouseID = table.Column<int>(type: "int", nullable: true),
                    LayerID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseLayer", x => x.HouseLayerID);
                });

            migrationBuilder.CreateTable(
                name: "IcivetLogin",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: true),
                    Userid = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EmpNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ImExPortProduct",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImExPortProductID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DatetimeUse = table.Column<DateTime>(type: "datetime", nullable: true),
                    Weights = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CardID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    PartPass = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true),
                    MacID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IP = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ComporationID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AreaID = table.Column<int>(type: "int", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ImExPortProduct_DriverInfor",
                columns: table => new
                {
                    ImExPortProductID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    DriverName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DriverID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TransportType = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CarNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ComporationID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ImExPortProduct_ProductInfor",
                columns: table => new
                {
                    ImExPortProductID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    ProductType = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Amounts = table.Column<int>(type: "int", nullable: true),
                    UnitType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ComporationID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Intermittent",
                columns: table => new
                {
                    IDInter = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID = table.Column<int>(type: "int", nullable: true),
                    UnitApplication = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NameVendor = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    NameContruc = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Area = table.Column<int>(type: "int", nullable: true),
                    Office = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ContentInter = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    AuditVendor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ImageAudit = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MemberAudit = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ImageMember = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ATLD2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ImageATLD2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TimeApplication = table.Column<DateTime>(type: "datetime", nullable: true),
                    Con1 = table.Column<int>(type: "int", nullable: true),
                    Con2 = table.Column<int>(type: "int", nullable: true),
                    Con3 = table.Column<int>(type: "int", nullable: true),
                    Con4 = table.Column<int>(type: "int", nullable: true),
                    Con5 = table.Column<int>(type: "int", nullable: true),
                    Con6 = table.Column<int>(type: "int", nullable: true),
                    Con7 = table.Column<int>(type: "int", nullable: true),
                    Con8 = table.Column<int>(type: "int", nullable: true),
                    Con9 = table.Column<int>(type: "int", nullable: true),
                    Con10 = table.Column<int>(type: "int", nullable: true),
                    Con11 = table.Column<int>(type: "int", nullable: true),
                    ConDefe = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true),
                    TypeDefe = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    EmpNoApp = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmpNameApp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NotesApp = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ExtTel = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Special = table.Column<int>(type: "int", nullable: true),
                    IN1 = table.Column<int>(type: "int", nullable: true),
                    IN2 = table.Column<int>(type: "int", nullable: true),
                    IN3 = table.Column<int>(type: "int", nullable: true),
                    IN4 = table.Column<int>(type: "int", nullable: true),
                    IN5 = table.Column<int>(type: "int", nullable: true),
                    AF1 = table.Column<int>(type: "int", nullable: true),
                    AF2 = table.Column<int>(type: "int", nullable: true),
                    AF3 = table.Column<int>(type: "int", nullable: true),
                    BF1 = table.Column<int>(type: "int", nullable: true),
                    BF2 = table.Column<int>(type: "int", nullable: true),
                    BF3 = table.Column<int>(type: "int", nullable: true),
                    BF4 = table.Column<int>(type: "int", nullable: true),
                    BF5 = table.Column<int>(type: "int", nullable: true),
                    ATLD3 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AuditFile = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EhsSign = table.Column<int>(type: "int", nullable: true),
                    FileClother = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FileDevices = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Assent = table.Column<int>(type: "int", nullable: true),
                    SendMess = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "InteruptInfrared",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpIDCreate = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    SpecialPhone = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ApplicationDepart = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ActionDepartment = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ContructionID = table.Column<int>(type: "int", nullable: true),
                    ActionLocation = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ActionContent = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    FromDate = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Todate = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AreaID = table.Column<int>(type: "int", nullable: true),
                    Reason = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ActionType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    InfraredLampOff = table.Column<int>(type: "int", nullable: true),
                    ApplicantEmail = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ApplicantExt = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Isdeleted = table.Column<int>(type: "int", nullable: true),
                    IsDisplay = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    OffCamera = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ItDevice_Info",
                columns: table => new
                {
                    ItDeviceID = table.Column<int>(type: "int", nullable: true),
                    DeviceType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AssetType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Brand = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Specifications = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Color = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    SN = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    HaveWifi = table.Column<int>(type: "int", nullable: true),
                    ProductID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Picture = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Notes = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ItDevices",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    RequirementType = table.Column<int>(type: "int", nullable: true),
                    AreaID = table.Column<int>(type: "int", nullable: true),
                    CreaterEmpID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CreaterName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreaterDepartment = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreaterSpecialPhone = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CreaterPhoneNum = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CreaterEmail = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ReasonType = table.Column<int>(type: "int", nullable: true),
                    LocationDetail = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    UseEmpID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    UseName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UseDepartment = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UseSpecialPhone = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    UsePhoneNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    UseEmail = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    UseTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    PartPass = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IpPass = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    BgIDUse = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ITDevices_ListPass",
                columns: table => new
                {
                    ItdeviceID = table.Column<int>(type: "int", nullable: false),
                    PartPass = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TimePass = table.Column<DateTime>(type: "datetime", nullable: true),
                    IpPass = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MacPass = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Itinerary",
                columns: table => new
                {
                    ItineraryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VisitCustID = table.Column<int>(type: "int", nullable: false),
                    BriefType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    BriefMeno = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    BriefAddress = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Person = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Phone = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    LtineraryStress = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Itinerary", x => x.ItineraryID);
                });

            migrationBuilder.CreateTable(
                name: "JurisdictionType",
                columns: table => new
                {
                    JurisdictionTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JurisdictionType = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    Meno = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Arrangement = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    IsBegin = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JurisdictionType", x => x.JurisdictionTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Layer",
                columns: table => new
                {
                    LayerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LayerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Layer", x => x.LayerID);
                });

            migrationBuilder.CreateTable(
                name: "LeaseContract",
                columns: table => new
                {
                    LeaseContractID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RentName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ContractNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Tenant = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FactoryName = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    ReportName = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Address = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true, comment: "內部 \r\n   外部"),
                    HouseNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    TotalArea = table.Column<double>(type: "float", nullable: true),
                    Rate = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Monthly = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true, comment: "0 在租  1 停租  2 續租"),
                    PayStatus = table.Column<int>(type: "int", nullable: true, comment: "0 未交  1 未交清  2 已交清"),
                    PayYear = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    PayNum = table.Column<double>(type: "float", nullable: true),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Tel = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Notes = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Code = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    File = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaseContract", x => x.LeaseContractID);
                });

            migrationBuilder.CreateTable(
                name: "Links",
                columns: table => new
                {
                    LinkID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LinkName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Url = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Arrangement = table.Column<double>(type: "float", nullable: true),
                    CreatTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Links", x => x.LinkID);
                });

            migrationBuilder.CreateTable(
                name: "List",
                columns: table => new
                {
                    ListID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ListName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    File = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Arrangement = table.Column<double>(type: "float", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_List", x => x.ListID);
                });

            migrationBuilder.CreateTable(
                name: "ListCamera",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: true),
                    IDList = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KVCC = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Area = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    House = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Floor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Position = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Time = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ListCarMer",
                columns: table => new
                {
                    IDCar = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID = table.Column<int>(type: "int", nullable: true),
                    NumberCar = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Weigh = table.Column<int>(type: "int", nullable: true),
                    ImageCar = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ListCarPass",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmpName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Notes = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AreaID = table.Column<int>(type: "int", nullable: true),
                    UnitName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ExtTel = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Mobile = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    BGID = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<int>(type: "int", nullable: true),
                    CompanyID = table.Column<int>(type: "int", nullable: true),
                    TimeApplication = table.Column<DateTime>(type: "datetime", nullable: true),
                    Memo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FileExcel = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListCarPass", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ListMer",
                columns: table => new
                {
                    IdItem = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID = table.Column<int>(type: "int", nullable: true),
                    NameMer = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Unit = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: true),
                    Direct = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Relation = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Image = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CarNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Weight = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListMer", x => x.IdItem);
                });

            migrationBuilder.CreateTable(
                name: "ListOutPL",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TimeOut = table.Column<DateTime>(type: "datetime", nullable: true),
                    IP = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Mac = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Weight = table.Column<int>(type: "int", nullable: true),
                    CarNumber = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ListPosisionCar",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Area = table.Column<int>(type: "int", nullable: true),
                    PossionName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsDeleted = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    LocationName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LocationDetail = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    AreaID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "lodging",
                columns: table => new
                {
                    lodgingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VisitCustID = table.Column<int>(type: "int", nullable: true),
                    lodgingNum = table.Column<int>(type: "int", nullable: true),
                    SingleRoom = table.Column<int>(type: "int", nullable: true),
                    DoubleRoom = table.Column<int>(type: "int", nullable: true),
                    Address = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lodging", x => x.lodgingID);
                });

            migrationBuilder.CreateTable(
                name: "log",
                columns: table => new
                {
                    LogID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminID = table.Column<int>(type: "int", nullable: true),
                    TableName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ID = table.Column<int>(type: "int", nullable: true),
                    OperTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    OperType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Old = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    New = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    IP = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Mac = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LOG", x => x.LogID);
                });

            migrationBuilder.CreateTable(
                name: "MachineIPPairing",
                columns: table => new
                {
                    MachineIPPairingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MachineName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    IP = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    MAC = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    AreaID = table.Column<int>(type: "int", nullable: true),
                    AreaName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "MachineIPPairingInfo",
                columns: table => new
                {
                    MachineName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    IP = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AreaID = table.Column<int>(type: "int", nullable: true),
                    AreaName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "MakeCardArea",
                columns: table => new
                {
                    MakeCardAreaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AreaID = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Meno = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MakeCardArea", x => x.MakeCardAreaID);
                });

            migrationBuilder.CreateTable(
                name: "MakeCardDataError",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false, comment: "證件ID,"),
                    TypeID = table.Column<int>(type: "int", nullable: true, comment: "證件類型,1表車輛通行證,2表客戶駐廠證或駐廠工作證"),
                    ErrorDate = table.Column<DateTime>(type: "datetime", nullable: true, comment: "出錯異常記錄時間"),
                    Meno = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true, comment: "備註"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "MaterialforChemistry",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChemistryFormID = table.Column<int>(type: "int", nullable: false),
                    MaterialID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MaterialName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FireTemp = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Mass = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Amount = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    TotalMass = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    MassofMaterialInStore = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    MassUsingofMaterialeveryday = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    MassofAllMaterialInStore = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    StoreMaxCapacity = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Doccument = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CategoryUnit = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "MaterialforChemistry",
                schema: "faceid",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChemistryFormID = table.Column<int>(type: "int", nullable: false),
                    MaterialID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MaterialName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FireTemp = table.Column<int>(type: "int", nullable: false),
                    Mass = table.Column<double>(type: "float", nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: true),
                    TotalMass = table.Column<double>(type: "float", nullable: true),
                    MassofMaterialInStore = table.Column<double>(type: "float", nullable: true),
                    MassUsingofMaterialeveryday = table.Column<double>(type: "float", nullable: true),
                    MassofAllMaterialInStore = table.Column<double>(type: "float", nullable: true),
                    StoreMaxCapacity = table.Column<double>(type: "float", nullable: true),
                    Doccument = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CategoryUnit = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Meal",
                columns: table => new
                {
                    MealID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VisitCustID = table.Column<int>(type: "int", nullable: true),
                    DiningTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    MealLeavel = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    MealAddress = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    MealCustNum = table.Column<int>(type: "int", nullable: true),
                    AccompanyManagers = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    AccompanyManagers1 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    AccompanyManagers2 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    MealNum = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meal", x => x.MealID);
                });

            migrationBuilder.CreateTable(
                name: "Merchandise",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Area = table.Column<int>(type: "int", nullable: true),
                    Unit = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ApplicationTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    UserTime = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmployeeNo = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true),
                    EmployeeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CarNumber = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    CarType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NameTool = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    EmployeeNoApp = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmployeeNameApp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ExtTel = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true),
                    Notes = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    BG = table.Column<int>(type: "int", nullable: true),
                    ImageIn = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ImageOut = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Secur = table.Column<int>(type: "int", nullable: true),
                    BGID = table.Column<int>(type: "int", nullable: true),
                    Mobile = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Image1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Image2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Image3 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Image4 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ImageInBye = table.Column<byte[]>(type: "image", nullable: true),
                    ImageOutBye = table.Column<byte[]>(type: "image", nullable: true),
                    Image1Bye = table.Column<byte[]>(type: "image", nullable: true),
                    Image2Bye = table.Column<byte[]>(type: "image", nullable: true),
                    Image3Bye = table.Column<byte[]>(type: "image", nullable: true),
                    Image4Bye = table.Column<byte[]>(type: "image", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merchandise", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MerCheProc",
                columns: table => new
                {
                    ProcID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID = table.Column<int>(type: "int", nullable: true),
                    StatusID = table.Column<int>(type: "int", nullable: true),
                    WorkDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Act = table.Column<int>(type: "int", nullable: true),
                    Memo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "MerCheStatus",
                columns: table => new
                {
                    StatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID = table.Column<int>(type: "int", nullable: true),
                    EmpNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmpName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Notes = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Leavel = table.Column<int>(type: "int", nullable: true),
                    Order = table.Column<int>(type: "int", nullable: true),
                    WordTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Para = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Ip = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "MerProc",
                columns: table => new
                {
                    ProcID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID = table.Column<int>(type: "int", nullable: true),
                    StatusID = table.Column<int>(type: "int", nullable: true),
                    Memo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Act = table.Column<int>(type: "int", nullable: true),
                    WorkDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MerProc", x => x.ProcID);
                });

            migrationBuilder.CreateTable(
                name: "MerStatus",
                columns: table => new
                {
                    StatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID = table.Column<int>(type: "int", nullable: true),
                    EmployeeNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmployeeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Notes = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Memo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Emp = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MerStatus", x => x.StatusID);
                });

            migrationBuilder.CreateTable(
                name: "MerTransfer",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Area = table.Column<int>(type: "int", nullable: true),
                    Unit = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Applicationtime = table.Column<DateTime>(type: "datetime", nullable: true),
                    UserTime = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EmployeeNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmployeeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CarNumber = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    CarType = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    NameTool = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EmployeeNoApp = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true),
                    EmployeeNameApp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ExtTel = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Notes = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MerTransfer", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MerTransferProc",
                columns: table => new
                {
                    ProcID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID = table.Column<int>(type: "int", nullable: true),
                    StatusID = table.Column<int>(type: "int", nullable: true),
                    Act = table.Column<int>(type: "int", nullable: true),
                    WordDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Memo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "MerTrasferStatus",
                columns: table => new
                {
                    StatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID = table.Column<int>(type: "int", nullable: true),
                    EmpNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmpName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Notes = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Leavel = table.Column<int>(type: "int", nullable: true),
                    Over = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Memo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    WorkTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Para = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Message",
                columns: table => new
                {
                    MessageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MessageTypeID = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Cotent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Arrangement = table.Column<double>(type: "float", nullable: true),
                    CreatTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Message", x => x.MessageID);
                });

            migrationBuilder.CreateTable(
                name: "MessageType",
                columns: table => new
                {
                    MessageTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MessageType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsDleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    Type = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessageType", x => x.MessageTypeID);
                });

            migrationBuilder.CreateTable(
                name: "MessSenLog",
                columns: table => new
                {
                    MessID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TimeSend = table.Column<DateTime>(type: "datetime", nullable: true),
                    Url = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    ID = table.Column<int>(type: "int", nullable: true),
                    FormID = table.Column<int>(type: "int", nullable: true),
                    EmpNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    FormType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    EmpName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TimeAdd = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "MfCarRental",
                columns: table => new
                {
                    MfCarRentalID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CredentalsNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MfAddress = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Contacter = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ContacterPhone = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MfCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CarNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Category = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Brand = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Color = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Number = table.Column<int>(type: "int", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Enddate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MfCarRental", x => x.MfCarRentalID);
                });

            migrationBuilder.CreateTable(
                name: "mqq",
                columns: table => new
                {
                    NO = table.Column<double>(type: "float", nullable: true),
                    areaid = table.Column<double>(type: "float", nullable: true),
                    regionname = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    region = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    buildingname = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    layer = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    F7 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    F8 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    F9 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    F10 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "mqq1",
                columns: table => new
                {
                    AreaRegionid = table.Column<double>(type: "float", nullable: true),
                    Buildingid = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "mqq3",
                columns: table => new
                {
                    RegionHouseID = table.Column<double>(type: "float", nullable: true),
                    LayerID = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "NighAction",
                columns: table => new
                {
                    IDNight = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID = table.Column<int>(type: "int", nullable: true),
                    NameContrucs = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NameVendor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UnitApplication = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Area = table.Column<int>(type: "int", nullable: true),
                    ContenAction = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Office = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TimeAplication = table.Column<DateTime>(type: "datetime", nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    EmpNoApp = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmpNameApp = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NotesApp = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ExtTel = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    UnitAuditNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    UnitAuditName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UnitAuditTC = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    UnitAuditTel = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    VendorAuditName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    VendorAuditTC = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    VendorAuditTel = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<int>(type: "int", nullable: true),
                    Zone = table.Column<int>(type: "int", nullable: true),
                    Normal = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Special = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NameRes = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    TelRes = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    IsAsse = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "NotesSendLog",
                columns: table => new
                {
                    NotesLogId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NotesTypeName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ID = table.Column<int>(type: "int", nullable: true),
                    FormstatusID = table.Column<int>(type: "int", nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsBodyHtml = table.Column<bool>(type: "bit", nullable: true),
                    ReturnReceipt = table.Column<bool>(type: "bit", nullable: true),
                    FromDisplayName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true, defaultValueSql: "('FOXCONN110')"),
                    ToAddressList = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    CCAddressList = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    BCCAddressList = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    Result = table.Column<string>(type: "varchar(800)", unicode: false, maxLength: 800, nullable: true, defaultValueSql: "('未發送')"),
                    SendTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    SysTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    FormName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Url = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NOTESSENDLOG", x => x.NotesLogId);
                });

            migrationBuilder.CreateTable(
                name: "nvipcard_From165",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    cardno = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ecardno = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    carid = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    cardname = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    tel = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    depart = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    msrepltranversion = table.Column<Guid>(name: "msrepl_tran_version", type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OndutyForATTW_Approve",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateSign = table.Column<DateTime>(type: "date", nullable: true),
                    AreaID = table.Column<int>(type: "int", nullable: true),
                    NameCheck = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    TimeUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Frametime = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OndutyForATTW_ListAuthor",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmpName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Notes = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ParaCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DateCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsDeleted = table.Column<int>(type: "int", nullable: true),
                    DeleteTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    AreaID = table.Column<int>(type: "int", nullable: true),
                    Sort = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OndutyForAttw_ListLocations",
                columns: table => new
                {
                    LocationID = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<int>(type: "int", nullable: true),
                    LocationAbrevationName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    LocationDetailName = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    AreaID = table.Column<int>(type: "int", nullable: true),
                    X = table.Column<int>(type: "int", nullable: true),
                    Y = table.Column<int>(type: "int", nullable: true),
                    Isdeleted = table.Column<int>(type: "int", nullable: true),
                    latitude = table.Column<double>(type: "float", nullable: true),
                    longitude = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OndutyForAttw_ListLocations", x => x.LocationID);
                });

            migrationBuilder.CreateTable(
                name: "OndutyForAttw_ListLocationsSign",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OndutyOfAttwDepartID = table.Column<int>(type: "int", nullable: true),
                    FrameTime = table.Column<int>(type: "int", nullable: true),
                    LocationID = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Image = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsOke = table.Column<int>(type: "int", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    TimeCheck = table.Column<DateTime>(type: "datetime", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true),
                    Isdelete = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OndutyForAttw_RulesForAllLocation",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<int>(type: "int", nullable: true),
                    RuleID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    RuleDetailName = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    LocationID = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Timeupdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Isdeleted = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OndutyForATTW_StatusSign",
                columns: table => new
                {
                    StatusID = table.Column<int>(type: "int", nullable: true),
                    ID = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    EmpNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Memo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    WorkTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Sort = table.Column<int>(type: "int", nullable: true),
                    Leavel = table.Column<int>(type: "int", nullable: true),
                    ParaCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EmpName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Notes = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OndutyListLocations",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationID = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    LocationAbrevationName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    LocationDetailName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    AreaID = table.Column<int>(type: "int", nullable: true),
                    X = table.Column<int>(type: "int", nullable: true),
                    Y = table.Column<int>(type: "int", nullable: true),
                    Isdeleted = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OndutyOfAttwDepart",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<int>(type: "int", nullable: true),
                    DateSing = table.Column<DateTime>(type: "date", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    AreaID = table.Column<int>(type: "int", nullable: true),
                    EmpNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EmpName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    FrameTime = table.Column<int>(type: "int", nullable: true),
                    Isdeleted = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OndutyOfAttwDepart_FrameTime",
                columns: table => new
                {
                    FrameID = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: true),
                    StartTime = table.Column<TimeSpan>(type: "time(0)", nullable: false),
                    EndTime = table.Column<TimeSpan>(type: "time(0)", nullable: true),
                    DatetimeUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    FrameTimeName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Isdeleted = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OndutyOfAttwDepart_FrameTime", x => x.FrameID);
                });

            migrationBuilder.CreateTable(
                name: "OndutySign",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<int>(type: "int", nullable: true),
                    DateSign = table.Column<DateTime>(type: "date", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    AreaID = table.Column<int>(type: "int", nullable: true),
                    EmpNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EmpName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    BGID = table.Column<int>(type: "int", nullable: true),
                    BGName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    StartTimeValid = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndTimeValid = table.Column<DateTime>(type: "datetime", nullable: true),
                    Isdeleted = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OndutySign_Area",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AreaID = table.Column<int>(type: "int", nullable: true),
                    AreaName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    AreaShortName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ListIndex = table.Column<int>(type: "int", nullable: true),
                    Isdeleted = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OndutySign_LocationSign",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OndutySignID = table.Column<int>(type: "int", nullable: true),
                    EmpNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EmpName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Image = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    LocationID = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    TimeSign = table.Column<DateTime>(type: "datetime", nullable: true),
                    Isdeleted = table.Column<int>(type: "int", nullable: true),
                    ReceivedEmpNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ReceivedTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    ReceivedStatus = table.Column<int>(type: "int", nullable: true),
                    DepartMentName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OndutySign_LocationSign_HistoryAll",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OndutySignID = table.Column<int>(type: "int", nullable: true),
                    EmpNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EmpName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Image = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    LocationID = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    TimeSign = table.Column<DateTime>(type: "datetime", nullable: true),
                    Isdeleted = table.Column<int>(type: "int", nullable: true),
                    ReceivedEmpNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ReceivedTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    ReceivedStatus = table.Column<int>(type: "int", nullable: true),
                    DepartMentName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OndutySignForAttw_Area",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AreaID = table.Column<int>(type: "int", nullable: true),
                    AreaName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    AreaShortName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ListIndex = table.Column<int>(type: "int", nullable: true),
                    Isdeleted = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OndutySignOfAttw_ListEmpNo",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EmpName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    TimeUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Isdeleted = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "othercar",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Companyname = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    carnumber = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    cartype = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    carcolor = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    drivername = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    driverphone = table.Column<double>(type: "float", nullable: true),
                    documentsnum = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OtherCarInfo",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CompanyName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CarNumber = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CarType = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CarColor = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DriverName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DriverPhone = table.Column<double>(type: "float", nullable: true),
                    DocumentsNum = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ParkProfileChart",
                columns: table => new
                {
                    ParkProfileID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParkProfileName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ParkProfileArea = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ParkProfileData = table.Column<int>(type: "int", nullable: true),
                    ParkProfileTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    ParkprofileStandby = table.Column<int>(type: "int", nullable: true),
                    ParkprofileCreateTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkProfileChart", x => x.ParkProfileID);
                });

            migrationBuilder.CreateTable(
                name: "PassForm",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormID = table.Column<int>(type: "int", nullable: true),
                    PartPass = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PassTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Ip = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Sta = table.Column<int>(type: "int", nullable: true),
                    CategoryID = table.Column<int>(type: "int", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "PeoPleList",
                columns: table => new
                {
                    IDList = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    EmpName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    IDNo = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    CreType = table.Column<int>(type: "int", nullable: true),
                    IDCreType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FileCreType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IDPre = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    FilePre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Memo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IDATLD = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ImageATLD = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ImagePeople = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeoPleList", x => x.IDList);
                });

            migrationBuilder.CreateTable(
                name: "PersonalDocuments",
                columns: table => new
                {
                    PersonalDocumentsGUID = table.Column<string>(type: "varchar(36)", unicode: false, maxLength: 36, nullable: false, defaultValueSql: "(newid())"),
                    PersonalDocumentsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardType = table.Column<int>(type: "int", nullable: false),
                    CardID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IDCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Sex = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    Nation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Birthday = table.Column<DateTime>(type: "datetime", nullable: true),
                    ValidDate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DepartMent = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    BitImage = table.Column<byte[]>(type: "image", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    Creator = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: true),
                    EditTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Editor = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: true),
                    DeleteTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Deletor = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: true),
                    XSZType = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((-1))", comment: "行駛證類型：0行駛證反面，1小型車，其它為行駛證正面，默認為2：>0都是正面,-1不是行駛證類型"),
                    XSZGUID = table.Column<string>(type: "varchar(36)", unicode: false, maxLength: 36, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalDocuments_1", x => x.PersonalDocumentsGUID);
                });

            migrationBuilder.CreateTable(
                name: "PersonalItem_Images",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersionalID = table.Column<int>(type: "int", nullable: true),
                    Image = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "PersonalItem_ListItems",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonItemsFormID = table.Column<int>(type: "int", nullable: false),
                    ItemsName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: true),
                    Reason = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "PersonalItems_Authority",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorityID = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    DepartMentSNID = table.Column<int>(type: "int", nullable: true),
                    EmployeeID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EmployeeNameT = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AreaID = table.Column<int>(type: "int", nullable: true),
                    Isdeleted = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "PersonalItems_SigStatus",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonalItemsFormID = table.Column<int>(type: "int", nullable: true),
                    SignerID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    SignerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    LevelSigne = table.Column<double>(type: "float", nullable: true),
                    Meno = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    TimeSigne = table.Column<DateTime>(type: "datetime", nullable: true),
                    Ip = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "PersonalItemsForm",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryType = table.Column<int>(type: "int", nullable: true),
                    Building = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    RoomNumber = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    BedNumber = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    TimeUse = table.Column<DateTime>(type: "datetime", nullable: true),
                    EmployeeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EmployeeID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    RoomMateName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RoomMateID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    KeyReturn = table.Column<int>(type: "int", nullable: true),
                    AssetReturn = table.Column<int>(type: "int", nullable: true),
                    ApplicationTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    TimePassKt = table.Column<DateTime>(type: "datetime", nullable: true),
                    TimePassMajorPart = table.Column<DateTime>(type: "datetime", nullable: true),
                    AreaID = table.Column<int>(type: "int", nullable: true),
                    Applicant = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    DocFile = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Isdeleted = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "PhotoIDMatch",
                columns: table => new
                {
                    PhotoIDMatchID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeID = table.Column<int>(type: "int", nullable: false),
                    ID = table.Column<int>(type: "int", nullable: false),
                    PhotoID = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhotoIDMatch", x => x.PhotoIDMatchID);
                });

            migrationBuilder.CreateTable(
                name: "PLApplication",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BGID = table.Column<int>(type: "int", nullable: true),
                    AreaID = table.Column<int>(type: "int", nullable: true),
                    ApplicationTime = table.Column<int>(type: "int", nullable: true),
                    BU = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EmpNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmpName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Notes = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PhoneNumber = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "PLList",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodePL = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    NamePL = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Unit = table.Column<string>(type: "char(20)", unicode: false, fixedLength: true, maxLength: 20, nullable: true),
                    IsDeleted = table.Column<int>(type: "int", nullable: true),
                    BGID = table.Column<int>(type: "int", nullable: true),
                    SpecificWeight = table.Column<int>(type: "int", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true),
                    AreaID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "PLListOut",
                columns: table => new
                {
                    IDList = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDPL = table.Column<int>(type: "int", nullable: true),
                    IDCode = table.Column<int>(type: "int", nullable: true),
                    Weights = table.Column<int>(type: "int", nullable: true),
                    Image = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TimeUp = table.Column<DateTime>(type: "datetime", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true),
                    BagID = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    WeightPerson = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PLListOut", x => x.IDList);
                });

            migrationBuilder.CreateTable(
                name: "PLListOut_ProtectorReset",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDPL = table.Column<int>(type: "int", nullable: true),
                    IP = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TimeReset = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PLListOut_ProtectorReset", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PLListValid",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodePL = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    NamePL = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Unit = table.Column<string>(type: "char(20)", unicode: false, fixedLength: true, maxLength: 20, nullable: true),
                    IsDeleted = table.Column<int>(type: "int", nullable: true),
                    BGID = table.Column<int>(type: "int", nullable: true),
                    SpecificWeight = table.Column<int>(type: "int", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true),
                    AreaID = table.Column<int>(type: "int", nullable: true),
                    IDList = table.Column<int>(type: "int", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    OldID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "PosisionCarVip",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AreaID = table.Column<int>(type: "int", nullable: true),
                    PosisionName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsDeleted = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "PossionCar",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitApplication = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EmployeeNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Tel = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    TimeApplication = table.Column<DateTime>(type: "datetime", nullable: true),
                    Unit = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TimeIn = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    TimeOut = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    AreaID = table.Column<int>(type: "int", nullable: true),
                    PossionCar = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NumberCar = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Notes = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AppEmpNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    AppEmpName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PossionCar", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PowerAdmin",
                columns: table => new
                {
                    PowerAdminID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminID = table.Column<int>(type: "int", nullable: true),
                    PowerListID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PowerAdmin", x => x.PowerAdminID);
                });

            migrationBuilder.CreateTable(
                name: "PowerList",
                columns: table => new
                {
                    PowerListID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PowerName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PowerNum = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PowerList", x => x.PowerListID);
                });

            migrationBuilder.CreateTable(
                name: "PowerRole",
                columns: table => new
                {
                    PowerRoleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminRoleID = table.Column<int>(type: "int", nullable: true),
                    PowerListID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PowerRole", x => x.PowerRoleID);
                });

            migrationBuilder.CreateTable(
                name: "PrintCard",
                columns: table => new
                {
                    IDPrint = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NamePrint = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TimePrint = table.Column<DateTime>(type: "datetime", nullable: true),
                    ID = table.Column<int>(type: "int", nullable: true),
                    TypeCard = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ProcessCarPass",
                columns: table => new
                {
                    IDPress = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID = table.Column<int>(type: "int", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Leavel = table.Column<int>(type: "int", nullable: true),
                    Sort = table.Column<int>(type: "int", nullable: true),
                    WorkDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Memo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    IP = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ParaCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EmpNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmpName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FormID = table.Column<int>(type: "int", nullable: true),
                    RoleName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcessCarPass", x => x.IDPress);
                });

            migrationBuilder.CreateTable(
                name: "ProcMer",
                columns: table => new
                {
                    ProcID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusID = table.Column<int>(type: "int", nullable: true),
                    ID = table.Column<int>(type: "int", nullable: true),
                    Memo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Act = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcMer", x => x.ProcID);
                });

            migrationBuilder.CreateTable(
                name: "ProductOpportunities",
                columns: table => new
                {
                    ProductOppID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductOpportunitiesName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUCTOPPORTUNITIES", x => x.ProductOppID);
                });

            migrationBuilder.CreateTable(
                name: "ProductOpportunitiesCust",
                columns: table => new
                {
                    ProductOpportunitiesCustID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductOppID = table.Column<int>(type: "int", nullable: true),
                    VisitCustID = table.Column<int>(type: "int", nullable: true),
                    Other = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductOpportunitiesCust", x => x.ProductOpportunitiesCustID);
                });

            migrationBuilder.CreateTable(
                name: "Profier2013051010",
                columns: table => new
                {
                    RowNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventClass = table.Column<int>(type: "int", nullable: true),
                    TextData = table.Column<string>(type: "ntext", nullable: true),
                    ApplicationName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    NTUserName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    LoginName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    CPU = table.Column<int>(type: "int", nullable: true),
                    Reads = table.Column<long>(type: "bigint", nullable: true),
                    Writes = table.Column<long>(type: "bigint", nullable: true),
                    Duration = table.Column<long>(type: "bigint", nullable: true),
                    ClientProcessID = table.Column<int>(type: "int", nullable: true),
                    SPID = table.Column<int>(type: "int", nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    BinaryData = table.Column<byte[]>(type: "image", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Profier201305101__5F0DF06A", x => x.RowNumber);
                });

            migrationBuilder.CreateTable(
                name: "Profiler2013050922",
                columns: table => new
                {
                    RowNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventClass = table.Column<int>(type: "int", nullable: true),
                    TextData = table.Column<string>(type: "ntext", nullable: true),
                    ApplicationName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    NTUserName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    LoginName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    CPU = table.Column<int>(type: "int", nullable: true),
                    Reads = table.Column<long>(type: "bigint", nullable: true),
                    Writes = table.Column<long>(type: "bigint", nullable: true),
                    Duration = table.Column<long>(type: "bigint", nullable: true),
                    ClientProcessID = table.Column<int>(type: "int", nullable: true),
                    SPID = table.Column<int>(type: "int", nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    BinaryData = table.Column<byte[]>(type: "image", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Profiler20130509__5C3183BF", x => x.RowNumber);
                });

            migrationBuilder.CreateTable(
                name: "QiMeiEmployeeExamine",
                columns: table => new
                {
                    TWEmployeeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BG = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    BU = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Dept = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EmployeeNO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Sex = table.Column<bool>(type: "bit", nullable: false),
                    Leavel = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Post = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Code = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Legal = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    EnterDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    WhetherJob = table.Column<bool>(type: "bit", nullable: false),
                    Source = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QiMeiEmployeeExamine", x => x.TWEmployeeID);
                });

            migrationBuilder.CreateTable(
                name: "QiMeiTwEmloyeeUpdate",
                columns: table => new
                {
                    Dept = table.Column<string>(type: "varchar(120)", unicode: false, maxLength: 120, nullable: true),
                    EnterDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EmployeeNO = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    WhetherJob = table.Column<string>(type: "varchar(46)", unicode: false, maxLength: 46, nullable: true),
                    XingShi = table.Column<string>(type: "varchar(120)", unicode: false, maxLength: 120, nullable: true),
                    MingZi = table.Column<string>(type: "varchar(120)", unicode: false, maxLength: 120, nullable: true),
                    Sex = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    Post = table.Column<string>(type: "varchar(180)", unicode: false, maxLength: 180, nullable: true),
                    Leavel = table.Column<string>(type: "varchar(36)", unicode: false, maxLength: 36, nullable: true),
                    Code = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: true),
                    Legal = table.Column<string>(type: "varchar(120)", unicode: false, maxLength: 120, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "QuitApply",
                columns: table => new
                {
                    QuitApplyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Company = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Department = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ApplyPeople = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CredNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ApplyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Annex = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuitApply", x => x.QuitApplyID);
                });

            migrationBuilder.CreateTable(
                name: "ReceivingCarPass",
                columns: table => new
                {
                    ReceiveID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardID = table.Column<int>(type: "int", nullable: true),
                    ReceivePeople = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Phone = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ReceiveTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    AdminID = table.Column<int>(type: "int", nullable: true),
                    CredentialsNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceivingCarPass", x => x.ReceiveID);
                });

            migrationBuilder.CreateTable(
                name: "ReceivingRecords",
                columns: table => new
                {
                    ReceiveID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardID = table.Column<int>(type: "int", nullable: true),
                    ReceivePeople = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Phone = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ReceiveTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    AdminID = table.Column<int>(type: "int", nullable: true),
                    CredentialsNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RECEIVINGRECORDS", x => x.ReceiveID);
                });

            migrationBuilder.CreateTable(
                name: "ReceptionProgram",
                columns: table => new
                {
                    ReceptionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VisitNotCustID = table.Column<int>(type: "int", nullable: false),
                    ReceptionTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    ReceptionContent = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ReceptionPeople = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Position = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RECEPTIONPROGRAM", x => x.ReceptionID);
                });

            migrationBuilder.CreateTable(
                name: "ReceptionProgramGovernment",
                columns: table => new
                {
                    ReceptionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReceptionTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    ReceptionPlace = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    ReceptionPosition = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ReceptionManagePosition = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true),
                    VisitGListID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RECEPTIONPROGRAMGOVERNMENT", x => x.ReceptionID);
                });

            migrationBuilder.CreateTable(
                name: "Region",
                columns: table => new
                {
                    RegionID = table.Column<long>(type: "bigint", nullable: true),
                    RegionName = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "RegionHouse",
                columns: table => new
                {
                    RegionHouseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AreaRegionID = table.Column<int>(type: "int", nullable: true),
                    BuildingID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegionHouse", x => x.RegionHouseID);
                });

            migrationBuilder.CreateTable(
                name: "RemandRecords",
                columns: table => new
                {
                    RemandID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardID = table.Column<int>(type: "int", nullable: true),
                    Dept = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Phone = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Reasons = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    RemandTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    AdminID = table.Column<int>(type: "int", nullable: false),
                    QuitApplyID = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Request114",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<int>(type: "int", nullable: true),
                    EmpNoApp = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmpNameApp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UnitApp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ExTel = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Mobile = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    NotesApp = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Posision = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BuCode = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ApplicationTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    AreaID = table.Column<int>(type: "int", nullable: true),
                    BGID = table.Column<int>(type: "int", nullable: true),
                    ContentRequest = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Request114Sign",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmpName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Notes = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Sort = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Order = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "RequestProc114",
                columns: table => new
                {
                    ProcID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusID = table.Column<int>(type: "int", nullable: true),
                    ID = table.Column<int>(type: "int", nullable: true),
                    EmpNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmpName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ParaCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Notes = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Sort = table.Column<int>(type: "int", nullable: true),
                    Order = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    WorkTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Memo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IP = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "RequestStatus114",
                columns: table => new
                {
                    StatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID = table.Column<int>(type: "int", nullable: true),
                    EmpNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmpName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ParaCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Notes = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Sort = table.Column<int>(type: "int", nullable: true),
                    Order = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    WorkTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Memo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IP = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SchedulePlan",
                columns: table => new
                {
                    ScheduleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VisitCustID = table.Column<int>(type: "int", nullable: false),
                    ScheduleTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Dept = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    VisitLeavel = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ReceptionPeople = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    VisitStress = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Preparation = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SCHEDULEPLAN", x => x.ScheduleID);
                });

            migrationBuilder.CreateTable(
                name: "ScrapCar",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateEmpID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CreateName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    BgID = table.Column<int>(type: "int", nullable: true),
                    CreatePhoneNum = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    StartTimeValid = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndTimeValid = table.Column<DateTime>(type: "datetime", nullable: true),
                    AreaID = table.Column<int>(type: "int", nullable: true),
                    LocationDetail = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    CardNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CarNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DriverName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DriverID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CarWeightsOld = table.Column<int>(type: "int", nullable: true),
                    CarWeight = table.Column<int>(type: "int", nullable: true),
                    CardChange = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    DateTimeIn = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ScrapCar_GaReject",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDPL = table.Column<int>(type: "int", nullable: true),
                    EmpNoID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Notes = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Ip = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScrapCar_GaReject", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ScrapCar_HistoryCheckPass",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDPL = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Type = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PartPass = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Passtime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Weight = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ScrapCarAuthority",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScrapAuthorityID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    BgID = table.Column<int>(type: "int", nullable: true),
                    EmpID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EmpNameV = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    EmpNameT = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    AreaID = table.Column<int>(type: "int", nullable: true),
                    Isdeleted = table.Column<int>(type: "int", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Endtime = table.Column<DateTime>(type: "datetime", nullable: true),
                    EmpNoUpdate = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    notes = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: true),
                    ParaCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    RuleName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ScrapCarContructor_Authority",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorityID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    BGID = table.Column<int>(type: "int", nullable: true),
                    EmpLoyeeNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EmLoyeeNameV = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ZaloID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AreaID = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<int>(type: "int", nullable: true),
                    Isdeleted = table.Column<int>(type: "int", nullable: true),
                    Notes = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    NameAbevation = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ScrapCarIn",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateEmpID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CreateName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreateDepartment = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    CreaatePhoneNum = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CreateEmail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    StartTimeValid = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndTimeValid = table.Column<DateTime>(type: "datetime", nullable: true),
                    AreaID = table.Column<int>(type: "int", nullable: true),
                    DetailLocation = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CardNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CarNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DriverName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DriverID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Weights = table.Column<int>(type: "int", nullable: true),
                    WeightsOld = table.Column<int>(type: "int", nullable: true),
                    CardChange = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CarImage01 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    WeightsImage01 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DatetimeUse = table.Column<DateTime>(type: "datetime", nullable: true),
                    DatetimeUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    PartPass = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BGID = table.Column<int>(type: "int", nullable: true),
                    PartParaCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    HasRejected = table.Column<int>(type: "int", nullable: true),
                    DayType = table.Column<int>(type: "int", nullable: true),
                    ScrapCarContructorID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ScrapContructorIn",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CreateID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CreatePhoneNum = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ContructorName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    TimeUse = table.Column<DateTime>(type: "date", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    AreaID = table.Column<int>(type: "int", nullable: true),
                    BgId = table.Column<int>(type: "int", nullable: true),
                    CarCount = table.Column<int>(type: "int", nullable: true),
                    ContructorID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DatetimeSign = table.Column<DateTime>(type: "datetime", nullable: true),
                    IpSign = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Isdeleted = table.Column<int>(type: "int", nullable: true),
                    NoteSign = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    CreateEmail = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ScrapContructorIn_ListDriver",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScrapContructorID = table.Column<int>(type: "int", nullable: true),
                    CarNumber = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    DriverName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DriverID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CardNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ScrapInconstant",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDPL = table.Column<int>(type: "int", nullable: true),
                    FileInc = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    TimeApplication = table.Column<DateTime>(type: "datetime", nullable: true),
                    WeightInc = table.Column<int>(type: "int", nullable: true),
                    EmpNoApp = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmpNameApp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Memo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScrapInconstant", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ScrapInconstantAuthor",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmpName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Notes = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Role = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Isdeleted = table.Column<int>(type: "int", nullable: true),
                    TimeAdd = table.Column<DateTime>(type: "datetime", nullable: true),
                    TimeDelete = table.Column<DateTime>(type: "datetime", nullable: true),
                    Leavel = table.Column<int>(type: "int", nullable: true),
                    Sort = table.Column<int>(type: "int", nullable: true),
                    AreaID = table.Column<int>(type: "int", nullable: true),
                    BGID = table.Column<int>(type: "int", nullable: true),
                    ParaCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ScrapList",
                columns: table => new
                {
                    IDList = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID = table.Column<int>(type: "int", nullable: true),
                    PLCode = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    PLName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Unit = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ScrapOut",
                columns: table => new
                {
                    IDPL = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    IDIN = table.Column<int>(type: "int", nullable: true),
                    ImageScrap = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<int>(type: "int", nullable: true),
                    UserTime = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Image1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Image2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Image3 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Image4 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FilePdf = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    StartTimePutToScale = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndTimePutToScalse = table.Column<DateTime>(type: "datetime", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ScrapOutProc",
                columns: table => new
                {
                    ProcID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusID = table.Column<int>(type: "int", nullable: true),
                    IDPL = table.Column<int>(type: "int", nullable: true),
                    Act = table.Column<int>(type: "int", nullable: true),
                    Memo = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    WorkDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    FormID = table.Column<int>(type: "int", nullable: true),
                    RuleName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Ip = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ScrapOutStatus",
                columns: table => new
                {
                    StatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDPL = table.Column<int>(type: "int", nullable: true),
                    EmpNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmpName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Notes = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ParaCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Leavel = table.Column<int>(type: "int", nullable: true),
                    Memo = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    WorkDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    FormID = table.Column<int>(type: "int", nullable: true),
                    Sort = table.Column<int>(type: "int", nullable: true),
                    Ip = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    RuleName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SecuretyTable",
                columns: table => new
                {
                    SecuretyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormType = table.Column<int>(type: "int", nullable: true),
                    ID = table.Column<int>(type: "int", nullable: true),
                    EmployeeNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmployeeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TimeIn = table.Column<DateTime>(type: "datetime", nullable: true),
                    Memo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SecurityError",
                columns: table => new
                {
                    IDEr = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID = table.Column<int>(type: "int", nullable: true),
                    NameEr = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    TimeEr = table.Column<DateTime>(type: "datetime", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    PeopleWork = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PosisionErr = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    SecurityName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ApplicationTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SecurityInfor",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    IDPeople = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    BirthDay = table.Column<DateTime>(type: "datetime", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: true),
                    DateIn = table.Column<DateTime>(type: "datetime", nullable: true),
                    PosisionWork = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CompanyName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    AreaID = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<int>(type: "int", nullable: true),
                    FileAtt = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PhoneNumber = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SecurityList",
                columns: table => new
                {
                    SecurityListID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AreaID = table.Column<int>(type: "int", nullable: true),
                    AccidentPeople = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AccidentTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    AccidentDept = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AccidentPlace = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    AccidentTypeID = table.Column<int>(type: "int", nullable: true),
                    Information = table.Column<string>(type: "varchar(2000)", unicode: false, maxLength: 2000, nullable: true),
                    AccidentContent = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    DealType = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Progress = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    ResponsePeople = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    Fileupload = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    BG = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecurityList", x => x.SecurityListID);
                });

            migrationBuilder.CreateTable(
                name: "SecurityProcess",
                columns: table => new
                {
                    IDSol = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDEr = table.Column<int>(type: "int", nullable: true),
                    SolutionName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Purpose = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Forfeit = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SecurityReport",
                columns: table => new
                {
                    SecurityReportID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AreaID = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    SignName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    SignMail = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    SignTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    SignMeno = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecurityReport", x => x.SecurityReportID);
                });

            migrationBuilder.CreateTable(
                name: "SecurityReportSigner",
                columns: table => new
                {
                    SecurityReportSignerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SignEmployeeNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    SignName = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Meno = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecurityReportSigner", x => x.SecurityReportSignerID);
                });

            migrationBuilder.CreateTable(
                name: "SecurityTrain",
                columns: table => new
                {
                    IDTr = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID = table.Column<int>(type: "int", nullable: true),
                    TimeTrain = table.Column<DateTime>(type: "datetime", nullable: true),
                    TrainContent = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PeopleTrain = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SeMerTransfer",
                columns: table => new
                {
                    SeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID = table.Column<int>(type: "int", nullable: true),
                    EmpName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TimeOut = table.Column<DateTime>(type: "datetime", nullable: true),
                    TimeIn = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SendSMS",
                columns: table => new
                {
                    SendSMSID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Content = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SendFlag = table.Column<int>(type: "int", nullable: true),
                    SendFlagMemo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SerialNumber",
                columns: table => new
                {
                    SerialNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    TypeID = table.Column<int>(type: "int", nullable: false),
                    ID = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Sheet1$",
                columns: table => new
                {
                    Arearegionid = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    type = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    meno = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ShuttleVisitors",
                columns: table => new
                {
                    ShuttleVisitorsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VisitCustID = table.Column<int>(type: "int", nullable: true),
                    ShuttleTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    ShuttleStartTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    ShuttleEndTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    StartJourney = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Destination = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ShuttlePeople = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ShuttleNum = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SHUTTLEVISITORS", x => x.ShuttleVisitorsID);
                });

            migrationBuilder.CreateTable(
                name: "SignLog",
                columns: table => new
                {
                    SignLogID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormstatusID = table.Column<int>(type: "int", nullable: true),
                    SignDae = table.Column<DateTime>(type: "datetime", nullable: true),
                    SignResult = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Meno = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    RollbackID = table.Column<int>(type: "int", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignLog", x => x.SignLogID);
                });

            migrationBuilder.CreateTable(
                name: "SignProcess",
                columns: table => new
                {
                    SignProcessID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    EmployeeNO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    SignTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    SignAct = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    SignMeno = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    ID = table.Column<int>(type: "int", nullable: true),
                    TypeID = table.Column<int>(type: "int", nullable: false),
                    IsUnderWriteFlow = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    RoleName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SIGNPROCESS", x => x.SignProcessID);
                });

            migrationBuilder.CreateTable(
                name: "SignRole",
                columns: table => new
                {
                    SignRoleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormType = table.Column<int>(type: "int", nullable: true),
                    RoleName = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    RoleEmp = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Notes = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EmployeeNO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignRole", x => x.SignRoleID);
                });

            migrationBuilder.CreateTable(
                name: "SignStatus",
                columns: table => new
                {
                    SignStatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<int>(type: "int", nullable: true),
                    ID = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    EmployeeNO = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    SignTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    SignPicture = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Meno = table.Column<string>(type: "varchar(600)", unicode: false, maxLength: 600, nullable: true),
                    RandomNum = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SIGNSTATUS", x => x.SignStatusID);
                });

            migrationBuilder.CreateTable(
                name: "SigStatusChemistry",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChemistryFormID = table.Column<int>(type: "int", nullable: false),
                    Category = table.Column<int>(type: "int", nullable: true),
                    SignerID = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    LevelSigne = table.Column<double>(type: "float", nullable: true),
                    Meno = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    SignerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SignedStDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SignerNameV = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Ip = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SigStatusChemistry",
                schema: "faceid",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChemistryFormID = table.Column<int>(type: "int", nullable: false),
                    Category = table.Column<int>(type: "int", nullable: true),
                    SignerID = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    LevelSigne = table.Column<double>(type: "float", nullable: true),
                    Meno = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    SignerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SignedStDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SpareCar",
                columns: table => new
                {
                    SpareCarID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarNumber = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    DriverName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Tel = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    AreaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpareCar", x => x.SpareCarID);
                });

            migrationBuilder.CreateTable(
                name: "StatusMer",
                columns: table => new
                {
                    StatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID = table.Column<int>(type: "int", nullable: true),
                    EmployeeNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmployeeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Notes = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    status = table.Column<int>(type: "int", nullable: true),
                    Memo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusMer", x => x.StatusID);
                });

            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    VendorCode = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    NChNName = table.Column<string>(name: "N_ChNName", type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    BitImage = table.Column<byte[]>(type: "image", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Temp_Contact",
                columns: table => new
                {
                    PID = table.Column<int>(type: "int", nullable: true),
                    ZID = table.Column<int>(type: "int", nullable: true),
                    ContactPeople = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ContactBG = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ContactUnitExtension = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ContactPhone = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NewAddress = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NewApplyPhone = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EmergencyContact = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EmergencyPhone = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Test_table",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sdt = table.Column<int>(type: "int", nullable: true),
                    Mathe = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Thoigian = table.Column<DateTime>(type: "datetime", nullable: true),
                    Diachi = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Memo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Test_Table_Sentdata1",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsCoppy = table.Column<int>(type: "int", nullable: true),
                    data = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    dataDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Test_Table_Sentdata2",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    data = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TestUploadImage",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestImage = table.Column<byte[]>(type: "image", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ToPrint",
                columns: table => new
                {
                    ToPrintID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeID = table.Column<int>(type: "int", nullable: true),
                    ID = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    SignAction = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SignDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ApplyMeno = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    SignMeno = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToPrint", x => x.ToPrintID);
                });

            migrationBuilder.CreateTable(
                name: "TotalType",
                columns: table => new
                {
                    TypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    Meno = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TotalType", x => x.TypeID);
                });

            migrationBuilder.CreateTable(
                name: "TroubleImage",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDTrouble = table.Column<int>(type: "int", nullable: true),
                    ImageTrouble = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TroubleType",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TroubleNameVN = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TroubleNameCN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsDeleted = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TT_Corona2019ByBG",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AreaID = table.Column<int>(type: "int", nullable: true),
                    Area = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Date = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Nhiem = table.Column<int>(type: "int", nullable: true),
                    Sot = table.Column<int>(type: "int", nullable: true),
                    Namvien = table.Column<int>(type: "int", nullable: true),
                    Ravien = table.Column<int>(type: "int", nullable: true),
                    TheodoiKTX = table.Column<int>(type: "int", nullable: true),
                    RaKTX = table.Column<int>(type: "int", nullable: true),
                    BGid = table.Column<int>(type: "int", nullable: true),
                    DVSN = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TT_DichCorona2020",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Nhiem = table.Column<int>(type: "int", nullable: true),
                    Sot = table.Column<int>(type: "int", nullable: true),
                    Namvien = table.Column<int>(type: "int", nullable: true),
                    Ravien = table.Column<int>(type: "int", nullable: true),
                    TheodoiKTX = table.Column<int>(type: "int", nullable: true),
                    RaKTX = table.Column<int>(type: "int", nullable: true),
                    AreaID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TTT",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: true),
                    EmployeeNO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    DoorPowerManageID = table.Column<int>(type: "int", nullable: false),
                    Tag = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TWEmployee",
                columns: table => new
                {
                    TWEmployeeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BG = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    BU = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Dept = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    EmployeeNO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(240)", maxLength: 240, nullable: true),
                    Sex = table.Column<bool>(type: "bit", nullable: true),
                    Leavel = table.Column<string>(type: "varchar(36)", unicode: false, maxLength: 36, nullable: true),
                    Post = table.Column<string>(type: "varchar(180)", unicode: false, maxLength: 180, nullable: true),
                    Code = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Legal = table.Column<string>(type: "varchar(120)", unicode: false, maxLength: 120, nullable: true),
                    EnterDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    WhetherJob = table.Column<bool>(type: "bit", nullable: false),
                    Source = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TWEmployeeBack",
                columns: table => new
                {
                    TWEmployeeID = table.Column<int>(type: "int", nullable: false),
                    BG = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    BU = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Dept = table.Column<string>(type: "varchar(120)", unicode: false, maxLength: 120, nullable: true),
                    EmployeeNO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Name = table.Column<string>(type: "varchar(240)", unicode: false, maxLength: 240, nullable: true),
                    Sex = table.Column<bool>(type: "bit", nullable: true),
                    Leavel = table.Column<string>(type: "varchar(36)", unicode: false, maxLength: 36, nullable: true),
                    Post = table.Column<string>(type: "varchar(180)", unicode: false, maxLength: 180, nullable: true),
                    Code = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Legal = table.Column<string>(type: "varchar(120)", unicode: false, maxLength: 120, nullable: true),
                    EnterDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    WhetherJob = table.Column<bool>(type: "bit", nullable: false),
                    Source = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TWEmployeeUpdate",
                columns: table => new
                {
                    TWEmployeeID = table.Column<int>(type: "int", nullable: false),
                    BG = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    BU = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Dept = table.Column<string>(type: "varchar(120)", unicode: false, maxLength: 120, nullable: true),
                    EmployeeNO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Name = table.Column<string>(type: "varchar(240)", unicode: false, maxLength: 240, nullable: true),
                    Sex = table.Column<bool>(type: "bit", nullable: true),
                    Leavel = table.Column<string>(type: "varchar(36)", unicode: false, maxLength: 36, nullable: true),
                    Post = table.Column<string>(type: "varchar(180)", unicode: false, maxLength: 180, nullable: true),
                    Code = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Legal = table.Column<string>(type: "varchar(120)", unicode: false, maxLength: 120, nullable: true),
                    EnterDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    WhetherJob = table.Column<bool>(type: "bit", nullable: false),
                    Source = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TWEmployeeUpdateBack",
                columns: table => new
                {
                    TWEmployeeID = table.Column<int>(type: "int", nullable: false),
                    BG = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    BU = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Dept = table.Column<string>(type: "varchar(120)", unicode: false, maxLength: 120, nullable: true),
                    EmployeeNO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Name = table.Column<string>(type: "varchar(240)", unicode: false, maxLength: 240, nullable: true),
                    Sex = table.Column<bool>(type: "bit", nullable: true),
                    Leavel = table.Column<string>(type: "varchar(36)", unicode: false, maxLength: 36, nullable: true),
                    Post = table.Column<string>(type: "varchar(180)", unicode: false, maxLength: 180, nullable: true),
                    Code = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Legal = table.Column<string>(type: "varchar(120)", unicode: false, maxLength: 120, nullable: true),
                    EnterDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    WhetherJob = table.Column<bool>(type: "bit", nullable: false),
                    Source = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TypeConfig",
                columns: table => new
                {
                    TypeConfigID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeConfigName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Type = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    Meno = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeConfig", x => x.TypeConfigID);
                });

            migrationBuilder.CreateTable(
                name: "UnderWriteFlow",
                columns: table => new
                {
                    UnderWriteFlowID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeID = table.Column<int>(type: "int", nullable: false),
                    ID = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    UnderWriteDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EmployeeNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Role = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    leavel = table.Column<int>(type: "int", nullable: false),
                    order = table.Column<int>(type: "int", nullable: false),
                    ParameterCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Meno = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    CreateEmployeeNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Notes = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UNDERWRITEFLOW", x => x.UnderWriteFlowID);
                });

            migrationBuilder.CreateTable(
                name: "UnderWriteModel",
                columns: table => new
                {
                    UnderWriteModelID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnderWriteFlowID = table.Column<int>(type: "int", nullable: false),
                    ModelName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ModeMeno = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnderWriteModel", x => x.UnderWriteModelID);
                });

            migrationBuilder.CreateTable(
                name: "UnderWriteRecord",
                columns: table => new
                {
                    UnderWriteRecordID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnderWriteFlowID = table.Column<int>(type: "int", nullable: false),
                    TypeID = table.Column<int>(type: "int", nullable: false),
                    Result = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    RecordDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Meno = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsAvailability = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnderWriteRecord", x => x.UnderWriteRecordID);
                });

            migrationBuilder.CreateTable(
                name: "UnderWriteType",
                columns: table => new
                {
                    UnderWriteTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnderWriteTypeName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnderWriteType", x => x.UnderWriteTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Untitled - 3",
                schema: "db_owner",
                columns: table => new
                {
                    RowNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventClass = table.Column<int>(type: "int", nullable: true),
                    TextData = table.Column<string>(type: "ntext", nullable: true),
                    ApplicationName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    NTUserName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    LoginName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    CPU = table.Column<int>(type: "int", nullable: true),
                    Reads = table.Column<long>(type: "bigint", nullable: true),
                    Writes = table.Column<long>(type: "bigint", nullable: true),
                    Duration = table.Column<long>(type: "bigint", nullable: true),
                    ClientProcessID = table.Column<int>(type: "int", nullable: true),
                    SPID = table.Column<int>(type: "int", nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    BinaryData = table.Column<byte[]>(type: "image", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Untitled - 3__473666D9", x => x.RowNumber);
                });

            migrationBuilder.CreateTable(
                name: "UpdateScrap",
                columns: table => new
                {
                    IDIn = table.Column<int>(type: "int", nullable: true),
                    Image1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Image2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TimeUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EmpNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Image3 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Image4 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Url",
                columns: table => new
                {
                    UrlLID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrlTitel = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Url = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Arrangement = table.Column<double>(type: "float", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_URL", x => x.UrlLID);
                });

            migrationBuilder.CreateTable(
                name: "UserBeforeLoding",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserBeforeLodingID = table.Column<int>(type: "int", nullable: false),
                    EmployeeNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    EmployeeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Notes = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    BGID = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    UserType = table.Column<int>(type: "int", nullable: true),
                    Area = table.Column<int>(type: "int", nullable: true),
                    BUCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CheckDelete = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserBeforeLoding", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserIDZalo",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpNo = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    UserID = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "UserLogin",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogin", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "UserMember",
                columns: table => new
                {
                    UserMemberID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmployeeNO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Ext = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Notes = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Password = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    BGID = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    RePwdTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMember", x => x.UserMemberID);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.RoleId, x.UserId });
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "VehicleCardRecord",
                columns: table => new
                {
                    CarNumber = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    DriverName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CarBrand = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    CarType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Color = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Stime = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    BAK = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "VehicleImportRecord_FstTier",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
                    Stime = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    carnum = table.Column<string>(name: "car_num", type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    SDIR = table.Column<string>(name: "S_DIR", type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    imagePath = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    BAK = table.Column<string>(type: "varchar(17)", unicode: false, maxLength: 17, nullable: true),
                    openState = table.Column<byte>(type: "tinyint", nullable: true),
                    Mid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "VehicleImportRecord_FstTier_History",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
                    Stime = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    carnum = table.Column<string>(name: "car_num", type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    SDIR = table.Column<string>(name: "S_DIR", type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    imagePath = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    BAK = table.Column<string>(type: "varchar(17)", unicode: false, maxLength: 17, nullable: true),
                    openState = table.Column<byte>(type: "tinyint", nullable: true),
                    Mid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "VehicleImportRecord_FstTier_Temp",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
                    Stime = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    carnum = table.Column<string>(name: "car_num", type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    SDIR = table.Column<string>(name: "S_DIR", type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    imagePath = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    BAK = table.Column<string>(type: "varchar(17)", unicode: false, maxLength: 17, nullable: true),
                    openState = table.Column<byte>(type: "tinyint", nullable: true),
                    Mid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "VehicleImportRecord_LHAQDM",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
                    Stime = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    carnum = table.Column<string>(name: "car_num", type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    SDIR = table.Column<string>(name: "S_DIR", type: "nvarchar(50)", maxLength: 50, nullable: false),
                    imagePath = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BAK = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    openState = table.Column<byte>(type: "tinyint", nullable: true),
                    Mid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "VehiclePeriod",
                columns: table => new
                {
                    VehiclePeriodID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehiclePeriodNo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    VehiclePermitID = table.Column<int>(type: "int", nullable: true),
                    AreaID = table.Column<int>(type: "int", nullable: true),
                    IsBeChecked = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    LotNumberDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Isdeleted = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehiclePeriod", x => x.VehiclePeriodID);
                });

            migrationBuilder.CreateTable(
                name: "VehiclePermit",
                columns: table => new
                {
                    VehiclePermitID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyID = table.Column<int>(type: "int", nullable: false),
                    CardID = table.Column<int>(type: "int", nullable: false),
                    CredentialsType = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    DriverName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CarBrand = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    CarType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Color = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CarNumber = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CredentialsNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Province = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    LicenseNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EmergencyContact = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmergencyContactPhone = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    WorkType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Caption = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    ContactUnit = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    EmployeeNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Signoff = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Signoff2 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    File = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PhotoID = table.Column<int>(type: "int", nullable: false),
                    DriverEmployeeNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Ext = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    BGID = table.Column<int>(type: "int", nullable: false),
                    IsFind = table.Column<bool>(type: "bit", nullable: false),
                    ContractEndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EmployeeName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ControlStatus = table.Column<int>(type: "int", nullable: false),
                    InureStartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    InureEndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    OrtherContact = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ArrangeNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ArrangeName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ArrangeTelephone = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AreaID = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    AreaCard = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Weight = table.Column<int>(type: "int", nullable: true),
                    NameCN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehiclePermit", x => x.VehiclePermitID);
                });

            migrationBuilder.CreateTable(
                name: "VehiclePermitAppend",
                columns: table => new
                {
                    InsertDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    VehiclePermitID = table.Column<int>(type: "int", nullable: true),
                    CompanyID = table.Column<int>(type: "int", nullable: true),
                    CardID = table.Column<int>(type: "int", nullable: true),
                    CredentialsType = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    DriverName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CarBrand = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    CarType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Color = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CarNumber = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CredentialsNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Province = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    LicenseNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EmergencyContact = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmergencyContactPhone = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    WorkType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Caption = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    ContactUnit = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    EmployeeNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Signoff = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Signoff2 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    File = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PhotoID = table.Column<int>(type: "int", nullable: false),
                    DriverEmployeeNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Ext = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    BGID = table.Column<int>(type: "int", nullable: false),
                    IsFind = table.Column<bool>(type: "bit", nullable: false),
                    ContractEndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EmployeeName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ControlStatus = table.Column<int>(type: "int", nullable: false),
                    InureStartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    InureEndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    OrtherContact = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ArrangeNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ArrangeName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ArrangeTelephone = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AreaID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "VehiclePermitEmployee",
                columns: table => new
                {
                    VehiclePermitEID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CredentialsNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Address = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true),
                    SerialNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VEHICLEPERMITEMPLOYEE", x => x.VehiclePermitEID);
                });

            migrationBuilder.CreateTable(
                name: "VehiclePermitHistory",
                columns: table => new
                {
                    InsertDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    VehiclePermitID = table.Column<int>(type: "int", nullable: true),
                    CompanyID = table.Column<int>(type: "int", nullable: true),
                    CardID = table.Column<int>(type: "int", nullable: true),
                    CredentialsType = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    DriverName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CarBrand = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    CarType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Color = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CarNumber = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CredentialsNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Province = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    LicenseNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EmergencyContact = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmergencyContactPhone = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    WorkType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Caption = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    ContactUnit = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    EmployeeNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Signoff = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Signoff2 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    File = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PhotoID = table.Column<int>(type: "int", nullable: false),
                    DriverEmployeeNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Ext = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    BGID = table.Column<int>(type: "int", nullable: false),
                    IsFind = table.Column<bool>(type: "bit", nullable: false),
                    ContractEndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EmployeeName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ControlStatus = table.Column<int>(type: "int", nullable: false),
                    InureStartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    InureEndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    OrtherContact = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ArrangeNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ArrangeName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ArrangeTelephone = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AreaID = table.Column<int>(type: "int", nullable: true),
                    AreaCard = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Weight = table.Column<int>(type: "int", nullable: true),
                    NameCN = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "VehiclePermitPhoto",
                columns: table => new
                {
                    VehiclePermitPhotoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehiclePermitID = table.Column<int>(type: "int", nullable: true),
                    PhotoID = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "VehiclePermitValid",
                columns: table => new
                {
                    VehiclePermitID = table.Column<int>(type: "int", nullable: true),
                    CompanyID = table.Column<int>(type: "int", nullable: true),
                    CardID = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    CredentialsType = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    DriverName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CarBrand = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    CarType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Color = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CarNumber = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CredentialsNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Province = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    LicenseNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EmergencyContact = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmergencyContactPhone = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    WorkType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Caption = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    ContactUnit = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    EmployeeNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    Signoff = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Signoff2 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    File = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PhotoID = table.Column<int>(type: "int", nullable: true),
                    DriverEmployeeNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Ext = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    BGID = table.Column<int>(type: "int", nullable: true),
                    IsFind = table.Column<bool>(type: "bit", nullable: true),
                    ContractEndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EmployeeName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ControlStatus = table.Column<int>(type: "int", nullable: true),
                    InureStartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    InureEndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    OrtherContact = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ArrangeNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ArrangeName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ArrangeTelephone = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AreaID = table.Column<int>(type: "int", nullable: true),
                    AreaCard = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Weight = table.Column<int>(type: "int", nullable: true),
                    NameCN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "VehiclesEmployee",
                columns: table => new
                {
                    VehiclesEmployeeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CredentialsNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Reason = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    DeleteDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehiclesEmployee", x => x.VehiclesEmployeeID);
                });

            migrationBuilder.CreateTable(
                name: "VeQuestionnaire",
                columns: table => new
                {
                    QuestionnaireId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CarNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Area = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Building = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Result = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Filepath = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Reason = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ISDelete = table.Column<int>(type: "int", nullable: true),
                    DateNumber = table.Column<int>(type: "int", nullable: true),
                    AreaName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VeQuestionnaire", x => x.QuestionnaireId);
                });

            migrationBuilder.CreateTable(
                name: "View_DriverCardMatch",
                columns: table => new
                {
                    CarNumber = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmployeeNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    UPdateTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "View_DriverCardMatchTemp",
                columns: table => new
                {
                    CarNumber = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmployeeNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "View_Old_ncomeuser",
                columns: table => new
                {
                    cardno = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    ecardno = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    CompanyName = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    CardNumber = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    name = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "View_Old_ncomeuserTemp1",
                columns: table => new
                {
                    cardno = table.Column<int>(type: "int", nullable: false),
                    ecardno = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CompanyName = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    CardNumber = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    name = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "View_Old_nusercard",
                columns: table => new
                {
                    cardno = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    ecardno = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    CompanyName = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    CardNumber = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    name = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "View_Old_nusercardTemp1",
                columns: table => new
                {
                    cardno = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    ecardno = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    CompanyName = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    CardNumber = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    name = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "View_SwipingCardCheck",
                columns: table => new
                {
                    CardNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    SerialNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    areaID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AreaName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InureEndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CredentialsNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CompanyName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    CompanyStatus = table.Column<int>(type: "int", nullable: false),
                    CardStatus = table.Column<int>(type: "int", nullable: true),
                    BitImage = table.Column<byte[]>(type: "image", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "View_SwipingCardCheckTemp1",
                columns: table => new
                {
                    CardNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    SerialNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AreaID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AreaName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InureEndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CredentialsNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CompanyName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    CompanyStatus = table.Column<int>(type: "int", nullable: false),
                    CardStatus = table.Column<int>(type: "int", nullable: true),
                    BitImage = table.Column<byte[]>(type: "image", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "View_VehicleCardCheck",
                columns: table => new
                {
                    CardNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    SerialNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CardStatus = table.Column<int>(type: "int", nullable: true),
                    AreaID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AreaName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InureEndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CredentialsNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CarNumber = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CompanyStatus = table.Column<int>(type: "int", nullable: false),
                    CompanyName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "View_VehicleCardCheckTemp",
                columns: table => new
                {
                    CardNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    SerialNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CardStatus = table.Column<int>(type: "int", nullable: true),
                    AreaID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AreaName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InureEndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CredentialsNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CarNumber = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CompanyStatus = table.Column<int>(type: "int", nullable: false),
                    CompanyName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ViheWeight",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: true),
                    CarNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Weight = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "VipCard",
                columns: table => new
                {
                    VipCardID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    SerialNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VipCard", x => x.VipCardID);
                });

            migrationBuilder.CreateTable(
                name: "VIPCardApplication",
                columns: table => new
                {
                    VIPID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VisitStartTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    VisitEndTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    ReceptionBG = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ReceptionDept = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ReceptionPeople = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Extension = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Tel = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true),
                    ID = table.Column<int>(type: "int", nullable: true),
                    ApplicationID = table.Column<int>(type: "int", nullable: true),
                    Reason = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VIPCARDAPPLICATION", x => x.VIPID);
                });

            migrationBuilder.CreateTable(
                name: "VipCardReceive",
                columns: table => new
                {
                    VipCardID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BG = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ReceiveCards = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ReceiveTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Extention = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Tel = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Notes = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CardNum = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VIPCARDRECEIVE", x => x.VipCardID);
                });

            migrationBuilder.CreateTable(
                name: "VipDisable",
                columns: table => new
                {
                    VipDisableID = table.Column<int>(type: "int", nullable: false),
                    EmpNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmpName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    IsDelete = table.Column<int>(type: "int", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeleteReason = table.Column<string>(type: "varchar(2000)", unicode: false, maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VipDisable", x => x.VipDisableID);
                });

            migrationBuilder.CreateTable(
                name: "VipOutCall",
                columns: table => new
                {
                    CallID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormID = table.Column<int>(type: "int", nullable: true),
                    TypeID = table.Column<int>(type: "int", nullable: true),
                    CallTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VipCallOut", x => x.CallID);
                });

            migrationBuilder.CreateTable(
                name: "VisitArrangements",
                columns: table => new
                {
                    VisitArrangementsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VisitNotCustID = table.Column<int>(type: "int", nullable: false),
                    AccessUnit = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    AccessContent = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    AccessTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    AccessMeno = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    AreaID = table.Column<int>(type: "int", nullable: true),
                    Area = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VISITARRANGEMENTS", x => x.VisitArrangementsID);
                });

            migrationBuilder.CreateTable(
                name: "VisitCar",
                columns: table => new
                {
                    VisitCarID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    CarType = table.Column<int>(type: "int", nullable: true),
                    CarColor = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    PassType = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((2))"),
                    PassNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Tel = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Sex = table.Column<int>(type: "int", nullable: true),
                    FormID = table.Column<int>(type: "int", nullable: true),
                    ReportID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitCar", x => x.VisitCarID);
                });

            migrationBuilder.CreateTable(
                name: "VisitCard",
                columns: table => new
                {
                    VisitorCardID = table.Column<int>(type: "int", nullable: false),
                    CardNum = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ECardNum = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CardStatus = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    IsDelete = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    ReceiveTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    ReturnTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    deleteddate = table.Column<DateTime>(type: "datetime", nullable: true),
                    deletedseason = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitCard", x => x.VisitorCardID);
                });

            migrationBuilder.CreateTable(
                name: "VisitCredentials",
                columns: table => new
                {
                    ApplicationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ApplicationType = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    UnitVisit = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    BGID = table.Column<int>(type: "int", nullable: true),
                    BU = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Dept = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ApplicationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    StartTime = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EndTime = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ReceptionDept = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ReceptionNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ReceptionPeople = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ReceptionExt = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    GuideNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    GuidePeople = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    GuideExt = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ReasonVisit = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    AreaRegionID = table.Column<int>(type: "int", nullable: true),
                    Build = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Floor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Office = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    SignMemo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EmployeeNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    GuideNo1 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    GuidePeople1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    GuideExt1 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CardNumber = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Notes = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Filelist = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Number = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitCredentials", x => x.ApplicationID);
                });

            migrationBuilder.CreateTable(
                name: "VisitCredentialsProc",
                columns: table => new
                {
                    VisitProcID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusID = table.Column<int>(type: "int", nullable: true),
                    ApplicationID = table.Column<int>(type: "int", nullable: true),
                    Act = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    WorkDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Meno = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitCredentialsProc", x => x.VisitProcID);
                });

            migrationBuilder.CreateTable(
                name: "VisitCredentialsStatus",
                columns: table => new
                {
                    StatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VisitID = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Notes = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Leavel = table.Column<double>(type: "float", nullable: true),
                    WorkTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    FormMeno = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    EmployeeNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ApplicationID = table.Column<int>(type: "int", nullable: true),
                    Emp = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Order = table.Column<int>(type: "int", nullable: true),
                    Sort = table.Column<int>(type: "int", nullable: true),
                    Ip = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitCredentialsStatus", x => x.StatusID);
                });

            migrationBuilder.CreateTable(
                name: "VisitCustomer",
                columns: table => new
                {
                    VisitCustID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductOppID = table.Column<int>(type: "int", nullable: true),
                    VisitNatureID = table.Column<int>(type: "int", nullable: true),
                    ApplicationUnit = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ApplicationTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    VisitUnits = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IsNewCust = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    VisitAim = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    Traffic = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    ShowAttachment = table.Column<bool>(type: "bit", nullable: false),
                    AdviceItem = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    BackstageStatus = table.Column<int>(type: "int", nullable: false),
                    ReceiverNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    VipCardID = table.Column<int>(type: "int", nullable: true),
                    Number = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Filepath = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    PosisionCar = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VISITCUSTOMER", x => x.VisitCustID);
                });

            migrationBuilder.CreateTable(
                name: "VisitFactory",
                columns: table => new
                {
                    FactID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VisitCustID = table.Column<int>(type: "int", nullable: false),
                    FactoryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    Area = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DetailAddress = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Meno = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    BGID = table.Column<int>(type: "int", nullable: true),
                    IsControl = table.Column<bool>(type: "bit", nullable: true),
                    ControlMeno = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VISITFACTORY", x => x.FactID);
                });

            migrationBuilder.CreateTable(
                name: "VisitGovernment",
                columns: table => new
                {
                    VisitGovernmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    ApplicationUnit = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ApplicationTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    VisitTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    VisitUnits = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    VisitAim = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    VisitIssues = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SalutatoryPlace = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    SalutatoryContent = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Isdeleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    BackstageStatus = table.Column<int>(type: "int", nullable: false),
                    ReceiverNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    VipCardID = table.Column<int>(type: "int", nullable: true),
                    Filepath = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitGovernment", x => x.VisitGovernmentID);
                });

            migrationBuilder.CreateTable(
                name: "VisitGovernmentAdvanced",
                columns: table => new
                {
                    VisitGovernmentAdvancedID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUnit = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ApplicationTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    VisitTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    VisitUnit = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    MeetingTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    DiscussMatters = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    VisitAim = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Problem = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    SalutatoryPlace = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    SalutatoryContent = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Number = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Isdeleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    Applicationleavel = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    BackstageStatus = table.Column<int>(type: "int", nullable: false),
                    ReceiverNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    VipCardID = table.Column<int>(type: "int", nullable: true),
                    Filepath = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitGovernmentAdvanced", x => x.VisitGovernmentAdvancedID);
                });

            migrationBuilder.CreateTable(
                name: "VisitGovernmentAdvancedList",
                columns: table => new
                {
                    VisitGAdListID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VisitGovernmentAdvancedID = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Sex = table.Column<bool>(type: "bit", nullable: true),
                    Position = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    IsFristVisit = table.Column<bool>(type: "bit", nullable: true),
                    VisitTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    VisitAddress = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Nature = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    VisitNumber = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    RemandTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    ReturnID = table.Column<int>(type: "int", nullable: true),
                    ReturnTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    ReceiverID = table.Column<int>(type: "int", nullable: true),
                    ReceiverTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    ReceiverNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ReturnReason = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VISITGOVERNMENTADVANCEDLIST", x => x.VisitGAdListID);
                });

            migrationBuilder.CreateTable(
                name: "VisitGovernmentList",
                columns: table => new
                {
                    VisitGListID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VisitGovernmentID = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Sex = table.Column<bool>(type: "bit", nullable: true),
                    Position = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    VisitNumber = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    RemandTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    ReturnID = table.Column<int>(type: "int", nullable: true),
                    ReturnTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    ReceiverID = table.Column<int>(type: "int", nullable: true),
                    ReceiverTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    ReceiverNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ReturnReason = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VISITGOVERNMENTLIST", x => x.VisitGListID);
                });

            migrationBuilder.CreateTable(
                name: "VisitHistory",
                columns: table => new
                {
                    VisitHistoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VisitGovernmentID = table.Column<int>(type: "int", nullable: true),
                    VisitInformation = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    UnderstandDegree = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitHistory", x => x.VisitHistoryID);
                });

            migrationBuilder.CreateTable(
                name: "VisitList",
                columns: table => new
                {
                    VisitID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VisitName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PeopleID = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    PhoneNumber = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ApplicationID = table.Column<int>(type: "int", nullable: true),
                    NumberCar = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true),
                    CardNumer = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    TimeIn = table.Column<DateTime>(type: "datetime", nullable: true),
                    TimeOut = table.Column<DateTime>(type: "datetime", nullable: true),
                    EmpNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    PRC72 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PassPostID = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    LeciID = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    CountVisit = table.Column<int>(type: "int", nullable: true),
                    Supplie = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ReasonSupp = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    FileSupplie = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ImageVisit = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    AreaID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitList", x => x.VisitID);
                });

            migrationBuilder.CreateTable(
                name: "VisitNature",
                columns: table => new
                {
                    VisitNatureID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VisitNatureName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitNature", x => x.VisitNatureID);
                });

            migrationBuilder.CreateTable(
                name: "VisitNatureCust",
                columns: table => new
                {
                    VisitNatureCustID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VisitNatureID = table.Column<int>(type: "int", nullable: true),
                    VisitCustID = table.Column<int>(type: "int", nullable: true),
                    Other = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitNatureCust", x => x.VisitNatureCustID);
                });

            migrationBuilder.CreateTable(
                name: "VisitNotCust",
                columns: table => new
                {
                    VisitNotCustID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUnit = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ApplicationTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    VisitTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    VisitUnits = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    VisitLeavel = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    VisitNatureID = table.Column<int>(type: "int", nullable: false),
                    WorkItem = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    WorkResult = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    Status = table.Column<int>(type: "int", nullable: true),
                    BackstageStatus = table.Column<int>(type: "int", nullable: false),
                    ReceiverNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    VipCardID = table.Column<int>(type: "int", nullable: true),
                    Number = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Filepath = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    PosisionCar = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitNotCust", x => x.VisitNotCustID);
                });

            migrationBuilder.CreateTable(
                name: "Visitors",
                columns: table => new
                {
                    VisitorsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TemporaryCredentialsID = table.Column<int>(type: "int", nullable: true),
                    VisitorsName = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CredentialsType = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    CredentialsNumber = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Sex = table.Column<bool>(type: "bit", nullable: true),
                    Meno = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    CardNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    SendTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    RemandTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitors_1", x => x.VisitorsID);
                });

            migrationBuilder.CreateTable(
                name: "VisitStatus",
                columns: table => new
                {
                    VisitStatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationID = table.Column<int>(type: "int", nullable: true),
                    EmployeeNo = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Notes = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Leavel = table.Column<double>(type: "float", nullable: true),
                    WorkTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    VisitMemo = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitStatus", x => x.VisitStatusID);
                });

            migrationBuilder.CreateTable(
                name: "WebVerson",
                columns: table => new
                {
                    WebVersonID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WebVersonName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    DeleteTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WebVerson", x => x.WebVersonID);
                });

            migrationBuilder.CreateTable(
                name: "WebVisitRecord",
                columns: table => new
                {
                    WebVisitRecordID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VisitDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Mac = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    IP = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    IsLoding = table.Column<bool>(type: "bit", nullable: false),
                    EmployeeNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    EmployeeName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsBefore = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WebVisitRecord", x => x.WebVisitRecordID);
                });

            migrationBuilder.CreateTable(
                name: "WeeklyReport",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    TimeUpload = table.Column<DateTime>(type: "datetime", nullable: true),
                    FileReport = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeeklyReport", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WeiCall",
                columns: table => new
                {
                    WeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID = table.Column<int>(type: "int", nullable: true),
                    Area = table.Column<int>(type: "int", nullable: true),
                    NameCall = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    CallTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    TypeCall = table.Column<int>(type: "int", nullable: true),
                    ContentWei = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameLis = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Method = table.Column<int>(type: "int", nullable: true),
                    Result = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Memo = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    ApplicationTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeiCall", x => x.WeID);
                });

            migrationBuilder.CreateTable(
                name: "WeightAPI",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDPL = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    TimeWeight = table.Column<DateTime>(type: "datetime", nullable: true),
                    ImageCar = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ImageCarOverall = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CarNumber = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    Weight = table.Column<int>(type: "int", nullable: true),
                    UnitWeight = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Status = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ImagePerson = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CardNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CarType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    UserID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ImageOfScale = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeightAPI", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WeightAPI1",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDPL = table.Column<int>(type: "int", nullable: false),
                    TimeWeight = table.Column<DateTime>(type: "datetime", nullable: true),
                    ImageCar = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CarNumber = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    Weight = table.Column<int>(type: "int", nullable: true),
                    UnitWeight = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Status = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ImagePerson = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CardNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CarType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeightAPI1", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WeightPO",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeAdd = table.Column<DateTime>(type: "datetime", nullable: true),
                    WeightIn = table.Column<int>(type: "int", nullable: true),
                    WeightIncotant = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "WorkNotes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    EmpName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Area = table.Column<int>(type: "int", nullable: true),
                    WorkTime = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "WorkTypeInFac",
                columns: table => new
                {
                    WorkTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkTypeNameC = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    WorkTypeNameV = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Type = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    Meno = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Isdeleted = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "YHUHU",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "DoorPowerManageApplication",
                columns: table => new
                {
                    DoorPowerManageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationID = table.Column<int>(type: "int", nullable: true),
                    BGID = table.Column<int>(type: "int", nullable: true),
                    EmployeeName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EmployeeNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Bu = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Dept = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Position = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Notes = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    File = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Picture = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EnglishPicture = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    BackMeno = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    IsFind = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    Tel = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DOORPOWERMANAGEAPPLICATION", x => x.DoorPowerManageID);
                    table.ForeignKey(
                        name: "FK_DOORPOWE_REFERENCE_APPLICAT",
                        column: x => x.ApplicationID,
                        principalTable: "ApplicationDoor",
                        principalColumn: "ApplicationID");
                });

            migrationBuilder.CreateTable(
                name: "SupplementaryInfo",
                columns: table => new
                {
                    SupplementaryInfoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BGID = table.Column<int>(type: "int", nullable: true),
                    BU = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    EmployeeNO = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    EmployeeName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EnglishName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Notes = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Tel = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Nation = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Position = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true, comment: "1車輛，2為門禁簽核權限"),
                    Files = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AddTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplementaryInfo", x => x.SupplementaryInfoID);
                    table.ForeignKey(
                        name: "FK_SUPPLEME_REFERENCE_BG",
                        column: x => x.BGID,
                        principalTable: "BG",
                        principalColumn: "BGID");
                });

            migrationBuilder.CreateTable(
                name: "InvalidRecords",
                columns: table => new
                {
                    InvalidID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardID = table.Column<int>(type: "int", nullable: true),
                    InvalidReasons = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Invalid = table.Column<DateTime>(type: "datetime", nullable: true),
                    AdminID = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    Effective = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    RecoveryType = table.Column<int>(type: "int", nullable: false, comment: "0為作廢未處理，1為證件收回，2為交賠償金，3為補卡"),
                    QuitApplyID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INVALIDRECORDS", x => x.InvalidID);
                    table.ForeignKey(
                        name: "FK_INVALIDR_REFERENCE_CARD",
                        column: x => x.CardID,
                        principalTable: "Card",
                        principalColumn: "CardID");
                });

            migrationBuilder.CreateTable(
                name: "CompanyControlHistory",
                columns: table => new
                {
                    CompanyControlHistoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyID = table.Column<int>(type: "int", nullable: true),
                    ControlTag = table.Column<bool>(type: "bit", nullable: false),
                    OperatTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    ControlMsg = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyControlHistory", x => x.CompanyControlHistoryID);
                    table.ForeignKey(
                        name: "FK_COMPANYC_REFERENCE_COMPANY",
                        column: x => x.CompanyID,
                        principalTable: "Company",
                        principalColumn: "CompanyID");
                });

            migrationBuilder.CreateTable(
                name: "TemporaryCredentials",
                columns: table => new
                {
                    TemporaryCredentialsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyID = table.Column<int>(type: "int", nullable: true),
                    BGID = table.Column<int>(type: "int", nullable: true),
                    Bu = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Dept = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ApplicationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    FactoryDoor = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    ApplicationType = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Content = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    LedPeople = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ReceptionDept = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ReceptionPeople = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ReceptionExt = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    UserMemberID = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    Signoff = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    AreaRegionID = table.Column<int>(type: "int", nullable: true),
                    Build = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Floor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Office = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemporaryCredentials_1", x => x.TemporaryCredentialsID);
                    table.ForeignKey(
                        name: "FK_TEMPORAR_REFERENCE_COMPANY",
                        column: x => x.CompanyID,
                        principalTable: "Company",
                        principalColumn: "CompanyID");
                });

            migrationBuilder.CreateTable(
                name: "VisitantCertificate",
                columns: table => new
                {
                    VisitantCertificateID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyID = table.Column<int>(type: "int", nullable: true),
                    CardID = table.Column<int>(type: "int", nullable: true),
                    VisitingUnits = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    BGID = table.Column<int>(type: "int", nullable: true),
                    ReceptionDept = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ReceptionPeople = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ReceptionExt = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ReceptionPhone = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmployeeNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    Signoff = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    File = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitantCertificate", x => x.VisitantCertificateID);
                    table.ForeignKey(
                        name: "FK_VISITANT_REFERENCE_CARD",
                        column: x => x.CardID,
                        principalTable: "Card",
                        principalColumn: "CardID");
                    table.ForeignKey(
                        name: "FK_VISITANT_REFERENCE_COMPANY",
                        column: x => x.CompanyID,
                        principalTable: "Company",
                        principalColumn: "CompanyID");
                });

            migrationBuilder.CreateTable(
                name: "CustTravelDetail",
                columns: table => new
                {
                    CustTravelDetailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustTravelID = table.Column<int>(type: "int", nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    TravelAim = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustTravelDetail", x => x.CustTravelDetailID);
                    table.ForeignKey(
                        name: "FK_CUSTTRAV_REFERENCE_CUSTTRAV",
                        column: x => x.CustTravelID,
                        principalTable: "CustTravel",
                        principalColumn: "CustTravelID");
                });

            migrationBuilder.CreateTable(
                name: "DoorPowerManageArea",
                columns: table => new
                {
                    DoorPowerManageID = table.Column<int>(type: "int", nullable: true),
                    AreaRegionID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_DOORPOWE_TT_DOORPOWE",
                        column: x => x.DoorPowerManageID,
                        principalTable: "DoorPowerManage",
                        principalColumn: "DoorPowerManageID");
                });

            migrationBuilder.CreateTable(
                name: "DoorPowerManageType",
                columns: table => new
                {
                    DoorPowerManageTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JurisdictionTypeID = table.Column<int>(type: "int", nullable: true),
                    DoorPowerManageID = table.Column<int>(type: "int", nullable: true),
                    Meno = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoorPowerManageType", x => x.DoorPowerManageTypeID);
                    table.ForeignKey(
                        name: "FK_DOORPOWE_UU_DOORPOWE",
                        column: x => x.DoorPowerManageID,
                        principalTable: "DoorPowerManage",
                        principalColumn: "DoorPowerManageID");
                });

            migrationBuilder.CreateTable(
                name: "DoorPowerManageBGSignSetupItem",
                columns: table => new
                {
                    BGSignSetupItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BGSignSetupID = table.Column<int>(type: "int", nullable: true),
                    SignAdminID = table.Column<int>(type: "int", nullable: true),
                    SignOrderID = table.Column<int>(type: "int", nullable: true),
                    SignRole = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    SignMeno = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    SignStatusID = table.Column<int>(type: "int", nullable: true),
                    SignDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsSign = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoorPowerManageBGSignSetupItem", x => x.BGSignSetupItemID);
                    table.ForeignKey(
                        name: "FK_DoorPowerManageBGSignSetupItem_DoorPowerManageBGSignSetup",
                        column: x => x.BGSignSetupID,
                        principalTable: "DoorPowerManageBGSignSetup",
                        principalColumn: "BGSignSetupID");
                });

            migrationBuilder.CreateTable(
                name: "DoorPowerManageModifyList",
                columns: table => new
                {
                    DoorPowerManageModifyID = table.Column<int>(type: "int", nullable: false),
                    DoorPowerManageID = table.Column<int>(type: "int", nullable: true),
                    AreaRegionID = table.Column<int>(type: "int", nullable: true),
                    JurisdictionTypeID = table.Column<int>(type: "int", nullable: true),
                    Meno = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ActionType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_DoorPowerManageModifyList_DoorPowerManageModify",
                        column: x => x.DoorPowerManageModifyID,
                        principalTable: "DoorPowerManageModify",
                        principalColumn: "DoorPowerManageModifyID");
                });

            migrationBuilder.CreateTable(
                name: "DoorPowerManageAreaVer",
                columns: table => new
                {
                    DoorPowerManageVerID = table.Column<int>(type: "int", nullable: true),
                    AreaRegionID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_DOORPOWE_LT_DOORPOWE",
                        column: x => x.DoorPowerManageVerID,
                        principalTable: "DoorPowerManageVer",
                        principalColumn: "DoorPowerManageVerID");
                });

            migrationBuilder.CreateTable(
                name: "DoorPowerManageTypeVer",
                columns: table => new
                {
                    DoorPowerManageTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JurisdictionTypeID = table.Column<int>(type: "int", nullable: true),
                    DoorPowerManageVerID = table.Column<int>(type: "int", nullable: true),
                    Meno = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DOORPOWERMANAGETYPEVER", x => x.DoorPowerManageTypeID);
                    table.ForeignKey(
                        name: "FK_DOORPOWE_PS_DOORPOWE",
                        column: x => x.DoorPowerManageVerID,
                        principalTable: "DoorPowerManageVer",
                        principalColumn: "DoorPowerManageVerID");
                });

            migrationBuilder.CreateTable(
                name: "DispatchRecords",
                columns: table => new
                {
                    DispatchRecordsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpareCarID = table.Column<int>(type: "int", nullable: true),
                    LogDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    OutTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    BackTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    OutMileage = table.Column<int>(type: "int", nullable: true),
                    BackMileage = table.Column<int>(type: "int", nullable: true),
                    UsePeople = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Destination = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    UseReason = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Dispatcher = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Meno = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DISPATCHRECORDS", x => x.DispatchRecordsID);
                    table.ForeignKey(
                        name: "FK_DISPATCH_REFERENCE_SPARECAR",
                        column: x => x.SpareCarID,
                        principalTable: "SpareCar",
                        principalColumn: "SpareCarID");
                });

            migrationBuilder.CreateTable(
                name: "OilRecords",
                columns: table => new
                {
                    OilRecordsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpareCarID = table.Column<int>(type: "int", nullable: true),
                    FuelDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    FuelPeople = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    BeforeOilMileage = table.Column<int>(type: "int", nullable: true),
                    OilNum = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OILRECORDS", x => x.OilRecordsID);
                    table.ForeignKey(
                        name: "FK_OILRECOR_REFERENCE_SPARECAR",
                        column: x => x.SpareCarID,
                        principalTable: "SpareCar",
                        principalColumn: "SpareCarID");
                });

            migrationBuilder.CreateTable(
                name: "SpareCarReport",
                columns: table => new
                {
                    SpareCarReportID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpareCarID = table.Column<int>(type: "int", nullable: true),
                    CreatTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpareCarReport", x => x.SpareCarReportID);
                    table.ForeignKey(
                        name: "FK_SPARECAR_REFERENCE_SPARECAR",
                        column: x => x.SpareCarID,
                        principalTable: "SpareCar",
                        principalColumn: "SpareCarID");
                });

            migrationBuilder.CreateTable(
                name: "VehiclePersonnel",
                columns: table => new
                {
                    VehiclePID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehiclePermitID = table.Column<int>(type: "int", nullable: true),
                    ID = table.Column<int>(type: "int", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true),
                    MatchTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    RemoveTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VEHICLEPERSONNEL", x => x.VehiclePID);
                    table.ForeignKey(
                        name: "FK_VEHICLEP_REFERENCE_VEHICLEP",
                        column: x => x.VehiclePermitID,
                        principalTable: "VehiclePermit",
                        principalColumn: "VehiclePermitID");
                });

            migrationBuilder.CreateTable(
                name: "VipCardNum",
                columns: table => new
                {
                    VipCardNumID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VipCardID = table.Column<int>(type: "int", nullable: false),
                    StartNum = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EndNum = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Num = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VipCardNum", x => x.VipCardNumID);
                    table.ForeignKey(
                        name: "FK_VIPCARDN_REFERENCE_VIPCARDR",
                        column: x => x.VipCardID,
                        principalTable: "VipCardReceive",
                        principalColumn: "VipCardID");
                });

            migrationBuilder.CreateTable(
                name: "DoorPowerManageAreaApplication",
                columns: table => new
                {
                    DoorPowerManageID = table.Column<int>(type: "int", nullable: true),
                    AreaRegionID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_DOORPOWE_RR_DOORPOWE",
                        column: x => x.DoorPowerManageID,
                        principalTable: "DoorPowerManageApplication",
                        principalColumn: "DoorPowerManageID");
                });

            migrationBuilder.CreateTable(
                name: "DoorPowerManageTypeApplication",
                columns: table => new
                {
                    DoorPowerManageTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JurisdictionTypeID = table.Column<int>(type: "int", nullable: true),
                    DoorPowerManageID = table.Column<int>(type: "int", nullable: true),
                    Meno = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DOORPOWERMANAGETYPEAPPLICAT", x => x.DoorPowerManageTypeID);
                    table.ForeignKey(
                        name: "FK_DOORPOWE_PP_DOORPOWE",
                        column: x => x.DoorPowerManageID,
                        principalTable: "DoorPowerManageApplication",
                        principalColumn: "DoorPowerManageID");
                });

            migrationBuilder.CreateTable(
                name: "RecovertRecords",
                columns: table => new
                {
                    RecovertID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvalidID = table.Column<int>(type: "int", nullable: true),
                    Reasons = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    RecovertTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    AdminID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RECOVERTRECORDS", x => x.RecovertID);
                    table.ForeignKey(
                        name: "FK_RECOVERT_REFERENCE_INVALIDR",
                        column: x => x.InvalidID,
                        principalTable: "InvalidRecords",
                        principalColumn: "InvalidID");
                });

            migrationBuilder.InsertData(
                table: "UserBeforeLoding",
                columns: new[] { "Id", "AccessFailedCount", "Area", "BGID", "BUCode", "CheckDelete", "ConcurrencyStamp", "CreateTime", "Email", "EmailConfirmed", "EmployeeName", "EmployeeNo", "IsDeleted", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Notes", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "Type", "UserBeforeLodingID", "UserName", "UserType" },
                values: new object[] { 1, 0, null, 0, null, null, "69683ade-bac6-4fec-a69c-f984dc261cba", new DateTime(2023, 1, 3, 9, 50, 7, 585, DateTimeKind.Local).AddTicks(7186), null, false, "Hà", "V0515311", false, false, null, null, null, "test@gmail.com", "1234567Aa", null, null, false, null, false, 0, 1, null, null });

            migrationBuilder.CreateIndex(
                name: "IX_APEXSQL_LOG_LOGIN_2010",
                table: "APEXSQL_LOG_LOGIN",
                columns: new[] { "SPID", "LOGIN_TIME", "SERVER_NAME" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Chr_employee_No",
                table: "Chr_Employee",
                column: "emp_no");

            migrationBuilder.CreateIndex(
                name: "IX_Chr_employee_Transit_NO",
                table: "Chr_employee_Transit",
                column: "emp_no");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyControlHistory_CompanyID",
                table: "CompanyControlHistory",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "NIDX_CONTROLPEOPLEID01",
                table: "ControlPeople",
                column: "ControlPeopleID");

            migrationBuilder.CreateIndex(
                name: "NIDX_CREDENTIALSNUMBER01",
                table: "ControlPeople",
                column: "CredentialsNumber");

            migrationBuilder.CreateIndex(
                name: "IX_CustTravelDetail_CustTravelID",
                table: "CustTravelDetail",
                column: "CustTravelID");

            migrationBuilder.CreateIndex(
                name: "IX_DispatchRecords_SpareCarID",
                table: "DispatchRecords",
                column: "SpareCarID");

            migrationBuilder.CreateIndex(
                name: "IX_DoorPowerManageApplication_ApplicationID",
                table: "DoorPowerManageApplication",
                column: "ApplicationID");

            migrationBuilder.CreateIndex(
                name: "IX_DoorPowerManageArea_DoorPowerManageID",
                table: "DoorPowerManageArea",
                column: "DoorPowerManageID");

            migrationBuilder.CreateIndex(
                name: "IX_DoorPowerManageAreaApplication_DoorPowerManageID",
                table: "DoorPowerManageAreaApplication",
                column: "DoorPowerManageID");

            migrationBuilder.CreateIndex(
                name: "IX_DoorPowerManageAreaVer_DoorPowerManageVerID",
                table: "DoorPowerManageAreaVer",
                column: "DoorPowerManageVerID");

            migrationBuilder.CreateIndex(
                name: "IX_DoorPowerManageBGSignSetupItem_BGSignSetupID",
                table: "DoorPowerManageBGSignSetupItem",
                column: "BGSignSetupID");

            migrationBuilder.CreateIndex(
                name: "IX_DoorPowerManageModifyList_DoorPowerManageModifyID",
                table: "DoorPowerManageModifyList",
                column: "DoorPowerManageModifyID");

            migrationBuilder.CreateIndex(
                name: "IX_DoorPowerManageType_DoorPowerManageID",
                table: "DoorPowerManageType",
                column: "DoorPowerManageID");

            migrationBuilder.CreateIndex(
                name: "IX_DoorPowerManageTypeApplication_DoorPowerManageID",
                table: "DoorPowerManageTypeApplication",
                column: "DoorPowerManageID");

            migrationBuilder.CreateIndex(
                name: "IX_DoorPowerManageTypeVer_DoorPowerManageVerID",
                table: "DoorPowerManageTypeVer",
                column: "DoorPowerManageVerID");

            migrationBuilder.CreateIndex(
                name: "IX_InvalidRecords_CardID",
                table: "InvalidRecords",
                column: "CardID");

            migrationBuilder.CreateIndex(
                name: "IX_OilRecords_SpareCarID",
                table: "OilRecords",
                column: "SpareCarID");

            migrationBuilder.CreateIndex(
                name: "IX_RecovertRecords_InvalidID",
                table: "RecovertRecords",
                column: "InvalidID");

            migrationBuilder.CreateIndex(
                name: "NIDX_ID01",
                table: "SignProcess",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "NIDX_IsDeleted01",
                table: "SignProcess",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "NIDX_IsUnderWriteFlow01",
                table: "SignProcess",
                column: "IsUnderWriteFlow");

            migrationBuilder.CreateIndex(
                name: "NIDX_TypeID01",
                table: "SignProcess",
                column: "TypeID");

            migrationBuilder.CreateIndex(
                name: "IX_SpareCarReport_SpareCarID",
                table: "SpareCarReport",
                column: "SpareCarID");

            migrationBuilder.CreateIndex(
                name: "IX_SupplementaryInfo_BGID",
                table: "SupplementaryInfo",
                column: "BGID");

            migrationBuilder.CreateIndex(
                name: "IX_TemporaryCredentials_CompanyID",
                table: "TemporaryCredentials",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_VehiclePersonnel_VehiclePermitID",
                table: "VehiclePersonnel",
                column: "VehiclePermitID");

            migrationBuilder.CreateIndex(
                name: "IX_VipCardNum_VipCardID",
                table: "VipCardNum",
                column: "VipCardID");

            migrationBuilder.CreateIndex(
                name: "IX_VisitantCertificate_CardID",
                table: "VisitantCertificate",
                column: "CardID");

            migrationBuilder.CreateIndex(
                name: "IX_VisitantCertificate_CompanyID",
                table: "VisitantCertificate",
                column: "CompanyID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "A_TestTable");

            migrationBuilder.DropTable(
                name: "acc");

            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "AdminRole");

            migrationBuilder.DropTable(
                name: "Android_UserLoading");

            migrationBuilder.DropTable(
                name: "APEXSQL_LOG_CONNECTION_MONITOR_SESSION");

            migrationBuilder.DropTable(
                name: "APEXSQL_LOG_LOGIN");

            migrationBuilder.DropTable(
                name: "APEXSQL_LOG_STRINGS");

            migrationBuilder.DropTable(
                name: "App_UserBeforeLoding");

            migrationBuilder.DropTable(
                name: "ApplicationSignoff");

            migrationBuilder.DropTable(
                name: "AppointmentAddress");

            migrationBuilder.DropTable(
                name: "AppointmentCount");

            migrationBuilder.DropTable(
                name: "AppointmentDate");

            migrationBuilder.DropTable(
                name: "AppointmentDateTime");

            migrationBuilder.DropTable(
                name: "AppointmentLog");

            migrationBuilder.DropTable(
                name: "AppointmentPeople");

            migrationBuilder.DropTable(
                name: "AppointmentTime");

            migrationBuilder.DropTable(
                name: "AppointPeople");

            migrationBuilder.DropTable(
                name: "Area");

            migrationBuilder.DropTable(
                name: "AreaCard");

            migrationBuilder.DropTable(
                name: "AreaDetail");

            migrationBuilder.DropTable(
                name: "Areafor_ImExProduct");

            migrationBuilder.DropTable(
                name: "AreaPowerManager");

            migrationBuilder.DropTable(
                name: "AreaPowerManagerApplication");

            migrationBuilder.DropTable(
                name: "AreaPowerManagerApprove");

            migrationBuilder.DropTable(
                name: "AreaPowerManagerProc");

            migrationBuilder.DropTable(
                name: "AreaPowerManagerStatus");

            migrationBuilder.DropTable(
                name: "AreaPowerManagerType");

            migrationBuilder.DropTable(
                name: "AreaRegion");

            migrationBuilder.DropTable(
                name: "AreaRegionCertificate");

            migrationBuilder.DropTable(
                name: "AreaRegionHistory");

            migrationBuilder.DropTable(
                name: "AreaRegionValid");

            migrationBuilder.DropTable(
                name: "AreaRegionVehiclePeriod");

            migrationBuilder.DropTable(
                name: "AreaRelation");

            migrationBuilder.DropTable(
                name: "AuditProcess");

            migrationBuilder.DropTable(
                name: "BGMatch");

            migrationBuilder.DropTable(
                name: "BlackList");

            migrationBuilder.DropTable(
                name: "Building");

            migrationBuilder.DropTable(
                name: "byf");

            migrationBuilder.DropTable(
                name: "byf_1");

            migrationBuilder.DropTable(
                name: "byf_2");

            migrationBuilder.DropTable(
                name: "byf_3");

            migrationBuilder.DropTable(
                name: "Camera");

            migrationBuilder.DropTable(
                name: "CameraStatus");

            migrationBuilder.DropTable(
                name: "Car");

            migrationBuilder.DropTable(
                name: "car_inout_record");

            migrationBuilder.DropTable(
                name: "Card_Test");

            migrationBuilder.DropTable(
                name: "CardAdded");

            migrationBuilder.DropTable(
                name: "CardBorrow");

            migrationBuilder.DropTable(
                name: "CardChangeHistory");

            migrationBuilder.DropTable(
                name: "CardCompanyHistory");

            migrationBuilder.DropTable(
                name: "CardCreateTables");

            migrationBuilder.DropTable(
                name: "CardHistoryData");

            migrationBuilder.DropTable(
                name: "CardModel");

            migrationBuilder.DropTable(
                name: "CardSwipe");

            migrationBuilder.DropTable(
                name: "CardText");

            migrationBuilder.DropTable(
                name: "CardVendor");

            migrationBuilder.DropTable(
                name: "CarPass");

            migrationBuilder.DropTable(
                name: "CarPassBill");

            migrationBuilder.DropTable(
                name: "CarPassProc");

            migrationBuilder.DropTable(
                name: "CarPassStatus");

            migrationBuilder.DropTable(
                name: "CarToStop01");

            migrationBuilder.DropTable(
                name: "CarTypePass");

            migrationBuilder.DropTable(
                name: "CarVip");

            migrationBuilder.DropTable(
                name: "CarVipProc");

            migrationBuilder.DropTable(
                name: "CarVipStatus");

            migrationBuilder.DropTable(
                name: "Certificate_Delay");

            migrationBuilder.DropTable(
                name: "CertificateDB");

            migrationBuilder.DropTable(
                name: "CertificatesDelay");

            migrationBuilder.DropTable(
                name: "ChargeRecords");

            migrationBuilder.DropTable(
                name: "CheckTemp");

            migrationBuilder.DropTable(
                name: "CheckTime");

            migrationBuilder.DropTable(
                name: "Chemistry_Authority_History");

            migrationBuilder.DropTable(
                name: "Chemistry_DocforMaterial");

            migrationBuilder.DropTable(
                name: "ChemistryAuthority_ChangeEmail");

            migrationBuilder.DropTable(
                name: "ChemistryForm");

            migrationBuilder.DropTable(
                name: "ChemistryForm",
                schema: "faceid");

            migrationBuilder.DropTable(
                name: "ChemistryForm_Authority");

            migrationBuilder.DropTable(
                name: "Chr_EmpCardinfo");

            migrationBuilder.DropTable(
                name: "Chr_EmpCardinfo_temp");

            migrationBuilder.DropTable(
                name: "Chr_Employee");

            migrationBuilder.DropTable(
                name: "Chr_Employee_Image");

            migrationBuilder.DropTable(
                name: "chr_employee_switch");

            migrationBuilder.DropTable(
                name: "chr_employee_tmp");

            migrationBuilder.DropTable(
                name: "Chr_employee_Transit");

            migrationBuilder.DropTable(
                name: "Chr_EmployeeUpdate");

            migrationBuilder.DropTable(
                name: "Chr_InFactory_Image");

            migrationBuilder.DropTable(
                name: "CivetIntentList");

            migrationBuilder.DropTable(
                name: "CivetIntentListMail");

            migrationBuilder.DropTable(
                name: "CivetListMail");

            migrationBuilder.DropTable(
                name: "CivetSendMess");

            migrationBuilder.DropTable(
                name: "CMC812log");

            migrationBuilder.DropTable(
                name: "code");

            migrationBuilder.DropTable(
                name: "ColorTypeCard");

            migrationBuilder.DropTable(
                name: "CompanyControlHistory");

            migrationBuilder.DropTable(
                name: "Construction");

            migrationBuilder.DropTable(
                name: "contolstatus_information");

            migrationBuilder.DropTable(
                name: "ControlCar");

            migrationBuilder.DropTable(
                name: "ControlCarN");

            migrationBuilder.DropTable(
                name: "ControlPeople");

            migrationBuilder.DropTable(
                name: "ControlPeopleBackup");

            migrationBuilder.DropTable(
                name: "ControlPeopleN");

            migrationBuilder.DropTable(
                name: "ControlRecord");

            migrationBuilder.DropTable(
                name: "ContrucProc");

            migrationBuilder.DropTable(
                name: "ContrucStatus");

            migrationBuilder.DropTable(
                name: "CostSign");

            migrationBuilder.DropTable(
                name: "Credential_DelayNew");

            migrationBuilder.DropTable(
                name: "CredentialContinu");

            migrationBuilder.DropTable(
                name: "CredentialDelaynew_ListCardNum");

            migrationBuilder.DropTable(
                name: "CredentialDelaynew_ListCardNum_New");

            migrationBuilder.DropTable(
                name: "CredentialDelayNew_SigStatus");

            migrationBuilder.DropTable(
                name: "CustCardRecord");

            migrationBuilder.DropTable(
                name: "CustList");

            migrationBuilder.DropTable(
                name: "CustNotList");

            migrationBuilder.DropTable(
                name: "CustTravelDetail");

            migrationBuilder.DropTable(
                name: "CustWorCredentsLastInserted",
                schema: "faceid");

            migrationBuilder.DropTable(
                name: "CustWorkCredentials");

            migrationBuilder.DropTable(
                name: "CustWorkCredentialsDelay");

            migrationBuilder.DropTable(
                name: "CustWorkHistory");

            migrationBuilder.DropTable(
                name: "CustWorkInFactory");

            migrationBuilder.DropTable(
                name: "CustWorkInFactory_PerSon");

            migrationBuilder.DropTable(
                name: "CustWorkInFactoryAdmin_Proc");

            migrationBuilder.DropTable(
                name: "CustWorkInFactoryProc");

            migrationBuilder.DropTable(
                name: "CustWorkInFactoryStatus");

            migrationBuilder.DropTable(
                name: "CustWorkValid");

            migrationBuilder.DropTable(
                name: "CustWorkValidNew",
                schema: "faceid");

            migrationBuilder.DropTable(
                name: "dbo.Chr_employee2");

            migrationBuilder.DropTable(
                name: "DealType");

            migrationBuilder.DropTable(
                name: "DefaultCardInfo");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "DepartmentAuditPerson");

            migrationBuilder.DropTable(
                name: "DietAttention");

            migrationBuilder.DropTable(
                name: "DimissionUserBeforeLoding");

            migrationBuilder.DropTable(
                name: "DispatchRecords");

            migrationBuilder.DropTable(
                name: "DoorPowerManageArea");

            migrationBuilder.DropTable(
                name: "DoorPowerManageAreaApplication");

            migrationBuilder.DropTable(
                name: "DoorPowerManageAreaVer");

            migrationBuilder.DropTable(
                name: "DoorPowerManageBGSetup");

            migrationBuilder.DropTable(
                name: "DoorPowerManageBGSetupItem");

            migrationBuilder.DropTable(
                name: "DoorPowerManageBGSignSetupItem");

            migrationBuilder.DropTable(
                name: "DoorPowerManageModifyList");

            migrationBuilder.DropTable(
                name: "DoorPowerManageType");

            migrationBuilder.DropTable(
                name: "DoorPowerManageTypeApplication");

            migrationBuilder.DropTable(
                name: "DoorPowerManageTypeVer");

            migrationBuilder.DropTable(
                name: "DoorReplace");

            migrationBuilder.DropTable(
                name: "DoorReplaceBG");

            migrationBuilder.DropTable(
                name: "Driver");

            migrationBuilder.DropTable(
                name: "DriverCompanyMatch");

            migrationBuilder.DropTable(
                name: "DriverVehicleMatch");

            migrationBuilder.DropTable(
                name: "EconConfig");

            migrationBuilder.DropTable(
                name: "EhsSign");

            migrationBuilder.DropTable(
                name: "ElectricUse");

            migrationBuilder.DropTable(
                name: "Envi_EnclosedSpace");

            migrationBuilder.DropTable(
                name: "EnviHighAction");

            migrationBuilder.DropTable(
                name: "Exemption_Car");

            migrationBuilder.DropTable(
                name: "ExpCar");

            migrationBuilder.DropTable(
                name: "FingerPrint");

            migrationBuilder.DropTable(
                name: "FireEngine");

            migrationBuilder.DropTable(
                name: "Form");

            migrationBuilder.DropTable(
                name: "FormBack",
                schema: "faceid");

            migrationBuilder.DropTable(
                name: "FormbackTest",
                schema: "faceid");

            migrationBuilder.DropTable(
                name: "FormStatus");

            migrationBuilder.DropTable(
                name: "FormWorkProc");

            migrationBuilder.DropTable(
                name: "GoingOut");

            migrationBuilder.DropTable(
                name: "gongyingshang");

            migrationBuilder.DropTable(
                name: "GroupChiefExecutive");

            migrationBuilder.DropTable(
                name: "GroupType");

            migrationBuilder.DropTable(
                name: "HandleResult");

            migrationBuilder.DropTable(
                name: "HandleTrouble");

            migrationBuilder.DropTable(
                name: "HangleSign");

            migrationBuilder.DropTable(
                name: "Help");

            migrationBuilder.DropTable(
                name: "HGCarInfo");

            migrationBuilder.DropTable(
                name: "Hinhvv");

            migrationBuilder.DropTable(
                name: "HoanCong");

            migrationBuilder.DropTable(
                name: "Hoisting");

            migrationBuilder.DropTable(
                name: "HouseLayer");

            migrationBuilder.DropTable(
                name: "IcivetLogin");

            migrationBuilder.DropTable(
                name: "ImExPortProduct");

            migrationBuilder.DropTable(
                name: "ImExPortProduct_DriverInfor");

            migrationBuilder.DropTable(
                name: "ImExPortProduct_ProductInfor");

            migrationBuilder.DropTable(
                name: "Intermittent");

            migrationBuilder.DropTable(
                name: "InteruptInfrared");

            migrationBuilder.DropTable(
                name: "ItDevice_Info");

            migrationBuilder.DropTable(
                name: "ItDevices");

            migrationBuilder.DropTable(
                name: "ITDevices_ListPass");

            migrationBuilder.DropTable(
                name: "Itinerary");

            migrationBuilder.DropTable(
                name: "JurisdictionType");

            migrationBuilder.DropTable(
                name: "Layer");

            migrationBuilder.DropTable(
                name: "LeaseContract");

            migrationBuilder.DropTable(
                name: "Links");

            migrationBuilder.DropTable(
                name: "List");

            migrationBuilder.DropTable(
                name: "ListCamera");

            migrationBuilder.DropTable(
                name: "ListCarMer");

            migrationBuilder.DropTable(
                name: "ListCarPass");

            migrationBuilder.DropTable(
                name: "ListMer");

            migrationBuilder.DropTable(
                name: "ListOutPL");

            migrationBuilder.DropTable(
                name: "ListPosisionCar");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "lodging");

            migrationBuilder.DropTable(
                name: "log");

            migrationBuilder.DropTable(
                name: "MachineIPPairing");

            migrationBuilder.DropTable(
                name: "MachineIPPairingInfo");

            migrationBuilder.DropTable(
                name: "MakeCardArea");

            migrationBuilder.DropTable(
                name: "MakeCardDataError");

            migrationBuilder.DropTable(
                name: "MaterialforChemistry");

            migrationBuilder.DropTable(
                name: "MaterialforChemistry",
                schema: "faceid");

            migrationBuilder.DropTable(
                name: "Meal");

            migrationBuilder.DropTable(
                name: "Merchandise");

            migrationBuilder.DropTable(
                name: "MerCheProc");

            migrationBuilder.DropTable(
                name: "MerCheStatus");

            migrationBuilder.DropTable(
                name: "MerProc");

            migrationBuilder.DropTable(
                name: "MerStatus");

            migrationBuilder.DropTable(
                name: "MerTransfer");

            migrationBuilder.DropTable(
                name: "MerTransferProc");

            migrationBuilder.DropTable(
                name: "MerTrasferStatus");

            migrationBuilder.DropTable(
                name: "Message");

            migrationBuilder.DropTable(
                name: "MessageType");

            migrationBuilder.DropTable(
                name: "MessSenLog");

            migrationBuilder.DropTable(
                name: "MfCarRental");

            migrationBuilder.DropTable(
                name: "mqq");

            migrationBuilder.DropTable(
                name: "mqq1");

            migrationBuilder.DropTable(
                name: "mqq3");

            migrationBuilder.DropTable(
                name: "NighAction");

            migrationBuilder.DropTable(
                name: "NotesSendLog");

            migrationBuilder.DropTable(
                name: "nvipcard_From165");

            migrationBuilder.DropTable(
                name: "OilRecords");

            migrationBuilder.DropTable(
                name: "OndutyForATTW_Approve");

            migrationBuilder.DropTable(
                name: "OndutyForATTW_ListAuthor");

            migrationBuilder.DropTable(
                name: "OndutyForAttw_ListLocations");

            migrationBuilder.DropTable(
                name: "OndutyForAttw_ListLocationsSign");

            migrationBuilder.DropTable(
                name: "OndutyForAttw_RulesForAllLocation");

            migrationBuilder.DropTable(
                name: "OndutyForATTW_StatusSign");

            migrationBuilder.DropTable(
                name: "OndutyListLocations");

            migrationBuilder.DropTable(
                name: "OndutyOfAttwDepart");

            migrationBuilder.DropTable(
                name: "OndutyOfAttwDepart_FrameTime");

            migrationBuilder.DropTable(
                name: "OndutySign");

            migrationBuilder.DropTable(
                name: "OndutySign_Area");

            migrationBuilder.DropTable(
                name: "OndutySign_LocationSign");

            migrationBuilder.DropTable(
                name: "OndutySign_LocationSign_HistoryAll");

            migrationBuilder.DropTable(
                name: "OndutySignForAttw_Area");

            migrationBuilder.DropTable(
                name: "OndutySignOfAttw_ListEmpNo");

            migrationBuilder.DropTable(
                name: "othercar");

            migrationBuilder.DropTable(
                name: "OtherCarInfo");

            migrationBuilder.DropTable(
                name: "ParkProfileChart");

            migrationBuilder.DropTable(
                name: "PassForm");

            migrationBuilder.DropTable(
                name: "PeoPleList");

            migrationBuilder.DropTable(
                name: "PersonalDocuments");

            migrationBuilder.DropTable(
                name: "PersonalItem_Images");

            migrationBuilder.DropTable(
                name: "PersonalItem_ListItems");

            migrationBuilder.DropTable(
                name: "PersonalItems_Authority");

            migrationBuilder.DropTable(
                name: "PersonalItems_SigStatus");

            migrationBuilder.DropTable(
                name: "PersonalItemsForm");

            migrationBuilder.DropTable(
                name: "PhotoIDMatch");

            migrationBuilder.DropTable(
                name: "PLApplication");

            migrationBuilder.DropTable(
                name: "PLList");

            migrationBuilder.DropTable(
                name: "PLListOut");

            migrationBuilder.DropTable(
                name: "PLListOut_ProtectorReset");

            migrationBuilder.DropTable(
                name: "PLListValid");

            migrationBuilder.DropTable(
                name: "PosisionCarVip");

            migrationBuilder.DropTable(
                name: "PossionCar");

            migrationBuilder.DropTable(
                name: "PowerAdmin");

            migrationBuilder.DropTable(
                name: "PowerList");

            migrationBuilder.DropTable(
                name: "PowerRole");

            migrationBuilder.DropTable(
                name: "PrintCard");

            migrationBuilder.DropTable(
                name: "ProcessCarPass");

            migrationBuilder.DropTable(
                name: "ProcMer");

            migrationBuilder.DropTable(
                name: "ProductOpportunities");

            migrationBuilder.DropTable(
                name: "ProductOpportunitiesCust");

            migrationBuilder.DropTable(
                name: "Profier2013051010");

            migrationBuilder.DropTable(
                name: "Profiler2013050922");

            migrationBuilder.DropTable(
                name: "QiMeiEmployeeExamine");

            migrationBuilder.DropTable(
                name: "QiMeiTwEmloyeeUpdate");

            migrationBuilder.DropTable(
                name: "QuitApply");

            migrationBuilder.DropTable(
                name: "ReceivingCarPass");

            migrationBuilder.DropTable(
                name: "ReceivingRecords");

            migrationBuilder.DropTable(
                name: "ReceptionProgram");

            migrationBuilder.DropTable(
                name: "ReceptionProgramGovernment");

            migrationBuilder.DropTable(
                name: "RecovertRecords");

            migrationBuilder.DropTable(
                name: "Region");

            migrationBuilder.DropTable(
                name: "RegionHouse");

            migrationBuilder.DropTable(
                name: "RemandRecords");

            migrationBuilder.DropTable(
                name: "Request114");

            migrationBuilder.DropTable(
                name: "Request114Sign");

            migrationBuilder.DropTable(
                name: "RequestProc114");

            migrationBuilder.DropTable(
                name: "RequestStatus114");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "SchedulePlan");

            migrationBuilder.DropTable(
                name: "ScrapCar");

            migrationBuilder.DropTable(
                name: "ScrapCar_GaReject");

            migrationBuilder.DropTable(
                name: "ScrapCar_HistoryCheckPass");

            migrationBuilder.DropTable(
                name: "ScrapCarAuthority");

            migrationBuilder.DropTable(
                name: "ScrapCarContructor_Authority");

            migrationBuilder.DropTable(
                name: "ScrapCarIn");

            migrationBuilder.DropTable(
                name: "ScrapContructorIn");

            migrationBuilder.DropTable(
                name: "ScrapContructorIn_ListDriver");

            migrationBuilder.DropTable(
                name: "ScrapInconstant");

            migrationBuilder.DropTable(
                name: "ScrapInconstantAuthor");

            migrationBuilder.DropTable(
                name: "ScrapList");

            migrationBuilder.DropTable(
                name: "ScrapOut");

            migrationBuilder.DropTable(
                name: "ScrapOutProc");

            migrationBuilder.DropTable(
                name: "ScrapOutStatus");

            migrationBuilder.DropTable(
                name: "SecuretyTable");

            migrationBuilder.DropTable(
                name: "SecurityError");

            migrationBuilder.DropTable(
                name: "SecurityInfor");

            migrationBuilder.DropTable(
                name: "SecurityList");

            migrationBuilder.DropTable(
                name: "SecurityProcess");

            migrationBuilder.DropTable(
                name: "SecurityReport");

            migrationBuilder.DropTable(
                name: "SecurityReportSigner");

            migrationBuilder.DropTable(
                name: "SecurityTrain");

            migrationBuilder.DropTable(
                name: "SeMerTransfer");

            migrationBuilder.DropTable(
                name: "SendSMS");

            migrationBuilder.DropTable(
                name: "SerialNumber");

            migrationBuilder.DropTable(
                name: "Sheet1$");

            migrationBuilder.DropTable(
                name: "ShuttleVisitors");

            migrationBuilder.DropTable(
                name: "SignLog");

            migrationBuilder.DropTable(
                name: "SignProcess");

            migrationBuilder.DropTable(
                name: "SignRole");

            migrationBuilder.DropTable(
                name: "SignStatus");

            migrationBuilder.DropTable(
                name: "SigStatusChemistry");

            migrationBuilder.DropTable(
                name: "SigStatusChemistry",
                schema: "faceid");

            migrationBuilder.DropTable(
                name: "SpareCarReport");

            migrationBuilder.DropTable(
                name: "StatusMer");

            migrationBuilder.DropTable(
                name: "SupplementaryInfo");

            migrationBuilder.DropTable(
                name: "Supplier");

            migrationBuilder.DropTable(
                name: "Temp_Contact");

            migrationBuilder.DropTable(
                name: "TemporaryCredentials");

            migrationBuilder.DropTable(
                name: "Test_table");

            migrationBuilder.DropTable(
                name: "Test_Table_Sentdata1");

            migrationBuilder.DropTable(
                name: "Test_Table_Sentdata2");

            migrationBuilder.DropTable(
                name: "TestUploadImage");

            migrationBuilder.DropTable(
                name: "ToPrint");

            migrationBuilder.DropTable(
                name: "TotalType");

            migrationBuilder.DropTable(
                name: "TroubleImage");

            migrationBuilder.DropTable(
                name: "TroubleType");

            migrationBuilder.DropTable(
                name: "TT_Corona2019ByBG");

            migrationBuilder.DropTable(
                name: "TT_DichCorona2020");

            migrationBuilder.DropTable(
                name: "TTT");

            migrationBuilder.DropTable(
                name: "TWEmployee");

            migrationBuilder.DropTable(
                name: "TWEmployeeBack");

            migrationBuilder.DropTable(
                name: "TWEmployeeUpdate");

            migrationBuilder.DropTable(
                name: "TWEmployeeUpdateBack");

            migrationBuilder.DropTable(
                name: "TypeConfig");

            migrationBuilder.DropTable(
                name: "UnderWriteFlow");

            migrationBuilder.DropTable(
                name: "UnderWriteModel");

            migrationBuilder.DropTable(
                name: "UnderWriteRecord");

            migrationBuilder.DropTable(
                name: "UnderWriteType");

            migrationBuilder.DropTable(
                name: "Untitled - 3",
                schema: "db_owner");

            migrationBuilder.DropTable(
                name: "UpdateScrap");

            migrationBuilder.DropTable(
                name: "Url");

            migrationBuilder.DropTable(
                name: "UserBeforeLoding");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserIDZalo");

            migrationBuilder.DropTable(
                name: "UserLogin");

            migrationBuilder.DropTable(
                name: "UserMember");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "VehicleCardRecord");

            migrationBuilder.DropTable(
                name: "VehicleImportRecord_FstTier");

            migrationBuilder.DropTable(
                name: "VehicleImportRecord_FstTier_History");

            migrationBuilder.DropTable(
                name: "VehicleImportRecord_FstTier_Temp");

            migrationBuilder.DropTable(
                name: "VehicleImportRecord_LHAQDM");

            migrationBuilder.DropTable(
                name: "VehiclePeriod");

            migrationBuilder.DropTable(
                name: "VehiclePermitAppend");

            migrationBuilder.DropTable(
                name: "VehiclePermitEmployee");

            migrationBuilder.DropTable(
                name: "VehiclePermitHistory");

            migrationBuilder.DropTable(
                name: "VehiclePermitPhoto");

            migrationBuilder.DropTable(
                name: "VehiclePermitValid");

            migrationBuilder.DropTable(
                name: "VehiclePersonnel");

            migrationBuilder.DropTable(
                name: "VehiclesEmployee");

            migrationBuilder.DropTable(
                name: "VeQuestionnaire");

            migrationBuilder.DropTable(
                name: "View_DriverCardMatch");

            migrationBuilder.DropTable(
                name: "View_DriverCardMatchTemp");

            migrationBuilder.DropTable(
                name: "View_Old_ncomeuser");

            migrationBuilder.DropTable(
                name: "View_Old_ncomeuserTemp1");

            migrationBuilder.DropTable(
                name: "View_Old_nusercard");

            migrationBuilder.DropTable(
                name: "View_Old_nusercardTemp1");

            migrationBuilder.DropTable(
                name: "View_SwipingCardCheck");

            migrationBuilder.DropTable(
                name: "View_SwipingCardCheckTemp1");

            migrationBuilder.DropTable(
                name: "View_VehicleCardCheck");

            migrationBuilder.DropTable(
                name: "View_VehicleCardCheckTemp");

            migrationBuilder.DropTable(
                name: "ViheWeight");

            migrationBuilder.DropTable(
                name: "VipCard");

            migrationBuilder.DropTable(
                name: "VIPCardApplication");

            migrationBuilder.DropTable(
                name: "VipCardNum");

            migrationBuilder.DropTable(
                name: "VipDisable");

            migrationBuilder.DropTable(
                name: "VipOutCall");

            migrationBuilder.DropTable(
                name: "VisitantCertificate");

            migrationBuilder.DropTable(
                name: "VisitArrangements");

            migrationBuilder.DropTable(
                name: "VisitCar");

            migrationBuilder.DropTable(
                name: "VisitCard");

            migrationBuilder.DropTable(
                name: "VisitCredentials");

            migrationBuilder.DropTable(
                name: "VisitCredentialsProc");

            migrationBuilder.DropTable(
                name: "VisitCredentialsStatus");

            migrationBuilder.DropTable(
                name: "VisitCustomer");

            migrationBuilder.DropTable(
                name: "VisitFactory");

            migrationBuilder.DropTable(
                name: "VisitGovernment");

            migrationBuilder.DropTable(
                name: "VisitGovernmentAdvanced");

            migrationBuilder.DropTable(
                name: "VisitGovernmentAdvancedList");

            migrationBuilder.DropTable(
                name: "VisitGovernmentList");

            migrationBuilder.DropTable(
                name: "VisitHistory");

            migrationBuilder.DropTable(
                name: "VisitList");

            migrationBuilder.DropTable(
                name: "VisitNature");

            migrationBuilder.DropTable(
                name: "VisitNatureCust");

            migrationBuilder.DropTable(
                name: "VisitNotCust");

            migrationBuilder.DropTable(
                name: "Visitors");

            migrationBuilder.DropTable(
                name: "VisitStatus");

            migrationBuilder.DropTable(
                name: "WebVerson");

            migrationBuilder.DropTable(
                name: "WebVisitRecord");

            migrationBuilder.DropTable(
                name: "WeeklyReport");

            migrationBuilder.DropTable(
                name: "WeiCall");

            migrationBuilder.DropTable(
                name: "WeightAPI");

            migrationBuilder.DropTable(
                name: "WeightAPI1");

            migrationBuilder.DropTable(
                name: "WeightPO");

            migrationBuilder.DropTable(
                name: "WorkNotes");

            migrationBuilder.DropTable(
                name: "WorkTypeInFac");

            migrationBuilder.DropTable(
                name: "YHUHU");

            migrationBuilder.DropTable(
                name: "CustTravel");

            migrationBuilder.DropTable(
                name: "DoorPowerManageBGSignSetup");

            migrationBuilder.DropTable(
                name: "DoorPowerManageModify");

            migrationBuilder.DropTable(
                name: "DoorPowerManage");

            migrationBuilder.DropTable(
                name: "DoorPowerManageApplication");

            migrationBuilder.DropTable(
                name: "DoorPowerManageVer");

            migrationBuilder.DropTable(
                name: "InvalidRecords");

            migrationBuilder.DropTable(
                name: "SpareCar");

            migrationBuilder.DropTable(
                name: "BG");

            migrationBuilder.DropTable(
                name: "VehiclePermit");

            migrationBuilder.DropTable(
                name: "VipCardReceive");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "ApplicationDoor");

            migrationBuilder.DropTable(
                name: "Card");
        }
    }
}
