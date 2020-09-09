using System;

class pessoa {
  private string nome; //apenas primeiro nome
  private int idade; //em anos completos
  private double peso; //peso em kg
  private double altura; //altura em centímetros

  public void dados(string n, int i, double p, double a) { // método para coletar os novos dados
    nome = n;
    idade = i;
    peso = p;
    altura = a;
  }

  public void mostrarDados() { // método para mostrar ao usuário os dados cadastrados
    Console.WriteLine("{0}\n{1}\n{2}\n{3}", nome, idade, peso, altura);
  }

  public void envelhecer(int id){ // id => idade atual
    //a cada ano que a pessoa envelhece ela cresce 0,5cm
    if (((id - idade) > 0) && (id < 21)){
      for (int i = id-idade; i > 0; i--) {
        crescer(0.5); 
      }
    }
    if (idade < id)
      idade = id;
  }

  public void engordar(double eg) { // eg => engordar
    peso = eg;
  }

  public void emagrecer(double em) { // em => emagrecer
    peso = em;
  }

  public void crescer(double al) { // al => altura
    // se a altura for igual a 0,5 fará apenas o incremento para o método de envelhecimento
    if (al == 0.5){
      altura += al;
    } else { // caso o valor seja maior que 0,5 já está fora do limiar do método de envelhecimento, então é uma nova entrada de altura
      altura = al;
    }
  }
}