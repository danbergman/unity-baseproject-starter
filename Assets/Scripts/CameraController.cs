using UnityEngine;

public class CameraController : MonoBehaviour
{
    [HideInInspector]
    private Transform _followObject;     

    // camera constraints.
    public float minHeight, maxHeight;      

    private void Awake()
    {
      
    }

    // Start is called before the first frame update
    void Start()
    {
        _followObject = GameManager.Instance.Player.transform;           
    }

    // Update is called once per frame
    void Update()
    {
        // follow the target.
        transform.position = new Vector3(_followObject.position.x, _followObject.position.y, transform.position.z);

        // clamp the camera on the Y-axis.
        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, minHeight, maxHeight), transform.position.z); 
      
    }
}
