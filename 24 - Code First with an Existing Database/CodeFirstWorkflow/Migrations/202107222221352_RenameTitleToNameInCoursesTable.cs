namespace CodeFirstWorkflow.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    //Alterando nome da coluna
    public partial class RenameTitleToNameInCoursesTable : DbMigration
    {
        public override void Up()
        {

            //Gerado:
            //AddColumn("dbo.Courses", "Name", c => c.String());
            //DropColumn("dbo.Courses", "Title");

            //1.
            //Não faz sentido tem um curso sem um nome
            //AddColumn("dbo.Courses", "Name", c => c.String(nullable:false));
            //DropColumn("dbo.Courses", "Title");

            //2.
            //Apagar uma coluna e criar outra apaga todos os dados dela, então seria melhor usar rename
            //RenameColumn("dbo.Courses", "Title","Name");

            //3.
            //Outra opção seria usar um método SQL
            AddColumn("dbo.Courses", "Name", c => c.String(nullable:false));
            Sql("UPDATE Courses SET Name = Title");
            DropColumn("dbo.Courses", "Title");
        }

        public override void Down()
        {
            //Gerado:
            //AddColumn("dbo.Courses", "Title", c => c.String());
            //DropColumn("dbo.Courses", "Name");

            //1.
            //É preciso alterar o Down() também, esse código será rodado caso a migration seja desfeita
            //Tudo que é alterado em Up() deve ser alterado aqui de forma reversa
            AddColumn("dbo.Courses", "Title", c => c.String(nullable: false));
            Sql("UPDATE Courses SET Title = Name");
            DropColumn("dbo.Courses", "Name");
        }
    }
}
