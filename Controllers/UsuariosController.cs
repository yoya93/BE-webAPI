using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entidades;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("v1/api/usuarios")]
    public class UsuariosController : ControllerBase
    {

        [HttpGet]
        public ActionResult<List<Usuario>> Get()
        {
            return new List<Usuario>()
            {
                new Usuario() {id =1 , nombre = "Jorge" },
                new Usuario() {id =2 , nombre = "Juan"},
                new Usuario() {id =3 , nombre = "Julian"}
            };
        }
    }
}
