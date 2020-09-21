using System.Collections.Generic;

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
