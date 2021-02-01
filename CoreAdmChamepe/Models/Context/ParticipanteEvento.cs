namespace CoreAdmChamepe.Models.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class ParticipanteEvento
    {        
        public int ParticipanteEventoId { get; set; }
        [Display(Name ="Nome Completo")]
        public string PartcipanteNomeCompleto { get; set; }
        [Display(Name = "Rg")]
        public string ParticipanteRg { get; set; }
        [Display(Name = "Email")]
        public string ParticipanteEmail { get; set; }
        [Display(Name = "Nº Telefone")]
        public string ParticipanteTelefone { get; set; }

        [Display(Name = "Idade")]
        public int ParticipanteIdade { get; set; }
        [Display(Name = "Igreja")]
        public int IgrejaId { get; set; }
        [Display(Name = "Evento")]
        public int EventoId { get; set; }
        [Display(Name = "Usuário")]
        public string UserId { get; set; }

        public virtual Evento Evento { get; set; }
        public virtual Igreja Igreja { get; set; }
    }
}
