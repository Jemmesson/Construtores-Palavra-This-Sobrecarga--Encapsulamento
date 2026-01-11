using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ExercicioComEnpasulamento
{
    internal class Produto
    {
        private string _nome; //Propriedade privade
        public double Preco {  get; private set; } //Propriedade autoimplementadas
        public int Quantidade { get; private set; } //Propriedade autoimplementadas

        //Construtores
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        //Propriedade Customizada
        public string Nome
        {
            get{ return _nome; }
            
            set 
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        //Até o override é chamada de "Outros metodos da classe";
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;

        }

        public override string ToString()
        {
            return _nome + ", " +
                "$ " + Preco.ToString("f2", CultureInfo.InvariantCulture) +
                ", " + Quantidade + " unidades" +
                ", " + "$ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
