using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class sceneSwitch : MonoBehaviour
{
    public void switchScene()
    {
        SceneManager.LoadScene(sceneName: "NotreDame_Main 1");
    }

    public void switchToPlay()
    {
        SceneManager.LoadScene(sceneName: "Build");
    }

    public void switchToFire()
    {
        SceneManager.LoadScene(sceneName: "Fire");
    }

    public void switchToLukasStory()
    {
        SceneManager.LoadScene(sceneName: "Story");
    }

    public void switchToTairStory()
    {
        SceneManager.LoadScene(sceneName: "StoryTair");
    }
}
