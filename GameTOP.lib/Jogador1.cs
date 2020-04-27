using GameTop.Interface;

namespace GameTOP.lib
{
    public class Jogador1 : iJogador
    {

        //Chuta
        public string Chuta()
        {
            return "Ronaldo está Chutando";
        }

        //Corre
        public string Corre()
        {
            return "Ronaldo está Correndo";
        }

        //Parse
        public string Passe()
        {
            return "Ronaldo está Passando";
        }
    }
}