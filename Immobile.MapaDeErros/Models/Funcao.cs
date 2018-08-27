namespace Immobile.MapaDeErros.Models
{
    using System;
    using Immobile.MapaDeErros.Enums;
    public class Funcao
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public StatusFuncaoEnum Status { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataAtivacao { get; set; }
        public DateTime? DataDesativacao { get; set; }
    }
}