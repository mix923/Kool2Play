using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[AddComponentMenu(SOArchitecture_Utility.EVENT_LISTENER_SUBMENU + "Weapon")]
	public sealed class WeaponGameEventListener : BaseGameEventListener<Weapon, WeaponGameEvent, WeaponUnityEvent>
	{
	}
}