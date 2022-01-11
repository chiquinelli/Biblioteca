using Biblioteca.DataContext;
using Biblioteca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Biblioteca.Helpers
{
    public class RetornaSelectListItem
    {
        private static BibliotecaDB db = new BibliotecaDB();

        public static List<SelectListItem> Autores()
        {
            List<Autor> lAutores = new List<Autor>();
            lAutores = db.Autores.ToList();

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
            return listaAutores;
        }

        public static List<SelectListItem> Categorias()
        {
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
            return ListaCategorias;

        }

    }
}