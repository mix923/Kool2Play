using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public class WeaponEvent : UnityEvent<Weapon> { }

	[CreateAssetMenu(
	    fileName = "WeaponVariable.asset",
	    menuName = SOArchitecture_Utility.VARIABLE_SUBMENU + "Weapon",
	    order = 120)]
	public class WeaponVariable : BaseVariable<Weapon, WeaponEvent>
	{
	}
}