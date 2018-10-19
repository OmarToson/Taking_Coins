using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject player;

    private Vector3 offset;

	// Use this for initialization
	void Start () {
        offset = transform.position - player.transform.position; //distance between camera and player
	}
	
	// Update is called once per frame
	void LateUpdate () {   //runs every frame like update
        transform.position = player.transform.position + offset;  // player position + distance
	}
    //in unity we press on camera --> cameracontroller --> drag player and drop on player in cameracontroller

}
