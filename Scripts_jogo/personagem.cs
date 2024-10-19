using System;
    class personagem
    {

       //Atributos atributos são variaives  que minha classe usa
       // Constructor e uma função/metodo definido como os objetos
       // Metodos sao função que representam o que objeto dessa classe pode fazer
       public string nome;
       public int forca;
       public double roubovida;
       public int vida;
       public double velataque;

       public void atacar(){
         Console.WriteLine($"Personagem {nome} Ataca com forca de {forca}, e tem de velocidade de ataque {velataque}, com roubo de vida de {roubovida}");
       }
       }
       public personagem(string nomepersonagem,int forcaInicial,int VidaInicial, double velataque2,double roubo){
          nome = nomepersonagem;
          forca = forcaInicial;
          vida = VidaInicial;
          velataque = velataque2;
          roubovida = roubo;
       }
}



class Jogo
{
            static void Main(string[] arg){
                //Criar um personagem
                personagem personagem1 = new personagem("Dama Vermelha",5,100,0.45,0.75);
                personagem1.atacar();
                personagem1.Andar();
                //Verifica a vida do personagem.
                
              for(int i=0; personagem1.vida<100; personagem1.vida++){
               Console.WriteLine($"O personagem {personagem1.nome}: {personagem1.vida}");
               personagem1.vida=personagem1.vida;
               personagem1.vida ++;
              }
              

            }
}    
