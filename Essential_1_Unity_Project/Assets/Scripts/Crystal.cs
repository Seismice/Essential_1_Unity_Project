using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crystal : MonoBehaviour
{
    [SerializeField] private Ground _ground;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Crystal");
        if (collision.gameObject.name == "CharacterRobotBoy")
            Destroy(gameObject);
    }
}
