using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public interface ICrud<T>
    {
        string Insert(T insertado);
        string Update(T actualizado);
        string Delete(T eliminado);
        List<T> GetAll();
    }
}
