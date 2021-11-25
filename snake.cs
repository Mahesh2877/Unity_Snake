using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class snake : MonoBehaviour
{

    //Current Movement direction will be set to Right
    Vector2 dir = Vector2.right;
    // Start is called before the first frame update
    void Start()
    {
        //originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        
        //Move the snake every 300 milliseconds
        InvokeRepeating("move", 0.3f, 0.3f);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
            dir = Vector2.right;
        else if (Input.GetKey(KeyCode.LeftArrow))
            dir = -Vector2.right;
        else if (Input.GetKey(KeyCode.DownArrow))
            dir = -Vector2.up;
        else if (Input.GetKey(KeyCode.UpArrow))
            dir = Vector2.up;
    }

    //Move the Snake in the appropriate direction
    void move()
    {
        //Move the snake's head into the right direction
        transform.Translate(dir);
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.name.StartsWith("FoodPrefab"))
        {
            Destroy(coll.gameObject);
            
        }
        else
        {
            this.gameObject.transform.position = new Vector2(0.4f, -8.3f);
        }
    }
}
