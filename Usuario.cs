using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Entrega_Alexis_Lucyk
{
    public class Usuario
    {
        private int _id {  get; set; }
        private string _nombre { get; set; }
        private string _apellido {  get; set; }
        private string _nombreUsuario {  get; set; }
        private string _contrasenia {  get; set; }
        private string _mail {  get; set; }

        // Aca uso el constructor parametrizado

        public Usuario(int id, string nombre, string apellido, string nombreUsuario, string contrasenia, string mail)
        {
            this._id = id;
            this._nombre = nombre;
            this._apellido = apellido;
            this._nombreUsuario = nombreUsuario;
            this._contrasenia = contrasenia;
            this._mail = mail;
        }

     
    }
    
}
