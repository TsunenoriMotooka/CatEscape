using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController2 : MonoBehaviour
{
    Transform player;
    GameObject gameDirector;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-0.2f, 0, 0, Space.World);
        if (transform.position.x < -13.0f) {    
            Destroy(gameObject);
        }
        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;
        float r2 = 0.80f;
        if (d < r1 + r2) {
            Destroy(gameObject);
            this.gameDirector.GetComponent<GameDirector2>().DecreaseHp();
        }
    }

    public void SeetPlayer(Transform player)
    {
        this.player = player;
    }

    public void SetGameDirector(GameObject gameDirector)
    {
        this.gameDirector = gameDirector;
    }
}
