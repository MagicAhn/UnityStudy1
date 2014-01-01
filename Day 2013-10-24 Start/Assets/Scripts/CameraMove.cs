using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
	    GameObject gameObj = GameObject.CreatePrimitive(PrimitiveType.Sphere);
	    gameObj.name = "GameObj";
        gameObj.renderer.material.color = Color.red;
        gameObj.transform.position = new Vector3(2,2,2);
        Destroy(gameObj,2);

	    GameObject q7= GameObject.Find("Cube");
	    GameObject q71 = (GameObject)Instantiate(q7);
        q71.transform.position=new Vector3(4,4,0);
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetMouseButtonDown(0))
	    {
	        this.gameObject.transform.Translate(Vector3.forward);
	    }
	    if (Input.GetMouseButtonUp(0))
	    {
	        this.gameObject.transform.Translate(Vector3.back);
	    }

	    if (Input.GetKeyDown(KeyCode.UpArrow))
	    {
	        this.gameObject.transform.Rotate(Vector3.left);
	    }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            this.gameObject.transform.Rotate(Vector3.right);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.gameObject.transform.Rotate(Vector3.up);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            this.gameObject.transform.Rotate(Vector3.down);
        }
	}
}
