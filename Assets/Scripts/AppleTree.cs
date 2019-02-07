using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour {

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
	}
	
	
	void Update () {
        // Basic Movement
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        // Changing Direction
	}
}
