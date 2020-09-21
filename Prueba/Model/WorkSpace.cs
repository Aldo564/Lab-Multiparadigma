using System.Collections.Generic;

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
