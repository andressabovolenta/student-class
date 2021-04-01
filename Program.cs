using System;

namespace student_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno(0);

            aluno.Nome = "Andressa Bovolenta";
            aluno.Matricula = "7513491";
            aluno.Curso = "Tecnologia da Informação";
            aluno.Disciplina = "Programação Orientada a Objetos";
                                 
            aluno.InserirNota(9.4);                        
            aluno.InserirNota(8.6);            
            aluno.InserirNota(9.2);                        
            aluno.InserirNota(7.8);

            aluno.ImprimirMedia();
        }
    }
}
