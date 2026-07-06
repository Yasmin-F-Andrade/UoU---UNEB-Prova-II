using System;

namespace Projeto001
{

public abstract class Heroi
{
  //Atributos

  protected string nome; //protected para organizar melhor o codigo, impedindo que esses atributos vazem para algo além das classes filhas de heroi
  protected float vida;
  protected float UTHeroi;
  protected Magia magia;  //variavel magia do tipo Magia(n sabia que dava pra fazer isso até ontem)
  protected Arma ArmaHeroi;


  //Construtor

       public Heroi(string nome, float vida)
      {
        this.nome = nome;
        this.vida = vida;
        this.UTHeroi = 7;  //atribuição de valor ao UTheroi
      }

       public float GetVida()
      {
        return(vida);
      }

       public string GetNome()
      {
        return(nome);
      }

       public float GetUTHeroi()
      {
        return(UTHeroi);
      }

       public Magia GetMagia()
      {
        return(magia);
      }

       public void SetVida(float vida)
      {
        this.vida = vida;
      }

       public void SetNome(string nome)
      {
        this.nome = nome;
      }

       public void SetUTHeroi(float UTHeroi)
      {
        this.UTHeroi = UTHeroi;
      }

       public void SetMagia(Magia magia)
      {
       this.magia = magia;

      }

      //Metodos

      //Metodo Lançar magia

  public abstract void LancarMagia(Heroi alvo); //variavel do tipo Heroi, chamada alvo

      //Metodo atacar com Arma
  public abstract void AtacarcomArma(Heroi alvo);


      //Sobrecarga-Receberdano

       public virtual void ReceberDano(float d1)
      {
      this.vida -= (float)d1;
      }

       public virtual void ReceberDano(float d1, float d2)
      {
       this.vida -= (float)(d1 + d2);
      }

       public virtual void ReceberCura(float D1)
      {
       this.vida += (float)D1;
      }

     //MetodosUT

       public virtual void AumentarUT(float Dd1)
      {
       this.UTHeroi += (float)Dd1;
      }

       public virtual void ReduzirUT(float Dd2)
      {
       this.UTHeroi -= (float)Dd2;
      }
}

      //Classe heroi da Aliança

   public class HeroiAlianca: Heroi
     {
       public HeroiAlianca(string nome, float vida) : base(nome, vida)
      {
        magia = new Magia ("Força Rutilante", 4, 20);
        ArmaHeroi = new Arma("Espada", 12, 10);
      }

       public override void ReceberCura(float D1)
      {
        this.vida += (float)D1;
      }

       public virtual void AumentarUt(float Dd1)
      {
        this.UTHeroi += (float)Dd1;
      }

       public override void ReduzirUT(float Dd2)
      {
        this.UTHeroi -= (float)Dd2;
      }

      public override void LancarMagia(Heroi alvo)
        {
          float Dano = 0;
          this.ReduzirUT((float)magia.GetCustoUT());
          this.magia.Lancar();
          Dano = magia.GetDano();
          alvo.ReceberDano(Dano);
          Console.WriteLine("{0} usou {1} e causou {2} de dano. Agora {3} tem {4} de vida. Agora, {5} tem {6} CustoUT", this.nome, this.magia.GetNOME(), Dano, alvo.GetNome(), alvo.GetVida(), this.nome, this.GetUTHeroi());
        }

      public override void AtacarcomArma(Heroi alvo)
        {
          float DanoA = 0;
          this.ReduzirUT((float)ArmaHeroi.GetCustoUTA());
          this.ArmaHeroi.Atacar();
          DanoA = ArmaHeroi.GetDanoA();
          alvo.ReceberDano(DanoA);
          Console.WriteLine("{0} usou {1} e causou {2} de dano. Agora {3} tem {4} de vida. Agora, {5} tem {6} CustoUT", this.nome, this.ArmaHeroi.GetNomeA(), DanoA, alvo.GetNome(), alvo.GetVida(), this.nome, this.GetUTHeroi());
        }

    }

     //Classe Heroi da Horda

   public class HeroiHorda: Heroi
     {
        public HeroiHorda(string nome, float vida) : base(nome, vida)
       {
         magia = new Magia ("Caminho de Chamas", 6, 30);
         ArmaHeroi = new Arma("Machado", 14, 20);
       }

        public override void ReceberDano(float d1, float d2)
       {
        this.vida -= (float)(d1 + d2);
       }

        public virtual void AumentarUt(float Dd1)
       {
        this.UTHeroi += (float)Dd1;
       }

        public override void ReduzirUT(float Dd2)
       {
        this.UTHeroi -= (float)Dd2;
       }

        public override void LancarMagia(Heroi alvo)
       {
          float Dano = 0;
          this.ReduzirUT((float)magia.GetCustoUT());
          this.magia.Lancar();
          Dano = magia.GetDano();
          alvo.ReceberDano(Dano);
          Console.WriteLine("{0} usou {1} e causou {2} de dano. Agora {3} tem {4} de vida. Agora, {5} tem {6} CustoUT", this.nome, this.magia.GetNOME(), Dano, alvo.GetNome(), alvo.GetVida(), this.nome, this.GetUTHeroi());
       }

        public override void AtacarcomArma(Heroi alvo)
       {
          float DanoA = 0;
          this.ReduzirUT((float)ArmaHeroi.GetCustoUTA());
          this.ArmaHeroi.Atacar();
          DanoA = ArmaHeroi.GetDanoA();
          alvo.ReceberDano(DanoA);
          Console.WriteLine("{0} usou {1} e causou {2} de dano. Agora {3} tem {4} de vida. Agora, {5} tem {6} CustoUT", this.nome, this.ArmaHeroi.GetNomeA(), DanoA, alvo.GetNome(), alvo.GetVida(), this.nome, this.GetUTHeroi());
       }

     }

     //classe magia

   public class Magia
     {

      //Atributos

      private string NOME;
      private float CustoUT;
      private float Dano;

      //Construtor

        public Magia(string NOME, float CustoUT, float Dano)
       {
        this.NOME = NOME;
        this.CustoUT = CustoUT;
        this.Dano = Dano;
       }

       //Get e Set

        public string GetNOME()
       {
          return(NOME);
       }

        public float GetCustoUT()
       {
          return(CustoUT);
       }

        public float GetDano()
       {
          return(Dano);
       }

        public void SetNOME(string NOME)
       {
          this.NOME = NOME;
       }

        public void SetCustoUT(float CustoUT)
       {
          this.CustoUT = CustoUT;
       }

        public void SetDano(float Dano)
       {
          this.Dano = Dano;
       }

        //Metodo

        public virtual float Lancar()
       {
          return(Dano);
       }

    }

     public class Arma
     {

      //Atributos

       private string NomeA;
       private float DanoA;
       private float CustoUTA;

       //Construtor

       public Arma(string NomeA, float CustoUTA, float DanoA)
       {
        this.NomeA = NomeA;
        this.DanoA = DanoA;
        this.CustoUTA = CustoUTA;
       }

       //Get e Set

        public string GetNomeA()
       {
         return(NomeA);
       }

        public float GetDanoA()
       {
         return(DanoA);
       }

        public float GetCustoUTA()
       {
         return(CustoUTA);
       }

        public void SetNomeA(string NomeA)
       {
         this.NomeA = NomeA;
       }

        public void SetDanoA(float DanoA)
       {
         this.DanoA = DanoA;
       }

        public void SetCustoUTA(float CustoUTA)
       {
         this.CustoUTA = CustoUTA;
       }

        public virtual void Atacar() //metodo atacar
       {

       }
     }


     public class Uou
     {
       public static void Main()
       {
          //Execução parte final da lista

          bool JogoRodando = true; //condição para inciar ou encerrar o gameloop
          HeroiAlianca Paçoquinha = new HeroiAlianca ("Paçoquinha", 80); //criação de um objeto que vai possuir as caracteristicas de HeroiAliança
          HeroiHorda Devo = new HeroiHorda ("Devorador de Mundos", 80); //criação de um objeto que vai possuir as caracteristicas de HeroiHorda

          while (JogoRodando == true) //looping de game pedido na atividade
          {
             Paçoquinha.AumentarUT(3);
             Console.WriteLine ("{0} tem {1} pontos UT", Paçoquinha.GetNome(), Paçoquinha.GetUTHeroi());

             Console.WriteLine("Escolha M para magia, A para arma ou C para cura:");//cura é bônus pq eu quero mt matar o destruidor de mundos
             string escolha = Console.ReadLine().ToLower();

             if (escolha == "m")
               {
                Paçoquinha.LancarMagia(Devo);
               }
             else if (escolha == "a")
               {
                Paçoquinha.AtacarcomArma(Devo);
               }
             else if (escolha == "c")
               {
                Paçoquinha.ReceberCura(30);
                Console.WriteLine("{0} Usou brisa verdejante e foi curado!!!!! Agora ele tem {1} de vida", Paçoquinha.GetNome(), Paçoquinha.GetVida());
               }
             else
               {
                Console.WriteLine("Escolha uma opção válida");
               }

             Console.WriteLine("O Devorador de mundos ataca!!!!!");
             Devo.AumentarUt(3);
             Console.WriteLine ("{0} tem {1} pontos UT", Devo.GetNome(), Devo.GetUTHeroi());

             Console.WriteLine("Escolha M para magia ou A para arma");
             escolha = Console.ReadLine().ToLower();

             if (escolha == "m")
               {
                Devo.LancarMagia(Paçoquinha);
               }
             else if (escolha == "a")
               {
                Devo.AtacarcomArma(Paçoquinha);
               }
             else
               {
                Console.WriteLine("Escolha uma opção válida");
               }





/*if (Devo.GetUTHeroi() >= 6) (tinha entendido errado o comando, mas achei interessante deixar aqui)
{
Devo.LancarMagia(Paçoquinha);
 }
 else
{
Devo.AtacarcomArma(Paçoquinha);
}*/

             if (Paçoquinha.GetVida() <= 0)
              {
               Console.WriteLine("{0} venceu com {1} de vida", Devo.GetNome(), Devo.GetVida());
               Console.WriteLine("GAME OVER");
               JogoRodando = false;
               break;
              }
             else if ((Devo.GetVida() <= 0))
              {
              Console.WriteLine("{0} venceu com {1} de vida", Paçoquinha.GetNome(), Paçoquinha.GetVida());
               Console.WriteLine("GAME OVER");
               JogoRodando = false;
               break;
              }
             else if (Devo.GetUTHeroi() <= 0)//bom, é estranho o jogo acabar assim os ut acabam, mas foi o que foi instruido no discord
             {
               Console.WriteLine("{0} venceu com {1} de vida", Paçoquinha.GetNome(), Paçoquinha.GetVida());
               Console.WriteLine("GAME OVER");
               break;
             }
             else if (Paçoquinha.GetUTHeroi() <= 0)
             {
               Console.WriteLine("{0} venceu com {1} de vida", Devo.GetNome(), Devo.GetVida());
               Console.WriteLine("GAME OVER");
               JogoRodando = false;
               break;
             }

          }
       }
     }
}
