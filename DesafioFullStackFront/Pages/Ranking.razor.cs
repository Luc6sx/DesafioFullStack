using DesafioFullStackFront.Models;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using System.Text.Json;

using Microsoft.AspNetCore.Components;
using DesafioFullStackFront.Context;




namespace DesafioFullStackFront.Pages
{
    

   
    public partial class Ranking : ComponentBase

    {
        [Inject]
        private PilotoContext pilotoContext { get; set; } // Injeção de dependência do contexto de Pilotos


        private List<Piloto> todosOsPilotos = new List<Piloto>();

        private List<Piloto> pilotosFiltrados = new List<Piloto>();

        private string? filtroCategoria;
        private string? filtroSexo;
        private string? filtroPeso; // O peso será tratado como string ("Leve", "Médio", "Pesado")
        private string? filtroTracado;
        public string? Erro { get; set; } // variavel pra guardar mensagem de erro

        public async Task Inicializar()
        {

            Console.WriteLine($"Número de pilotos carregados: {pilotosFiltrados?.Count ?? 0}");
            try
            {
                var options = new JsonSerializerOptions
                {
                    // Para ignorar maiúsculas/minúsculas nos NOMES das propriedades
                    PropertyNameCaseInsensitive = true,

                    // Esta nova opção é para os VALORES DOS ENUMS (ex: "Formula1", "Masculino")
                    Converters = { new JsonStringEnumConverter() }
                };

                // Pede ao HttpClient para buscar o arquivo JSON e já o converte (desserializa)
                // para uma lista de objetos Piloto.




                var pilotosCarregados = await pilotoContext.GetPilotos();

                // Verificação de segurança para garantir que a lista não seja nula
                if (pilotosCarregados != null)
                {
                    todosOsPilotos = pilotosCarregados;
                    AplicarFiltros();
                }
            }
            catch (Exception ex)
            {
                // se um erro acontecer na busca ou na conversão, será capturado aqui
                Erro = ex.Message; //guarda a mensagem de erro
                Console.WriteLine($"Ocorreu um erro: {ex.Message}");
            }
            finally
            {
                StateHasChanged();
            }

        }
        private void AplicarFiltros()
        {
            IEnumerable<Piloto> query = todosOsPilotos;

            // Aplicamos cada filtro se ele tiver um valor selecionado
            if (!string.IsNullOrEmpty(filtroCategoria))
            {
                query = query.Where(p => p.Categoria.ToString() == filtroCategoria);
            }

            if (!string.IsNullOrEmpty(filtroSexo))
            {
                query = query.Where(p => p.Sexo.ToString() == filtroSexo);
            }

            if (!string.IsNullOrEmpty(filtroTracado))
            {
                query = query.Where(p => p.Tracado == filtroTracado);
            }

            // Lógica para filtro de Peso (Exemplo: <70 Leve, 70-80 Médio, >80 Pesado)
            if (!string.IsNullOrEmpty(filtroPeso))
            {
                query = filtroPeso switch
                {
                    "Leve" => query.Where(p => p.Peso < 70),
                    "Medio" => query.Where(p => p.Peso >= 70 && p.Peso <= 80),
                    "Pesado" => query.Where(p => p.Peso > 80),
                    _ => query
                };
            }

            // A lista final filtrada é atribuída para ser exibida na tela
            pilotosFiltrados = query.ToList();
        }
    }
}
