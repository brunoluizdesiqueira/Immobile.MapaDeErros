namespace Immobile.MapaDeErros.Controllers
{
    using System;
    using System.Linq;
    using Immobile.MapaDeErros.Enums;
    using Immobile.MapaDeErros.Models;
    using Immobile.MapaDeErros.Repositories;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;

    public class FuncaoController : Controller
    {
        private readonly FuncaoRepository funcaoRepository;
        
        public FuncaoController(IConfiguration configuration)
        {
            funcaoRepository = new FuncaoRepository(configuration);
        }

        // GET: Tarefas
        public ActionResult Index()
        {
            return View(funcaoRepository.FindAll().ToList());
        }

        // GET: Funcao/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return StatusCode(StatusCodes.Status404NotFound);
            }
            Funcao funcao = funcaoRepository.FindByID(id.Value);
            if (funcao == null)
            {
                return StatusCode(StatusCodes.Status404NotFound);
            }
            return View(funcao);
        }

        // GET: Funcao/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Funcoes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("Id,Nome,Status,DataCriacao,DataAtivacao,DataDesativacao")] Funcao funcao)
        {
            if (ModelState.IsValid)
            {
                funcao.DataCriacao = DateTime.Now;
              

                if (funcao.Status.Equals(StatusFuncaoEnum.Ativa)) {
                    funcao.DataAtivacao = DateTime.Now;
                }                

                if (funcao.Status.Equals(StatusFuncaoEnum.Finalizada)) {
                    funcao.DataDesativacao = DateTime.Now;
                }

                funcaoRepository.Add(funcao);
                return RedirectToAction("Index");
            }

            return View(funcao);
        }

        // GET: Funcoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return StatusCode(StatusCodes.Status400BadRequest);
            }
            Funcao funcao = funcaoRepository.FindByID(id.Value);
            if (funcao == null)
            {
                return StatusCode(StatusCodes.Status404NotFound);
            }
            return View(funcao);
        }

        // POST: Funcoes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind("Id,Nome,Status,DataAtivacao,Datadesativacao")] Funcao funcao)
        {
            if (ModelState.IsValid)
            {
                if (funcao.Status.Equals(StatusFuncaoEnum.Finalizada) && (!funcao.DataDesativacao.HasValue)) {
                    funcao.DataDesativacao = DateTime.Now;
                }

                funcaoRepository.Update(funcao);
                return RedirectToAction("Index");
            }
            return View(funcao);
        }

        // GET: Funcoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return StatusCode(StatusCodes.Status400BadRequest);
            }

            Funcao funcao = funcaoRepository.FindByID(id.Value);

            if (funcao == null)
            {
                return StatusCode(StatusCodes.Status404NotFound);
            }
            return View(funcao);
        }

        // POST: Funcoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            funcaoRepository.Remove(id);
            return RedirectToAction("Index");
        }

    }
}