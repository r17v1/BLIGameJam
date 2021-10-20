using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    // Start is called before the first frame update
    Image showHealth;
    float maxHealth = 100f;
    public static float curHealth;
    void Start()
    {
        showHealth = GetComponent<Image>();
        curHealth = maxHealth;

    }

    // Update is called once per frame
    void Update()
    {
        showHealth.fillAmount = curHealth / maxHealth;

    }

    public void changeHealth(int lost)
    {
        curHealth -= lost;
    }
}
