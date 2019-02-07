using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour {
    [Header("Set in Inspector")]
    public GameObject applePrefab;

    //speed in which tree moves
    public float speed = 1f;

    //distance tree moves around
    public float leftAndRightEdge = 20f;

    //Chance tree change direction
    public float chancetoChangeDirections = 0.1f;

    //Rate between apples
    public float secondsBetweenAppleDrops = 1f;
	
	void Start () {
        //dropping apples every second
        Invoke("DropApple", 2f);
	}

    void DropApple() {
        GameObject apple = Instantiate<GameObject>(applePrefab);
        apple.transform.position = transform.position;
        Invoke("DropApple", secondsBetweenAppleDrops);
    }
	
	
	void Update () {
        // Basic Movement
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        // Changing Direction
        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed); //Move Right
        }
        else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed); //Move Left
        }
	}

    void FixedUpdate()
    {
        if (Random.value < chancetoChangeDirections)
        {
            speed *= -1; //Change direction
        }
    }
}
