﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class QuitButton : MonoBehaviour {
	public Button button;
	public AudioSource audio;

	void Start()
	{
		Button btn = button.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		StartCoroutine(playSoundThenQuit());
	}

	IEnumerator playSoundThenQuit()
	{
		audio.Play();
		yield return new WaitForSeconds(audio.clip.length - 0.3f);
		Application.Quit ();
	}
}