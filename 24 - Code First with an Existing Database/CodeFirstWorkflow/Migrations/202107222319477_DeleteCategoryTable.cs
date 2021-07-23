namespace CodeFirstWorkflow.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    //Deletetando tabela
    public partial class DeleteCategoryTable : DbMigration
    {
        public override void Up()
        {
            //Gerado:
            //DropTable("dbo.Categories");

            //1.
            //Preservando os dados da tabela
            //O crteate poderia ser feito usando Sql(); também
            CreateTable(
                "dbo._Categories",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                })
                .PrimaryKey(t => t.Id);
            Sql("INSERT INTO _Categories (Name) SELECT Name FROM Categories");
            DropTable("dbo.Categories");

        }
        
        public override void Down()
        {
            //Gerado:
            //CreateTable(
            //    "dbo.Categories",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            Name = c.String(),
            //        })
            //    .PrimaryKey(t => t.Id);

            //1.
            //Recuperando os dados da tabela _
            //O create poderia ser feito usando Sql(); também
            CreateTable(
                "dbo.Categories",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                })
                .PrimaryKey(t => t.Id);
            Sql("INSERT INTO Categories (Name) SELECT Name FROM _Categories");
            DropTable("dbo._Categories");

        }
    }
}
