using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    class cuentaOffShore
    {
        /* En esta clase el constructor por defecto debera sumar uno al atributo estatico cantidad de cuentas
         * y el lugar por defecto sera bahamas, no repetir lineas de codigo. Constructor de clase en esta clase
         * sera el encargado de inicializar la cantidad de cuentas a cero 0. */

        private Enum.eTipoDeBeneficio beneficio;
        public  static int CantidadDeCuentas = 0;
        public List<Cliente> ListadoClientes;
        private Enum.eParaisosFiscales lugar;

         public cuentaOffShore()
        {
            CantidadDeCuentas = 1;
            this.lugar = Enum.eParaisosFiscales.Bahamas;
        }

         private static cuentaOffShore()
        {
            CantidadDeCuentas = 0;   
        }



        public cuentaOffShore(Enum.eParaisosFiscales lugar)
        {
            this.lugar = lugar;
        }

        public cuentaOffShore(Enum.eParaisosFiscales lugar, Enum.eTipoDeBeneficio beneficio)
        {
            this.lugar = lugar;
            this.beneficio = beneficio;
        }


    }
}

namespace Enum
{
    public enum eParaisosFiscales
    {
       Anguila, Bahamas, Belice, Delaware, Gibraltar, Hong_Kong, Mauricio, Panama, Seychelles, Singapur, Suiza
    }

    public enum eTipoProducto
    {
        Cuentas_Bancarias, Polizas_de_Seguros, Inversiones_Inmobiliarias, Sociedades_Extranjeras, Fondos_de_Inversion
    }

    public enum eTipoDeBeneficio
    {
        Secreto_Bancario, Beneficios_Fiscales, Secreto_Bancario_Y_Beneficios_Fiscales
    }

    public enum eTipoCliente
    {
        Politico_Corrupto, Empresario_Corrupto, JugadorDeFutbol, financista, maestroRural
    }

}