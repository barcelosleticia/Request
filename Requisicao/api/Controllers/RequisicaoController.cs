using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.IO;

namespace api.Controllers
{
    [Route("api/[controller]")]
    public class RequisicaoController : Controller
    {
        public class Requisicao
        {
            public string id {get; set;}
            public string name {get; set;}
        }
    }
}
