using System;

public class Enfermeiro : PessoaFisica{
  public UInt32 Corean { get; set; }

  public override String ToString(){
    return "\n\nNome: " + Nome + "\nEmail: " + Email + "\nCpf: " + Cpf + "\nSexo: " + Sexo.Masculino + "\nCorean: " + Corean;
}
  }