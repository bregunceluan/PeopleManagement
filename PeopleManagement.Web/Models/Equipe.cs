using Newtonsoft.Json;

namespace PeopleManagement.Web.Models
{
    public class Equipe
    {
        public Equipe(int id, string nome, string descricao, int coordId, int gestorId)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            CoordId = coordId;
            GestorId = gestorId;
        }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Nome { get; set; }

        [JsonProperty("descricao")]
        public string Descricao { get; set; }

        [JsonProperty("coordenadorId")]
        public int CoordId { get; set; }

        [JsonProperty("gestorId")]
        public int GestorId { get; set; }
    }
}
