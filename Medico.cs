using System;

public class Medico : PessoaFisica{
  public UInt32 Crm { get; set; }

  public override String ToString(){
    return "\n\nNome: " + Nome + "\nEmail: " + Email + "\nCpf: " + Cpf + "\nSexo: " + Sexo.Masculino + "\nCrm: " + Crm;
  }
}