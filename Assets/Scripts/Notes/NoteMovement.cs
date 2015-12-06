using UnityEngine;
using System.Collections;

public class NoteMovement : MonoBehaviour {

	private Rigidbody2D _Rigidbody;

	// Use this for initialization
	void Start () 
	{
		_Rigidbody = GetComponent<Rigidbody2D>();
		_Rigidbody.velocity = new Vector2(0, -4);
	}
	
	// Update is called once per frame
	void Update ()
	{
	}
}
