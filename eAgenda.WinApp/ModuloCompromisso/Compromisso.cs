using eAgenda.ConsoleApp.Compartilhado;
using eAgenda.WinApp.ModuloContato;
//////using System;
//////using System.Collections.Generic;
//////using System.Linq;
//////using System.Text;
//////using System.Threading.Tasks;
//////using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
//////using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace eAgenda.WinApp.ModuloCompromisso
{
    public class Compromisso : EntidadeBase
    {
        public string Assunto { get; set; }
        public string Local { get; set; }
        public DateTime InicioCompromisso { get; set; }
        public DateTime TerminoCompromisso { get; set; }
        public string CompromissoDia { get; set; }
        public string CompromissoSemana { get; set; }

        public Compromisso(string assunto, string local, string v, DateTime inicioCompromisso, DateTime terminoCompromisso, string compromissoDia, string compromissoSemana)
        {
            Assunto = assunto;
            Local = local;
            InicioCompromisso = inicioCompromisso;
            TerminoCompromisso = terminoCompromisso;
            CompromissoDia = compromissoDia;
            CompromissoSemana = compromissoSemana;
        }

        public Compromisso()
        {
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Assunto.Trim()))
                erros.Add("O campo \"assunto\" é obrigatório");

            if (string.IsNullOrEmpty(Local.Trim()))
                erros.Add("O campo \"local\" é obrigatório");

            if (InicioCompromisso == null)
                erros.Add("O campo \"Início do Compromisso\" é obrigatório");
            return erros;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Compromisso atualizado = (Compromisso)novoRegistro;

            Assunto = atualizado.Assunto;
            Local = atualizado.Local;
            InicioCompromisso = atualizado.InicioCompromisso;
            TerminoCompromisso = atualizado.TerminoCompromisso;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Assunto: {Assunto}, Local: {Local}, Início do Compromisso: {InicioCompromisso} Término do Compromisso: {TerminoCompromisso}";
        }

        public static implicit operator Compromisso(TelaCompromissoForm v)
        {
            throw new NotImplementedException();
        }
    }
}
