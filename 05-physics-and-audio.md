# Playing with rays

* FallingCoconut: Transform GvrEditorEmulator so you can see chest
* FallingCoconut: Add chest /UdacityVR/Art/Prefabs/Objects/Chest
* FallingCoconut: Remove original chest (can't be openned)
* Chest: add box colider
* Camera: add script DetectTreasure
* Read: https://docs.unity3d.com/ScriptReference/Physics.Raycast.html
* DetectTreasure: add FixedUpdate from the raycast reference

# Adding an open chest animation

* Chest.Lid: add OpenChest script
* Read: https://docs.unity3d.com/ScriptReference/Transform-rotation.html
* Chest.Lid: add EventTrigger, add PointerClick wire up

# Create a list

* Project: Add AudioPicker script
* Scene: Add AudioSource
* AudioSource: add AudioPicker, wire-up

# Pick a song

* Read: https://docs.unity3d.com/ScriptReference/Random.Range.html
* AudioSource: update start() to pick a song

