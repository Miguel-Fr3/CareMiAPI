﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CareMIAPI.Models
{
    [Table("t_paciente")]
    public class Paciente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CdPaciente { get; set; }

        [Required]
        [StringLength(100)]
        public string NmPaciente { get; set; }

        [Column(TypeName = "NUMBER(6)")]
        public decimal NrPeso { get; set; }

        [Column(TypeName = "NUMBER(4)")]
        public decimal NrAltura { get; set; }

        [StringLength(6)]
        public string NmGrupoSanguineo { get; set; }

        [Column(TypeName = "CHAR(1)")]
        public char FlSexoBiologico { get; set; }

        public int UsuarioCdUsuario { get; set; }

        [ForeignKey("UsuarioCdUsuario")]
        public Usuario Usuario { get; set; } 


        public Paciente()
        {
        }


        public Paciente(int cdPaciente, string nmPaciente, decimal nrPeso, decimal nrAltura, string nmGrupoSanguineo, char flSexoBiologico, int usuarioCdUsuario)
        {
            CdPaciente = cdPaciente;
            NmPaciente = nmPaciente;
            NrPeso = nrPeso;
            NrAltura = nrAltura;
            NmGrupoSanguineo = nmGrupoSanguineo;
            FlSexoBiologico = flSexoBiologico;
            UsuarioCdUsuario = usuarioCdUsuario;
        }
    }
}