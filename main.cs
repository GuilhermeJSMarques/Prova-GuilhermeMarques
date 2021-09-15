using System;

class Program {
  public static void Main (string[] args) {
    Concessionaria ford;
    ford = new Concessionaria("Jacaraípe","Guilherme",2021);
    
    Veiculo carro1;
    carro1 = new Veiculo("Preto", "Ford", "KA", 2018);
    carro1.definirValorVeiculo(32050);
    
    Importado carro2;
    carro2 = new Importado("Azul", "Ford", "Focus", 2016);
    carro2.definirValorVeiculo(22504);

    Nacional carro3;
    carro3 = new Nacional("Branco", "Ford", "Fox", 2007);
    carro3.definirValorVeiculo(10500);

    ford.AdicionarCarro(carro1);
    ford.AdicionarCarro(carro2);
    ford.AdicionarCarro(carro3);

    Console.WriteLine("Valor total da Concessionaria: "+ ford.CalcularPortfolio());
  }
}