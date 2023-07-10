using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    public void OnStartGame(string SceneName)
    {
        SceneManager.LoadScene(SceneName); // load scene, scene name
    }
}
