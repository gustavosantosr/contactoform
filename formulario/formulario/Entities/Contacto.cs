using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace formulario.Entities
{
    public class Contacto
    {

            public int Id { get; set; }
            public string nombre { get; set; }
            [Required]
            public string email { get; set; }
            public string mensaje { get; set; }
            [Required]
            public int documento { get; set; }
            [Required]
            public int TipoDocumentoID { get; set; }
            public TipoDocumento TipoDocumento { get; set; }



    }
}
