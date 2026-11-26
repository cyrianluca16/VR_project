using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadProgramScene : MonoBehaviour
{
    const string PROGRAM_SCENE = "ProgramScene";
    void Start()
    {
        Scene programScene = SceneManager.GetSceneByName(PROGRAM_SCENE);
        if (!programScene.IsValid())
            SceneManager.LoadScene(PROGRAM_SCENE, LoadSceneMode.Additive);
    }
}
