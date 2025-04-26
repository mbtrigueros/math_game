using UnityEngine;
using System.Collections;
using UnityEngine.UI;

// A very simplistic car driving on the x-z plane.

public class DriveAlt : MonoBehaviour
{
    float speed = 5;

    Vector3 direction;
    float stoppingDistance = 0.1f;
    public GameObject fuel;

    void Start()
    {
        direction = fuel.transform.position - this.transform.position;
        Coords dirNormal = CustomMath.GetNormal(new Coords(direction));
        direction = dirNormal.ToVector();
    }
    void Update()
    {
        if (CustomMath.Distance(new Coords(this.transform.position), new Coords(fuel.transform.position)) > stoppingDistance)
        {

            this.transform.position += direction * speed * Time.deltaTime;
        }



    }
}