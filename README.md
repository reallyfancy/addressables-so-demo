# Addressables/ScriptableObjects demo

This is a minimal demonstration of the principles of keeping a persistent, shared instance of a ScriptableObject in memory across multiple scenes when using Addressables.

Instructions:

* Build the Addressables for this project.
* If you're testing this in the Editor, set the Addressables *Play mode* option to *Use Existing Build*.
* Open the *Bootstrap* scene.
* Select the *SceneLoader* GameObject. In its *SceneLoader* component, ensure that *Preload Assets* is checked.
* Enter Play Mode, or Build and Run the project.
* Observe the text on the screen; this demonstrates that the two separate scenes reference the same instance.
* Return to Edit Mode.
* Select the *SceneLoader* GameObject. In its *SceneLoader* component, uncheck *Preload Assets*.
* Enter Play Mode, or Build and Run the project.
* Observe the text on the screen; this demonstrates that the two separate scenes reference separate instances.
