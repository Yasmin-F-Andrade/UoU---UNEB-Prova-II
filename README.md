ENGLISH:
1. Overload the ReduceLife method on the Heroi (hero) class so that it receives a damage value and subtracts that value from the hero’s health points.



The Method


        public virtual void ReduzirVida() 
        {
            this.ptsVida--;
        }


From the Original Code had it’s name altered to ReceberDano (With the Purpose of Facilitating Code Reading) and was Altered to Generate a Overload


       public virtual void ReceberDano(float d1)
      {
      this.vida -= (float)d1;
      }


       public virtual void ReceberDano(float d1, float d2)
      {
       this.vida -= (float)(d1 + d2);
      }




2. Add a new Attribute to the Hero Class Called UTHeroi (Time Units). This Attribute will be Utilized to control the quantity of Actions a Hero can do each Game Cycle.


 protected float UTHeroi;


Protected was used To avoid that the Variable ends up being pulled out by an out of the Class Code, and float because it utilizes a small memory quantity, wich would be appropriate considering that the Values would be Small.




3. Adjust the Heroi Class’s Constructor to start the UTHeroi Attribute with the value of 7.


       public Heroi(string nome, float vida)
      {
        this.nome = nome;
        this.vida = vida;
        this.UTHeroi = 7;  
      }


The Heroi Class’s not was Altered from this.UTHeroi=UTHeroi to this.UTHeroi=7. Therefore,initializing UTHero with a 7 Value.

4. Create two Methods,one to Add up a Value to the UTHeroi Attribute (AumentarUT) and another tl subtract a Value from the UTHeroi Aattribute (ReduzirUT).


       public virtual void AumentarUT(float Dd1)
      {
       this.UTHeroi += (float)Dd1;
      }


       public virtual void ReduzirUT(float Dd2)
      {
       this.UTHeroi -= (float)Dd2;
      }


Inside the Methods,AumentaeUT and ReduzirUT have been added, Based on Float,So that a fixed value can be added Later.




5. Create a class named Magia (spell). A spell has a name, a time unit cost (CustoUT), and a damage value.

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


The explanations follow the same logic as in the previous questions.



6. Add a method named Lancar( ) to the Magia class that returns the
amount of damage dealt.

        //Metodo


        public virtual float Lancar()
       {
          return(Dano);
       }


Public so that this method can be accessed by any other class, Virtual to allow this method to be overridden in the future, and Float to be consistent with Damage.

To return damage, return(Dano) was used.



7. Create an attribute of type Magia in the Heroi class. 
protected Magia magia;






8. Update the constructor for the HeroiAlianca and HeroiHorda classes to
create a new spell for the hero according to the table below:


In the constructor

    public HeroiHorda(string nome, float vida) : base(nome, vida)
       {


       }




        public HeroiHorda(string nome, float vida) : base(nome, vida)
       {
    
       }


was added

    public HeroiHorda(string nome, float vida) : base(nome, vida)
       {
         magia = new Magia ("Caminho de Chamas", 6, 30);
       }


        public HeroiHorda(string nome, float vida) : base(nome, vida)
       {
         magia = new Magia ("Caminho de Chamas", 6, 30);
       }


Using the Magia attribute created earlier—which is accessible because HeroiAlianca and HeroiHorda are subclasses of Heroi, an object was created with the attributes NOME (Name), CustoUT, and Dano (Magic Damage), assigned the values "Caminho de Chamas", 6, 30.



9. Create a class named Arma. A weapon (Arma) has a name, a time unit cost (CustoUT), and a damage value.


10. Add a method to the Arma (weapon) class, called Atacar(), that returns the damage value.

11. Create an attribute of type ArmaHeroi in the Heroi class.

12. Update the constructor of the HeroiAlianca and HeroiHorda classes to create a weapon for the hero according to the table below:

Well, the creation logic is the same as explained previously in the creation of the Magia Class, so I will just put the code.


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




        public HeroiHorda(string nome, float vida) : base(nome, vida)
       {
         magia = new Magia ("Caminho de Chamas", 6, 30);
         ArmaHeroi = new Arma("Machado", 14, 20);
       }


       public HeroiAlianca(string nome, float vida) : base(nome, vida)
      {
        magia = new Magia ("Força Rutilante", 4, 20);
        ArmaHeroi = new Arma("Espada", 12, 10);
      }


13. Create an Herói da Aliança  (Alliance Hero) and a Herói da Horda  (Horde Hero), both with 80 health points.


HeroiAlianca Paçoquinha = new HeroiAlianca ("Paçoquinha", 80);


HeroiHorda Devo = new HeroiHorda ("Devorador de Mundos", 80); 


Creation of two objects inheriting the attributes Nome (name) and Vida (health) from HeroiAlianca/HeroiHorda, assigned the values ("Paçoquinha", 80) and ("Devorador de Mundos", 80), respectively;

14. Create a “Game Loop” that alternates between an Alliance attack and a Horde attack. With each attack, the game must perform the following actions:
I will break this part of the explanation down into topics to make it easier to understand.

a. Assign 3 UTs to the attacker.
b. Display the attacker's UT balance.
c. Wait for the attack: the player must press the “M” key for
magic or the “A” key for weapon.
d. Depending on the player's choice, call the attacker's
LancarMagia() or AtacarComArma() methods, passing the
target as an argument.
e. Display the target's remaining hit points.

          while (JogoRodando == true) // Game loop requested in the activity
          {
             Paçoquinha.AumentarUT(3);
             Console.WriteLine ("{0} tem {1} pontos UT", Paçoquinha.GetNome(), Paçoquinha.GetUTHeroi());


             Console.WriteLine("Escolha M para magia, A para arma ou C para cura:");// Healing is a bonus because I really want to kill destruidor de mundos.
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






While initiates the game loop, with the condition JogoRodando == true (a variable named bool JogoRodando was added at the beginning of the main class).

Paçoquinha.AumentarUT(3) convoca o metodo Aumentar Ut, aumentando o Ut em +3


 Console.WriteLine ("{0} tem {1} pontos UT", Paçoquinha.GetNome(), Paçoquinha.GetUTHeroi()) // Write the Hero's name and their current Ut balance.

The player's choice is made based on what he writes, whether the letter is in capslock or not does not affect it, as .ToLower was placed at the end (reads any text typed as lowercase).
Using an if system, the code reads the player's response, and triggers AtacarcomArma or LancarMagia.

To enable these methods to record damage and Ut cost, I overrode AtacarcomArma and LancarMagia within the HeroiHorda and HeroiAlianca classes. Both follow this logic:

        public override void AtacarcomArma(Heroi alvo)
       {
          float DanoA = 0;
          this.ReduzirUT((float)ArmaHeroi.GetCustoUTA());
          this.ArmaHeroi.Atacar();
          DanoA = ArmaHeroi.GetDanoA();
          alvo.ReceberDano(DanoA);
          Console.WriteLine("{0} usou {1} e causou {2} de dano. Agora {3} tem {4} de vida. Agora, {5} tem {6} CustoUT", this.nome, this.ArmaHeroi.GetNomeA(), DanoA, alvo.GetNome(), alvo.GetVida(), this.nome, this.GetUTHeroi());




The following method:

Creates a variable of type Heroi, called target (which will be used to direct the methods it invokes) does not return itself (void), sets Damage to 0 (initially), calls ReduzirUt, and assigns CustoUTA as its cost, calls the Atacar method, sets DanoA to DanoA, applies ReceberDano to the target and writes a message that records the attacker's name, the ability used, the damage dealt, the target's name, the target's remaining life and the target's final Ut cost.


The same logic was used to program the HeroiHorda attack.

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




f. If the attack is sufficient to take away all of the target's life, the game
should be ended with the following actions:
i. Display a message informing the name of the winning hero and their remaining life.
j. Display a Game Over message.
Additional: The professor requested on Discord that if the UT of any of the heroes reaches 0, this would be considered a game over.



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
             else if (Devo.GetUTHeroi() <= 0)// Well, it's strange that the game ends like this, the ultimate biases end, but that's what was instructed on Discord.
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


PORTUGUESE:
1. Realize uma sobrecarga do método ReduzirVida na classe Heroi, de
forma que ele receba um valor de dano e subtraia esse valor dos pontos
de vida do herói.


O método


        public virtual void ReduzirVida() 
        {
            this.ptsVida--;
        }


do código original teve seu nome alterado para ReceberDano com (propósito de facilitar a leitura do código), e foi alterado para gerar uma sobrecarga


       public virtual void ReceberDano(float d1)
      {
      this.vida -= (float)d1;
      }


       public virtual void ReceberDano(float d1, float d2)
      {
       this.vida -= (float)(d1 + d2);
      }




2. Adicione um novo atributo à classe Herói chamado UTHeroi (unidades
de tempo). Esse atributo será utilizado para controlar a quantidade de
ações que um herói pode realizar a cada ciclo de jogo.


 protected float UTHeroi;


foi usado protected para evitar que a variável acabasse sendo puxada por um código fora da classe, e float pois utiliza uma quantidade pequena de memória, o que seria adequado considerando que os valores utilizados nessa variável seriam pequenos.




3. Ajuste o construtor da classe Heroi para iniciar o atributo UTHeroi com
valor 7.


       public Heroi(string nome, float vida)
      {
        this.nome = nome;
        this.vida = vida;
        this.UTHeroi = 7;  
      }


O construtor da classe Heroi foi alterado de this.UTHeroi = UtHeroi para this.UTHeroi = 7. Portanto, iniciando UTHeroi com o valor 7
4. Crie dois métodos, um para adicionar um valor ao atributo UT (AumentarUT) e outro para subtrair um valor do atributo UTHeroi (ReduzirUT).


       public virtual void AumentarUT(float Dd1)
      {
       this.UTHeroi += (float)Dd1;
      }


       public virtual void ReduzirUT(float Dd2)
      {
       this.UTHeroi -= (float)Dd2;
      }


Dentro dos métodos, foi adicionado AumentarUT e ReduzirUT, tendo como base float, para que um valor fixo possa ser adicionado posteriormente.




5. Crie uma classe chamada Magia. Uma magia possui um nome, um
custo de unidades de tempo (CustoUT) e um valor de dano.


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


As explicações seguem a mesma lógica explicada nas questões anteriores




6. Adicione um método à classe Magia, chamado Lancar( ), que retorne o
valor de dano causado.


        //Metodo


        public virtual float Lancar()
       {
          return(Dano);
       }


Public para que esse método possa ser acessado por qualquer outra classe, virtual para permitir que esse método seja sobrescrito futuramente e Float para ser condizente com Dano.


Para retornar dano, foi usado retunr(Dano).




7. Crie um atributo do tipo Magia na classe Heroi.
 protected Magia magia;








8. Atualize o construtor das classes HeroiAlianca e HeroiHorda para
criar uma nova magia para o herói de acordo com a tabela abaixo:


No construtor 


    public HeroiHorda(string nome, float vida) : base(nome, vida)
       {


       }




        public HeroiHorda(string nome, float vida) : base(nome, vida)
       {
    
       }


foi adicionado


    public HeroiHorda(string nome, float vida) : base(nome, vida)
       {
         magia = new Magia ("Caminho de Chamas", 6, 30);
       }


        public HeroiHorda(string nome, float vida) : base(nome, vida)
       {
         magia = new Magia ("Caminho de Chamas", 6, 30);
       }


utilizando do atributo magia, criado anteriormente (que pode ser puxado pois HeroiAlianca e HeroiHorda são classes filhas de Heroi), foi criado um objeto que possui os atributos     NOME, CustoUT, Dano (de magia), ao qual forem atribuídos “"Caminho de Chamas", 6, 30”




9. Crie uma classe chamada Arma. Uma arma possui um nome, um custo
de unidades de tempo (CustoUT) e um valor de dano.


10. Adicione um método à classe Arma, chamado Atacar(), que retorne o
valor do dano causado.


11. Crie um atributo do tipo ArmaHeroi na classe Heroi.


12. Atualize o construtor das classes HeroiAlianca e HeroiHorda para
criar uma arma para o herói de acordo com a tabela abaixo:


Pois bem, a lógica de criação é a mesma explicada anteriormente na criação da Classe Magia, então vou apenas colocar os códigos


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




        public HeroiHorda(string nome, float vida) : base(nome, vida)
       {
         magia = new Magia ("Caminho de Chamas", 6, 30);
         ArmaHeroi = new Arma("Machado", 14, 20);
       }


       public HeroiAlianca(string nome, float vida) : base(nome, vida)
      {
        magia = new Magia ("Força Rutilante", 4, 20);
        ArmaHeroi = new Arma("Espada", 12, 10);
      }


13. Crie um Herói da Aliança e um Herói da Horda, ambos com 80 pontos de
vida.


HeroiAlianca Paçoquinha = new HeroiAlianca ("Paçoquinha", 80);


HeroiHorda Devo = new HeroiHorda ("Devorador de Mundos", 80); 


Criação de dois objetos, que herdam os atributos nome e vida, de HeroiAlianca/HeroiHorda, ao qual foram atribuídos ("Paçoquinha", 80)/("Devorador de Mundos", 80);


14. Crie um “Game Loop” que alterne entre um ataque da Aliança e um
ataque da Horda. A cada ataque, o jogo deverá realizar as seguintes
ações:
Vou dividir essa parte da explicação em tópicos, para facilitar a compreensão


a. Atribuir 3 UTs para o atacante.
b. Exibir o saldo de UTs do atacante.
c. Aguardar o ataque: o jogador deverá digitar a tecla “M” para
magia ou a tecla “A” para arma.
d. A depender da escolha do jogador, chamar os métodos
LancarMagia()ou AtacarComArma() do atacante, passando o
alvo como argumento.
e. Exibir os pontos de vida restantes do alvo.


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






While inicia o gameloop, tendo como condição JogoRodando == true (foi adicionada uma variavel chamada bool JogoRodando no inicio da classe principal.).


Paçoquinha.AumentarUT(3) convoca o metodo Aumentar Ut, aumentando o Ut em +3


 Console.WriteLine ("{0} tem {1} pontos UT", Paçoquinha.GetNome(), Paçoquinha.GetUTHeroi()) Escreve o nome do Heroi, e seu saldo atual de Ut


A escolha do jogador é executada baseado no que ele escreve, a letra estar em capslock ou não não interfere, pois foi colocado .ToLower no final (lê qualquer texto digitado como minúsculo).
Usando um sistema de if, o código lê a resposta do jogador, e aciona AtacarcomArma ou LancarMagia.


Para fazer com que esses métodos fossem capazes de registrar dano e custo de Ut, eu sobrescrevi AtacarcomArma e LancarMagia dentro das classes HeroiHorda e HeroiAlianca. Ambos seguem a seguinte lógica


        public override void AtacarcomArma(Heroi alvo)
       {
          float DanoA = 0;
          this.ReduzirUT((float)ArmaHeroi.GetCustoUTA());
          this.ArmaHeroi.Atacar();
          DanoA = ArmaHeroi.GetDanoA();
          alvo.ReceberDano(DanoA);
          Console.WriteLine("{0} usou {1} e causou {2} de dano. Agora {3} tem {4} de vida. Agora, {5} tem {6} CustoUT", this.nome, this.ArmaHeroi.GetNomeA(), DanoA, alvo.GetNome(), alvo.GetVida(), this.nome, this.GetUTHeroi());




O seguinte método:
 Cria uma variavel do tipo Heroi, chamada alvo (que sera utilizada para direcionar os métodos que invoca) não retorna a si mesmo (void), define Dano como 0 (inicialmente), convoca ReduzirUt, e atribui como seu custo CustoUTA, convoca o método Atacar, define DanoA como DanoA, aplica ReceberDano no alvo e escreve uma mensagem que registra o nome do atacante, a habilidade usada, o dano causado, o nome do alvo, a vida restante do alvo e o custo final de Ut do alvo. 




A mesma lógica foi usada para programar o ataque do HeroiHorda


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




f. Se o ataque for suficiente para retirar toda a vida do alvo, o jogo
deverá ser encerrado com as seguintes ações:
i. Exibir uma mensagem informando o nome do herói
vencedor e a quantidade restante de vida dele.
ii. Exibir uma mensagem de Game Over.
Adicional: Foi pedido pelo professor no discord que caso o UT de algum dos herois chega-se a 0, isso seria considerado um game over .




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
         


Esse código if atua para caso VIda ou Ut, de qualquer um dos herois, chegue a 0, isso tornara JogoRodando = false, exibindo uma mensagem informando o heroi vencedor, sua vida,  um GameOver para o heroi perdedor e por fim encerrando o looping.




Adicional:
Com as execuções do código, percebi que HeroiHorda era mais forte que HeroiAlianca, visando balancear isso criei uma ação extra, chamada Curar, que invoca ReceberCura, com um valor de 30.
         


