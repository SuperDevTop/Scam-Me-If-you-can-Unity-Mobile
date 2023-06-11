using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using VM_Middleware;

public class QuitApp : MonoBehaviour {
	public void OnApplicationQuit() {
		MainMiddleware.Instance.ClosePort();
		StartCoroutine("DelayQuit");
	}

	IEnumerator DelayQuit() {
		yield return new WaitForSeconds(2.0f);
		Application.Quit();
	}
}