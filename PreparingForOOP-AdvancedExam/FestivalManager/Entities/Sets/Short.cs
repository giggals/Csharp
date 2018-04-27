namespace FestivalManager.Entities.Sets
{
	using System;

	public class Short : Set
	{
        private const int Max_Duration = 15;

		public Short(string name) 
			: base(name, new TimeSpan(0,15, 0))
		{
		}
	}
}