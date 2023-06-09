using DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICA
{
    public class Servicio
    {
        Repositorio repositorio;
        public Servicio(string stringConnection) 
        {
        repositorio = new Repositorio(stringConnection);
        }

        public string Insert(string insertado) 
        {
        
        return repositorio.Insert(insertado);
        }
    }
}
