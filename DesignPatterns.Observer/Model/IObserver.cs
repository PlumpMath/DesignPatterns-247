using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.Model
{
    public interface IObserver
    {
        void Update(double value);
    }
}