using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossElevatorPlatform : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] bool moving;
    [SerializeField] public Vector2 targetPosition = new Vector2(0, 0);
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
           
            moving = true;

        }
    }
    private void Update()
    {
        if (moving)
        {
            transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), targetPosition, speed * Time.deltaTime);
        }
        if (transform.position.y < 140 )
        {
            Destroy(this.gameObject);
        }
    }



}


