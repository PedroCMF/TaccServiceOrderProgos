using System;
using System.Collections.Generic;
using System.Text;

namespace Tacc.serviceOrder.Domain.Entities
{
    //cadastro dos fabricante
    public class Manufacturing : BaseEntity
    {
        public string Nome { get; set; }
        public string DocumentNumber { get; set; }
        public string? Email { get; set; }
        //O fabricante tem varos produtos 1:N, ou seja, um fabricante pode ter vários produtos, e um produto pertence a um fabricante, por isso é uma coleção 1:N
<<<<<<< HEAD
        public IEnumerable<Product> Products { get; set; } //um fabricante pode ter vários produtos, por isso é uma coleção 1:N
=======
        public Enumerable<product> Producst { get; set; } //um fabricante pode ter vários produtos, por isso é uma coleção 1:N


>>>>>>> a890a364e4b1bd7f486f40dedfb44e9d3b4e6cd6

    }
}
