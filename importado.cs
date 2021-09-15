public class Importado:Veiculo{

  public Importado(string c, string m, string mod, double v, int ano):base(c,  m,  mod,  v,  ano){}

  public override void definirValorVeiculo(double CustoFixo){
    Valor = (CustoFixo * 3.0) + (0.6*CustoFixo) + (CustoFixo/5);
  }

}