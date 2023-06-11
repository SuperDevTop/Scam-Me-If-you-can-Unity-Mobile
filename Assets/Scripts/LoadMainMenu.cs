using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using VM_Middleware;

public class LoadMainMenu : MonoBehaviour {
	float timeLeft = 8f;

	void Start() {
		if(MainMiddleware.Instance.IsInitialize) {
			if(MainMiddleware.Instance.GetTotalItemAvailable() > 0) {
				MainMiddleware.Instance.DropItem();
			}
		}
	}

	void Update() {
		timeLeft -= Time.deltaTime;

		if(timeLeft <= 0) {
			SceneManager.LoadScene(0);
		}
	}
}