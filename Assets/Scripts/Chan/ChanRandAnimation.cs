using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChanRandAnimation : MonoBehaviour
{
	public Animator anim;

	void Start ()
	{
		anim = GetComponent<Animator> ();
	}

	void Update ()
	{
		if (Input.GetMouseButtonDown (0)) {
			anim.Play ("JUMP00", -1, 0f);
		}
//		if (Input.GetKeyDown ("1")) {
//			anim.Play ("JUMP00", -1, 0f);
//		} else if (Input.GetKeyDown ("2")) {
//			anim.Play ("JUMP01", -1, 0f);
//		} else if (Input.GetKeyDown ("3")) {
//			anim.Play ("WAIT02", -1, 04);
//		} else if (Input.GetKeyDown ("4")) {
//			anim.Play ("WAIT03", -1, 0f);
//		} else if (Input.GetKeyDown ("5")) {
//			anim.Play ("WAIT04", -1, 0f);
//		}
	}
}
