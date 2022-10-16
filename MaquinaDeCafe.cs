
/*

TEMA: Encapsulamiento y Constructores
NOMBRE: Darling Fajardo
MATRICULA: 100451815
UNIVERSIIDAD: UASD
ASIGNATURA: Lab. Programacion 1
SECCION: 18

*/
using System;

//Clase princpal
class TUCAFE{

      //Atributos de lac clase
      private double CafeRegular = 10.00;
      private double CafeExpreso = 15.00;
      private double Capuchino = 25.00;
      private double Mocaccino = 25.00;
      private double Saldo = 25.00;
   
   //Metodo que muestra un menu
   public void MostrarMenu(){
        
        Console.WriteLine("\n\t> MAQUINA EXPENDEDORA TUCAFE\tSaldo: RD$" + Saldo + "\n\t_______________________________");
        Console.WriteLine("\tTipo de Bebida:    |\tPrecio:\n\t___________________|___________");
        Console.WriteLine("\t1.Cafe Regular \t   |\tRD$" + CafeExpreso + "\n\t2.Cafe Expreso \t   |\tRD$" + CafeRegular);
        Console.WriteLine("\t3.Capuchino \t   |\tRD$" + Capuchino + "\n\t4.Mocaccino \t   |\tRD$" + Mocaccino);
   } 
   
   //Metodo que permite depositar monedas
   public void IntroducirMonedas(){
          
          Deposito:
          Console.Write("\n\t> Deposita tus monedas: ");
          int Monedas = int.Parse(Console.ReadLine());
          switch(Monedas){
          case 1: 
          case 5:
          case 10:
          case 25: Saldo += Monedas; break;
          default: Console.WriteLine("\n\tSolo se aceptan monedas de RD$1.00, RD$5.00, RD$10.00, RD$25.00. Intente de nuevo.");
          Console.ReadKey();
          Console.Clear();
          TUCAFE Objeto = new TUCAFE();
          Objeto.MostrarMenu();
          goto Deposito;
       }

    }
    
    //Metodo que permite comprar las bebidas
    public void ComprarBebida(){
        
        string mensaje = "\n\tNo posee saldo suficiente.";
        string mensaje2 = "\n\tCompra realizada.";
        comprar:
        Console.Write("\n\t> Seleccone la Bebida que desea comprar: ");
        int comprar = int.Parse(Console.ReadLine());
          switch(comprar){
          case 1: 
          if(Saldo >= 10){  
          Saldo -= CafeRegular; Console.WriteLine(mensaje2); Console.ReadKey(); break;}
          else{Console.WriteLine(mensaje);
          Console.ReadKey();
          break;}
          case 2: 
          if(Saldo >= 15){  
          Saldo -= CafeExpreso; Console.WriteLine(mensaje2); Console.ReadKey(); break;}
          else{Console.WriteLine(mensaje);
          Console.ReadKey();
          break;}
          case 3: 
          if(Saldo >= 25){  
          Saldo -= Capuchino; Console.WriteLine(mensaje2); Console.ReadKey(); break;}
          else{Console.WriteLine(mensaje);
          Console.ReadKey();
          break;}
          case 4: 
          if(Saldo >= 25){  
          Saldo -= Mocaccino; Console.WriteLine(mensaje2); Console.ReadKey(); break;}
          else{Console.WriteLine(mensaje);
          Console.ReadKey();
          break;}
          default: Console.WriteLine("\n\tIntroduce la opcion correcta.");
          Console.ReadKey();
          Console.Clear();
          TUCAFE Objeto = new TUCAFE();
          Objeto.MostrarMenu();
          goto comprar;
       }

    }
    
    //Metodo que permite reiniciar la maquina
    public void ReiniciarMaquina(){

        Console.WriteLine("\n\n\tPresione ENTER Para Reiniciar Maquina.");
        Console.ReadKey();

    }
     
        //Metodo Destructor
        ~TUCAFE(){}

}

//Clase que ejecuta el programa
class Program{


    static void Main(String[] args){
        
        Inicio:
        TUCAFE Objeto = new TUCAFE(); //Creando el Objeto

        //Menu de opciones
        Refrescar:
        Objeto.MostrarMenu();
        Console.WriteLine("\n\tQue deseas realizar ?");
        Console.WriteLine("\n\t1.Depositar Monedas");
        Console.WriteLine("\t2.Comprar Bebida");
        Console.WriteLine("\t3.Reiniciar Maquina");
        char opcion = Console.ReadKey(true).KeyChar;
        switch(opcion){
             case '1': Objeto.IntroducirMonedas(); Console.Clear(); goto Refrescar;
             case '2': Objeto.ComprarBebida(); Console.Clear(); goto Refrescar;
             case '3': Objeto.ReiniciarMaquina(); Console.Clear(); goto Inicio;
             default: Console.WriteLine("\n\tIntroduce la opcion correcta.");
             Console.ReadKey();
             Console.Clear();
             goto Refrescar;
        }

   }


}
