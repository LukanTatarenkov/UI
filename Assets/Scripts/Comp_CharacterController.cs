using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comp_CharacterController : MonoBehaviour
{
	private Animator _animator;
	private Comp_PlayerInputs _inputs;
	private Comp_CameraController _cameraController;
	// Start is called before the first frame update
	void Start()
	{
		_animator = GetComponent<Animator>();
		_inputs = GetComponent<Comp_PlayerInputs>();
		_cameraController = GetComponent<Comp_CameraController>();

		_animator.applyRootMotion = false;

	}

	// Update is called once per frame
	void Update()
	{
		Vector3 _moveInputVector = new Vector3(_inputs.MoveAxisForwardRaw, 0, _inputs.MoveAxisForwardRaw);
		Vector3 _cameraPlanarDirection = _cameraController.CameraPlanarDirection;
		Quaternion _cameraPlanarRotation = Quaternion.LookRotation(_cameraPlanarDirection);

		Debug.DrawLine(transform.position, transform.position + _moveInputVector, Color.green);
	}
}
