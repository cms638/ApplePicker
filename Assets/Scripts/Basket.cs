using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Basket : MonoBehaviour {
    [Header("Set Dynamically")]
    public Text scoreGT;

    void Start()
    {
        GameObject scoreGO = GameObject.Find("ScoreCounter");
        scoreGT = scoreGO.GetComponent<Text>();
        scoreGT.text = "0";
    }

    // Update is called once per frame
	void Update () {
        // gets x and y from mouse
        Vector3 mousePos2D = Input.mousePosition;
        //gets the z position from main camera
        mousePos2D.z = -Camera.main.transform.position.z;
        //makes it a point within the game space
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);
        //where am i 
        Vector3 pos = this.transform.position;
        //where on x axis
        pos.x = mousePos3D.x;
        //move 
        this.transform.position = pos;
	}

    private void OnCollisionEnter(Collision coll)
    {
        // Find out what hit this basket
        GameObject collidedWith = coll.gameObject;
        if (collidedWith.tag == "Apple") {
            Destroy(collidedWith);
            int score = int.Parse(scoreGT.text);
            score += 100;
            scoreGT.text = score.ToString();
            if (score > HighScore.score) {
                HighScore.score = score;
            }
        }
    }
}
