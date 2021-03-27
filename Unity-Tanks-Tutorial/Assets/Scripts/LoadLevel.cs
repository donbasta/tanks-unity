using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour {

	public void LoadScene(string name) {
		Application.LoadLevel(name);
	}

	public void QuitGame() {
		Application.Quit();
	}

}
