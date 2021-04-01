using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_class
{
    class Aluno
    {
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public string Senha { private get; set; }
        public string Curso { get; set; }
        public string Disciplina { get; set; }

        public double Nota = 0;
        private double Media = 0;

        public Aluno(double media)
        {
            Media = media;
        }

        public void InserirNota(double nota)
        {
            Nota = Nota + nota;
        }

        public double CalcularNotaFinal()
        {
            int provas = 4;
            double notaFinal = Nota / 4;
            return Media + notaFinal;
        }

        public void ImprimirMedia()
        {
            Console.WriteLine($"{Nome}, sua média para a disciplina '{Disciplina}' do curso '{Curso}' é {CalcularNotaFinal()}");
        }
    }
}
