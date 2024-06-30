using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicPotion : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool basicpotionn;
    public GameObject Base;

    
    void Start()
    {
        basicpotionn = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        basicpotionn = true;
        Debug.Log("Basic Potion Enter " + basicpotionn);
        Base.SetActive(false);
    }
}
