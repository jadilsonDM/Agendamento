using Agendamento.Models;
using Application.InputModel;
using Application.Serviços.Interface;
using Application.ViewModel;
using Core.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Agendamento.Controllers
{
    public class PacienteController : Controller
    {
        private readonly IPacienteServico _pacienteServico;

        public PacienteController(IPacienteServico pacienteServico)
        {
            _pacienteServico = pacienteServico;
        }
        // GET: PacienteController
        public ActionResult Index()
        {
            var pacienteViewModels = new List<PacienteViewModel>();

            var pacientes = _pacienteServico.ObterTodos();

            foreach (var item in pacientes)
            {
                pacienteViewModels.Add(new PacienteViewModel(item.Id, item.Nome, item.CPF, item.DataNascimento, item.Telefone, item.Email, item.Sexo));
            }

            return View(pacienteViewModels);
        }

        // GET: PacienteController/Details/5
        public ActionResult Details(int id)
        {

            var paciente = _pacienteServico.ObterUm(id);

            var pacienteInputModel = new PacienteInputModel
            {
                Nome = paciente.Nome,
                CPF = paciente.CPF,
                DataNscimento = paciente.DataNascimento,
                Telefone = paciente.Telefone,
                Email = paciente.Email,


            };

            return View(pacienteInputModel);
        }

        // GET: PacienteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PacienteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PacienteInputModel model)
        {
            if (ModelState.IsValid)
            {
                var paciente = new Paciente(model.Id, model.Nome, model.CPF, model.DataNscimento, model.Telefone, model.Email, model.Sexo);
                _pacienteServico.Cadastro(paciente); 
                return RedirectToAction(nameof(Index));
            }


            return View();
        }

        // GET: PacienteController/Edit/5
        public ActionResult Edit(int id)
        {


            var paciente = _pacienteServico.ObterUm(id);

            var pacienteInputModel = new PacienteInputModel
            {
                Nome = paciente.Nome,
                CPF = paciente.CPF,
                DataNscimento = paciente.DataNascimento,
                Telefone = paciente.Telefone,
                Email = paciente.Email,

            };
           
            return View(pacienteInputModel);
        }

        // POST: PacienteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, PacienteInputModel pacienteimput)
        {
            try
            {
                var paciente = new Paciente(pacienteimput.Id, pacienteimput.Nome, pacienteimput.CPF, pacienteimput.DataNscimento, pacienteimput.Telefone, pacienteimput.Email, pacienteimput.Sexo); 

                _pacienteServico.Atualizar(id, paciente);
                
                
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PacienteController/Delete/5
        public ActionResult Delete(int id)
        {
            var paciente = _pacienteServico.ObterUm(id);

            var pacienteInputModel = new PacienteInputModel
            {
                Nome = paciente.Nome,
                CPF = paciente.CPF,
                DataNscimento = paciente.DataNascimento,
                Telefone = paciente.Telefone,
                Email = paciente.Email,

            };

            return View(pacienteInputModel);
        }

        // POST: PacienteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {

                _pacienteServico.Deletar(id);
                
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
