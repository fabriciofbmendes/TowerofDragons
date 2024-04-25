using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UIElements;

public class scr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float posx = transform.position.x;
        float posy = transform.position.y;
        if(Input.GetKeyDown(KeyCode.W)) {
            transform.position = new Vector2(posx, posy + 1);
        }
        if(Input.GetKeyDown(KeyCode.S)) {
            transform.position = new Vector2(posx, posy - 1);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position = new Vector2(posx - 1, posy);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position = new Vector2(posx + 1, posy);
        }
    }
}
