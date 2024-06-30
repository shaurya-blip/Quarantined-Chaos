
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Puzzle2 : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Dropdown dropdown1;
    public TMP_Dropdown dropdown2;
    public TMP_Dropdown dropdown3;
    public TMP_Dropdown dropdown4;
    public Text textComp;
    public GameObject buttonrestart;
    string s="Enter Code!";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float value1 = dropdown1.value;
        float value2 = dropdown2.value;
        float value3 = dropdown3.value;
        float value4 = dropdown4.value;
        DetermineCorrect(value1, value2, value3, value4);
        textComp.text = s;
    }

    void DetermineCorrect(float val1, float val2, float val3, float val4){
        if (val1 == 7 & val2== 12 & val3 == 1 & val4 == 5) {
            s = "CONGRATULATIONS! YOU HAVE OBTAINED THE ANTIDOTE!";
            buttonrestart.SetActive(true);
        } else {
            s = "INCORRECT CODE";
            buttonrestart.SetActive(false);
        }
    }
}
