List<Aluno> turma1I3 = new();

turma1I3.Add(new Aluno (){ rm= 1, nome= "Aurora"});
// Console.WriteLine(turma1I3.Count);
// Console.WriteLine(turma1I3.ElementAt(0).nome);
turma1I3.Add(new Aluno (){ rm= 2, nome= "Julia"});
turma1I3.Add(new Aluno (){ rm= 3, nome= "Bianca"});

Console.WriteLine(turma1I3.Count);

foreach (var aluno in turma1I3)
{
    Console.WriteLine($"Nº {aluno.rm} - {aluno.nome}");
}