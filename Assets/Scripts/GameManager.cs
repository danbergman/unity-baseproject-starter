using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Player Player;
    public static GameManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        // Cache references to all desired variables
        Player = FindObjectOfType<Player>();
    }

    // Start is called before the first frame update
    void Start()
    {
        // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
        UIController.instance.FadeFromBlack();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
