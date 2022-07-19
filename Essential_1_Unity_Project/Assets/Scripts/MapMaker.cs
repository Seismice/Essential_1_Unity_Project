using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMaker : MonoBehaviour
{
    const float SIZEW = 2.1f;
    const float SIZEH = 0.55f;

    [SerializeField] private GameObject GroundPrefab;

    [SerializeField] private int Width = 10;
    [SerializeField] private int Height = 10;

    void Start()
    {
        for (int i = 0; i < Width; i++)
        {
            for (int j = 0; j < Height; j++)
            {
                Vector2 pos = new Vector2(i * SIZEW, j * SIZEH);
                //Vector2 pos = new Vector2(i, j);
                if (j % 2 == 0)
                {
                 pos.x += SIZEW / 2;
                }

                GameObject ground = Instantiate(GroundPrefab, pos, Quaternion.identity);
            }
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            
            if(hit)
            {
                Debug.Log(hit.collider.name);
                hit.collider.GetComponent<SpriteRenderer>().color = Color.blue;
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit)
            {
                Debug.Log(hit.collider.name);
                hit.collider.GetComponent<SpriteRenderer>().color = Color.red;
            }
        }
    }
}
