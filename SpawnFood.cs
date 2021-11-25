using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFood : MonoBehaviour
{
    //FoodPrefab
    public GameObject FoodPrefab;

    //Borders
    public Transform bottom_border;
    public Transform top_border;
    public Transform left_border;
    public Transform right_border;

    //Spawn Function
    public void spawn()
    {
        //x position initiation
        int x = (int)Random.Range(left_border.position.x, right_border.position.x);

        //y position initiation
        int y = (int)Random.Range(bottom_border.position.y, top_border.position.y);

        //Instantiate the food prefab at the above coordinates
        Instantiate(FoodPrefab,
            new Vector2(x, y),
            Quaternion.identity);
    }

    // Start is called before the first frame update
    void Start()
    {
        //Call the spawn() function every 3 seconds starting with 4
        InvokeRepeating("spawn", 4, 3);
    }
}
