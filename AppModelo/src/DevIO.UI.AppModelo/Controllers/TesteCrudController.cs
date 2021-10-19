using DevIO.UI.AppModelo.Data;
using DevIO.UI.AppModelo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.UI.AppModelo.Controllers
{
    public class TesteCrudController : Controller
    {
        private readonly MeuDbContext _context;

        public TesteCrudController(MeuDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var aluno = new Aluno
            { 
                Nome = "Luis",
                DataNascimento = DateTime.Now,
                Email = "luis@outlook.com.br"
            };

            _context.Alunos.Add(aluno);
            _context.SaveChanges();

            //var aluno2 = _context.Alunos.Find(aluno.Id);
            //var aluno3 = _context.Alunos.FirstOrDefault(a => a.Email == "luis@outlook.com.br");
            //var aluno4 = _context.Alunos.Where(a => a.Nome == "luis");

            //aluno.Nome = "João";
            //_context.Alunos.Update(aluno);
            //_context.SaveChanges();

            ////Remove é feito sempre com a entidade do aluno
            //_context.Alunos.Remove(aluno);
            //_context.SaveChanges();

            return View();
        }
    }
}
