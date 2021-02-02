using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public sealed class PoisonValueReference : BaseReference<PoisonValue, PoisonValueVariable>
	{
	    public PoisonValueReference() : base() { }
	    public PoisonValueReference(PoisonValue value) : base(value) { }
	}
}