namespace CodeFirstWorkflow.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    //Adicionando tabela

    public partial class AddCategoryTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                })
                .PrimaryKey(t => t.Id);

            //Inserido manualmente
            Sql("INSERT INTO Categories VALUES ('Web Development')");
            Sql("INSERT INTO Categories VALUES ('Programming Languages')");

        }
        
        public override void Down()
        {
            DropTable("dbo.Categories");
        }
    }
}
