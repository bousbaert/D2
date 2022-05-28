using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void ChangeSceneBtn()
    {
        switch (this.gameObject.name)
        {
            case "StartBtn":
                SceneManager.LoadScene("basic Scene");
                break;
            
            case "ExitBtn":
                SceneManager.LoadScene("Exit");
                break;
        }

    }
}
