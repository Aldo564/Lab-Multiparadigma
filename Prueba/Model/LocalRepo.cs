using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
