namespace Aula1901.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class primeira : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Equipas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomeEquipa = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Equipas");
        }
    }
}
