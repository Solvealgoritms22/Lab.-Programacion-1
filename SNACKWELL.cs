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
class VendingMachine{

      //Atributos de la clase
      private double Platanitos = 30.00;
      private double Yuquitas = 35.00;
      private double MyM = 60.00;
      private double MasMas = 25.00;
      private double Saldo = 0.00;
      private string hora = "";
      private bool Off_On = false;
   
   //Metodo que muestra un menu
   public void MostrarMenu(){
        
        Console.WriteLine("\n\t> MAQUINA EXPENDEDORA SNACKWELL\n\tSaldo: RD$" + Saldo + "\t  Hora: " + hora + "\n\t_______________________________");
        Console.WriteLine("\tTipo de Articulo:  |\tPrecio:\n\t___________________|___________");
        Console.WriteLine("\t1.Platanitos \t   |\tRD$" + Platanitos + "\n\t2.Yuquitas \t   |\tRD$" + Yuquitas);
        Console.WriteLine("\t3.M y M \t   |\tRD$" + MyM + "\n\t4.Mas Mas \t   |\tRD$" + MasMas);
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
          default: Console.WriteLine("\n\tSolo se aceptan monedas de RD$10.00 y RD$25.00. Intente de nuevo.");
          Console.ReadKey();
          Console.Clear();
          MostrarMenu();
          goto Deposito;
       }

    }
    
    //Metodo que permite comprar las bebidas
    public void ComprarArticulo(){
        
        string mensaje = "\n\tNo posee saldo suficiente.";
        string mensaje2 = "\n\tCompra realizada.";
        comprar:
        Console.Write("\n\t> Seleccione el Articulo que desea comprar: ");
        int comprar = int.Parse(Console.ReadLine());
          switch(comprar){
          case 1: if(Saldo >= 30){Saldo -= Platanitos; Console.WriteLine(mensaje2); Console.ReadKey(); break;} else{Console.WriteLine(mensaje);
          Console.ReadKey();break;}
          case 2: if(Saldo >= 35){Saldo -= Yuquitas; Console.WriteLine(mensaje2); Console.ReadKey(); break;} else{Console.WriteLine(mensaje);
          Console.ReadKey();break;}
          case 3: if(Saldo >= 60){Saldo -= MyM; Console.WriteLine(mensaje2); Console.ReadKey(); break;} else{Console.WriteLine(mensaje);
          Console.ReadKey();break;}
          case 4: if(Saldo >= 25){Saldo -= MasMas; Console.WriteLine(mensaje2); Console.ReadKey(); break;} else{Console.WriteLine(mensaje);
          Console.ReadKey();break;}
          default: Console.WriteLine("\n\tIntroduce la opcion correcta.");
          Console.ReadKey();
          Console.Clear();
          MostrarMenu();
          goto comprar;
       }

    }

    public bool encendidoApagado(){
       string hoys = "";
       DateTime hoy = DateTime.Now;
       this.hora = hoy.ToShortTimeString();

       for(int i = 0; i < this.hora.Length; i++){
        if(this.hora[i] > 64 && this.hora[i] < 91){hoys += this.hora[i];}
       }

       if(hoys == "AM"){
          this.Off_On = true;
          this.Saldo += 35;
       }
       else if(hoys == "PM"){
          this.Off_On = false;
          Console.WriteLine("\n\tLa maquina esta apagada.");
          Console.ReadKey();
       }
       return this.Off_On;
    }
     
        //Metodo Destructor (Opcional ya que el propio sistema se encarga de destruir estos objetos basura)
        ~VendingMachine(){}

}

//Clase que ejecuta el programa
class TesterClass{

    static void Main(String[] args){
        
        VendingMachine SNACKWELL = new VendingMachine(); //Creando el Objeto

        //Menu de opciones
        SNACKWELL.encendidoApagado();
        Refrescar:
        SNACKWELL.MostrarMenu();
        Console.WriteLine("\n\tQue deseas realizar ?");
        Console.WriteLine("\n\t1.Depositar Monedas");
        Console.WriteLine("\t2.Comprar Articulo");
        char opcion = Console.ReadKey(true).KeyChar;
        switch(opcion){
             case '1': SNACKWELL.IntroducirMonedas(); Console.Clear(); goto Refrescar;
             case '2': SNACKWELL.ComprarArticulo(); Console.Clear(); goto Refrescar;
             default: Console.WriteLine("\n\tIntroduce la opcion correcta.");
             Console.ReadKey();
             Console.Clear();
             goto Refrescar;
        }

    }


}