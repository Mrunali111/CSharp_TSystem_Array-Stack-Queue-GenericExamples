using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystem_Day3_2DArray
{
    public class Generic<T>
    {
        private T data;

        public Generic(T data)
        {
            this.data = data;
        }

        public T GetData()
        {
            return data;
        }
    }
}
