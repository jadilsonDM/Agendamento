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
                pacienteViewModels.Add(new PacienteViewModel(item.Id, item.Nome, item.CPF, item.DataNscimento, item.Telefone, item.Email, item.Sexo));
            }

            return View(pacienteViewModels);
        }

        // GET: PacienteController/Details/5
        public ActionResult Details(int id)
        {
            return View();
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
            try
            {
                var paciente = new Paciente(model.Id, model.Nome, model.CPF, model.DataNscimento, model.Telefone, model.Email);
                _pacienteServico.Cadastro(paciente);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PacienteController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PacienteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, PacienteInputModel pacienteimput)
        {
            try
            {
                var paciente = new Paciente(pacienteimput.Id, pacienteimput.Nome, pacienteimput.CPF, pacienteimput.DataNscimento, pacienteimput.Telefone, pacienteimput.Email); 

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
            return View();
        }

        // POST: PacienteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
