using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[AddComponentMenu(SOArchitecture_Utility.EVENT_LISTENER_SUBMENU + "PoisonValue")]
	public sealed class PoisonValueGameEventListener : BaseGameEventListener<PoisonValue, PoisonValueGameEvent, PoisonValueUnityEvent>
	{
	}
}