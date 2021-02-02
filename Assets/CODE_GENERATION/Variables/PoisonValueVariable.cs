using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public class PoisonValueEvent : UnityEvent<PoisonValue> { }

	[CreateAssetMenu(
	    fileName = "PoisonValueVariable.asset",
	    menuName = SOArchitecture_Utility.VARIABLE_SUBMENU + "PoisonValue",
	    order = 120)]
	public class PoisonValueVariable : BaseVariable<PoisonValue, PoisonValueEvent>
	{
	}
}