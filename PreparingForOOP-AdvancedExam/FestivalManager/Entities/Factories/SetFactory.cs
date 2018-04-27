using System;

using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;





namespace FestivalManager.Entities.Factories
{
    using Contracts;
    using Entities.Contracts;
    using Sets;
    using System.Linq;

    public class SetFactory : ISetFactory
    {
        public ISet CreateSet(string name, string type)
        {
            Type set = Assembly.GetCallingAssembly().GetTypes().FirstOrDefault(x => x.Name == type);
            
            if (set == null)
            {
                throw new ArgumentException("Cannot be null");
            }
            if (!typeof(ISet).IsAssignableFrom(set))
            {
                throw new InvalidOperationException("Not assignable from ISet");
            }

            return (ISet)Activator.CreateInstance(set, name);
        }
    }




}
