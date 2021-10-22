using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public static bool isPaused = false;
    public GameObject gameOver;
    public GameObject gameWon;
    
    public GameObject pauseMenuUI;
    // Update is called once per frame
    public GameObject buttons;
    /// ######################################### pause menu
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)) {
            if(isPaused) {
                resumeGame();
            }
            else {
                pauseGame();
            }
        }
        if(PlayerControlls.isWon) {
            gameWon.SetActive(true);
        }
        if(Health.isLost) {
            gameOver.SetActive(true);
        }

    }
    void pauseGame() {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }
    public void resumeGame() {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
    // ############################### menu
    public void openScene(int index) {
        Time.timeScale = 1f;
        SceneManager.LoadScene(index);
    }
    public void exitGame() {
        Application.Quit();
    }
    
}
