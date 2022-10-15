using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_type
{
    interface IGenericJsonData<T> where T : class
    {
       public void Save(T data);
     

        T Read();
    }

    class IGenericinterfaceJsonData<T> : IGenericJsonData<T> where T : class
    {
       public void Save(T user)
        {
            
        }
    public T Read()
        {
            return default;
        }

    }

     class GenerateInterfaceData<InterfaceType, User> : IGenericinterfaceJsonData<User> where User : class 
    {
        public void Save()
        {

        }

        public Type Read()
        {
            return default;
        }
    }
}