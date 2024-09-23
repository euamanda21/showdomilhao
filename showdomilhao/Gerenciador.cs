using System.Security.Cryptography.X509Certificates;
using Microsoft.UI.Xaml.Automation.Peers;
using showdomilhao;

public class Gerenciador 
{
         CriarQuestoes (Label labelPergunta, Button buttontResp01, buttontResp02, Button buttonResp03, Button buttonResp04, Button buttonResp05)
    }
{}
    void CriarQuestoes (Label labelPergunta, Button buttonResp01 Button butttonResp02, Button buttonResp03, Button buttonResp04, Button buttonResp05)
    {
        var q1 = new Questao();
        q1.pergunta= "Quanto é 2+2 ?";
        q1.resposta01="1";
        q1.resposta02="3";
        q1.resposta03="11";
        q1.resposta04="4";
        q1.resposta05="12";
        q1.respostacorreta = 4;
        
        public void ProximaQuestao()
        {
            var numRandomico= Random.Shared.Next(0, listaQuestoes.Count);
            while(listaQuestoesRespondidas.Countains(numRandomico))
             numRamdomico=Random.Shared.Next(0,listaQuestoes.count);

             listaQuestoesRespondidas.Add(numRandomico);
             QuestaoCorrente= listaQuestoes[numRandomico];
             QuestaoCorrente.Desenha();
        }
        
        public async void verificaCorreto (int RR)
        {
            if (QuestaoCorrent.Verifica Resposta(RR))
            {
                await Task.Delay (1000);
                ProximaQuestao();
            }
        }
    }   
}