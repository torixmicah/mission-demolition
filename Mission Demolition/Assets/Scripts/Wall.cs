using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public bool hasCollided = false;
    private void OnCollisionEnter(Collision collision)
    {
        GameObject collidedWith = collision.gameObject;
        if (collidedWith.tag == "Ground" && !hasCollided)
        {
            ScoreSystem.S.totalScore += 25;
            hasCollided = true;
        }
    }
}
