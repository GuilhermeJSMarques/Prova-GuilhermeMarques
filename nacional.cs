using System;

class Nacional:Veiculo{
  
  public Nacional(string cor, string marca, string modelo, int ano):base(cor, marca, modelo, ano){

  }
  
  public override void definirValorVeiculo(double CustoFixo){
    this.valor = (CustoFixo *1.5) + (0.2*CustoFixo) + (CustoFixo/10);
  }
}
