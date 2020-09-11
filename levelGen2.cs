﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelGen2 : MonoBehaviour
{
    public Transform[] startingPositions;
    public GameObject[] rooms;
    
    

    public float moveAmountx;
    public float moveAmounty;
    private int direction;
    

    private float timeBtwRoom;
    public float startTimeBtwRoom = .25f;

    public float minX;
    public float maxX;
    public float minY;
    public bool stopGeneration;

    private void Start()
    {
        int randStartingPos = Random.Range(1, startingPositions.Length);
        transform.position = startingPositions[randStartingPos].position;
        Instantiate(rooms[0], transform.position, Quaternion.identity);
        direction = Random.Range(1, 6);
    }
    private void Update()
    {
        
        if (timeBtwRoom <= 0 && stopGeneration == false)
        {
            
            Move();
            
            timeBtwRoom = startTimeBtwRoom;

        }
        else
        {
            
            timeBtwRoom -= Time.deltaTime;
        }
       

    }


    private void Move()
    {

        if (direction == 1 || direction == 2)
        {
            if (transform.position.x < maxX)
            {
                Vector2 newPos = new Vector2(transform.position.x + moveAmountx, transform.position.y);
                transform.position = newPos;

                direction = Random.Range(1, 6);


                if (direction == 3)
                {
                    direction = 2;
                }
                else if (direction == 4)
                {
                    direction = 5;
                }
            }
            else
            {
                direction = 5;
            }
        }
        else if (direction == 3 || direction == 4)
        {
            if (transform.position.x > minX)
            {
                Vector2 newPos = new Vector2(transform.position.x - moveAmountx, transform.position.y);
                transform.position = newPos;

                direction = Random.Range(3, 6);

            }
            else
            {
                direction = 5;
            }
        }
        else if (direction == 5)
        {
            if (transform.position.y < minY)
            {
                Vector2 newPos = new Vector2(transform.position.x, transform.position.y + moveAmounty);
                transform.position = newPos;


                direction = Random.Range(1, 6);
            }
            else
            {
                Instantiate(rooms[1], transform.position, Quaternion.identity);
                stopGeneration = true;
            }
        }

    } 
}
    


