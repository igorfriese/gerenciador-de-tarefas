using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorDeTarefas
{
    internal class Tarefa
    {
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public bool Concluida { get; set; }

        public Tarefa(string titulo, string descricao)
        {
            Titulo = titulo;
            Descricao = descricao;
            DataInicio = DateTime.Now;
            Concluida = false;
        }

        public void Concluir()
        {
            Concluida = true;
        }

        public override string ToString()
        {
            string status = (Concluida) ? "Sim" : "Não";

            return $"Título da tarefa: {Titulo}\nDescrição: {Descricao}\nHorário de início: {DataInicio}\nConcluída: {status}";
        }
    }
}
