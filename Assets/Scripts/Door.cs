using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Door : MonoBehaviour
{
    public GameEvent HitEvent;
    public UnityEvent DamageEvent;

    private void OnTriggerEnter2D(Collider2D collision)
    {
      
       
            DamageEvent.Invoke();
     
    }
}
