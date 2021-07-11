using FarmMgmt.Interfaces;

namespace FarmMgmt.Services
{
	using System.Collections.Generic;

	public class SettingsFileService : ISettingsService
    {
	    public IEnumerable<string> GetDefaultPetNames()
	    {
		    return Properties.Resources.DefaultPetNames.Split(';');
		}
    }
}
