using Newtonsoft.Json;

namespace PeopleManagement.Web.Models
{
    public class Cargo
    {
        public Cargo(int id, string nome, string descricao)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
        }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Nome { get; set; }

        [JsonProperty("descricao")]
        public string Descricao { get; set; }
    }
}
