public class Nacional:Veiculo{

  public Nacional(string c, string m, string mod, double v, int ano):base(c,  m,  mod,  v,  ano){}

  public override void definirValorVeiculo(double CustoFixo){
    Valor = CustoFixo *1.5 + 0.2*CustoFixo + CustoFixo/10;
  }
  
}
