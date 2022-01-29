using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptableObjectUser : MonoBehaviour
{
    public ExampleScriptableObject referenceToScriptableObject;
    public string exampleData;

    void Start () 
    {
        var oldData = referenceToScriptableObject.exampleData;
        referenceToScriptableObject.exampleData = exampleData;

        var sceneLoader = (SceneLoader)FindObjectOfType(typeof(SceneLoader));

		sceneLoader.AppendText("ScriptableObject instance ID is " + referenceToScriptableObject.GetInstanceID() + ", old data was '" + oldData + "', new data is '" + referenceToScriptableObject.exampleData + "'");
    }
}
