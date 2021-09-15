using System.Collections.Generic;

class Concessionaria{
  
  private string Localizacao;
  public void setLocalizacao(string local){
    Localizacao = local;
  }
  public string getLocalizacao(){
    return Localizacao;
  }

  private string GerentePrincipal;
  public void setGerente(string gp){
    GerentePrincipal = gp;
  }
  public string getGerente(){
    return GerentePrincipal;
  }

  private int AnoFundacao;
  public void setAno(int a){
    AnoFundacao = a;
  }
  public int getAno(){
    return AnoFundacao;
  }

  public List<Veiculo> CarrosDisponiveis = new List<Veiculo>();

  public Concessionaria(string l, string gp, int ano){
    Localizacao  = l;
    GerentePrincipal = gp;
    AnoFundacao = ano;
		CarrosDisponiveis = new List<Veiculo>();
  }

  public void AdicionarCarro(Veiculo carro){
    CarrosDisponiveis.Add(carro);
  }

  public void CalcularPortifolio(){
    double soma = 0;
    for (int i = 0; i < CarrosDisponiveis.Count; i++){
      soma += CarrosDisponiveis[i].Valor;
    }
  }
}