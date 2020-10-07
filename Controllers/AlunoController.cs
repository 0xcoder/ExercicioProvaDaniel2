using DanielProva02Exercicio.Context;
using DanielProva02Exercicio.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DanielProva02Exercicio.Controllers
{
    public class AlunoController : Controller
    {
        private readonly Contexto db = new Contexto();

        // GET: Aluno
        public ActionResult Index()
        {
            return View(db.alunos.ToList());
        }

        public ActionResult Create() 
        {
            return View();  
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AlunoModel alunoModel)
        {
            if (ModelState.IsValid)
            {
                db.alunos.Add(alunoModel);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(alunoModel);
        }


        public ActionResult Details(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }

            AlunoModel alunoModel = db.alunos.Find(id);

            if (alunoModel == null) 
            {
                HttpNotFound();
            }
            return View(alunoModel);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }

            AlunoModel alunoModel = db.alunos.Find(id);

            if (alunoModel == null)
            {
                HttpNotFound();
            }
            return View(alunoModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(AlunoModel alunoModel) 
        {
            if (ModelState.IsValid)
            {
                db.Entry(alunoModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(alunoModel);
        }

        public ActionResult Delete(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }

            AlunoModel alunoModel = db.alunos.Find(id);

            if(alunoModel == null)
            {
                HttpNotFound();
            }

            db.alunos.Remove(alunoModel);
            db.SaveChanges();
            return RedirectToAction(nameof(Index));

        }

    }
}