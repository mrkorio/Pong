using UnityEngine;
using System.Collections;

public class BallControl : MonoBehaviour {

    // Use this for initialization
   public Transform trans;
    public float ballSpeed = 100;
    Rigidbody2D rgb;

    IEnumerator Start () {
        rgb = trans.GetComponent<Rigidbody2D>();
        yield return new WaitForSeconds(2);
        GoBall();

    }
	
	// Update is called once per frame
	void Update () {

        
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.collider.tag == "Player")
        {
            rgb.velocity = new Vector2(rgb.velocity.x, rgb.velocity.y / 2 + coll.rigidbody.velocity.y / 3);
            rgb.mass -=(float) 0.01;

        }

    }

   public  IEnumerator ResetBall()
    {
        rgb.velocity = Vector2.zero;
        rgb.position = Vector2.zero;
        yield return new WaitForSeconds(1);
        GoBall();
    }

    private void GoBall()
    {
        float rand = Random.Range(0f, 2f);
       
        if (rand <= 1f)
        {
            rgb.AddForce(new Vector2(ballSpeed, 30));
        }
        else
        {
            rgb.AddForce(new Vector2(-ballSpeed, -50));
        }
    }
}
