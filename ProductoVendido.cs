using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Entrega_Alexis_Lucyk
{
    public class ProductoVendido
    {
        private int _id {  get; set; }
        private int _idProducto {  get; set; }
        private int _stock {  get; set; }
        private int _idVenta {  get; set; }
        
       
        public ProductoVendido(int id, int idProducto, int stock, int idVenta)
        {
            this._id = id;
            this._idProducto = idProducto;
            this._stock = stock;
            this._idVenta = idVenta;

        }
    }
    }
}
