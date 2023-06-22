using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemycontroller : MonoBehaviour
{
    GameObject player;

    public float walkSpeed = 0.01f;
    private bool stayOrWalk;
    public int Health = 3;
    public float range;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void FixedUpdate()
    {
        if(IsPlayerInRange(range))
        {
            Follow();
        }
        
        if (Health <= 0)
        {
            Destroy(gameObject);
        }
        
        /*if (player != null)
        {
            
            if (stayOrWalk == false)
            {
                transform.position = Vector2.MoveTowards(transform.position, player.position, walkSpeed);
            }
            
            Vector3 difference = player.transform.position - transform.position;
            difference.Normalize();
            float rotation_z = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;

            
        }*/
       
    }
    
    private bool IsPlayerInRange(float range)
    {
        return Vector3.Distance(transform.position, player.transform.position) <= range;
    }

    void Follow()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, walkSpeed * Time.deltaTime);
    }
    
    public void TakeDamage(int damage)
    {
        Health -= damage;
    }
    public void Death()
    {
        Destroy(gameObject);
    }
}
