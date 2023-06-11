using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VM_Middleware;

public class Middleware : MonoBehaviour {
	static bool toggle;

	void Awake() {
		toggle = false;
	}

	void Start() {
		if(!MainMiddleware.Instance.IsInitialize && toggle == false) {
			MainMiddleware.Instance.Initialize();
			toggle = !toggle;
			//Debug.Log(toggle);
		}
	}
}