﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingTest : MonoBehaviour
{
    private Rigidbody2D rigidBody2D;
    public Vector3 shieldvelocity = new Vector3(5, 0,0);

    //a mettre dans le joueur
    [SerializeField] GameObject shieldPrefab;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
        rigidBody2D.velocity = shieldvelocity;
    }

    // Update is called once per frame
    void Update()
    {


        //transform.position += Time.deltaTime * shieldvelocity;
        //private void Collision
    }


}
