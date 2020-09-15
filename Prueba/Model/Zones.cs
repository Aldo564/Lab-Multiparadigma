using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Model
{
    class Zones
    {
        public WorkSpace workSpace;
        public Index index;
        public LocalRepo localRepo;
        public RemoteRepo remoteRepo;

        public Zones(WorkSpace workSpace, Index index, LocalRepo localRepo, RemoteRepo remoteRepo)
        {
            this.workSpace = workSpace;
            this.index = index;
            this.localRepo = localRepo;
            this.remoteRepo = remoteRepo;
        }
    }
}
