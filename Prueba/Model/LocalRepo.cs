using System.Collections.Generic;

namespace Prueba.Model
{
    class LocalRepo
    {
        public List<Commit> commits;

        public LocalRepo(List<Commit> commits)
        {
            this.commits = commits;
        }
    }
}
