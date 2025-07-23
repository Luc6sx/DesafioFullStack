Este projeto foi desenvolvido como parte do Desafio de Desenvolvimento Fullstack Web da Sisecom. A aplicação exibe um ranking interativo de pilotos de automobilismo, focando na exibição, agrupamento e filtragem de dados para simular uma experiência de acompanhamento de corridas.


*Tecnologias Utilizadas*
.NET / C#


Blazor WebAssembly 


ASP.NET Core Web API 


HTML/CSS 

*Requisitos do Desafio Atendidos*
*Requisitos Mínimos (Obrigatório)*
 

Tecnologias: Projeto desenvolvido com C# e Blazor WebAssembly, utilizando HTML/CSS para a interface.


Estrutura de Dados de Piloto: Foi definida uma classe Piloto com todas as propriedades mínimas, como Nome, Equipe, MelhorVolta (TimeSpan), e enums para Categoria e Sexo.


Listagem de Pilotos: A aplicação carrega e exibe com sucesso uma lista de pilotos a partir de um arquivo JSON, demonstrando a leitura de dados.


Interface de Ranking e Agrupamento: Os pilotos são apresentados em cards, agrupados visualmente por Categoria, Sexo e Traçado. Dentro de cada card, os pilotos são ordenados pela melhor volta.


Funcionalidades de Filtragem: Foram implementados filtros interativos que atualizam os cards em tempo real, permitindo refinar a visualização por Categoria, Sexo, Traçado e Classe de Peso.


Organização do Código: O código foi componentizado, separando a lógica da página principal (Ranking.razor) da exibição de cada card (CardPilotos.razor), demonstrando a separação de responsabilidades.

*Requisitos Adicionais (Pontos Extras)*

Design e UX: A interface foi estilizada com uma temática de automobilismo, utilizando uma paleta de cores com vermelho e branco.
 

Animações Sutis: Foi adicionada uma animação em CSS para o carregamento dos cards, melhorando a experiência do usuário.



Persistência de Dados (Fullstack): Foi criada uma API backend em ASP.NET Core para servir os dados do arquivo JSON, cumprindo o requisito fullstack para Blazor WebAssembly.

Responsividade Avançada: Foi implementada uma solução para a quebra de tabelas em telas de dispositivos móveis, garantindo uma boa experiência em diferentes tamanhos de tela.

*Jornada de Desenvolvimento e Aprendizados:*

Este projeto marcou meu primeiro contato com o framework Blazor, sendo uma intensa e gratificante jornada de aprendizado.

Configuração Inicial: Um dos primeiros desafios foi a configuração do ambiente e do repositório Git. O projeto foi acidentalmente iniciado em uma pasta de sistema (System32), o que exigiu a movimentação dos arquivos e a reconfiguração de permissões no Git para poder versionar o código corretamente.

Estrutura e Componentização: Aproveitei a estrutura inicial do Blazor para organizar o projeto. Comecei com uma lista de dados "hardcoded" para validar a exibição nos cards e, em seguida, evoluí para o consumo de um arquivo JSON. A componentização foi um passo importante, separando a página de ranking do componente que exibe cada card.

Manipulação de Dados e Desafios Técnicos: A transição para o consumo de um arquivo JSON trouxe um desafio interessante com a codificação de caracteres (encoding). O navegador não reconhecia letras acentuadas, o que foi resolvido ao salvar o arquivo .json com a codificação correta (UTF-8).

Responsividade: Ao testar a aplicação em diferentes telas, notei que as tabelas "vazavam" lateralmente em dispositivos móveis. Este problema foi resolvido de forma eficaz ao envolver a tabela em uma div com a classe table-responsive, uma solução prática do Bootstrap.

Desenvolvimento Fullstack (API): A etapa mais desafiadora e de maior aprendizado foi a implementação da API para conectar o frontend ao backend. Após diversas tentativas, a solução foi criar um novo projeto com a estrutura correta (Cliente, Servidor e Compartilhado) e migrar o código já existente. Com a ajuda do meu irmão, consegui refazer o backend do zero, compreendendo na prática a comunicação entre os projetos e finalmente fazendo a tabela ser preenchida através da API.

Superação e Crescimento: Durante o processo, a tensão e o medo de ser julgado trouxeram alguns bloqueios momentâneos, mas a persistência e a ajuda recebida foram fundamentais para superá-los. Ver a tabela finalmente aparecer na tela, preenchida com os dados vindos da API, foi um momento de grande satisfação e a consolidação de todo o aprendizado.
