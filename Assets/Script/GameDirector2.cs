using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector2 : MonoBehaviour
{
    public GameObject hpGaude;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DecreaseHp()
    {
        this.hpGaude.GetComponent<Image>().fillAmount -= 0.1f;       
    }
}
