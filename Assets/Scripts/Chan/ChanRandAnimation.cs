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
			anim.Play ("DAMAGED00", -1, 0f);
		} else if (Input.GetKeyDown ("1")) {
			anim.Play ("WAIT02", -1, 04);
		} else if (Input.GetKeyDown ("2")) {
			anim.Play ("WAIT03", -1, 0f);
		} else if (Input.GetKeyDown ("3")) {
			anim.Play ("WAIT04", -1, 0f);
		} else if (Input.GetKeyDown ("4")) {
			anim.Play ("WALK00_F", -1, 0f);
		} else if (Input.GetKeyDown ("5")) {
			anim.Play ("RUN00_F", -1, 0f);
		} else if (Input.GetKeyDown ("6")) {
			anim.Play ("SLIDE00", -1, 0f);
		} else if (Input.GetKeyDown ("7")) {
			anim.Play ("WIN00", -1, 0f);
		} else if (Input.GetKeyDown ("8")) {
			anim.Play ("LOSE00", -1, 0f);
		} else if (Input.GetKeyDown ("9")) {
			anim.Play ("JUMP00", -1, 0f);
		} else if (Input.GetKeyDown ("0")) {
			anim.Play ("HANDUP00_R", -1, 0f);
		}
		
	}
}
