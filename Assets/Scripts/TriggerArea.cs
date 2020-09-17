using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerArea : MonoBehaviour
{
    public GameEventsSingleton GameEvents;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameEvents.DoorwayTriggerEnter();
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        GameEvents.DoorwayTriggerExit();
    }   
}
