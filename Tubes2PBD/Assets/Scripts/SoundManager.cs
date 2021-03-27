using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour {

	public InputField inputFieldSoundVolume;
	void Start () {
        var se = new InputField.SubmitEvent();
        se.AddListener(Submit);
        inputFieldSoundVolume.onEndEdit = se;
    }

    public void Submit(string arg0) {
		float value = (float) Int32.Parse(arg0) / ((float) 100.0);
		PlayerPrefs.SetFloat("SoundVolume", value);
        Debug.Log(arg0);
		Debug.Log(value);
    }

}
