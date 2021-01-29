using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMoveManage : MonoBehaviour
{

     public void ChangeScene()
    {
        if(CompareTag("SettingsButton"))
        {
            SceneManager.LoadScene("Settings Scene");
        }
        else if(CompareTag("GameStartButton"))
        {
            SceneManager.LoadScene("Game Scene");
        }
        //이후 추가

    }
}
