using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class repeatbg : MonoBehaviour
{
    public float speed=5;

    public float startY;
    public float endY;

    private int count=500;
    public float aspeed=0.1f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);

        if (transform.position.y >= endY)
        {
            Vector2 pos = new Vector2(transform.position.x, startY);
            transform.position = pos;
        }

        if (speed < count) { speed += aspeed; }
        
    }
}
