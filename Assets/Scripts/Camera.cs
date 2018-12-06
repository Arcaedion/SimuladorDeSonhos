using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

    public Transform objetoAlvo;
	
	void Update () {
        transform.position = objetoAlvo.position;	
	}
}
