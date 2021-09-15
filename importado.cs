using System;

class Importado:Veiculo{

  public Importado(string cor, string marca, string modelo, int ano):base(cor, marca, modelo, ano){

  }
  
  public override void definirValorVeiculo(double CustoFixo){
    this.valor = (CustoFixo *3.0) + (0.6*CustoFixo) + (CustoFixo/5);
  }
}
