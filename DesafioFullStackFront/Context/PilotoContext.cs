using System.ComponentModel;
using System.Text.Json;
using DesafioFullStackFront.Models;
using static System.Net.WebRequestMethods;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json.Serialization;


namespace DesafioFullStackFront.Context
{
    public class PilotoContext
    {


        private readonly HttpClient _httpClient;

        //construtor que recebe o HttpClient que recebe pelo Blazor WASM
        public PilotoContext(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Piloto>> GetPilotos()
        {
            try 
            {
                //URI será defenida no program.cs do Blazor WASM, onde o HttpClient é configurado
                //Cria a requisição Get para endpoint "api/pilotos/piloto"
                HttpResponseMessage requisicao = await _httpClient.GetAsync("api/pilotos/piloto");

                //se o status não der ok terá um eceção
                requisicao.EnsureSuccessStatusCode();

                //lê o corpo da resposta como uma string
                string rawBody = await requisicao.Content.ReadAsStringAsync();

                if(string.IsNullOrEmpty(rawBody))
                {
                    return new List<Piloto>(); // Retorna uma lista vazia se o corpo estiver vazio
                }

                JsonSerializerOptions options = new JsonSerializerOptions
                {
                    // Para ignorar maiúsculas/minúsculas nos NOMES das propriedades
                    PropertyNameCaseInsensitive = true,

                    //converte enum para string
                    Converters = { new JsonStringEnumConverter() }


                };

                // Desserializa o JSON para uma lista de objetos Piloto para que o c# consiga ler o json
                List<Piloto> pilotos = JsonSerializer.Deserialize<List<Piloto>>(rawBody, options);

                return pilotos;

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar pilotos: " + ex.Message);
            }
        }



        /*  HttpClient http = new HttpClient();
              string urlApi = "http://localhost:5110/api";
              string endpoint = "/pilotos/piloto";
              HttpRequestMessage requisicao = new HttpRequestMessage();
              requisicao.Method = HttpMethod.Get;
              requisicao.RequestUri = new Uri(urlApi + endpoint);

              HttpResponseMessage responseMessage = await http.SendAsync(requisicao);

              string rawBody = await responseMessage.Content.ReadAsStringAsync();
              if(rawBody == "")
              {
                  return new List<Piloto>();
              }

              List<Piloto> pilotos = JsonSerializer.Deserialize<List<Piloto>>(rawBody, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

              return pilotos; */

    }
}

