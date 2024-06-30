using UnityEngine;

public class EventSystem : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Puzzle1;
    public GameObject AlarmLOUD;
    public GameObject ItemsNotFound;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(AcidicPotion.acidpotionn & BasicPotion.basicpotionn){
            Puzzle1.SetActive(true);
            AlarmLOUD.SetActive(true);
            Debug.Log("Both Potion Found; Stage entered;");
        }   else {
            ItemsNotFound.SetActive(true);
        }
    }
    

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(AcidicPotion.acidpotionn & BasicPotion.basicpotionn){
            Debug.Log("Puzzle Exit");
            Puzzle1.SetActive(false);
            AlarmLOUD.SetActive(false);
        }   else {
            ItemsNotFound.SetActive(false);
        }

    }
}
