using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
	public CharacterMovement characterMovement;

	public void FixedUpdate()
	{
		characterMovement.MoveUpdate();
	}
}
