using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FA.JustBlog.Core.Migrations
{
    public partial class AddTriggerAutomaticUpdateAt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE TRIGGER [dbo].[Tags_UPDATE] ON [dbo].[Tags]
                                        AFTER UPDATE
                                    AS
                                    BEGIN
                                        SET NOCOUNT ON;

                                        IF ((SELECT TRIGGER_NESTLEVEL()) > 1) RETURN;

                                        DECLARE @Id INT

                                        SELECT @Id = INSERTED.Id
                                        FROM INSERTED

                                        UPDATE dbo.Tags
                                        SET UpdateAt = GETDATE()
                                        WHERE Id = @Id
                                    END 
                               ");
            migrationBuilder.Sql(@"CREATE TRIGGER [dbo].[Categories_UPDATE] ON [dbo].[Categories]
                                        AFTER UPDATE
                                    AS
                                    BEGIN
                                        SET NOCOUNT ON;

                                        IF ((SELECT TRIGGER_NESTLEVEL()) > 1) RETURN;

                                        DECLARE @Id INT

                                        SELECT @Id = INSERTED.Id
                                        FROM INSERTED

                                        UPDATE dbo.Categories
                                        SET UpdateAt = GETDATE()
                                        WHERE Id = @Id
                                    END");
            migrationBuilder.Sql(@"CREATE TRIGGER [dbo].[Posts_UPDATE] ON [dbo].[Posts]
                                        AFTER UPDATE
                                    AS
                                    BEGIN
                                        SET NOCOUNT ON;

                                        IF ((SELECT TRIGGER_NESTLEVEL()) > 1) RETURN;

                                        DECLARE @Id INT

                                        SELECT @Id = INSERTED.Id
                                        FROM INSERTED

                                        UPDATE dbo.Posts
                                        SET UpdateAt = GETDATE()
                                        WHERE Id = @Id
                                    END");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP TRIGGER [dbo].[Categories_UPDATE]");
            migrationBuilder.Sql(@"DROP TRIGGER [dbo].[Posts_UPDATE]");
            migrationBuilder.Sql(@"DROP TRIGGER [dbo].[Tags_UPDATE]");
        }
    }
}
