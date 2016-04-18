using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    //Public variables
    public KeyCode moveUp, moveDown;
    public float speed = 10;
    public Transform transform;



    //private variables
    private Rigidbody2D rgb2D;
    void Start()
    {
        rgb2D = transform.GetComponent<Rigidbody2D>();
    }
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(moveUp))
        {
            rgb2D.velocity = new Vector2(0, speed);
        }
        else if (Input.GetKey(moveDown))
        {
            rgb2D.velocity= new Vector2(0, speed * -1);
        }
        else
        {
            rgb2D.velocity = Vector2.zero;
        }
	}
}
