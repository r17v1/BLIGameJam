using UnityEngine;

public class ProjectileProperties : MonoBehaviour
{
    public float speed;
    public string target;
    public string[] destroyTags;
    public float damage;
    public float range;
    void Update()
    {
        Vector2 direction = new Vector2(1, 0);
        Vector2 moveVal = direction * speed * Time.deltaTime;
        transform.Translate(moveVal);
        range -= moveVal.x;
        if (range <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.tag);
        string tag = collision.gameObject.tag;

        if(tag == target)
        {
            collision.GetComponent<Stats>().TakeDamage(damage);
            Destroy(gameObject);
        }
        foreach(string t in destroyTags)
        {
            if(tag == t)
                Destroy(gameObject);
        }
    }
}
