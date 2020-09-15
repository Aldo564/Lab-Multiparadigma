using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Model
{
    class RemoteRepo
    {
        public List<Commit> commits;
        public bool estado_actualizacion = false;

        public RemoteRepo(List<Commit> commits)
        {
            this.commits = commits;
        }
    }
}
