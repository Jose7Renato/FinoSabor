﻿using SistemaERP.Domain.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaERP.Domain.Entities
{
    public class Categoria : EntityBase
    {

        public Categoria()
        {
                
        }

        public Categoria(string nome)
        {
            this.nome = nome;
        }

        public string nome { get; set; }

        /*
         * Auto-relacionamento
         * 1-Informatica - P:null
         * - 2-Mouse: P:1
         * -- 3-Mouse sem fio P:2
         * -- 4-Mouse Gamer P:2
         */
        /*
        public Guid? CategoriaPaiId { get; set; }
	    //public string Descricao { get; set; }


        //EF Relation
        public virtual Categoria CategoriaPai { get; set; }
        */
    }
}
