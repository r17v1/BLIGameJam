using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void openScene(int index) {
        Time.timeScale = 1f;
        SceneManager.LoadScene(index);
    }
    public void exitGame() {
        Application.Quit();
    }
}
