

namespace DesafioFullStackFront.Models
{
	// Este record define a estrutura da nossa chave de agrupamento
	public record GrupoPilotoKey(CategoriaPiloto Categoria, SexoPiloto Sexo, string Tracado);
}