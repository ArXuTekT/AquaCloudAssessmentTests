using System.Collections.Generic;

namespace FarmMgmt.Interfaces
{
	public interface ISettingsService{
		public IEnumerable<string> GetDefaultPetNames();
	}
}
