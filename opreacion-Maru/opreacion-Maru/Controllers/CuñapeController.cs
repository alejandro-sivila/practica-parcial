using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace opreacion_Maru.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CuñapeController : ControllerBase
    {
       [HttpGet]
       public string arepa(int numerito) 
        {
            string frase = "";
            if (numerito == 0) 
            { 
                frase = "uwu"; 
            }
            if (numerito > 0) 
            { 
                frase = "owo"; 
            }
            if (numerito < 0) 
            { 
                frase = "unu"; 
            }
            return frase;
        }
    }
}
