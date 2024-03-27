using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.Interface{
public interface IComponent<T>
{
    T GetText();
}

}