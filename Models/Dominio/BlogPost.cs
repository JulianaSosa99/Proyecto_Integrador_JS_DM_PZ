namespace Proyecto_Integrador_JS_DM_PZ.Models.Dominio
{
    public class BlogPost
    {
        public Guid ID { get; set; }

        public string Encabezado { get; set; }

        public string TituloPagina{ get; set; }

        public string Contenido { get; set; }
        public string Descripcion { get; set; }

        public string ImagenUrl{ get; set; }
        public string ManejoUrl { get; set; }
        public DateTime FechaPublicacion { get; set; }

        public string Autor {  get; set; }
        public bool Visibilidad { get; set; }

        public ICollection<Tag> Tags { get; set; }
    }   
}
