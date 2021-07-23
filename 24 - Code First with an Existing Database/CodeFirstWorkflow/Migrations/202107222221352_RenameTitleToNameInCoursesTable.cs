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
            //N�o faz sentido tem um curso sem um nome
            //AddColumn("dbo.Courses", "Name", c => c.String(nullable:false));
            //DropColumn("dbo.Courses", "Title");

            //2.
            //Apagar uma coluna e criar outra apaga todos os dados dela, ent�o seria melhor usar rename
            //RenameColumn("dbo.Courses", "Title","Name");

            //3.
            //Outra op��o seria usar um m�todo SQL
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
            //� preciso alterar o Down() tamb�m, esse c�digo ser� rodado caso a migration seja desfeita
            //Tudo que � alterado em Up() deve ser alterado aqui de forma reversa
            AddColumn("dbo.Courses", "Title", c => c.String(nullable: false));
            Sql("UPDATE Courses SET Title = Name");
            DropColumn("dbo.Courses", "Name");
        }
    }
}
