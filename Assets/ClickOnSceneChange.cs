using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickOnSceneChange : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnClick()
	{
		SceneManager.LoadScene("vuforiaScene", LoadSceneMode.Single);
        Debug.Log("scene switched");
	}
}
