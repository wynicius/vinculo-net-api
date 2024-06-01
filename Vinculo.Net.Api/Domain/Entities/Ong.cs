namespace Vinculo_Net_Api.Domain.Entities
{
    public class Ong : EntidadeBase
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Whatsapp { get; set; }
        public string City { get; set; }
        public string Uf { get; set; }
    }
}