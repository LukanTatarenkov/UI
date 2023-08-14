using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
	// Start is called before the first frame update
	public Animator anim;

	public float vertical;
	public float horizontal;
	public float moveAmout;

	public void MoveUpdate()
	{
		vertical = Input.GetAxis("Vertical");
		horizontal = Input.GetAxis("Horizontal");
		moveAmout = Mathf.Clamp01(Mathf.Abs(vertical) + Mathf.Abs(horizontal));

		anim.SetFloat("vertical", vertical, 0.15f, Time.deltaTime);
	}
}
