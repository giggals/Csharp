namespace FestivalManager.Entities.Factories
{
	using System;
	using System.Linq;
	using System.Reflection;
	using System.Runtime.InteropServices.WindowsRuntime;
	using Contracts;
	using Entities.Contracts;
	using Instruments;

	public class InstrumentFactory : IInstrumentFactory
	{
		public IInstrument CreateInstrument(string type)
		{
            Type instrument = Assembly.GetCallingAssembly().GetTypes().FirstOrDefault(x => x.Name == type);

            if (instrument == null)
            {
                throw new ArgumentException("Cannot be null");
            }
            if (!typeof(IInstrument).IsAssignableFrom(instrument))
            {
                throw new InvalidOperationException("Not assignable from IInstrument");
            }


            return (IInstrument)Activator.CreateInstance(instrument);
		}
	}
}