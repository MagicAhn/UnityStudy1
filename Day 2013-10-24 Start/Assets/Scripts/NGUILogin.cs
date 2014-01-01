using UnityEngine;
using System.Collections;

public class NGUILogin : MonoBehaviour
{

    public UIInput txtusername;
    public UIInput txtpwd;
    public UILabel msg;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnClick()
    {
        if (txtusername.text.Equals("Ahn") && txtpwd.text.Equals("Love Feng"))
        {
            msg.text = "Wakaka";
        }
        else
        {
            msg.text = "Ahn Love Feng";
        }
    }
}
