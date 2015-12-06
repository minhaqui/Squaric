using UnityEngine;
using System.Collections;

public abstract class GenericMovementHelperScript : MonoBehaviour {

	public GenericMovementHelperScript()
	{
		_SetInitialBothSidesStatus();
	}

	public bool HasMovimentInProgress
	{
		get
		{
			return (LeftSideStatus != EClickStatus.Released || RightSideStatus != EClickStatus.Released);
		}
	}

	public EClickStatus LeftSideStatus { get; protected set; }
	public EClickStatus RightSideStatus { get; protected set; }

	protected abstract void _SetInitialBothSidesStatus();

	public abstract void UpdateBothSidesStatus();
}