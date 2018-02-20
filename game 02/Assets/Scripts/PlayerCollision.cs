﻿using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public Playermovement movement;
     
    
    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;

            FindObjectOfType<GameManager1>().EndGame();
        }    
                
                 }

}
