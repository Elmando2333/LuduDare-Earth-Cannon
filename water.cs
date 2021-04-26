using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water : MonoBehaviour
{
    // Start is called before the first frame update

    public int health = 1;
    public float speed = 1f;
    public float aspeed=0.5f;
    private float wall = 30;
    public float awall = 3;


    public GameObject eff;

    private void Update()
    {
        if(transform.position.y>wall)
        {
            Destroy(gameObject);
        }
        transform.Translate(Vector2.up * speed * Time.deltaTime);
        if (speed < awall)
        {
            speed += aspeed;
        }
 
    }
    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {

            Instantiate(eff, transform.position, Quaternion.identity);

            other.GetComponent<player>().watercount += health;
            //Debug.Log("±»Ωœ÷µ£∫" + gameObject.CompareTag("Player"));
            //Debug.Log(other.GetComponent<player>().watercount);
            Destroy(gameObject);
        }
    }
}
