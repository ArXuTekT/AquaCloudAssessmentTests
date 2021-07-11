using FarmMgmt.Models;
using System.Collections.Generic;
using FarmMgmt.Interfaces;
using System.Linq;

namespace FarmMgmt.Services{

	public class PetInMemoryService : IPetService
	{
		private readonly ISettingsService _settingsService;
		private Dictionary<string, Pet> Pets{ get; set; }

		public PetInMemoryService(ISettingsService settingsService)
		{
			_settingsService = settingsService;
			Pets = new Dictionary<string, Pet>();

			var defaultPetNames = _settingsService.GetDefaultPetNames();
			
			foreach (var petName in defaultPetNames){
				Pets.Add(petName, new Pet(petName));
			}
		}

		public Pet[] List(){
			return Pets.Values.ToArray();
		}

		public Pet[] List(int limit){
			return Pets.Values.Take(limit).ToArray();
		}

		public Pet[] List(int limit, int shift){
			return Pets.Values.Skip(shift).Take(limit).ToArray();
		}

		public bool Add(string petName){
			return Pets.TryAdd(petName, new Pet(petName));
		}

		public bool Remove(string petName){
			return Pets.Remove(petName);
		}
	}
}