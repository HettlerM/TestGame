using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movment : MonoBehaviour
{
    private float speed = 15;
    // Start is called before the first frame update
 

    // Update is called once per frame
    void Update()
    {
        float x_move = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float y_move = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(x_move,y_move,0);
    }
}
