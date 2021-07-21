using System;
using System.ComponentModel.DataAnnotations;

namespace aluraflix_api.Models
{
    public class Video
    {
        //id
        //

        // o titulo do youtube aceita no maximo 100 caracteres
        [Required(ErrorMessage = "O campo título é obrigatório.")]
        [StringLength(100, ErrorMessage = "O campo título não pode ter mais que 100 caracteres.")]
        public string titulo { get; set; }

        // o campo descricao do youtube aceita no maximo 5000 caracteres
        [StringLength(5000, ErrorMessage = "O campo descrição não pode ter mais que 5000 caracteres.")]
        public string descricao { get; set; }

        // o campo URL do navegador aceita no maximo 2083 caracteres
        [Required(ErrorMessage = "O campo da url é obrigatório.")]
        [StringLength(2000, ErrorMessage = "O campo da url não pode ultrapassar de 2000 caracteres.")]
        public string url { get; set; }
    }
}
