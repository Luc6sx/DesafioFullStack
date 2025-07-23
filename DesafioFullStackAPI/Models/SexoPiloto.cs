using System;
using System.Text.Json.Serialization;


namespace DesafioFullStackFront.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum SexoPiloto
	{
		Masculino,
		Feminino
	}
}
