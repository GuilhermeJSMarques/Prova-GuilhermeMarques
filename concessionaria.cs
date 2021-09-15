using System;
using System.Collections.Generic;

class Concessionaria{ 
//ATRIBUTO
  public string localizacao{get; private set;}
  public string gerente{get; private set;}
  public int ano{get; private set;}
  public List<Veiculo> carrosDisponiveis;

//CONSTRUTOR
  public Concessionaria(string localizacao, string gerente, int ano){
    this.localizacao = localizacao;
    this.gerente = gerente;
    this.ano = ano;  
    carrosDisponiveis = new List<Veiculo>();
  }

//METODOS
  public void AdicionarCarro(Veiculo carro){
    carrosDisponiveis.Add(carro);
  }

  public double CalcularPortfolio(){
    double valorTotal = 0;
    foreach(Veiculo carro in carrosDisponiveis){
      valorTotal += carro.valor;
    }
    return valorTotal;
  }
}