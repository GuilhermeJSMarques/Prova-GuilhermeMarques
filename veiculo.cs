using System;

class Veiculo{
//ATRIBUTO
  public string cor{get; private set;}
  public string marca{get; private set;}
  public string modelo{get; private set;}
  public double valor{get; protected set;}
  public int ano{get; private set;}

  //CONTRUTORES
  public Veiculo(string cor, string marca, string modelo, int ano){
    this.cor = cor;
    this.marca = marca;
    this.modelo = modelo;
    this.ano = ano;  
    valor = 0; //setando
  }

  //METODOS
  public virtual void definirValorVeiculo(double CustoFixo){
    valor = CustoFixo;
  }
}
