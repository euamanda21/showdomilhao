using System.Runtime.CompilerServices;
using Windows.ApplicationModel.UserDataTasks;

namespace showdomilhao;
public class Questao
{
    public string pergunta;
    public string resposta1;
    public string resposta2;
    public string resposta3;
    public string resposta4; 
    public string resposta5;
    public int respostacorreta;
    public int nível;
    Label labelpergunta;
    Button buttonResposta1;
    Button buttonResposta2;
    Button buttonResposta3;
    Button buttonResposta4;
    Button buttonResposta5;
    public void Desenhar()
    {
        labelpergunta.Text = pergunta;
         buttonResposta1.Text = resposta1;
         buttonResposta2.Text = resposta2;
         buttonResposta3.Text = resposta3;
         buttonResposta4.Text = resposta4;
         buttonResposta5.Text = resposta5;
        
    }
    public Boll VerificaResposta (int RR);
    
        If (resposta Certa == rr)
        {
            var btn = Qualbtn (rr)
            btn BackgrowColor = Colors.Green;
            return true;
        }
        else
        {
            var btnCorreto = QualBtn (resposta1 Certa);
            var btnIncorreto = QualBtn (rr);
             btnCorreto.BackgroundColor = Colors.Yellow;
             btnIncorreto.BackgroundColor = Colors.Red;
             return false;
        }
        private Button QualBtn(int rr)
        {
            if (rr==1)
            return BotaoResposta01;

            else if (rr==2)
            return BotaoResposta02;

            else if (rr==3)
            return BotaoResposta03;

            else if (rr==3)
            return BotaoResposta03;

            else if (rr==4)
            return BotaoResposta04;

            else if (rr==5)
            return BotaoResposta05;

            else 
             return null;
        }
    } 

