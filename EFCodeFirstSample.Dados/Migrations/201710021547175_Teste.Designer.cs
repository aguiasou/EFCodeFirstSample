// <auto-generated />
namespace EFCodeFirstSample.Dados.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    using System.Resources;
    
    public sealed partial class Teste : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(Teste));
        
        string IMigrationMetadata.Id
        {
            get { return "201710021547175_Teste"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return Resources.GetString("Target"); }
        }
    }
}