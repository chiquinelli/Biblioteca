using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Biblioteca.Models
{
    public class Livro
    {
        //Data notetion é como se fosse uma camada de regra de negocios 
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        [DisplayName("Nome do Livro")]    //isso faz com que ao inves do display exibir nome ele exibira nome do livro na label
        public string Nome { get; set; }

        [DisplayName("Total de páginas do Livro")]
        public int TotalPaginas { get; set; }

        [DisplayName("Descrição do Livro")]
        public string Descricao { get; set; }

        [DisplayName("Quantidade")]
        public int Quantidade { get; set; }
        //Aqui instanciei outra classe com outras propriedades
        public Categoria Categoria { get; set; }

        public Autor Autor { get; set; }

        public int CategoriaId { get; set; }

        public int AutorId { get; set; }
    }
}