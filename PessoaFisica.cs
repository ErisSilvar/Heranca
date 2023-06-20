using System;

public class PessoaFisica : Pessoa{
  public UInt64 Cpf { get; set;}
  public Sexo sexo { get; set; }

  public override String ToString(){
    return "\n\nNome: " + Nome + "\nEmail: " + Email + "\nCpf: " + Cpf + "\nSexo: " + Sexo.Masculino;
    
  }
}