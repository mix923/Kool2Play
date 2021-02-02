using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	[CreateAssetMenu(
	    fileName = "WeaponGameEvent.asset",
	    menuName = SOArchitecture_Utility.GAME_EVENT + "Weapon",
	    order = 120)]
	public sealed class WeaponGameEvent : GameEventBase<Weapon>
	{
	}
}