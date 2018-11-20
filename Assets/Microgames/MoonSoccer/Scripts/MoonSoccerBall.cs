﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonSoccerBall : MonoBehaviour {
    
    [Header("Movement Speed")]
    [SerializeField]
    private float moveSpeed = 1f;

    
	// Update is called once per frame
	void Update () {
		if (gameObject.activeSelf)
        {
            // Move to the right at the set movement speed
            transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);
            if (transform.position.x >= 7) {
                MicrogameController.instance.setVictory(victory: true, final: true);
                Destroy(gameObject);
            }
        }
    
	}
    
    // Make this object active and set it's starting position
    public void activate (Vector2 position) 
    {
        transform.position = position;
        transform.position = new Vector2(transform.position.x + 1.2f, transform.position.y - 1);
        gameObject.SetActive(true);
    }
}
