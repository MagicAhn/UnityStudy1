using UnityEngine;
using System.Collections;

public class CubeMove : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.gameObject.transform.Rotate(Vector3.right, Time.deltaTime * 10);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.gameObject.transform.Rotate(Vector3.left, Time.deltaTime * 10);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.gameObject.transform.Rotate(Vector3.up, Time.deltaTime * 10);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.gameObject.transform.Rotate(Vector3.down, Time.deltaTime * 10);
        }
        if (Input.GetKey(KeyCode.W))
        {
            this.gameObject.transform.Translate(Vector3.forward);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.gameObject.transform.Translate(Vector3.left);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.gameObject.transform.Translate(Vector3.back);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.gameObject.transform.Translate(Vector3.right);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            this.gameObject.transform.Translate(Vector3.up);
        }
    }
}
