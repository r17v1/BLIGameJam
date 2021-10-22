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
    /// ######################################### pause menu
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)) {
            if(isPaused) {
                resumeGame();
                StartCoroutine(audioToggle(true));
            }
            else {
                pauseGame();
                StartCoroutine(audioToggle(false));

            }
        }
        if(PlayerControlls.isWon) {
            Time.timeScale = 0f;
            gameWon.SetActive(true);
        }
        if(Health.isLost) {
            Time.timeScale = 0f;
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

    public void restartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    // ############################### menu
    public void openScene(int index) {
        Time.timeScale = 1f;
        SceneManager.LoadScene(index);
    }
    public void exitGame() {
        Application.Quit();
    }

    IEnumerator audioToggle(bool index) {
        AudioSource audio = GetComponent<AudioSource>();
        if(index) {
            audio.Play();
        } else {
            audio.Stop();
        }
        yield return new WaitForSeconds(0);
    }

    
}
