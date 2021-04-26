using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    private Vector2 targetPos;

    public float Xmove=5;

    public float speed=1;

    public float iflive = 1;
    public GameObject gameover;

    public int watercount = 0;

    public Text healthDisplay;

    public GameObject deatheff;

    //public int deathCount = 0;
    // Update is called once per frame
    void Update()
    {
        if (iflive < 0)
        {
            gameover.SetActive(true);
            //deathCount++;
            Destroy(gameObject);
        }

        healthDisplay.text = "Memory Drops: " + watercount.ToString();
        
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.A))
        {
            
            targetPos = new Vector2(transform.position.x - Xmove, transform.position.y);
            //transform.position = targetPos;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            targetPos = new Vector2(transform.position.x + Xmove, transform.position.y);
            //transform.position = targetPos;
        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Wall"))
        {

            Instantiate(deatheff, transform.position, Quaternion.identity);

            iflive = -1;
            //Destroy(gameObject);
            //Debug.Log("hihi");
        }
    }
}
