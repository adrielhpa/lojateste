using System.Globalization;

namespace TesteLojaAdriel
{
    public class Produto
    {
        private string _nomeProduto;
        private string _marcaProduto;
        private string _tipoProduto;
        private double _valorProduto;
        public string getNomeProduto()
        {
            return this._nomeProduto;
        }
        public void setNomeProduto(string value)
        {
            this._nomeProduto = value;
        }
        public string getMarcaProduto()
        {
            return this._marcaProduto;
        }
        public void setMarcaProduto(string value)
        {
            this._marcaProduto = value;
        }
        public string getTipoProduto()
        {
            return this._tipoProduto;
        } 
        public void setTipoProduto(string value)
        {
            this._tipoProduto = value;
        }
        public double getValorProduto()
        {
            this._valorProduto.ToString("C2", CultureInfo.CurrentCulture);
            return this._valorProduto;
        }
        public void setValorProduto(double value)
        {
            this._valorProduto = value;
        }
    }
}
