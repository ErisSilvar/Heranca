using System;

public class Paciente : PessoaFisica{
    public UInt64 Cns { get; set; }

  public override String ToString(){
    return "\n\nNome: " + Nome + "\nEmail: " + Email + "\nCpf: " + Cpf + "\nSexo: " + Sexo.Feminino + "\nCns: " + Cns;
    
  }
}