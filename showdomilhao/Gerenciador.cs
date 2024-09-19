using showdomilhao;

public class Gerenciador 
{
    void CriarQuestoes (Label labelPergunta, , Button btResp02, Button btResp03, Button btResp04, Button btResp05)
    {
        var q1 = new Questao();
        q1.pergunta= "Quanto é 2+2 ?";
        q1.resposta01="1";
        q1.resposta02="3";
        q1.resposta03="11";
        q1.resposta04="4";
        q1.respostacorreta = 4;
        q1.ConfigurarDesenho(labelPergunta, btnResposta01, btnResposta02, btnResposta03, btnResposta04);
        listaQuestoes.Add(q1);
        

    }
}