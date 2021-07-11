namespace FarmMgmt.Interfaces
{
	using FarmMgmt.Models;

	public interface IPetService{
		public Pet[] List();
		public Pet[] List(int limit);
		public Pet[] List(int limit, int shift);
		public bool Add(string petName);
		public bool Remove(string petName);
	}
}
