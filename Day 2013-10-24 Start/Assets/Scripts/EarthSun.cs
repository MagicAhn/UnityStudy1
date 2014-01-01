using UnityEngine;
using System.Collections;

public class EarthSun : MonoBehaviour
{

    private GameObject sun;
    private GameObject earth;

    // Use this for initialization
    void Start()
    {
        sun = GameObject.Find("Sun");
        earth = GameObject.Find("Earth");
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.RotateAround(sun.transform.position,Vector3.back,1);
        this.gameObject.transform.RotateAround(earth.transform.position,new Vector3(0.5f,1,0),0.5f);
    }
}
