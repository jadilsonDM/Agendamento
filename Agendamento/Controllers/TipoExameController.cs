using Application.InputModel;
using Application.ViewModel;
using Core.Entity;
using Core.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agendamento.Controllers
{
    public class TipoExameController : Controller
    {

        private readonly IGenericoRepository<TipoDeExame> _genericoRepository;

        public TipoExameController(IGenericoRepository<TipoDeExame> genericoRepository)
        {
            _genericoRepository = genericoRepository;
        }

        // GET: TipoDeExameController
        public ActionResult Index()
        {
            var tipoDeExameViewModel = new List<TipoDeExameViewModel>();

            var tiposDeExame = _genericoRepository.ObterTodos();

            foreach (var item in tiposDeExame)
            {
                tipoDeExameViewModel.Add(new TipoDeExameViewModel(item.Id, item.NomeDoTipo, item.Descricao, item.Exames));
            }

            return View(tipoDeExameViewModel);
        }

        // GET: TipoDeExameController/Details/5
        public ActionResult Details(int id)
        {
            var tipoDeExame = _genericoRepository.ObterUm(id);

            var tipoDeExameinputModel = new TipoDeExameInputModel
            {
                NomeDoTipo = tipoDeExame.NomeDoTipo,
                Descricao = tipoDeExame.Descricao,


            };

            return View(tipoDeExameinputModel);
        }

        // GET: TipoDeExameController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoDeExameController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TipoDeExameInputModel model)
        {
            try
            {
                var tiposDeExame = new TipoDeExame(model.Id, model.NomeDoTipo, model.Descricao);
                _genericoRepository.Cadastro(tiposDeExame);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TipoDeExameController/Edit/5
        public ActionResult Edit(int id)
        {
            var tipoDeExame = _genericoRepository.ObterUm(id);

            var tipodeExameInputModel = new TipoDeExameInputModel
            {
                NomeDoTipo = tipoDeExame.NomeDoTipo,
                Descricao = tipoDeExame.Descricao,

            };
            return View(tipodeExameInputModel);
        }

        // POST: TipoDeExameController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TipoDeExameInputModel tipoDeExameInput)
        {
            try
            {
                var tipoDexame = new TipoDeExame(tipoDeExameInput.Id, tipoDeExameInput.NomeDoTipo, tipoDeExameInput.Descricao);

                _genericoRepository.Atualizar(id, tipoDexame);


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TipoDeExameController/Delete/5
        public ActionResult Delete(int id)
        {
            var tipoDeExame = _genericoRepository.ObterUm(id);

            var tipoDeExameinputModel = new TipoDeExameInputModel
            {
                NomeDoTipo = tipoDeExame.NomeDoTipo,
                Descricao = tipoDeExame.Descricao,


            };

            return View(tipoDeExameinputModel);
        }

        // POST: TipoDeExameController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                _genericoRepository.Deletar(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
