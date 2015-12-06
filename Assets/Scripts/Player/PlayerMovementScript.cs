using UnityEngine;
using System.Collections;

public class PlayerMovementScript : MonoBehaviour {
	
	private int translate = 0;
	private bool moving = false;
	
	public float displacement;
	public float rightLimiter;
	public float leftLimiter;

	private Animator _ChildAnimator;

	public GenericMovementHelperScript KeyHelper { private get; set; }

	// Use this for initialization
	void Start () {
		KeyHelper = new KeyMovementHelperScript();	
		_ChildAnimator = GetComponentInChildren<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		KeyHelper.UpdateBothSidesStatus();
		
		Debug.Log (KeyHelper.RightSideStatus);
		Debug.Log (KeyHelper.LeftSideStatus);

		if(_PlayerMovementLimiter(true))
		{
			if (KeyHelper.LeftSideStatus == EClickStatus.Down)
				transform.Translate(-displacement, 0f, 0f);
			
			if (KeyHelper.LeftSideStatus == EClickStatus.Up)
				transform.Translate(-displacement, 0f, 0f);
		}

		if(_PlayerMovementLimiter(false))
		{
			if (KeyHelper.RightSideStatus == EClickStatus.Down)
				transform.Translate(displacement, 0f, 0f);
			
			if (KeyHelper.RightSideStatus == EClickStatus.Up)
				transform.Translate(displacement, 0f, 0f);
		}
	}
	
	private bool _PlayerMovementLimiter(bool leftSide)
	{
		if (leftSide)
			return !((transform.position.x - displacement) < leftLimiter);
		else
			return !((transform.position.x + displacement) > rightLimiter);
	}
}