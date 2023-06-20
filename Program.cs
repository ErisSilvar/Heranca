using System;

class Program {
  public static void Main (string[] args) {
    
    Paciente p = new Paciente() {Nome = "Joana", Email = "joana@mail.com", Cpf = 4395803, Cns = 34};
    Console.WriteLine(p);

    Medico m = new Medico(){Nome = "Eris", Email = "eris@mail.com", Cpf = 68954, Crm = 54};
    Console.WriteLine(m);

    Enfermeiro e = new Enfermeiro() { Nome = "Joao", Email = "joao@mail.com", Cpf = 989988909, Corean = 23};
    Console.WriteLine(e);

    
  }
}