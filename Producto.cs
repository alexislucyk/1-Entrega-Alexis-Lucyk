using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Entrega_Alexis_Lucyk
{
    public class Producto
    {
        private int _id {  get; set; }
        private string _descripcion {  get; set; }
        private double _costo {  get; set; }
        private double _precioVenta {  get; set; }
        private int _stock {  get; set; }
        private int _idUsuario {  get; set; }

        // Aca uso el contructor por defecto para dar valor a las atributos/variables
        public Producto()
        {
            _id = 0;
            _descripcion = string.Empty;
            _costo = 0;
            _precioVenta = 0;
            _stock = 0;
            _idUsuario = 0;
        }
    }
}
