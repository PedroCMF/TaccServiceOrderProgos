using System;
using System.Collections.Generic;
using System.Text;
using Tacc.serviceOrder.Domain.Entities;

namespace Tacc.serviceOrder.Domain
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        //a classe product tem um fabricate 1:1, ou seja, um produto pertence a um fabricante, e um fabricante pode ter vários produtos, por isso é uma coleção 1:N
        public Manufacturing Manufacturing { get; set; } //A propriedade é do tipo Manufacturing, pois um produto pertence a um fabricante(manufacture), dentro dela tem tudo qie a classe Manufacturing tem, como o nome do fabricante, o documento, o email e a coleção de produtos que ele tem
        public int ManufactureId { get; set; } //chave estrangeira para o fabricante, para evitar problemas de relacionamento entre as tabelas no banco
    }
}
