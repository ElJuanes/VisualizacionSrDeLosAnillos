using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Campos para asignar las escenas desde el Inspector
    public string sceneOne;
    public string sceneTwo;
    public string sceneThree;
    public void ChangeToSceneOne()
    {
        SceneManager.LoadScene("SceneOne");
    }

    public void ChangeToSceneTwo()
    {
        SceneManager.LoadScene("SceneTwo");
    }

    public void ChangeToSceneThree()
    {
        SceneManager.LoadScene("SceneThree");
    }
}