using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneScript : MonoBehaviour
{
    private void Awake()
    {
        // if (instance != null)
        // {
        //     Destroy(gameObject);
        // }
        // else
        // {
        //     instance = GetComponent<SceneScript>();
        //     DontDestroyOnLoad(gameObject);
        // }
    }

    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}

