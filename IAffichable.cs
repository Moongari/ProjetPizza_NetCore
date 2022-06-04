using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPizza
{
    public interface IAffichable
    {

        void AfficherMessage(bool isWriteFile = false);
        void AfficherError();
    }
}
