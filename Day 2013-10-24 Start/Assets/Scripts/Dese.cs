using UnityEditor;
using UnityEngine;
using System.Collections;

public class Dese : MonoBehaviour
{
    public Texture img;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKey(KeyCode.W))
	    {
	        this.gameObject.animation.Play("Walk");
	    }
	}
}
