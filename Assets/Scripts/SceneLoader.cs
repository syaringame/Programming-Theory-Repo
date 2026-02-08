using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void TitleSceneStart()
    {
        SceneManager.LoadScene(0);
    }

    public void EncapsulationSceneStart()
    {
        SceneManager.LoadScene(1);
    }

    public void InheritanceSceneStart()
    {
        SceneManager.LoadScene(2);
    }

    public void PolymorphismSceneStart()
    {
        SceneManager.LoadScene(3);
    }

    public void AbstractionSceneStart()
    {
        SceneManager.LoadScene(4);
    }

    public void ExitGame()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }

}
