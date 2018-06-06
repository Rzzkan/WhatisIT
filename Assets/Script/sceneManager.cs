using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour {

    string nameScene;

	// Use this for initialization
	void Start () {
        Scene currentScene = SceneManager.GetActiveScene();
        nameScene = currentScene.name;
        
	}
	
	// Update is called once per frame
	void Update () {

        getBack();
	}

    public void ketujuan(string tujuan)
    {
        Application.LoadLevel(tujuan);
    }

    public void getBack(){
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (nameScene.Equals("Home"))
            {
                Application.Quit();
            }
            else if (nameScene.Equals("Book"))
            {
                SceneManager.LoadScene("Home");
            }
            else if (nameScene.Equals("Category"))
            {
                SceneManager.LoadScene("Home");
            }
            else if (nameScene.Equals("About"))
            {
                SceneManager.LoadScene("Home");
            }
        }

    }
}
