using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
        }
        public Negocio(string nombre)
            : this()
        {
            this.nombre = nombre;
        }

        public Cliente Cliente
        {
            get { return clientes.Dequeue(); }
            set { bool respuesta = this+value; }
        }



        public static bool operator ==(Negocio neg, Cliente cli)
        {
            foreach (Cliente item in neg.clientes)
            {
                if (cli == item)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Negocio neg, Cliente cli)
        {
            return !(neg == cli);
        }
        public static bool operator +(Negocio neg, Cliente cli)
        {
            if (neg != cli)
            {
                neg.clientes.Enqueue(cli);
                return true;
            }
            return false;
        }
        public static bool operator ~ (Negocio neg)
        {
            if (neg.clientes.Count > 0)
            {
                return neg.caja.Atender(neg.Cliente);
            }
            return false;
        }
        public int ClientesPendientes
        {
            get
            {
                return this.clientes.Count;
            }
        }
    }

}
