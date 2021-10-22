using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    Image showHealth;
    public float maxHealth;
    public static float curHealth;
    public static bool isLost = false;
    Stats stats;

    void Start()
    {
        stats = player.GetComponent<Stats>();
        showHealth = GetComponent<Image>();
        maxHealth = stats.health;
        curHealth = maxHealth;

    }

    // Update is called once per frame
    void Update()
    {
        curHealth = stats.health;
        showHealth.fillAmount = curHealth / maxHealth;
        if (curHealth <= 0) {
            Debug.Log(curHealth);
            isLost = true;
        }

    }
}
