using System;
using UnityEngine;
using System.Collections;

public class GUITest : MonoBehaviour
{
    private String username = String.Empty;
    private String pwd;
    public Texture2D btnImg;
    private Boolean btnClick;
    private Int32 toolbarIndex;

    private GameObject cube;
    private Rect rect;

    // Use this for initialization
    void Start()
    {
        pwd = String.Empty;
        btnClick = false;
        toolbarIndex = 0;

        cube = GameObject.Find("Cube");
        rect = new Rect(100, 100, 200, 50);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnGUI()
    {
        #region Basic
        ////0.1f
        //GUILayout.Label("Hello Unity", GUILayout.Width(100));

        //GUILayout.BeginHorizontal();
        //username = GUILayout.TextField(username, GUILayout.Width(100));
        ////Debug.Log(username);
        //pwd = pwd = GUILayout.PasswordField(pwd, '@');
        //GUILayout.EndHorizontal();
        //if (GUILayout.Button(btnImg, GUILayout.Height(btnImg.height), GUILayout.Width(btnImg.width)))
        //{
        //    btnClick = true;
        //}
        //if (btnClick)
        //{
        //    GUILayout.Label("btn click", GUILayout.Width(100));
        //}
        //toolbarIndex = GUILayout.Toolbar(toolbarIndex, new string[] { "Ahn", "Love", "Feng" }); 
        #endregion

        #region Button RepeatButton
        //if (GUILayout.Button("Button"))
        //{
        //    cube.transform.Translate(new Vector3(1,1,1));
        //}
        //if (GUILayout.RepeatButton("RepeatButton"))
        //{
        //    cube.transform.Translate(new Vector3(1,1,1));
        //} 
        #endregion

        #region Basic2
        //if (!btnClick)
        //{
        //    GUILayout.BeginHorizontal();
        //    GUILayout.Label("username");
        //    username = GUILayout.TextField(username, GUILayout.Width(100));
        //    GUILayout.EndHorizontal();
        //    GUILayout.BeginHorizontal();
        //    GUILayout.Label("password");
        //    pwd = GUILayout.PasswordField(pwd, '*',GUILayout.Width(100));
        //    GUILayout.EndHorizontal();
        //    if (GUILayout.Button("Login", GUILayout.Width(100)))
        //    {
        //        btnClick = true;
        //    }
        //}
        //if (btnClick)
        //{
        //    if (username.Equals("Ahn") && pwd.Equals("Feng"))
        //    {
        //        GUILayout.Label("Welcome, Ahn love Feng", GUILayout.Width(300));
        //    }
        //    else
        //    {
        //        GUILayout.Label("Wakaka, Ahn love Feng", GUILayout.Width(300));
        //        if (GUILayout.Button("Login", GUILayout.Width(100)))
        //        {
        //            btnClick = false;
        //        }
        //    }
        //} 
        #endregion

        #region Area
        //GUILayout.BeginArea(new Rect((Screen.width - 100) / 2, (Screen.height - 100) / 2, 100, 100));

        //GUILayout.Label("AhnLoveFeng");

        //GUILayout.EndArea(); 
        #endregion

        #region window
        //if (!btnClick)
        //{
        //    GUILayout.Window(0, new Rect(100, 100, 200, 50), WinShow, "Show Love");
        //}

        //if (!btnClick)
        //{
        //    GUILayout.Window(0, new Rect(100, 100, 200, 50), (i) =>
        //    {
        //        GUILayout.Label("Ahn Love Feng");
        //        if (GUILayout.Button("Wakaka", GUILayout.Width(100)))
        //        {
        //            btnClick = true;
        //        }
        //    }, "Show Love");
        //}

        //if (GUILayout.Button("ShowLove"))
        //{
        //    btnClick = true;
        //}
        //if (btnClick)
        //{
        //    rect = GUILayout.Window(0, rect, (i) =>
        //     {
        //         GUILayout.Label("Ahn Love Feng");
        //         if (GUILayout.Button("Wakaka", GUILayout.Width(100)))
        //         {
        //             btnClick = false;
        //         }
        //         GUI.DragWindow();
        //     }, "Show Love");
        //} 
        #endregion
        #region Texture

        //GUI.DrawTexture(rect,btnImg);
        //var snoopy = Resources.Load("snoopy") as Texture2D;
        //GUI.DrawTexture(new Rect(100,100,100,100),snoopy ); 
        #endregion
    }

    void WinShow(Int32 id)
    {
        GUILayout.Label("Ahn Love Feng");
        if (GUILayout.Button("Wakaka", GUILayout.Width(100)))
        {
            btnClick = true;
        }
        GUI.DragWindow();
    }
}
