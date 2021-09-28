using Microsoft.EntityFrameworkCore.Migrations;

namespace MeroThriftGhar.DataAccess.Migrations
{
    public partial class storedprocedures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"CREATE PROC [dbo].[usp_CreateCoverType]
                                   @Name varchar(100)
                                   AS 
                                   BEGIN 
                                    INSERT INTO dbo.CoverTypes(Name)
                                    VALUES (@Name)
                                   END";
            var sp1 = @"CREATE PROC [dbo].[usp_DeleteCoverType]
                                                @Id int
                                    AS 
                                    BEGIN 
                                     DELETE FROM dbo.CoverTypes
                                     WHERE  Id = @Id
                                    END";

            var sp2 = @"CREATE PROC [dbo].[usp_GetCoverType] 
                                    @Id int 
                                    AS 
                                    BEGIN 
                                     SELECT * FROM   dbo.CoverTypes  WHERE  (Id = @Id) 
                                    END";
            var sp3 = @"CREATE PROC [dbo].[usp_GetCoverTypes] 
                                    AS 
                                    BEGIN 
                                     SELECT * FROM   dbo.CoverTypes 
                                    END";
            var sp4 = @"CREATE PROC [dbo].[usp_UpdateCoverType]
                                                @Id int,
                                                @Name varchar(100)
                                    AS 
                                    BEGIN 
                                     UPDATE dbo.CoverTypes
                                     SET  Name = @Name
                                     WHERE  Id = @Id
                                    END";

            migrationBuilder.Sql(sp);
            migrationBuilder.Sql(sp1);
            migrationBuilder.Sql(sp2);
            migrationBuilder.Sql(sp3);
            migrationBuilder.Sql(sp4);
           
        }



        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
