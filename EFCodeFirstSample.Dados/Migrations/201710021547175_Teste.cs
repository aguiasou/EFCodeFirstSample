namespace EFCodeFirstSample.Dados.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Teste : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Descricao = c.String(),
                        Livro_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Livroes", t => t.Livro_Id)
                .Index(t => t.Livro_Id);
            
            CreateTable(
                "dbo.Livroes",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Titulo = c.String(),
                        ISBN = c.String(),
                        Subtitulo = c.String(),
                        Edicao = c.String(),
                        Ano = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Autors",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Nome = c.String(),
                        Sobrenome = c.String(),
                        Origem = c.String(),
                        Livro_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Livroes", t => t.Livro_Id)
                .Index(t => t.Livro_Id);
            
            CreateTable(
                "dbo.Exemplars",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        DataAquisicao = c.DateTime(nullable: false),
                        Livro_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Livroes", t => t.Livro_Id)
                .Index(t => t.Livro_Id);
            
            CreateTable(
                "dbo.Emprestimoes",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        DataEmprestimo = c.DateTime(nullable: false),
                        DataDevolucao = c.DateTime(),
                        Usuario_Id = c.Long(),
                        Exemplar_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.Usuario_Id)
                .ForeignKey("dbo.Exemplars", t => t.Exemplar_Id)
                .Index(t => t.Usuario_Id)
                .Index(t => t.Exemplar_Id);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Emprestimoes", new[] { "Exemplar_Id" });
            DropIndex("dbo.Emprestimoes", new[] { "Usuario_Id" });
            DropIndex("dbo.Exemplars", new[] { "Livro_Id" });
            DropIndex("dbo.Autors", new[] { "Livro_Id" });
            DropIndex("dbo.Categorias", new[] { "Livro_Id" });
            DropForeignKey("dbo.Emprestimoes", "Exemplar_Id", "dbo.Exemplars");
            DropForeignKey("dbo.Emprestimoes", "Usuario_Id", "dbo.Usuarios");
            DropForeignKey("dbo.Exemplars", "Livro_Id", "dbo.Livroes");
            DropForeignKey("dbo.Autors", "Livro_Id", "dbo.Livroes");
            DropForeignKey("dbo.Categorias", "Livro_Id", "dbo.Livroes");
            DropTable("dbo.Emprestimoes");
            DropTable("dbo.Exemplars");
            DropTable("dbo.Autors");
            DropTable("dbo.Livroes");
            DropTable("dbo.Categorias");
            DropTable("dbo.Usuarios");
        }
    }
}
