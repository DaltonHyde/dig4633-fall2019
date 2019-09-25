using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamerManager : MonoBehaviour
{
    public bool hatRestored = false;

    public bool armRestored = false;

    public bool armRestoredTwo = false;

    public GameObject finishText;


    public void checkForVictory()
    {
        if (hatRestored && armRestored && armRestoredTwo)
        {
          Debug.Log("Dalton is perplexed");
            finishText.SetActive(true); 
        }
    }
    public void hatWasRestored()
    {
        this.hatRestored = true;
        checkForVictory();
           
    }

    public void armWasRestored()
    {
        this.armRestored = true;
        checkForVictory();
    }

    public void armTwoWasRestored()
    {
        this.armRestoredTwo = true;
        checkForVictory();

    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
