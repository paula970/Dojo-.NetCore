
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DojoNetCore.Modelo;
using Microsoft.AspNetCore.Mvc;
 //clase controller donde se definirá los metodos http de la API
namespace DojoNetCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        FirebaseAccount Instancia = FirebaseAccount.Instancia;
        [HttpGet]
        public async Task<List<Usuario>> Get(){
            FirebaseAccount Instancia =FirebaseAccount.Instancia;
            return await Instancia.GetUser();
        }

        [HttpPost]

        public async Task<String> Post(Usuario user){
            return await Instancia.AddUser(user);
        }

        [HttpDelete]

        public async Task<String> Delete([FromQuery]String id){
            return await Instancia.DeleteUser(id);
        }
    }
}