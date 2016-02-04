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
        if (Input.GetKeyDown("m"))
        {
            visible = !visible;
        }    
    }

    void OnGUI()
    {
		if (visible == false) Graphics.DrawTexture(new Rect(170, 80, image.width / 2, image.height / 2), image);
    }
}
