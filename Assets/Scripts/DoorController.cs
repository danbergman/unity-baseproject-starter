using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameEventsSingleton.current.OnDoorwayTriggerEnter += OnDoorwayOpen;
        GameEventsSingleton.current.OnDoorwayTriggerExit += OnDoorwayClose;
    }

    private void OnDoorwayOpen()
    {
        Debug.Log("triggered!");
        transform.position = new Vector3(transform.position.x, transform.position.y + 10, 0f);
    }
    private void OnDoorwayClose()
    {
        Debug.Log("triggered exit!");
        transform.position = new Vector3(transform.position.x, transform.position.y - 10, 0f);
    }

    private void OnDestroy()
    {
        GameEventsSingleton.current.OnDoorwayTriggerEnter -= OnDoorwayOpen;
        GameEventsSingleton.current.OnDoorwayTriggerExit -= OnDoorwayClose;
    }
}
