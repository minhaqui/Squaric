using UnityEngine;
using System.Collections;

public class NoteBallSpliter : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		PlayerMovementScript playerOne = other.GetComponentsInParent<PlayerMovementScript>()[0];
		//PlayerMovementScript playerTwo = other.GetComponentsInParent<PlayerMovementScript>()[1];
		Debug.Log(other.GetComponentsInParent<PlayerMovementScript>().Length);

		playerOne.KeyHelper = new KeyMovementHelperScript();
		playerOne.transform.position = new Vector2(-2.1f, -4f);
		playerOne.rightLimiter = 0f;

		//playerTwo.KeyHelper = new KeyMovementHelperScript();
		//playerTwo.transform.position = new Vector2(2.1f, 0f);
		//playerOne.leftLimiter = 0f;
	}
}
