using System;

namespace AlbertoZaranzaAnotacoes
{
    public class Nota
    {
        private int id;
        private string titulo;
        private string conteudo;

        public Nota(int id, string titulo, string conteudo){
            this.id = id;
            this.titulo = titulo;
            this.conteudo = conteudo;
        }
    }
}
