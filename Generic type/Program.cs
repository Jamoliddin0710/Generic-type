using Generic_type;
using Umbraco.Core.Models.Entities;

public class Generic
{
    public static void Main(string[] args)
    {
        Generic<User> user = new Generic<User>();
        user.ReadUser();
        user.Save(new User());
    }
    static T SaveData<T, TData>() where T : class where TData : struct
    {

        return default;
    }

    static T result<T>()
    {
        return default;
    }
}

public class Generic<Type> where Type : BaseClass, IEntity
{
    public void Save(Type data)
    {

    }

    public Type ReadUser()
    {
        return default;
    }

}
