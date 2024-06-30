using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcidicPotion : MonoBehaviour
{
    // Start is called before the first frame update    
    public static bool acidpotionn;
    public GameObject Acid;

    void Start()
    {
        acidpotionn = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        acidpotionn = true;
        Debug.Log("Acidic Potion Enter" + acidpotionn);
        Acid.SetActive(false);
    }
}
