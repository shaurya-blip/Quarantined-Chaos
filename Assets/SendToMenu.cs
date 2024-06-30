
using UnityEngine;
using UnityEngine.SceneManagement;

public class SendToMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void SendToMenuf(){
        SceneManager.LoadSceneAsync(0);
    }
}
