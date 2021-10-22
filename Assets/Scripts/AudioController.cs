using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerControlls.isWon) {
            StartCoroutine(audioChange());
        }
        if(Health.isLost) {
            Debug.Log("Lost");
            StartCoroutine(audioChange());
        }
        
    }
    IEnumerator audioChange() {
        AudioSource audio = GetComponent<AudioSource>();
        audio.Stop();
        yield return new WaitForSeconds(0);
    }
}
