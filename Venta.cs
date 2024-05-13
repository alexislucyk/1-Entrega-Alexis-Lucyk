using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Entrega_Alexis_Lucyk
{
    public class Venta
    {
        private int id {  get; set; }
        private string comentario { get; set; }
        private int idUsuario { get; set; }

        public Venta(int id, string comentario, int idUsuario)
        {
            this.id = id;
            this.comentario = comentario;
            this.idUsuario = idUsuario;
        }


    }
}
