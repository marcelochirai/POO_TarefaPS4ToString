using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ProdutoEstoqueTS
{
    class Produto
    {
        public string Product;
        public double Price;
        public int Qty;

        //Método para cálculo do valor total em estoque
        public double TotalValueStock()
        {
            return Price * Qty;
        }

        //Método para adicionar produtos
        public void AddProduct(int qty)
        {
            Qty += qty;
        }

        //Método para remover produtos
        public void RemoveProduct(int qty)
        {
            Qty -= qty;
        }

        //Método ToString para inserir todas as informações unificadas
        public override string ToString()
        {
            return Product
            + ",$"
            + Price.ToString("F2", CultureInfo.InvariantCulture)
            + " " + Qty
            + " unidades, Total: $ "
            + TotalValueStock().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
