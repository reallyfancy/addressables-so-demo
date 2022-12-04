# Addressables/ScriptableObjects demo

If you store runtime state in an Addressable ScriptableObject, you must ensure that you always have at least one reference to the ScriptableObject at all times. This prevents the Addressables system from unloading/reloading the ScriptableObject, which can lead to data loss. This problem occurs most commonly when changing scenes.

This minimal Unity project demonstrates how to preload a single instance of an Addressable ScriptableObject and then keep a reference to it that persists between scene changes. This ensures that the ScriptableObject remains in memory throughout the lifetime of an application. 

You can test this by toggling the preloading on and off, and see the effect that this change has on the two Addressable scenes.

The project also shows how to explicitly assign an Addressable ScriptableObject to a common AssetBundle, and how to load that AssetBundle on startup via its label.

## Compatibility

Created with Unity 2021.2.0f1 and Addressables 1.19.17.

## Instructions

1. Build the Addressables for this project.
2. If you're testing this in the Editor, set the Addressables *Play mode* option to *Use Existing Build*.
3. Open the *Bootstrap* scene.
4. Select the *SceneLoader* GameObject. In its *SceneLoader* component, ensure that *Preload Assets* is checked.
5. Enter Play Mode, or Build and Run the project.
6. Observe the text on the screen; this demonstrates that the two separate scenes reference the same instance.
7. Return to Edit Mode.
8. Select the *SceneLoader* GameObject. In its *SceneLoader* component, uncheck *Preload Assets*.
9. Enter Play Mode, or Build and Run the project.
10. Observe the text on the screen; this demonstrates that the two separate scenes reference separate instances.
