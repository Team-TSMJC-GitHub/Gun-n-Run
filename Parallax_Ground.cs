using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax_Ground : MonoBehaviour {

    public float backroundSize;

    private Transform camerTransform;
    private Transform[] layers;
    private float viewZone = 10;
    private int leftIndex;
    private int rightIndex;

    //private Vector3 GroundY;


    // Use this for initialization
    private void Start()
    {
        camerTransform = Camera.main.transform;
        layers = new Transform[transform.childCount];


        for (int i = 0; i < transform.childCount; i++)
            layers[i] = transform.GetChild(i);


        leftIndex = 0;
        rightIndex = layers.Length - 1;
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
            ScrollLeft();

        if (Input.GetKeyDown(KeyCode.D))
            ScrollRigth();
        /* if (camerTransform.position.x < layers[leftIndex].transform.position.x + viewZone)
             ScrollLeft();
         if (camerTransform.position.x < layers[leftIndex].transform.position.x + viewZone)
             ScrollRigth();
         */

    }

    private void ScrollLeft()
    {
        int lastRight = rightIndex;
        layers[rightIndex].position = new Vector3(layers[leftIndex].position.x - backroundSize, -8.71347f, 0);
        leftIndex = rightIndex;
        rightIndex--;
        if (rightIndex < 0)

            rightIndex = layers.Length - 1;

    }

    private void ScrollRigth()
    {
        int lastLeft = leftIndex;
        layers[leftIndex].position = new Vector3(layers[rightIndex].position.x + backroundSize, -8.71347f, 0);
        rightIndex = leftIndex;
        leftIndex++;
        if (leftIndex == layers.Length)
            leftIndex = 0;

    }

}

