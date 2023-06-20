using System;

public class PessoaJuridica : Pessoa{
  public UInt64 Cnpj { get; set; }

  public override String ToString(){
    return "Nome: " + Nome + "\nEmail: " + Email + "\nCnpj: " + Cnpj;
  }
}