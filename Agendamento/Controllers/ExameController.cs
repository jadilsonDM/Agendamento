using Application.InputModel;
using Application.Serviços.Interface;
using Application.ViewModel;
using Core.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agendamento.Controllers
{
    public class ExameController : Controller
    {
        private readonly IGenericoServico<Exame> _genericoServicoExame;
        private readonly IGenericoServico<TipoDeExame> _genericoServicoTipoExame;

        public ExameController(IGenericoServico<Exame> genericoServicoExame, IGenericoServico<TipoDeExame> genericoServicoTipoExame)
        {
            _genericoServicoExame = genericoServicoExame;
            _genericoServicoTipoExame = genericoServicoTipoExame;
        }
        // GET: ExameController
        public ActionResult Index()
        {
            var exames = _genericoServicoExame.ObterTodos();
            var examesViewModel = new List<ExameViewModel>();
            foreach (var item in exames)
            {
                examesViewModel.Add(new ExameViewModel(item.Id, item.NomeDoExame, item.Observacao, item.IdTipoExame, _genericoServicoTipoExame.ObterUm(item.IdTipoExame)));
            }
            return View(examesViewModel);
        }

        // GET: ExameController/Details/5
        public ActionResult Details(int id)
        {
            return View();
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

        // GET: ExameController/Create
        public ActionResult Create()
        {
            PopularTipoExames();
            return View();
        }

        // POST: ExameController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm] ExameInputModel exameInputModel)
        {

            if (ModelState.IsValid)
            {
                var exame = new Exame(exameInputModel.Id, exameInputModel.NomeDoExame, exameInputModel.Observacao, exameInputModel.IdTipoExame);
                _genericoServicoExame.Cadastro(exame);

                return RedirectToAction(nameof(Index));
            }
            PopularTipoExames();

            return View("Create");

        }

        // GET: ExameController/Edit/5
        public ActionResult Edit(int id)
        {
            PopularTipoExames();
            var exame = _genericoServicoExame.ObterUm(id);

            var exameInputModel = new ExameInputModel {
                Id= exame.Id,
                NomeDoExame= exame.NomeDoExame,
                Observacao = exame.Observacao,
                IdTipoExame = exame.IdTipoExame 
            };
            
            return View(exameInputModel);
        }

        // POST: ExameController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ExameInputModel  inputModel)
        {
            PopularTipoExames();
            try
            {
                if (ModelState.IsValid)
                {
                    var exame = new Exame(inputModel.Id, inputModel.NomeDoExame, inputModel.Observacao, inputModel.IdTipoExame);
                    _genericoServicoExame.Atualizar(id, exame);
                    return RedirectToAction(nameof(Index)); 
                }
                else
                {
                    return View("Edit");
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: ExameController/Delete/5
        public ActionResult Delete(int id)
        {
            var exame = _genericoServicoExame.ObterUm(id);
            var exameViewModel = new ExameViewModel(exame.Id, exame.NomeDoExame, exame.Observacao, exame.IdTipoExame, exame.TipoDeExame);
            return View(exameViewModel);
        }

        // POST: ExameController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                _genericoServicoExame.Deletar(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
