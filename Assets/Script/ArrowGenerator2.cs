using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator2 : MonoBehaviour
{
    public Transform player;
    public GameObject arrowPrefab;
    public GameObject gameDirector;
    
    float span = 1.0f;
    float delta = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime; // sec/frame 
        if (this.delta > this.span) {
            this.delta = 0;
            GameObject go = Instantiate(arrowPrefab);
            int py = Random.Range(-4, 5);
            go.transform.position = new Vector3(13, py, 0);
            go.GetComponent<ArrowController2>().SeetPlayer(player);
            go.GetComponent<ArrowController2>().SetGameDirector(gameDirector);
        }    
    }
}
