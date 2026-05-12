using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosProgramacion
{
    internal interface IEjercicio
    {
        string Titulo { get; }
        void Run();
    }
}
