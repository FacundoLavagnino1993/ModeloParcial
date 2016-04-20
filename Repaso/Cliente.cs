using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    class Cliente
    {
        /*creaAlias() : Crea el alias concatenando un numero random de 4 cifras con la nacionalidad y el tipo de cliente,
         *invocarlo a este metodo en el constructor por defecto.
         *getAlias() : Retorna el alias.
         *retornarDatos(De instancia y privado) : Retorna un string con todos los datos
         *retornarDatos(estatico y publico) : Retorna un string con todos los datos, utilizar el metodo de instancia.
         */

        private string _aliasParaIncognito;
        private string _nacionalidad;
        private string _nombre;
        private Enum.eTipoCliente _tipoCliente;

        private static Cliente()
        { 
                
        }

        public Cliente(Enum.eTipoCliente cliente, string nombre)
        {
            this._nombre = nombre;
            this._tipoCliente = cliente;

        }

        public Cliente(Enum.eTipoCliente cliente, string nombre, string nacionalidad)
        {
            this._tipoCliente = cliente;
            this._nombre = nombre;
            this._nacionalidad = nacionalidad;
        }
        
        public Cliente(string nombre)
        {
            this._nombre = nombre;
        }

        public void creaAlias(string nacionalidad, Enum.eTipoCliente cliente)
        {

        }
    }
}
