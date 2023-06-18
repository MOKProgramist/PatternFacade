using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternFacade;

namespace PatternFacade
{
    internal class WorkFacade
    {
        Facade facede;
        public WorkFacade(Facade facede)
        {
            this.facede = facede;
        }

        public void CreateApplication()
        {
            this.facede.Start();
            this.facede.Stop();
        }
    }
}
