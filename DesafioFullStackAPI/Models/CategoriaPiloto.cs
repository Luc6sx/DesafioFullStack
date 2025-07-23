using System;
using System.Text.Json.Serialization;


namespace DesafioFullStackFront.Models
{
	[JsonConverter(typeof(JsonStringEnumConverter))]
	public enum CategoriaPiloto
	{
		Formula1,
		Endurance,
		StockCar,
		Kart
	}
}
