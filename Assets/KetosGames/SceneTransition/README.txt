Scene Transition

This is to be used to smoothly transition between scenes with an optional loading screen in between.

------------------------------------
Loading a Scene
------------------------------------
1. Open or create a script that you want to load another scene with.
2. Add a using statement to the top of your script: using KetosGames.SceneTransition;
3. Where you want to load your scene, call: SceneLoader.LoadScene('NameOfSceneToGoTo');
   or find SceneManager.LoadScene and replace with SceneLoader.LoadScene.
   (For single line execution: KetosGames.SceneTransition.SceneLoader.LoadScene('NameOfSceneToGoTo');)

The SceneLoader prefab will automatically be added to your scene and the transition will take place.

See Assets\KetosGames\SceneTransition\Scripts\ChangeSceneFromClick.cs for an example.

To customize your transition, edit the prefab settings or the assets within the prefab:
Assets\KetosGames\SceneTransition\Resources\KetosGames\SceneTransition\Prefabs\

------------------------------------
VR Support
------------------------------------
If you are using this asset for VR:
1. Check the VR Support checkbox on the SceneLoader prefab.

When transitioning, it will use a camera filter to create the fade effect instead of using a canvas. In VR Mode, you leave it as a solid color or use a loading scene. You cannot use the loading UI as that is for a ui canvas.
The example scenes can be used to test VR, but you will need to update them for your VR setup first. For Steam VR, I found this tutorial helpful: https://unity3d.college/2017/06/17/steamvr-laser-pointer-menus/
If you do not need VR support, it's better to leave this setting off.

This asset now supports VR in the Universal Rendering Pipeline (URP) for Unity 2019.1 and up.
If you switch your project to or from URP, you will need to restart Unity so that the proper #define symbols can be set.

------------------------------------
Two options for a loading screen
------------------------------------
1. A Loading Scene
2. A Loading UI (Not available with VR)

------------------------------------
A Loading Scene
------------------------------------
To use this mode:
1. Add Assets\KetosGames\SceneTransition\Scenes\Loading scene to your build settings.
2. Select the SceneLoader Prefab
3. Check the 'Use Scene For Loading Screen' checkbox.

During load, a scene will be used to show the loading screen.
This is useful if you want to show 3D objects during loading.
In order for this to work, the Loading scene will need to be added to the Build Settings.
Feel free to modify the Loading scene to your liking.

------------------------------------
A Loading UI (Not available with VR)
------------------------------------
To use this mode:
1. Select the SceneLoader Prefab and . 
2. Uncheck the 'Use Scene For Loading Screen' checkbox

A Loading UI will keep the current scene loaded until the next scene is ready.
This has the added benefit that the new scene can begin loading immediately during the first fade out.
No need to Loading scene to the Build Settings as it will not be used in this mode.

------------------------------------
SceneLoader Prefab Settings
------------------------------------
Use Scene For Loading Screen - When checked, use the Loading scene as the Loading screen (instead of the Loading UI).
Loading Scene Name - The name of the Loading scene to load.
Fade In Loading Screen - When checked,  fade in the loading screen.
Fade Out Loading Screen - When checked, fade out the loading screen.
Fade Seconds - The number of seconds to show the loading screen after fade in. Set it to 0 to go to the new scene as soon as it's ready.
Fade Color - The color to use in the fade animation.

------------------------------------
Loading Progress
------------------------------------
You can also show progress on your loading screen or scene (progress bar or percent) by using SceneLoader.Instance.Progress in your update function.
This will be a float from 0 to 1. If you wanted percent, it would be Mathf.Floor(SceneLoader.Instance.Progress * 100) + "%".
Note that the progress only works in builds. It will not work correctly in the editor (Last checked in Unity 2017.4).
See Assets\KetosGames\SceneTransition\Scripts\LoadingBar.cs for an example of using progress.

------------------------------------
Tips
------------------------------------
1. If the loading bar seems to complete all at once, try loading a bigger scene and run it from a build instead of the editor.
2. If you would like to change the Loading UI graphics, navigate to Assets\KetosGames\SceneTransition\Resources\KetosGames\SceneTransition\Prefabs and drag the SceneLoader prefab in to a scene so that you can see the child components. Inside the Loading Screen GameObject, you will see Spinner and Loading Text. You can replace those, or change them however you like. Then just save the prefab back by dragging from the scene back to the SceneLoader prefab. Then you can delete the SceneLoader in your scene.
3. If you would like the game to start with a fade in, simply add the SceneLoader prefab (Assets\Resources\Ketos Games\Scene Transition\SceneLoader) to the first scene.
4. If you would like to see it in action, add Scene 1 and Scene 2 to the Build Settings, start one of the scenes and try it out.
5. If you don't really want a loading screen at all, set 'Minimum Loading Screen Seconds' to 0, set 'Use Scene For Loading Screen' to unchecked, set the background of the Loading Sceen in the Scene Loader Prefab to match the Fade Color and remove all the UI elements under the Loading Screen in the SceneLoader Prefab.

------------------------------------
The essential components included
------------------------------------
Assets\KetosGames\SceneTransition\Scenes\Loading         (If using the Loading Scene)
Assets\KetosGames\SceneTransition\Scripts\LoadingText    (If used in the Loading Screen)
Assets\KetosGames\SceneTransition\Scripts\LoadingSpinner (If used in the Loading Screen)
Assets\KetosGames\SceneTransition\Scripts\SceneLoader
Assets\KetosGames\SceneTransition\Images\LoadingStar     (If used in the Loading Screen)
Assets\KetosGames\SceneTransition\Resources\KetosGames\SceneTransition\Prefabs\SceneLoader