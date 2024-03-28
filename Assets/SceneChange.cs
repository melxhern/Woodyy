using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public string sceneNameToLoad;

    // Start is called before the first frame update
    void Start()
    {

    }


    public void ChangeScene()
    {
        //Application.loadedLevelName();
        SceneManager.LoadScene(sceneNameToLoad);//on change de scène

    }
}
