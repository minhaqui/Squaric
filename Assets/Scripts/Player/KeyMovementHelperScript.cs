using UnityEngine;
using System.Collections;

public class KeyMovementHelperScript : GenericMovementHelperScript {
	
	public KeyMovementHelperScript()
		: base() { }

	private const KeyCode RIGHT_KEY = KeyCode.RightArrow;
	private const KeyCode LEFT_KEY = KeyCode.LeftArrow;

	private bool _RightKeyDown;
	private bool _LeftKeyDown;

	// Use this for initialization
	void Start () { }
	
	// Update is called once per frame
	void Update () { }

	protected override void _SetInitialBothSidesStatus ()
	{
		RightSideStatus = EClickStatus.Released;
		LeftSideStatus = EClickStatus.Released;
	}

	public override void UpdateBothSidesStatus()
	{
		RightSideStatus = _GenericUpdateSideStatus(RIGHT_KEY, ref _RightKeyDown);
		LeftSideStatus = _GenericUpdateSideStatus(LEFT_KEY, ref _LeftKeyDown);
	}

	private EClickStatus _GenericUpdateSideStatus(KeyCode key, ref bool keyDown)
	{
		EClickStatus status = EClickStatus.Released;

		if (keyDown)
			status = EClickStatus.Pressed;

		if (Input.GetKeyDown(key) && !HasMovimentInProgress)
		{
			status = EClickStatus.Down;
			keyDown = true;
		}

		if (Input.GetKeyUp(key) && keyDown)
		{
			keyDown = false;
			status = EClickStatus.Up;
		}

		return status;
	}
}
