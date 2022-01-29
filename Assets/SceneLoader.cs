using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;
using TMPro;

public class SceneLoader : MonoBehaviour
{
    public bool preloadAssets;
    public TextMeshProUGUI textArea;

	IEnumerator Start () 
    {
        if (preloadAssets)
        {
            AppendText("Preloading ScriptableObjects");
            var labelHandle = Addressables.LoadAssetsAsync<ScriptableObject>("preload", null);
            yield return labelHandle;
        }

        AppendText("Loading first Addressable scene");
		AsyncOperationHandle<SceneInstance> firstLoadHandle = Addressables.LoadSceneAsync("Assets/AddScene1.unity", LoadSceneMode.Additive);
        yield return firstLoadHandle;

        // Allow time to update the text area :)
        yield return null;

        AppendText("Unloading first Addressable scene");
        AsyncOperationHandle<SceneInstance> unloadHandle = Addressables.UnloadSceneAsync(firstLoadHandle);
        yield return unloadHandle;

        AppendText("Loading second Addressable scene");
		AsyncOperationHandle<SceneInstance> secondLoadHandle = Addressables.LoadSceneAsync("Assets/AddScene2.unity", LoadSceneMode.Additive);
        yield return secondLoadHandle;
    }

    public void AppendText(string text)
    {
        textArea.text += text + "\n\n";
    }
}