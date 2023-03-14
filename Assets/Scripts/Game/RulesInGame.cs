using UnityEngine;
using UnityEngine.SceneManagement;

public class RulesInGame : MonoBehaviour
{
    public void GoToTutorial()
    {
        SceneManager.LoadScene(0);
    }
}
