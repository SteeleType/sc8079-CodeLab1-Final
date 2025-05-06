using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneManagers : MonoBehaviour
{
    public string sceneName;
    
    public void ManageScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
