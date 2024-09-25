using System.Security.Cryptography.X509Certificates;
using Microsoft.UI.Xaml.Automation.Peers;
using showdomilhao;

namespace showdomilhao;

List <Questao> listaQuestoes = new ListViewCachingStrategy<Questao>();
List <int> listaQuestoesRespondidas = new Lista<int>();
Questao questaoCorrente;
public Gerenciador(Label labelPergunta,Button btnResp01, Button btnResp02, Button btnResp03, Button btnResp04, Button btnResp05)

{

    CriarQuestoes(labelPergunta,btnResp05,btnResp04,btnResp05);

} 

void CriarQuestoes(Label labelPergunta,Button btnResp01, Button btnResp02, Button btnResp03, Button btnResp04, Button btnResp05)
{
    var q1=new Questao();
    q1.pergunta = "Quanto é 2+2";
    q1.resposta01="1";
    q1.resposta02="13";
    q1.resposta03="21";
    q1.resposta04="11";
    q1.resposta05="4";
    q1.respostaCorreta=5;
    q1.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
    ListaQuestoes.Add(q1);

var q1 = new Questao();
q1.pergunta = "Quanto é 2 + 2?";
q1.resposta01 = "1";
q1.resposta02 = "13";
q1.resposta03 = "21";
q1.resposta04 = "11";
q1.resposta05 = "4";
q1.respostaCorreta = 5;
q1.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q1);


var q2 = new Questao();
q2.pergunta = "Qual é a capital da França?";
q2.resposta01 = "Berlim";
q2.resposta02 = "Madri";
q2.resposta03 = "Paris";
q2.resposta04 = "Lisboa";
q2.resposta05 = "Roma";
q2.respostaCorreta = 3;
q2.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q2);


var q3 = new Questao();
q3.pergunta = "Qual é a fórmula da água?";
q3.resposta01 = "CO2";
q3.resposta02 = "H2O";
q3.resposta03 = "O2";
q3.resposta04 = "H2O2";
q3.resposta05 = "CH4";
q3.respostaCorreta = 2;
q3.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q3);


var q4 = new Questao();
q4.pergunta = "Quem escreveu 'Dom Casmurro'?";
q4.resposta01 = "Jorge Amado";
q4.resposta02 = "Machado de Assis";
q4.resposta03 = "Clarice Lispector";
q4.resposta04 = "Graciliano Ramos";
q4.resposta05 = "José Saramago";
q4.respostaCorreta = 2;
q4.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q4);


var q5 = new Questao();
q5.pergunta = "Qual é o maior planeta do sistema solar?";
q5.resposta01 = "Terra";
q5.resposta02 = "Júpiter";
q5.resposta03 = "Saturno";
q5.resposta04 = "Marte";
q5.resposta05 = "Vênus";
q5.respostaCorreta = 2;
q5.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q5);

var q6 = new Questao();
q6.pergunta = "Qual é o elemento químico representado pelo símbolo 'O'?";
q6.resposta01 = "Ouro";
q6.resposta02 = "Oxigênio";
q6.resposta03 = "Ósmio";
q6.resposta04 = "Ozônio";
q6.resposta05 = "Carbono";
q6.respostaCorreta = 2;
q6.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q6);


var q7 = new Questao();
q7.pergunta = "Qual o continente mais populoso?";
q7.resposta01 = "África";
q7.resposta02 = "Ásia";
q7.resposta03 = "Europa";
q7.resposta04 = "América do Norte";
q7.resposta05 = "Oceania";
q7.respostaCorreta = 2;
q7.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q7);


var q8 = new Questao();
q8.pergunta = "Qual é a moeda do Japão?";
q8.resposta01 = "Won";
q8.resposta02 = "Dólar";
q8.resposta03 = "Euro";
q8.resposta04 = "Iene";
q8.resposta05 = "Rupia";
q8.respostaCorreta = 4;
q8.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q8);


var q9 = new Questao();
q9.pergunta = "Quem pintou a Mona Lisa?";
q9.resposta01 = "Van Gogh";
q9.resposta02 = "Picasso";
q9.resposta03 = "Da Vinci";
q9.resposta04 = "Monet";
q9.resposta05 = "Rembrandt";
q9.respostaCorreta = 3;
q9.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q9);


var q10 = new Questao();
q10.pergunta = "Qual é o maior oceano do mundo?";
q10.resposta01 = "Atlântico";
q10.resposta02 = "Índico";
q10.resposta03 = "Ártico";
q10.resposta04 = "Antártico";
q10.resposta05 = "Pacífico";
q10.respostaCorreta = 5;
q10.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q10);

//nivel 2


var q11 = new Questao();
q11.pergunta = "Qual é a língua mais falada do mundo?";
q11.resposta01 = "Inglês";
q11.resposta02 = "Mandarim";
q11.resposta03 = "Espanhol";
q11.resposta04 = "Árabe";
q11.resposta05 = "Hindi";
q11.respostaCorreta = 2;
q11.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q50);

     

var ListaQuestoes = new List<Questao>();


var q12 = new Questao();
q12.pergunta = "Qual é o principal gás responsável pelo efeito estufa?";
q12.resposta01 = "Oxigênio";
q12.resposta02 = "Dióxido de carbono";
q1.resposta03 = "Metano";
q1.resposta04 = "Nitrogênio";
q1.resposta05 = "Hélio";
q1.respostaCorreta = 2;
q1.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q1);


var q13 = new Questao();
q2.pergunta = "Qual a capital da Mongólia?";
q2.resposta01 = "Ulaanbaatar";
q2.resposta02 = "Astana";
q2.resposta03 = "Tóquio";
q2.resposta04 = "Seul";
q2.resposta05 = "Pequim";
q2.respostaCorreta = 1;
q2.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp01, btnResp05);
ListaQuestoes.Add(q2);


var q14 = new Questao();
q3.pergunta = "Qual é a obra mais famosa de Michelangelo?";
q3.resposta01 = "A Criação de Adão";
q3.resposta02 = "Davi";
q3.resposta03 = "Pietà";
q3.resposta04 = "Capela Sistina";
q3.resposta05 = "A Última Ceia";
q3.respostaCorreta = 2;
q3.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q3);


var q15 = new Questao();
q4.pergunta = "Qual é a capital da Nova Zelândia?";
q4.resposta01 = "Auckland";
q4.resposta02 = "Wellington";
q4.resposta03 = "Christchurch";
q4.resposta04 = "Hamilton";
q4.resposta05 = "Dunedin";
q4.respostaCorreta = 2;
q4.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q4);

// Pergunta 5
var q16 = new Questao();
q5.pergunta = "Quem descobriu a penicilina?";
q5.resposta01 = "Louis Pasteur";
q5.resposta02 = "Alexander Fleming";
q5.resposta03 = "Marie Curie";
q5.resposta04 = "Edward Jenner";
q5.resposta05 = "Joseph Lister";
q5.respostaCorreta = 2;
q5.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q5);

// Pergunta 6
var q17 = new Questao();
q6.pergunta = "Qual é a unidade de medida da força no Sistema Internacional?";
q6.resposta01 = "Joule";
q6.resposta02 = "Newton";
q6.resposta03 = "Pascal";
q6.resposta04 = "Watt";
q6.resposta05 = "Volt";
q6.respostaCorreta = 2;
q6.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q6);

// Pergunta 7
var q18 = new Questao();
q7.pergunta = "Em que ano caiu o Muro de Berlim?";
q7.resposta01 = "1987";
q7.resposta02 = "1989";
q7.resposta03 = "1991";
q7.resposta04 = "1993";
q7.resposta05 = "1995";
q7.respostaCorreta = 2;
q7.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q7);

// Pergunta 8
var q19 = new Questao();
q8.pergunta = "Qual é o menor país do mundo?";
q8.resposta01 = "Mônaco";
q8.resposta02 = "Nauru";
q8.resposta03 = "Vaticano";
q8.resposta04 = "Maldivas";
q8.resposta05 = "San Marino";
q8.respostaCorreta = 3;
q8.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q8);

// Pergunta 9
var q20 = new Questao();
q9.pergunta = "Qual é o autor de 'Cem Anos de Solidão'?";
q9.resposta01 = "Jorge Amado";
q9.resposta02 = "Gabriel García Márquez";
q9.resposta03 = "Mario Vargas Llosa";
q9.resposta04 = "Julio Cortázar";
q9.resposta05 = "Pablo Neruda";
q9.respostaCorreta = 2;
q9.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q9);

  //nivel 02
var q21 = new Questao();
q10.pergunta = "Qual é o conceito econômico que descreve o aumento geral dos preços?";
q10.resposta01 = "Recessão";
q10.resposta02 = "Inflação";
q10.resposta03 = "Deflação";
q10.resposta04 = "Estagflação";
q10.resposta05 = "Desemprego";
q10.respostaCorreta = 2;
q10.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q10);

// Pergunta 11
var q22 = new Questao();
q11.pergunta = "Qual é a montanha mais alta do mundo?";
q11.resposta01 = "K2";
q11.resposta02 = "Kangchenjunga";
q11.resposta03 = "Makalu";
q11.resposta04 = "Everest";
q11.resposta05 = "Lhotse";
q11.respostaCorreta = 4;
q11.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q11);

// Pergunta 12
var q23 = new Questao();
q12.pergunta = "Qual era o nome do famoso navio que afundou em 1912?";
q12.resposta01 = "Britannic";
q12.resposta02 = "Lusitania";
q12.resposta03 = "Titanic";
q12.resposta04 = "Oceânica";
q12.resposta05 = "Majestic";
q12.respostaCorreta = 3;
q12.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q12);

// Pergunta 13
var q24 = new Questao();
q13.pergunta = "Quem foi o primeiro homem a viajar ao espaço?";
q13.resposta01 = "Yuri Gagarin";
q13.resposta02 = "Neil Armstrong";
q13.resposta03 = "Buzz Aldrin";
q13.resposta04 = "John Glenn";
q13.resposta05 = "Valentina Tereshkova";
q13.respostaCorreta = 1;
q13.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q13);

// Pergunta 14
var q25 = new Questao();
q14.pergunta = "Qual é a principal religião do Japão?";
q14.resposta01 = "Budismo";
q14.resposta02 = "Cristianismo";
q14.resposta03 = "Xintoísmo";
q14.resposta04 = "Hinduísmo";
q14.resposta05 = "Taoísmo";
q14.respostaCorreta = 3;
q14.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q14);

// Pergunta 15
var q26 = new Questao();
q15.pergunta = "Qual é a raiz quadrada de 144?";
q15.resposta01 = "10";
q15.resposta02 = "12";
q15.resposta03 = "14";
q15.resposta04 = "16";
q15.resposta05 = "18";
q15.respostaCorreta = 2;
q15.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q15);

// Pergunta 16
var q27 = new Questao();
q16.pergunta = "Qual é a principal obra de William Shakespeare?";
q16.resposta01 = "Hamlet";
q16.resposta02 = "Odisseia";
q16.resposta03 = "Divina Comédia";
q16.resposta04 = "Moby Dick";
q16.resposta05 = "Dom Quixote";
q16.respostaCorreta = 1;
q16.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q16);

// Pergunta 17
var q28 = new Questao();
q17.pergunta = "Qual é o maior mamífero do mundo?";
q17.resposta01 = "Elefante";
q17.resposta02 = "Baleia Azul";
q17.resposta03 = "Tubarão Branco";
q17.resposta04 = "Girafa";
q17.resposta05 = "Rinoceronte";
q17.respostaCorreta = 2;
q17.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q17);

// Pergunta 18
var q29 = new Questao();
q18.pergunta = "Qual é a principal fonte de energia do Sol?";
q18.resposta01 = "Fissão nuclear";
q18.resposta02 = "Fusão nuclear";
q18.resposta03 = "Combustão";
q18.resposta04 = "Geotérmica";
q18.resposta05 = "Eólica";
q18.respostaCorreta = 2;
q18.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q18);


var q30 = new Questao();
q19.pergunta = "Qual é a língua oficial da Brasil?";
q19.resposta01 = "Espanhol";
q19.resposta02 = "Inglês";
q19.resposta03 = "Francês";
q19.resposta04 = "Português";
q19.resposta05 = "Italiano";
q19.respostaCorreta = 4;
q19.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q19);

 //nivel 3
var q31 = new Questao();
q20.pergunta = "Qual é o elemento químico mais abundante no universo?";
q20.resposta01 = "Hélio";
q20.resposta02 = "Carbono";
q20.resposta03 = "Oxigênio";
q20.resposta04 = "Hidrogênio";
q20.resposta05 = "Nitrogênio";
q20.respostaCorreta = 4;
q20.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q20);

// Pergunta 21
var q32 = new Questao();
q21.pergunta = "Qual é a capital da Islândia?";
q21.resposta01 = "Oslo";
q21.resposta02 = "Reykjavik";
q21.resposta03 = "Copenhague";
q21.resposta04 = "Helsinque";
q21.resposta05 = "Estocolmo";
q21.respostaCorreta = 2;
q21.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q21);

// Pergunta 22
var q33 = new Questao();
q22.pergunta = "Qual é o valor de π (pi) até a segunda casa decimal?";
q22.resposta01 = "2,14";
q22.resposta02 = "3,14";
q22.resposta03 = "3,16";
q22.resposta04 = "3,12";
q22.resposta05 = "2,72";
q22.respostaCorreta = 2;
q22.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q22);


var ListaQuestoes = new List<Questao>();

// Pergunta 1
var q34 = new Questao();
q1.pergunta = "Qual é o principal gás responsável pelo efeito estufa?";
q1.resposta01 = "Oxigênio";
q1.resposta02 = "Dióxido de carbono";
q1.resposta03 = "Metano";
q1.resposta04 = "Nitrogênio";
q1.resposta05 = "Hélio";
q1.respostaCorreta = 2;
q1.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q1);

// Pergunta 2
var q35 = new Questao();
q2.pergunta = "Qual a capital da Mongólia?";
q2.resposta01 = "Ulaanbaatar";
q2.resposta02 = "Astana";
q2.resposta03 = "Tóquio";
q2.resposta04 = "Seul";
q2.resposta05 = "Pequim";
q2.respostaCorreta = 1;
q2.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q2);

// Pergunta 3
var q36 = new Questao();
q3.pergunta = "Qual é a obra mais famosa de Michelangelo?";
q3.resposta01 = "A Criação de Adão";
q3.resposta02 = "Davi";
q3.resposta03 = "Pietà";
q3.resposta04 = "Capela Sistina";
q3.resposta05 = "A Última Ceia";
q3.respostaCorreta = 2;
q3.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q3);

// Pergunta 4
var q37 = new Questao();
q4.pergunta = "Qual é a capital da Nova Zelândia?";
q4.resposta01 = "Auckland";
q4.resposta02 = "Wellington";
q4.resposta03 = "Christchurch";
q4.resposta04 = "Hamilton";
q4.resposta05 = "Dunedin";
q4.respostaCorreta = 2;
q4.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q4);

// Pergunta 5
var q38 = new Questao();
q5.pergunta = "Quem descobriu a penicilina?";
q5.resposta01 = "Louis Pasteur";
q5.resposta02 = "Alexander Fleming";
q5.resposta03 = "Marie Curie";
q5.resposta04 = "Edward Jenner";
q5.resposta05 = "Joseph Lister";
q5.respostaCorreta = 2;
q5.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q5);

// Pergunta 6
var q39 = new Questao();
q6.pergunta = "Qual é a unidade de medida da força no Sistema Internacional?";
q6.resposta01 = "Joule";
q6.resposta02 = "Newton";
q6.resposta03 = "Pascal";
q6.resposta04 = "Watt";
q6.resposta05 = "Volt";
q6.respostaCorreta = 2;
q6.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q6);

// Pergunta 7
var q40 = new Questao();
q7.pergunta = "Em que ano caiu o Muro de Berlim?";
q7.resposta01 = "1987";
q7.resposta02 = "1989";
q7.resposta03 = "1991";
q7.resposta04 = "1993";
q7.resposta05 = "1995";
q7.respostaCorreta = 2;
q7.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q7);

 //nivel 4
var q41 = new Questao();
q8.pergunta = "Qual é o menor país do mundo?";
q8.resposta01 = "Mônaco";
q8.resposta02 = "Nauru";
q8.resposta03 = "Vaticano";
q8.resposta04 = "Maldivas";
q8.resposta05 = "San Marino";
q8.respostaCorreta = 3;
q8.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q8);

// Pergunta 9
var q42 = new Questao();
q9.pergunta = "Qual é o autor de 'Cem Anos de Solidão'?";
q9.resposta01 = "Jorge Amado";
q9.resposta02 = "Gabriel García Márquez";
q9.resposta03 = "Mario Vargas Llosa";
q9.resposta04 = "Julio Cortázar";
q9.resposta05 = "Pablo Neruda";
q9.respostaCorreta = 2;
q9.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q9);

// Pergunta 10
var q43 = new Questao();
q10.pergunta = "Qual é o conceito econômico que descreve o aumento geral dos preços?";
q10.resposta01 = "Recessão";
q10.resposta02 = "Inflação";
q10.resposta03 = "Deflação";
q10.resposta04 = "Estagflação";
q10.resposta05 = "Desemprego";
q10.respostaCorreta = 2;
q10.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q10);

// Pergunta 11
var q44 = new Questao();
q11.pergunta = "Qual é a montanha mais alta do mundo?";
q11.resposta01 = "K2";
q11.resposta02 = "Kangchenjunga";
q11.resposta03 = "Makalu";
q11.resposta04 = "Everest";
q11.resposta05 = "Lhotse";
q11.respostaCorreta = 4;
q11.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q11);

// Pergunta 12
var q45 = new Questao();
q12.pergunta = "Qual era o nome do famoso navio que afundou em 1912?";
q12.resposta01 = "Britannic";
q12.resposta02 = "Lusitania";
q12.resposta03 = "Titanic";
q12.resposta04 = "Oce";
var ListaQuestoes = new List<Questao>();

// Pergunta 1
var q46 = new Questao();
q1.pergunta = "Qual é o principal gás responsável pelo efeito estufa?";
q1.resposta01 = "Oxigênio";
q1.resposta02 = "Dióxido de carbono";
q1.resposta03 = "Metano";
q1.resposta04 = "Nitrogênio";
q1.resposta05 = "Hélio";
q1.respostaCorreta = 2;
q1.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q1);

// Pergunta 2
var q47 = new Questao();
q2.pergunta = "Qual a capital da Mongólia?";
q2.resposta01 = "Ulaanbaatar";
q2.resposta02 = "Astana";
q2.resposta03 = "Tóquio";
q2.resposta04 = "Seul";
q2.resposta05 = "Pequim";
q2.respostaCorreta = 1;
q2.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q2);

// Pergunta 3
var q48 = new Questao();
q3.pergunta = "Qual é a obra mais famosa de Michelangelo?";
q3.resposta01 = "A Criação de Adão";
q3.resposta02 = "Davi";
q3.resposta03 = "Pietà";
q3.resposta04 = "Capela Sistina";
q3.resposta05 = "A Última Ceia";
q3.respostaCorreta = 2;
q3.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q3);

// Pergunta 4
var q49 = new Questao();
q4.pergunta = "Qual é a capital da Nova Zelândia?";
q4.resposta01 = "Auckland";
q4.resposta02 = "Wellington";
q4.resposta03 = "Christchurch";
q4.resposta04 = "Hamilton";
q4.resposta05 = "Dunedin";
q4.respostaCorreta = 2;
q4.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q4);

// Pergunta 5
var q50 = new Questao();
q5.pergunta = "Quem descobriu a penicilina?";
q5.resposta01 = "Louis Pasteur";
q5.resposta02 = "Alexander Fleming";
q5.resposta03 = "Marie Curie";
q5.resposta04 = "Edward Jenner";
q5.resposta05 = "Joseph Lister";
q5.respostaCorreta = 2;
q5.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q5);

//nivel 5
var ListaQuestoes = new List<Questao>();

// Pergunta 1
var q51 = new Questao();
q1.pergunta = "Qual é a principal fonte de energia do Sol?";
q1.resposta01 = "Fissão nuclear";
q1.resposta02 = "Fusão nuclear";
q1.resposta03 = "Reações químicas";
q1.resposta04 = "Radiação eletromagnética";
q1.resposta05 = "Desintegração radioativa";
q1.respostaCorreta = 2;
q1.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q1);

// Pergunta 2
var q52 = new Questao();
q2.pergunta = "Quem foi o autor do 'Príncipe'?";
q2.resposta01 = "Thomas Hobbes";
q2.resposta02 = "Jean-Jacques Rousseau";
q2.resposta03 = "Maquiavel";
q2.resposta04 = "Friedrich Nietzsche";
q2.resposta05 = "Voltaire";
q2.respostaCorreta = 3;
q2.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q2);

// Pergunta 3
var q53 = new Questao();
q3.pergunta = "Qual é a capital da Letônia?";
q3.resposta01 = "Tallinn";
q3.resposta02 = "Vilnius";
q3.resposta03 = "Riga";
q3.resposta04 = "Minsk";
q3.resposta05 = "Kiev";
q3.respostaCorreta = 3;
q3.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q3);

// Pergunta 4
var q54 = new Questao();
q4.pergunta = "Qual é o nome do processo que transforma gás em líquido?";
q4.resposta01 = "Evaporação";
q4.resposta02 = "Condensação";
q4.resposta03 = "Sublimação";
q4.resposta04 = "Solidificação";
q4.resposta05 = "Fusão";
q4.respostaCorreta = 2;
q4.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q4);

// Pergunta 5
var q55 = new Questao();
q5.pergunta = "Qual é o autor do famoso romance '1984'?";
q5.resposta01 = "Aldous Huxley";
q5.resposta02 = "George Orwell";
q5.resposta03 = "Ray Bradbury";
q5.resposta04 = "Isaac Asimov";
q5.resposta05 = "Philip K. Dick";
q5.respostaCorreta = 2;
q5.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q5);

// Pergunta 6
var q56 = new Questao();
q6.pergunta = "Qual é a fórmula química da cafeína?";
q6.resposta01 = "C8H10N4O2";
q6.resposta02 = "C7H8N4O2";
q6.resposta03 = "C8H10N4O3";
q6.resposta04 = "C8H10N4O5";
q6.resposta05 = "C6H8N4O2";
q6.respostaCorreta = 1;
q6.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q6);

// Pergunta 7
var q57 = new Questao();
q7.pergunta = "Qual é a teoria que explica a origem do universo?";
q7.resposta01 = "Teoria do Big Bang";
q7.resposta02 = "Teoria da Relatividade";
q7.resposta03 = "Teoria das Cordas";
q7.resposta04 = "Teoria do Multiverso";
q7.resposta05 = "Teoria da Evolução";
q7.respostaCorreta = 1;
q7.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q7);

// Pergunta 8
var q58 = new Questao();
q8.pergunta = "Qual é o elemento mais abundante no universo?";
q8.resposta01 = "Hidrogênio";
q8.resposta02 = "Hélio";
q8.resposta03 = "Oxigênio";
q8.resposta04 = "Carbono";
q8.resposta05 = "Nitrogênio";
q8.respostaCorreta = 1;
q8.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q8);

// Pergunta 9
var q59 = new Questao();
q9.pergunta = "Qual é a capital da Suécia?";
q9.resposta01 = "Estocolmo";
q9.resposta02 = "Helsinque";
q9.resposta03 = "Copenhague";
q9.resposta04 = "Oslo";
q9.resposta05 = "Reykjavik";
q9.respostaCorreta = 1;
q9.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q9);

// Pergunta 10
var q60 = new Questao();
q10.pergunta = "Qual é a capital do Quênia?";
q10.resposta01 = "Nairobi";
q10.resposta02 = "Mombasa";
q10.resposta03 = "Kisumu";
q10.resposta04 = "Nakuru";
q10.resposta05 = "Eldoret";
q10.respostaCorreta = 1;
q10.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q10);

//nivel 6

var ListaQuestoes = new List<Questao>();

// Pergunta 1
var q61 = new Questao();
q1.pergunta = "Qual é a principal fonte de energia do Sol?";
q1.resposta01 = "Fissão nuclear";
q1.resposta02 = "Fusão nuclear";
q1.resposta03 = "Reações químicas";
q1.resposta04 = "Radiação eletromagnética";
q1.resposta05 = "Desintegração radioativa";
q1.respostaCorreta = 2;
q1.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q1);

// Pergunta 2
var q62 = new Questao();
q2.pergunta = "Quem foi o autor do 'Príncipe'?";
q2.resposta01 = "Thomas Hobbes";
q2.resposta02 = "Jean-Jacques Rousseau";
q2.resposta03 = "Maquiavel";
q2.resposta04 = "Friedrich Nietzsche";
q2.resposta05 = "Voltaire";
q2.respostaCorreta = 3;
q2.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q2);

// Pergunta 3
var q63 = new Questao();
q3.pergunta = "Qual é a capital da Letônia?";
q3.resposta01 = "Tallinn";
q3.resposta02 = "Vilnius";
q3.resposta03 = "Riga";
q3.resposta04 = "Minsk";
q3.resposta05 = "Kiev";
q3.respostaCorreta = 3;
q3.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q3);

// Pergunta 4
var q64 = new Questao();
q4.pergunta = "Qual é o nome do processo que transforma gás em líquido?";
q4.resposta01 = "Evaporação";
q4.resposta02 = "Condensação";
q4.resposta03 = "Sublimação";
q4.resposta04 = "Solidificação";
q4.resposta05 = "Fusão";
q4.respostaCorreta = 2;
q4.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q4);

// Pergunta 5
var q65 = new Questao();
q5.pergunta = "Qual é o autor do famoso romance '1984'?";
q5.resposta01 = "Aldous Huxley";
q5.resposta02 = "George Orwell";
q5.resposta03 = "Ray Bradbury";
q5.resposta04 = "Isaac Asimov";
q5.resposta05 = "Philip K. Dick";
q5.respostaCorreta = 2;
q5.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q5);

// Pergunta 6
var q66 = new Questao();
q6.pergunta = "Qual é a fórmula química da cafeína?";
q6.resposta01 = "C8H10N4O2";
q6.resposta02 = "C7H8N4O2";
q6.resposta03 = "C8H10N4O3";
q6.resposta04 = "C8H10N4O5";
q6.resposta05 = "C6H8N4O2";
q6.respostaCorreta = 1;
q6.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q6);

// Pergunta 7
var q67 = new Questao();
q7.pergunta = "Qual é a teoria que explica a origem do universo?";
q7.resposta01 = "Teoria do Big Bang";
q7.resposta02 = "Teoria da Relatividade";
q7.resposta03 = "Teoria das Cordas";
q7.resposta04 = "Teoria do Multiverso";
q7.resposta05 = "Teoria da Evolução";
q7.respostaCorreta = 1;
q7.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q7);

// Pergunta 8
var q68 = new Questao();
q8.pergunta = "Qual é o elemento mais abundante no universo?";
q8.resposta01 = "Hidrogênio";
q8.resposta02 = "Hélio";
q8.resposta03 = "Oxigênio";
q8.resposta04 = "Carbono";
q8.resposta05 = "Nitrogênio";
q8.respostaCorreta = 1;
q8.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q8);

// Pergunta 9
var q69 = new Questao();
q9.pergunta = "Qual é a capital da Suécia?";
q9.resposta01 = "Estocolmo";
q9.resposta02 = "Helsinque";
q9.resposta03 = "Copenhague";
q9.resposta04 = "Oslo";
q9.resposta05 = "Reykjavik";
q9.respostaCorreta = 1;
q9.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q9);

// Pergunta 10
var q70 = new Questao();
q10.pergunta = "Qual é a capital do Quênia?";
q10.resposta01 = "Nairobi";
q10.resposta02 = "Mombasa";
q10.resposta03 = "Kisumu";
q10.resposta04 = "Nakuru";
q10.resposta05 = "Eldoret";
q10.respostaCorreta = 1;
q10.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q10);

//nivel 7

var ListaQuestoes = new List<Questao>();

// Pergunta 1
var q71 = new Questao();
q1.pergunta = "Qual é a primeira obra de ficção científica reconhecida?";
q1.resposta01 = "Frankenstein";
q1.resposta02 = "A Máquina do Tempo";
q1.resposta03 = "20.000 Léguas Submarinas";
q1.resposta04 = "Guerra dos Mundos";
q1.resposta05 = "O Conto da Aia";
q1.respostaCorreta = 1;
q1.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q1);

// Pergunta 2
var q72 = new Questao();
q2.pergunta = "Qual foi o primeiro satélite artificial lançado ao espaço?";
q2.resposta01 = "Apollo 11";
q2.resposta02 = "Sputnik 1";
q2.resposta03 = "Explorer 1";
q2.resposta04 = "Vostok 1";
q2.resposta05 = "Hubble";
q2.respostaCorreta = 2;
q2.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q2);

// Pergunta 3
var q73 = new Questao();
q3.pergunta = "Qual é o nome da partícula subatômica responsável pela carga elétrica positiva?";
q3.resposta01 = "Nêutron";
q3.resposta02 = "Elétron";
q3.resposta03 = "Próton";
q3.resposta04 = "Fóton";
q3.resposta05 = "Glúon";
q3.respostaCorreta = 3;
q3.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q3);

// Pergunta 4
var q74 = new Questao();
q4.pergunta = "Qual é o nome do fenômeno em que a luz é desviada por um objeto massivo?";
q4.resposta01 = "Refração";
q4.resposta02 = "Reflexão";
q4.resposta03 = "Gravitação";
q4.resposta04 = "Lente gravitacional";
q4.resposta05 = "Difração";
q4.respostaCorreta = 4;
q4.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q4);

// Pergunta 5
var q75 = new Questao();
q5.pergunta = "Quem foi o primeiro homem a viajar no espaço?";
q5.resposta01 = "Neil Armstrong";
q5.resposta02 = "Yuri Gagarin";
q5.resposta03 = "Buzz Aldrin";
q5.resposta04 = "John Glenn";
q5.resposta05 = "Valentina Tereshkova";
q5.respostaCorreta = 2;
q5.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q5);

// Pergunta 6
var q76 = new Questao();
q6.pergunta = "Qual é a capital do Japão?";
q6.resposta01 = "Pequim";
q6.resposta02 = "Tóquio";
q6.resposta03 = "Seul";
q6.resposta04 = "Bangkok";
q6.resposta05 = "Hanoi";
q6.respostaCorreta = 2;
q6.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q6);

// Pergunta 7
var q77 = new Questao();
q7.pergunta = "Qual é a obra-prima do pintor holandês Vincent van Gogh?";
q7.resposta01 = "Noite Estrelada";
q7.resposta02 = "A Criação de Adão";
q7.resposta03 = "O Grito";
q7.resposta04 = "Guernica";
q7.resposta05 = "A Persistência da Memória";
q7.respostaCorreta = 1;
q7.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q7);

// Pergunta 8
var q78 = new Questao();
q8.pergunta = "Quem desenvolveu a teoria da relatividade?";
q8.resposta01 = "Isaac Newton";
q8.resposta02 = "Albert Einstein";
q8.resposta03 = "Niels Bohr";
q8.resposta04 = "Galileu Galilei";
q8.resposta05 = "Stephen Hawking";
q8.respostaCorreta = 2;
q8.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q8);

// Pergunta 9
var q79 = new Questao();
q9.pergunta = "Qual é a moeda oficial do Japão?";
q9.resposta01 = "Yuan";
q9.resposta02 = "Won";
q9.resposta03 = "Yen";
q9.resposta04 = "Dólar";
q9.resposta05 = "Libra";
q9.respostaCorreta = 3;
q9.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q9);

// Pergunta 10
var q80 = new Questao();
q10.pergunta = "Quem é o autor de 'Crime e Castigo'?";
q10.resposta01 = "Fiodor Dostoiévski";
q10.resposta02 = "Liev Tolstói";
q10.resposta03 = "Anton Tchekhov";
q10.resposta04 = "Ivan Turguêniev";
q10.resposta05 = "Mikhail Bulgakov";
q10.respostaCorreta = 1;
q10.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q10);

//nivel 8

var ListaQuestoes = new List<Questao>();

// Pergunta 1
var q81 = new Questao();
q1.pergunta = "Qual é o princípio físico que explica a flutuação de objetos em líquidos?";
q1.resposta01 = "Princípio de Pascal";
q1.resposta02 = "Princípio de Arquimedes";
q1.resposta03 = "Lei de Bernoulli";
q1.resposta04 = "Teorema de Torricelli";
q1.resposta05 = "Teorema de Stevin";
q1.respostaCorreta = 2;
q1.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q1);

// Pergunta 2
var q82 = new Questao();
q2.pergunta = "Qual é a capital da Mongólia?";
q2.resposta01 = "Ulan Bator";
q2.resposta02 = "Astana";
q2.resposta03 = "Tashkent";
q2.resposta04 = "Bishkek";
q2.resposta05 = "Baku";
q2.respostaCorreta = 1;
q2.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q2);

// Pergunta 3
var q83 = new Questao();
q3.pergunta = "Qual é o nome da maior estrutura viva do planeta?";
q3.resposta01 = "A Grande Barreira de Coral";
q3.resposta02 = "A Floresta Amazônica";
q3.resposta03 = "O sistema de raízes das sequoias";
q3.resposta04 = "O fungo Armillaria ostoyae";
q3.resposta05 = "O Parque Nacional de Yellowstone";
q3.respostaCorreta = 1;
q3.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q3);

// Pergunta 4
var q84 = new Questao();
q4.pergunta = "Qual autor é conhecido por sua obra 'A Metamorfose'?";
q4.resposta01 = "Franz Kafka";
q4.resposta02 = "Gabriel Garcia Márquez";
q4.resposta03 = "Jorge Luis Borges";
q4.resposta04 = "Fiódor Dostoiévski";
q4.resposta05 = "Virginia Woolf";
q4.respostaCorreta = 1;
q4.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q4);

// Pergunta 5
var q85 = new Questao();
q5.pergunta = "Quem foi o primeiro presidente dos Estados Unidos?";
q5.resposta01 = "George Washington";
q5.resposta02 = "Thomas Jefferson";
q5.resposta03 = "Abraham Lincoln";
q5.resposta04 = "John Adams";
q5.resposta05 = "James Madison";
q5.respostaCorreta = 1;
q5.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q5);

// Pergunta 6
var q86 = new Questao();
q6.pergunta = "Qual é a partícula responsável pela força eletromagnética?";
q6.resposta01 = "Próton";
q6.resposta02 = "Nêutron";
q6.resposta03 = "Elétron";
q6.resposta04 = "Fóton";
q6.resposta05 = "Glúon";
q6.respostaCorreta = 4;
q6.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q6);

// Pergunta 7
var q87 = new Questao();
q7.pergunta = "Quem é o filósofo associado à frase 'O homem é a medida de todas as coisas'?";
q7.resposta01 = "Platão";
q7.resposta02 = "Sócrates";
q7.resposta03 = "Aristóteles";
q7.resposta04 = "Protágoras";
q7.resposta05 = "Epicuro";
q7.respostaCorreta = 4;
q7.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q7);

// Pergunta 8
var q88 = new Questao();
q8.pergunta = "Qual é a obra famosa de Leonardo da Vinci que retrata a Última Ceia de Jesus Cristo?";
q8.resposta01 = "A Criação de Adão";
q8.resposta02 = "A Última Ceia";
q8.resposta03 = "Mona Lisa";
q8.resposta04 = "A Dama do Arminho";
q8.resposta05 = "A Virgem das Rochas";
q8.respostaCorreta = 2;
q8.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q8);

// Pergunta 9
var q89 = new Questao();
q9.pergunta = "Qual é o nome da cidade antiga que é famosa por suas ruínas e seu coliseu?";
q9.resposta01 = "Atenas";
q9.resposta02 = "Roma";
q9.resposta03 = "Jerusalém";
q9.resposta04 = "Cartago";
q9.resposta05 = "Mênfis";
q9.respostaCorreta = 2;
q9.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q9);

// Pergunta 10
var q90 = new Questao();
q10.pergunta = "Qual é o princípio da termodinâmica que afirma que a energia não pode ser criada nem destruída?";
q10.resposta01 = "Primeiro Princípio da Termodinâmica";
q10.resposta02 = "Segundo Princípio da Termodinâmica";
q10.resposta03 = "Terceiro Princípio da Termodinâmica";
q10.resposta04 = "Lei da Conservação da Energia";
q10.resposta05 = "Princípio da Entropia";
q10.respostaCorreta = 1;
q10.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q10);

//nivel 9

var ListaQuestoes = new List<Questao>();

// Pergunta 1
var q91 = new Questao();
q1.pergunta = "Qual é o teorema que estabelece a relação entre os ângulos e os lados de um triângulo qualquer?";
q1.resposta01 = "Teorema de Pitágoras";
q1.resposta02 = "Teorema do Cosseno";
q1.resposta03 = "Teorema de Tales";
q1.resposta04 = "Teorema de Euclides";
q1.resposta05 = "Teorema de Steiner";
q1.respostaCorreta = 2;
q1.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q1);

// Pergunta 2
var q92 = new Questao();
q2.pergunta = "Qual filósofo introduziu o conceito de 'tabula rasa', sugerindo que a mente humana é uma lousa em branco ao nascer?";
q2.resposta01 = "John Locke";
q2.resposta02 = "David Hume";
q2.resposta03 = "Immanuel Kant";
q2.resposta04 = "Thomas Hobbes";
q2.resposta05 = "Jean-Jacques Rousseau";
q2.respostaCorreta = 1;
q2.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q2);

// Pergunta 3
var q93 = new Questao();
q3.pergunta = "Qual é o nome do composto químico cuja fórmula molecular é C₆H₁₂O₆?";
q3.resposta01 = "Frutose";
q3.resposta02 = "Glicose";
q3.resposta03 = "Sacarose";
q3.resposta04 = "Galactose";
q3.resposta05 = "Maltose";
q3.respostaCorreta = 2;
q3.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q3);

// Pergunta 4
var q94 = new Questao();
q4.pergunta = "Quem é conhecido como o pai da teoria da evolução?";
q4.resposta01 = "Charles Darwin";
q4.resposta02 = "Gregor Mendel";
q4.resposta03 = "Jean-Baptiste Lamarck";
q4.resposta04 = "Richard Dawkins";
q4.resposta05 = "Thomas Malthus";
q4.respostaCorreta = 1;
q4.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q4);

// Pergunta 5
var q95 = new Questao();
q5.pergunta = "Qual é o nome do fenômeno que ocorre quando a luz muda de direção ao passar de um meio para outro?";
q5.resposta01 = "Refração";
q5.resposta02 = "Reflexão";
q5.resposta03 = "Dispersão";
q5.resposta04 = "Difração";
q5.resposta05 = "Absorção";
q5.respostaCorreta = 1;
q5.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q5);

// Pergunta 6
var q96 = new Questao();
q6.pergunta = "Qual é a capital da Etiópia, conhecida por ser a sede da União Africana?";
q6.resposta01 = "Nairobi";
q6.resposta02 = "Addis Abeba";
q6.resposta03 = "Asmara";
q6.resposta04 = "Kampala";
q6.resposta05 = "Mogadíscio";
q6.respostaCorreta = 2;
q6.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q6);

// Pergunta 7
var q97 = new Questao();
q7.pergunta = "Qual artista é famoso por sua técnica de 'trompe-l'œil', que cria ilusões de ótica em pinturas?";
q7.resposta01 = "Pablo Picasso";
q7.resposta02 = "Michelangelo";
q7.resposta03 = "M.C. Escher";
q7.resposta04 = "Caravaggio";
q7.resposta05 = "Salvador Dalí";
q7.respostaCorreta = 3;
q7.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q7);

// Pergunta 8
var q98 = new Questao();
q8.pergunta = "Qual é o maior continente do mundo em área?";
q8.resposta01 = "África";
q8.resposta02 = "Ásia";
q8.resposta03 = "América do Norte";
q8.resposta04 = "Antártica";
q8.resposta05 = "Europa";
q8.respostaCorreta = 2;
q8.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q8);

// Pergunta 9
var q99 = new Questao();
q9.pergunta = "Qual é o nome da única letra do alfabeto que não aparece na tabela periódica dos elementos?";
q9.resposta01 = "X";
q9.resposta02 = "Q";
q9.resposta03 = "Z";
q9.resposta04 = "J";
q9.resposta05 = "W";
q9.respostaCorreta = 2;
q9.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q9);

// Pergunta 10
var q100 = new Questao();
q10.pergunta = "Qual a linguagem de programação amplamente utilizada para desenvolvimento web do lado do servidor?";
q10.resposta01 = "Python";
q10.resposta02 = "JavaScript";
q10.resposta03 = "Java";
q10.resposta04 = "Ruby";
q10.resposta05 = "PHP";
q10.respostaCorreta = 5;
q10.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q10);








}
    var q2=new Questao();

    public void ProximaQuestao()
   {
         var numRandomico=Random.Shared.Next(0,ListaQuestoes.Cout-1);
        while(listaQuestoesRespondidas.Add(numRandomico))
        numRandomico=Randon.Shared.next(0,ListaQuestoes.Count-1);
          listaQuestoesRespondidas.Add(num);
   }



   public int pontuacao{get;private set;}
   int nivelAtual=0;
   void Inicializar()
{
  pontuacao=0;
  nivelAtual=0;
  ProximaQuestao();

}
    public async void VerificaCorreta(int rr)
    {
     if(questaoCorrente.EstaCorreto(rr))
    {
    await Task.Delay(1000);
    AdicionaPontuacao(NivelAtual);
    NivelAtual++;
    ProximaQuestao();
}
        else
    
         awaint DisplayAlert = "Game over, Voce perdeu, ok";
         Inicializar();
    }


        void AdicionaPontuacao(int rr)
     {    
        if(n==1)
        Pontuacao=1000;
        else if (n==2)
        Pontuacao=2000;
        else if (n==3)
        Pontuacao=5000;
        else if (n==4)
        Pontuacao=10000;
        else if (n==5)
        Pontuacao=20000;
        else if (n==6)
        Pontuacao=50000;
        else if (n==7)
        Pontuacao=100000;
        else if (n==8)
        Pontuacao=200000;
        else if (n==9)
        Pontuacao=500000;
        else
        Pontuacao=1000000;
     }
    
    





    
    