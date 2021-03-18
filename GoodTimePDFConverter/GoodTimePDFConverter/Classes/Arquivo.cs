using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodTimePDFConverter.Classes
{
    public class Arquivo
    {
        public Arquivo(string nome, string tipo, string status, string mensagem)
        {
            this.SetNome(nome);
            this.SetTipo(tipo);
            this.SetStatus(status);
            this.SetMensagem(mensagem);
        }
        private string nome, status, mensagem, tipo;

        //Getters
        public string GetNome() { return this.nome; }
        public string GetStatus() { return this.status; }
        public string GetMensagem() { return this.mensagem; }
        public string GetTipo() { return this.tipo; }


        //Setters
        public void SetNome(string value) { this.nome = value; }
        public void SetStatus(string value) { this.status= value; }
        public void SetMensagem(string value) { this.mensagem = value; }
        public void SetTipo(string value) { this.tipo = value; }

    }
}
