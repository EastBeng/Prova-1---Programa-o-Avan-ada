using System;

class Program {
  public static void Main (string[] args) {
    Importado Carro1 = new Importado("Preto", "Ford", "Fusion", 75000, 2010);
    Nacional Carro2 = new Nacional("Vermelho", "Ferrari", "Italia", 5000000, 2017);

    Carro1.definirValorVeiculo(100000);
    Carro2.definirValorVeiculo(2000000);

    Concessionaria UCL = new Concessionaria("Serra", "Marlon Ferrari", 2020);
    UCL.AdicionarCarro(Carro1);
    UCL.AdicionarCarro(Carro2);
    Console.WriteLine("Soma do Portifolio >> "+ UCL.CalcularPortifolio());
  }
  
}