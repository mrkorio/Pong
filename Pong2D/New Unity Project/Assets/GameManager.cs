using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    // Use this for initialization


    static int playerScore01 = 0;
    static int playerScore02 = 0;
    public GUISkin skin;
    
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public static void Score(string wallName)
    {
        switch (wallName)
        {
            case "rightWall":
                playerScore01 += 1;
                break;
            case "leftWall":
                playerScore02 += 1;
                break;

            default:
                break;
        }
    

    }
    void OnGUI()
    {
        GUI.skin = skin;
        GUI.Label(new Rect(Screen.width / 2 - 150 - 12, 20, 100, 100), string.Format("{0}", playerScore01));
        GUI.Label(new Rect(Screen.width / 2 + 150 - 12, 20, 100, 100), string.Format("{0}", playerScore02));

    }
}
