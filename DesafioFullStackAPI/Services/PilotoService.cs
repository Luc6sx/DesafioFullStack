using System.Text.Json;
using DesafioFullStackFront.Models;
using Microsoft.OpenApi.Services;

namespace DesafioFullStackAPI.Services
{
    public class PilotoService
    {
        public List<Piloto> GetPilotos()
        {
            string caminhoJson = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Dados" , "Pilotos.json");

            string stringJson = File.ReadAllText(caminhoJson);
            List<Piloto> pilotos = JsonSerializer.Deserialize<List<Piloto>>(stringJson);

            return pilotos;
        }
    }
}
