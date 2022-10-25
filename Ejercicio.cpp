#include <iostream>
#include <conio2.h>
#include <stdlib.h>
#include <string>

using namespace std;

void Polindromos();
void BuscarPatron();
void CadenaReal();
void ConcatenarCadena();

#define TITULO "MENU PRACTICA TEMA 5 (CADENAS)"

int main(){

   volver:
   string opcion;
   cout<<"\n\t"<<TITULO
       <<"\n\t==========================="
       <<"\n\tA.Palindromos."
       <<"\n\tB.Busca Patron."
       <<"\n\tC.Cadena a Real."
       <<"\n\tD.Concatenar Cadenas."
       <<"\n\tX.Salir del Programa."
       <<"\n\n\tIntroduzca Opcion: ";

       getline(cin, opcion);

   switch(opcion){
     case 'A': Polindromos(); break;
     case 'B': BuscarPatron(); break;
     case 'C': CadenaReal(); break;
     case 'D': ConcatenarCadena(); break;
     case 'X': break;
         default: cout<<"\n\n\tOpcion incorrecta, vuelva a intentarlo."<<endl;
         getch;
         goto volver;
   }

  getch();
  return 0;
}


void Polindromos(){
   cout<<"Hola mundo";
}

void BuscarPatron(){


}

void CadenaReal(){


}

void ConcatenarCadena(){


}
