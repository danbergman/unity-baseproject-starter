using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    public string Name;  

    private SpriteRenderer spriteRenderer;
    private Rigidbody2D rb2D;
   
    public void SetName(string newName)
    {
        Name = newName;
    }
    private void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {          
           
    }
}
