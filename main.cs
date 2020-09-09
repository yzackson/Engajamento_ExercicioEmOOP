using System;

class MainClass {

  public static void Main () {
    pessoa isaac = new pessoa();

    isaac.dados("Isaac", 15, 76.0, 187.0);

    isaac.mostrarDados();
    Console.ReadKey();

    isaac.envelhecer(20);
    isaac.engordar(80);
    isaac.mostrarDados();
    Console.ReadKey();

    isaac.emagrecer(70);
    isaac.crescer(190);
    isaac.mostrarDados();
    Console.ReadKey();
  }

}