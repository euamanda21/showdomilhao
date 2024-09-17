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
    public boll Verifica Resposta (int rr)
    {
        if (resposta Certa == rr)
        {
            var btn = Qualbtn (rr);
            btn BackgrowColor = Colors.Green;
            Return True;
        }
        else
        {
            var btnCorreto = QualBtn (resposta1 Certa);
            var btnIncorreto = QualBtn (RR);
             btnCorreto.BackgrounColor = Colors.Yellow;
             btnIncorreto.BackgrounColor = Colors.Red;
             Return false;
        }
    } 

}