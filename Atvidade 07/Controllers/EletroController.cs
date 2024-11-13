using Eletrodomesticos.Models;
using Microsoft.AspNetCore.Mvc;

namespace Atvidade_07.Controllers
{
    public class EletroController : Controller
    {
        public IActionResult Index()
        {
            List<Eletrodomestico> eletro = new List<Eletrodomestico>
            {
                new Geladeira {Marca = "Eletrolux", Modelo = "Frefrost", CapacidadeLitros = 450, ConsumoEnergetico = 47.9 , TemFreezer = true},
                new Geladeira {Marca = "Eletrolux", Modelo = "Frefrost", CapacidadeLitros = 450, ConsumoEnergetico = 47.9 , TemFreezer = false},
                new Televisor {Marca = "Samsung", Modelo = "Crystal 4k", TamanhoTela = 55, ConsumoEnergetico = 110 , EhSmart = true}

            };
            return View(eletro);
        }
    }
}
