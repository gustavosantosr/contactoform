using System;
using System.Collections.Generic;
using System.Linq;
using formulario.Context;
using formulario.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace formulario.Controllers
{
    //controlador Endpoint de servicio para contacto
    [Route("api/[controller]")]
    [ApiController]
    public class ContactosController:ControllerBase
    {
        private readonly AplicationDbContext context;

        public ContactosController(AplicationDbContext context)
        {
            this.context = context;
        }

        //metodo get del servicio, lista los elementos de contactos
        [HttpGet]
        public ActionResult<IEnumerable<Contacto>> Get()
        {
            return context.Contactos.Include(x=>x.TipoDocumento).ToList();
        }
        //metodo get del servicio, retorna el elemento filtrado por el Id de Contacto
        [HttpGet("{id}",Name ="ObtenerContacto")]
        public ActionResult<Contacto> Get(int id)
        {
            var contacto = context.Contactos.FirstOrDefault(x => x.Id == id);
            if (contacto == null)
            {
                return NotFound();
            }
            return contacto;
        }
        //metodo post del servicio agrega elementos suministrados por la vista
        [HttpPost]
        public ActionResult Post([FromBody] Contacto contacto)
        {
            context.Contactos.Add(contacto);
            context.SaveChanges();
            return new CreatedAtRouteResult("ObtenerContacto", new { contacto.Id }, contacto);
        }
        // metodo put del servicio, actualiza informacion basado en el Id
        [HttpPut]
        public ActionResult Put(int id,[FromBody] Contacto value)
        {
            if (id != value.Id)
            {
                return BadRequest();
            }
            context.Entry(value).State= EntityState.Modified;
            context.SaveChanges();
            return Ok();
        }
        //metodo Delete, borra registros basados en el Id
        [HttpDelete("{id}")]
        public ActionResult<Contacto> Delete(int id)
        {
            var contacto = context.Contactos.FirstOrDefault(x => x.Id == id);
            if (contacto == null)
            {
                return NotFound();
            }
            context.Contactos.Remove(contacto);
            context.SaveChanges();
            return contacto;
        }
    }
}
