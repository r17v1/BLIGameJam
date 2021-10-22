using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LoadingScene : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
         if(Input.GetKeyDown(KeyCode.Return)) {
           openScene(1);        
        }
    }

    public void openScene(int index) {
        Time.timeScale = 1f;
        SceneManager.LoadScene(index);
    }



}
