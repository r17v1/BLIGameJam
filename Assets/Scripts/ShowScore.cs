using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowScore : MonoBehaviour
{
    // Start is called before the first frame update
    TextMeshProUGUI tmp;
    void Start()
    {
        tmp= gameObject.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        tmp.SetText("Score : "+Scorer.score);
    }
}
