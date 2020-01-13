using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void scenloader (int scennumber)
    
    {
        SceneManager.LoadScene(scennumber);
    }
   
   
}