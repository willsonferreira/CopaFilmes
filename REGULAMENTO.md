Estrutura
A Copa do mundo de filmes funciona da seguinte maneira: uma lista inicial de 8 filmes é selecionada e,
dentre esses filmes, são realizadas partidas para encontrar o vencedor. Para montar o chaveamento
será necessário:
• Ordenar os filmes alfabeticamente;
• Fazer com que os filmes disputem em eliminatórias da seguinte forma: o filme na primeira
posição disputará contra o da última posição, o segundo com o penúltimo, e assim por diante
(ver mais detalhes na próxima sessão);
Veja o exemplo abaixo:
Exibição gráfica de como devem ser os confrontos.
Fase de Eliminatórias
Dessa fase em diante é necessário realizar partidas entre os filmes. Partida é uma disputa entre dois
filmes, onde o filme com maior nota é o vencedor. Caso existam disputas entre filmes com mesma nota,
utilize o critério de desempate descrito neste arquivo mais abaixo.
O chaveamento é definido da seguinte maneira: Vencedor da disputa entre Filme 1 e Filme 8 enfrenta o
vencedor da disputa do Filme 2 com o Filme 7, enquanto o vencedor da disputa entre o Filme 3 e o Filme
6 enfrenta o vencedor da disputa entre Filme 4 e Filme 5. Depois esses vencedores disputarão entre si,
sendo o primeiro vencedor contra o segundo vencedor e o terceiro vencedor contra o quarto. Os dois
filmes restantes disputam entre si para encontrar o campeão. Para uma melhor visualização de como deve
ser a competição, veja o exemplo abaixo:
Exibição gráfica de como deve ser a fase eliminatória.
Resultado Final
O filme vencedor da final será o campeão, seguido pelo filme que perdeu a final.
Critério de desempate
Caso dois filmes tenham a mesma nota, o vencedor será definido pela ordem alfabética.
Exemplo: "Filme A" e "Filme B" possuem a mesma nota, portanto em uma disputa entre eles o vencedor
será o "Filme A".
Requisitos mínimos
Para a entrega desta solução, é esperado dois projetos distintos: um projeto de backend, onde deverão
ser implementadas as regras de negócio e a comunicação com a base dos dados (nossa API – ler mais no
próximo tópico) e um projeto de front-end SPA. Abaixo, descrevemos o mínimo entregável:
1) Web API de Back-End
• Desenvolver a Web API utilizando ASP.NET CORE;
2) Projeto SPA de Front-End
• Usar um framework javascript de SPA de preferência Angular 2+ ou React;
Instruções:
1) Consuma nossa API de filmes e avaliações:
• http://copafilmes.azurewebsites.net/api/filmes
Por meio da URL indicada acima você conseguirá acessar uma lista de filmes com as seguintes
informações:
• Id;
• Título;
• Ano de Lançamento;
• Nota.
Utilize esses filmes e essas notas em sua solução.
2) Crie uma tela para que o usuário possa selecionar os filmes:
A API retornará 16 filmes, o usuário deverá escolher apenas 8 filmes através de uma listagem para dar
início à competição.
Crie uma tela e exiba esses filmes, com a possibilidade de o usuário escolher quais entrarão na disputa,
mantendo um contador de quantos filmes já foram escolhidos. Em seguida, coloque um botão que dará
início ao campeonato. Este botão deverá enviar os filmes selecionados para o backend que você
desenvolverá e realizará a competição. 