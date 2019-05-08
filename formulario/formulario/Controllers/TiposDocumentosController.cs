using System;
using System.Collections.Generic;
using System.Linq;
using formulario.Context;
using formulario.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace formulario.Controllers

{

    [Route("api/[controller]")]
    [ApiController]
    public class TiposDocumentosController : ControllerBase
    {
        public readonly AplicationDbContext context;
        public TiposDocumentosController(AplicationDbContext context)
        {
            this.context = context;
        }
       
        [HttpGet]
        public ActionResult<IEnumerable<TipoDocumento>> Get()
        {
            return context.TiposDocumentos.ToList();
        }

    }
}
