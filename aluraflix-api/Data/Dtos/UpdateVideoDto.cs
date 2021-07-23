using System;
using System.ComponentModel.DataAnnotations;

namespace aluraflix_api.Data.Dtos
{
    public class UpdateVideoDto
    {
        [StringLength(100, ErrorMessage = "O campo título não pode ter mais que 100 caracteres.")]
        public string titulo { get; set; }

        [Required(ErrorMessage = "O campo descrição é obrigatório.")]
        [StringLength(5000, ErrorMessage = "O campo descrição não pode ter mais que 5000 caracteres.")]
        public string descricao { get; set; }

        [Required(ErrorMessage = "O campo da url é obrigatório.")]
        [StringLength(2000, ErrorMessage = "O campo da url não pode ultrapassar de 2000 caracteres.")]
        public string url { get; set; }
    }
}
