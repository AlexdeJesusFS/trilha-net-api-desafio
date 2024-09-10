using System.Text.Json.Serialization;

namespace TrilhaApiDesafio.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum EnumStatusTarefa
    {
        Pendente,
        Finalizado
    }
}