using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingNext : MonoBehaviour
{
    private void OnEnable() {
        SceneManager.LoadScene(1);
        
    }
}
