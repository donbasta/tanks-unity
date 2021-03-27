using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour {

	public InputField inputFieldPlayer1Name;
	public InputField inputFieldPlayer2Name;
	void Start () {
        var se1 = new InputField.SubmitEvent();
        se1.AddListener(SubmitName1);
        inputFieldPlayer1Name.onEndEdit = se1;

		var se2 = new InputField.SubmitEvent();
        se2.AddListener(SubmitName2);
        inputFieldPlayer2Name.onEndEdit = se2;
    }

    public void SubmitName1(string arg0)
    {
		PlayerPrefs.SetString("Player1Name", arg0);
        Debug.Log(arg0);
    }

	public void SubmitName2(string arg0)
    {
		PlayerPrefs.SetString("Player2Name", arg0);
        Debug.Log(arg0);
    }
}
