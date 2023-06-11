using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
	QuestionsInstance questionsManager;
	QuestionsXMLManager questionsXMLManager;

	void Awake() {
		// Set screen size for Windows standalone
		//#if UNITY_STANDALONE
		//Screen.SetResolution(1080, 1920, false);
		//Screen.fullScreen = false;
		//#endif
	}

	void Start() {
		questionsManager = FindObjectOfType<QuestionsInstance>();
		questionsXMLManager = FindObjectOfType<QuestionsXMLManager>();
	}

	public void Play() {
		//questionsXMLManager.LoadQuestion();
		questionsManager.LoadQuestion();
		StartCoroutine(WaitForSceneLoad());
	}

	public void Exit() {
		Application.Quit();
	}

	IEnumerator WaitForSceneLoad() {
		yield return new WaitForSeconds(0.5f);
		SceneManager.LoadScene("Level Select");
	}
}