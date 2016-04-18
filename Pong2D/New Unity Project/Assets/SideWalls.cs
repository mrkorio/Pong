using UnityEngine;
using System.Collections;

public class SideWalls : MonoBehaviour {

    // Use this for initialization

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.name == "Ball")
        {
            string name = transform.name;
            GameManager.Score(name);
            hitInfo.gameObject.SendMessage("ResetBall");
        }


    }
    
}
