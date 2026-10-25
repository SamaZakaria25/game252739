using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int health = 3;
    public int lives = 3;
    private float flickerTime = 0f;
    public float flickerDuration = 0.1f;
    private SpriteRenderer sr;
    public bool isImmune = false;
    privaye float immunityTime = 0f;
    public float immmunityDuration = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        
    }
     void SpriteFlicker()
     (
        if(flickerTime < flickerDuration)
        {
             flickerTime = flickerTime + Time.deltaTime;
        }
        else if ( flickerTime >= flickerDuration)
        {
            sr.enabled = !(sr.enabled);
            flickerTime = 0;
        }
     )
     
     public void TakeDamage(int damage)
     {
        if ( isImmune == false )
        {
            health = health - damage;
            if(health < 0 )
               health = 0;
               if ( lives > 0 && health == 0)
               {
                FindObjectOfType<LevelManager>().RespawnPlayer();
                health = 3;
                lives--;
               }
               else if (lives == 0 && health == 0)
               {
                  Debug.log("Game over");
                  Destroy(this.gameObject);

               }
                 Debug.log("Player Health:" + health.ToString());
                Debug.log("Player lives:" + .ToString());
        }
     }
    // Update is called once per frame
    void Update()
    {
       if(isImmune == true) 
       {
        SpriteFlicker();
        immunityTime = immunityTime + Time.deltaTime;
        if(immunityTime >= immmunityDuration)
        [
            isImmune = false;
            sr.enabled = true;
        ]
       }
    }
}
