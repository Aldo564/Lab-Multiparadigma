using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Model
{
    class WorkSpace
    {
        public List<Archivo> archivos;

        public WorkSpace(List<Archivo> archivos)
        {
            this.archivos = archivos;
        }
    }
}
