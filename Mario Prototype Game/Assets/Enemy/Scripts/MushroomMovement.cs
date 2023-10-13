using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomMovement : Enemy
{
    //Purpose of this class is for the Mushroom enemies to have back and forth movement via linear interpolation

    //Target and current position can be defined from editor

    [SerializeField]
    private Transform TargetPosition; 

    [SerializeField]
    private Transform CurrentPosition;

    private Transform Aposition; // Reference point for current position
    private Transform Bposition;// Reference point for target position

    [SerializeField]
    private float moveSpeed;

    private float elapsedTime = 0.0f;
    

    void Start()
    {
        Aposition = CurrentPosition;
        Bposition = TargetPosition;

        transform.position = CurrentPosition.position;
    }

    // Update is called once per frame
    void Update()
    {
        /* Given the condition a gameobject or 
          the Goombas will interpolate from one point 
              to another
         */
        if (transform.position != Bposition.position) 
        {
            elapsedTime += Time.deltaTime * moveSpeed;
            elapsedTime = Mathf.Clamp(elapsedTime, 0, Mathf.PI); // Get a value between zero and PI
            float time = evaluate(elapsedTime);

            transform.position = Vector3.Lerp(Aposition.position, Bposition.position, time);
        }

        swap();
    }

    public void swap()
    {
        //Swaps the positions for back and forth interpolation 
        //Resets all the values

        if (transform.position != Bposition.position)
        {
            return;
        }

        Transform temp = Aposition;
        Aposition = Bposition;
        Bposition = temp;
        elapsedTime = 0;

    }


    public float evaluate(float x) // sinusoidal function for linear interpolation
    {
        //Since the values are between 0 and PI, the return values will be between zero and one
        return 0.5f * Mathf.Sin(x - Mathf.PI / 2f) + 0.5f; 
    }
}
