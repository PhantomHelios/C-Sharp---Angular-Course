using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Project.Abstract
{
    internal interface IBaseService <T>
    {
        void Add(T item);
        void Delete(T item);
        void Update(T item);
    }
}
