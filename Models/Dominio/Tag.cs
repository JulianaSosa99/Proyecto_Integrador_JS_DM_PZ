namespace Proyecto_Integrador_JS_DM_PZ.Models.Dominio
{
    public class Tag
    {
        public Guid ID { get; set; }
        public string Nombre { get; set; }
        public string NombreDisplay { get; set; }
        public ICollection<BlogPost> BlogPosts { get; set; }
    }
}
