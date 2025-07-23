using System;

namespace DesafioFullStackFront.Models
{
    

    public class Piloto
    {

        public string Nome { get; set; } = string.Empty;
        public string Equipe { get; set; } = string.Empty;
        public TimeSpan MelhorVolta { get; set; }
        public double Peso { get; set; }
        public CategoriaPiloto Categoria { get; set; }
        public SexoPiloto Sexo { get; set; }
        public string Nacionalidade { get; set; } = string.Empty;
        public string Tracado { get; set; } = string.Empty;


        public Piloto()
        {

        }

    }
}
