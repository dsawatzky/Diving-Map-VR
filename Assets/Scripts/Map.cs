using UnityEngine;
using System.Collections;

public class Map : MonoBehaviour
{

    public Texture2D image;
    public Renderer rend;
    public bool visible = false;


    // Use this for initialization
    void Start()
    {
        image = (Texture2D)Resources.Load("sound_guide");
        
    }

    void Update()
    {
		if (Input.GetKeyDown("joystick button 0") || Input.GetKeyDown("m") || Cardboard.SDK.Triggered==true)	{
            visible = !visible;
        } 

		if (Input.GetKeyDown("joystick button 1") || Input.GetKeyDown("r"))	{
			Cardboard.SDK.VRModeEnabled = !Cardboard.SDK.VRModeEnabled;
		}

		if (Input.GetKeyDown ("joystick button 2") || Input.GetKeyDown ("c")) {
			Cardboard.SDK.Recenter();
		}
	}

    void OnGUI()
    {
		if (visible == true) Graphics.DrawTexture(new Rect(200, 120, image.width / 2, image.height / 2), image);
    }
}
