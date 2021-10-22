using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LoadingScene : MonoBehaviour
{ private float delay = 10f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(showTyping());
        // Debug.Log( this.GetComponent<Text>().text);
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetKeyDown(KeyCode.Return)) {
           openScene(0);        
        }
    }

    IEnumerator showTyping() {
     
        yield return new WaitForSeconds(delay);
    }
    public void openScene(int index) {
        Time.timeScale = 1f;
        SceneManager.LoadScene(index);
    }

}
