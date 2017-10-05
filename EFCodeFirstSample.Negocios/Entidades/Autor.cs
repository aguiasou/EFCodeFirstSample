namespace EFCodeFirstSample.Negocios.Entidades
{
    public class Autor: Entity
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public string Origem { get; set; }
    }
}