using System.Collections;
using UnityEngine;

public class LoaderCallback : MonoBehaviour
{
    private bool isFirstUpdate = true;
    Coroutine waitCoroutine;

    private void Start()
    {
        waitCoroutine = StartCoroutine(WaitBeforeLoadScene());
    }

    public void LoadSceneNow()
    {
        if (isFirstUpdate)
        {
            isFirstUpdate = false;
            LevelLoader.LoaderCallback();
        }
    }

    private IEnumerator WaitBeforeLoadScene()
    {
        yield return new WaitForSeconds(1);

        LoadSceneNow();
    }
}