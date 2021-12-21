using Biblioteca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Biblioteca.DataContext;

namespace Biblioteca.Controllers
{
    public class LivroController : Controller
    {
        // instanciando o Banco de dados 
        private BibliotecaDB db = new BibliotecaDB();
        // GET: Livro
        public ActionResult Index()
        {
            List<Livro> lLivros = new List<Livro>();
            lLivros = db.Livros.ToList();
            return View(lLivros);
        }

        // GET: Livro/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Livro/Create
        public ActionResult Create()
        {
            List<Autor> lAutores = new List<Autor>();
            lAutores = db.Autores.ToList();

            List<Categoria> lCategoria = new List<Categoria>();
            lCategoria = db.Categorias.ToList();


            List<SelectListItem> ListaCategorias = lCategoria.ConvertAll(a =>
            {
                return new SelectListItem()
                {
                    Text = a.Nome,  // texto que vira no dropdown
                    Value = a.Id.ToString(), // valor no dropdown
                    Selected = false //nenhum vira selecionado
                };
            });

            //Aqui estou preenchendo essa varlAutores com valores do banco para listar num dropdown
            List<SelectListItem> listaAutores = lAutores.ConvertAll(a =>
            {
                return new SelectListItem()
                {
                    Text = a.Nome,  // texto que vira no dropdown
                    Value = a.Id.ToString(), // valor no dropdown
                    Selected = false //nenhum vira selecionado
                };
            });
            //Viewbag irá intermediar os dados entre o controler e a view
            @ViewBag.Autores = listaAutores;
            @ViewBag.Categorias = ListaCategorias;

            return View();
        }

        // POST: Livro/Create
        [HttpPost]
        public ActionResult Create(Livro livro)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    //aqui estou dizendo que o banco vai salvar na tabela livro tudo passado no parametro livro
                    db.Livros.Add(livro);
                    db.SaveChanges();

                return RedirectToAction("Index");
                }
                return View(livro);

            }
            catch
            {
                return View();
            }
        }

        // GET: Livro/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Livro/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Livro/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Livro/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
