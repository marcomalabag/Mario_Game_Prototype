using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomMovement : Enemy
{
    // Start is called before the first frame update
    [SerializeField]
    private Transform TargetPosition;

    [SerializeField]
    private Transform CurrentPosition;

    private Transform Aposition;
    private Transform Bposition;

    [SerializeField]
    private float duration;

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
        if(transform.position != Bposition.position)
        {
            elapsedTime += Time.deltaTime * moveSpeed;
            elapsedTime = Mathf.Clamp(elapsedTime, 0, Mathf.PI);
            float time = evaluate(elapsedTime);

            transform.position = Vector3.Lerp(Aposition.position, Bposition.position, time);
        }

        swap();
    }

    public void swap()
    {
        

    }


    public float evaluate(float x) // sinusoidal function for linear interpolation
    {
        return 0.5f * Mathf.Sin(x - Mathf.PI / 2f) + 0.5f;
    }
}
