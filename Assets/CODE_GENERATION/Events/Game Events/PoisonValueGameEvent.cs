using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	[CreateAssetMenu(
	    fileName = "PoisonValueGameEvent.asset",
	    menuName = SOArchitecture_Utility.GAME_EVENT + "PoisonEvent",
	    order = 120)]
	public sealed class PoisonValueGameEvent : GameEventBase<PoisonValue>
	{
	}
}