using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	[CreateAssetMenu(
	    fileName = "EnemyGameEvent.asset",
	    menuName = SOArchitecture_Utility.GAME_EVENT + "Enemy",
	    order = 120)]
	public sealed class EnemyGameEvent : GameEventBase<Enemy>
	{
	}
}