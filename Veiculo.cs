public class Veiculo{
  public string Cor{get; protected set;}
  public string Marca{get; protected set;}
  public string Modelo{get; protected set;}
  public double Valor{get; protected set;}
  public int AnoFabri{get; protected set;}

  public Veiculo(string c, string m, string mod, double v, int ano){
    Cor = c;
    Marca = m;
    Modelo = mod;
    Valor = v;
    AnoFabri = ano;
  } 

  public Veiculo(string c, string m, string mod, int ano){
    Cor = c;
    Marca = m;
    Modelo = mod;
    AnoFabri = ano;
  }

  public Veiculo(string c, string m, string mod, double valor){
    Cor = c;
    Marca = m;
    Modelo = mod;
    Valor = valor;
  }

  public virtual void definirValorVeiculo(double CustoFixo){
  
  }

} 
