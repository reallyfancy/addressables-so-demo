# Addressables/ScriptableObjects demo

This is a minimal demonstration of the principles of keeping a persistent, shared instance of a ScriptableObject in memory across multiple scenes when using Addressables.

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
