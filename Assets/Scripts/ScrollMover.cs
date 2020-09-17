using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/// <summary>
/// moves an object in association with the scrollbar movement.
/// </summary>
public class ScrollMover : MonoBehaviour
{
    private float currentScrollbarValue;
    private float oldValue;
    private Slider scrollbar;

    public Transform startingPoint;
    public Transform endingPoint;
    Vector2 targetPosition;

    // Start is called before the first frame update
    void Start()
    {
        scrollbar = FindObjectOfType<Slider>();
        targetPosition = new Vector2(startingPoint.position.x, startingPoint.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        // change transform position by slider value.
        currentScrollbarValue = scrollbar.value;
    }
  
    // event when scrollbar moves
    public void MoveIt()
    {
        float step = 5.0f * Time.deltaTime; // calculate distance to move         

        // if not at boundary...
        //if (Vector2.Distance(transform.position, targetPosition) > 0.001f)
        //{
            // find the direction to move
            if (currentScrollbarValue < oldValue)
            {
                // going to the left
                transform.position = Vector3.MoveTowards(transform.position, startingPoint.position, step);
                targetPosition = startingPoint.position;
            }
            else
            {
                // going to the right
                transform.position = Vector3.MoveTowards(transform.position, endingPoint.position, step);
                targetPosition = endingPoint.position;
            }

            oldValue = currentScrollbarValue;
       // }       
    }
}
