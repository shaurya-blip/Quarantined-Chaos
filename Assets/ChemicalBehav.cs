
using UnityEngine;

public class ChemicalBehav : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject BasicPotion;
    public GameObject AcidicPotion;
    public GameObject Puzzle1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Puzzle Enter");
        Puzzle1.SetActive(true);

    }
    

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Puzzle Exit");
        Puzzle1.SetActive(false);
    }
}
