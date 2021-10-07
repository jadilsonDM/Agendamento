using Agendamento.Models;
using Application.InputModel;
using Application.Serviços.Interface;
using Application.ViewModel;
using Core.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Agendamento.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPacienteServico _pacienteServico;
        private readonly IGenericoServico<Exame> _genericoServicoExame;
        private readonly IGenericoServico<TipoDeExame> _genericoServicoTipoExame;
        public HomeController(IPacienteServico pacienteServico, IGenericoServico<Exame> genericoServicoExame, IGenericoServico<TipoDeExame> genericoServicoTipoExame)
        {
            _pacienteServico = pacienteServico;
            _genericoServicoExame = genericoServicoExame;
            _genericoServicoTipoExame = genericoServicoTipoExame;
        }

        public IActionResult Index(string searchString)
        {
            if (!String.IsNullOrEmpty(searchString))
            {
                var pacientes = PacienteViews().Where(p => p.Nome.Contains(searchString) || p.CPF == searchString);
                return View(pacientes);
            }
            return View(PacienteViews());
        }

        [HttpGet]
        public ActionResult Consulta(int idPaciente)
        {
            ObterExamePorTipoExame(null);
            PopularTipoExames();
            var consulta = new ConsultaInputModel
            {
                DataDaConsulta = DateTime.Now,
                Exame = null,
                TipoDeExame = null,
                Paciente = _pacienteServico.ObterUm(idPaciente)
            };

            return View(consulta);
        }
        
        public ActionResult ObterExamePorTipoExame(int? idTipoExame)
        {
            var exame = new List<Exame>();
            if (idTipoExame != null)
            {
                 exame = _genericoServicoExame.ObterTodos().Where(e => e.IdTipoExame == idTipoExame).ToList();

                ViewBag.Exame = exame.Select(s => new SelectListItem
                {
                    Value = s.Id.ToString(),
                    Text = s.NomeDoExame
                }).ToList(); 
            }
            else
            {
                ViewBag.Exame = new List<SelectListItem>();
            }

            var json = Json(exame);
            return json;

        }

      
        private List<PacienteViewModel> PacienteViews()
        {
            var pacienteViewModels = new List<PacienteViewModel>();

            var pacientes = _pacienteServico.ObterTodos();

            foreach (var item in pacientes)
            {
                pacienteViewModels.Add(new PacienteViewModel(item.Id, item.Nome, item.CPF, item.DataNascimento, item.Telefone, item.Email, item.Sexo));
            }

            return pacienteViewModels;
        }
        private void PopularTipoExames()
        {
            var tiposExames = _genericoServicoTipoExame.ObterTodos().Select(te => new SelectListItem
            {
                Value = te.Id.ToString(),
                Text = te.NomeDoTipo
            }).ToList();
            ViewBag.TiposExame = tiposExames;
        }
    }
}
