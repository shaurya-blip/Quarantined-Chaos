using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalGate : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Puzzle2;
    public GameObject AlarmLOUD;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Puzzle2.SetActive(true);
        AlarmLOUD.SetActive(true);
    }
    

    private void OnTriggerExit2D(Collider2D collision)
    {
        Puzzle2.SetActive(false);
        AlarmLOUD.SetActive(false);
    }
}
