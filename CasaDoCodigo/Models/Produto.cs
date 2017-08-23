using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace CasaDoCodigo.Models
{
    public class Produto : BaseModel
    {
        [DataMember]
        public string Nome { get; private set; }
        [DataMember]
        public decimal Preco { get; private set; }

        public Produto()
        {

        }

        public Produto(int id, string nome, decimal preco): this(nome, preco)
        {
            this.Id = id;
        }

        public Produto(string nome, decimal preco)
        {
            this.Nome = nome;
            this.Preco = preco;
        }
    }
}
