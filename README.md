# VRSampleCode
This is sample code created for a VR development with Unity course at New College of Florida. The intention of this code is to demonstrate the basics of building a VR project in Unity using the new Meta XR SDKs and demonstrate the capabilities of the building blocks (such as grab interactions and camera rig) with a few extra basic Unity features (such as switching scenes and a day/night cycle). 


## PROJECT OVERVIEW
See a short playthrough of this project [here](https://drive.google.com/file/d/1UG5XNriw43X-S13GNOyyzoujjEL2yyU0/view?usp=sharing).

When you play through this project you can expect 3 scenes. In each scene, there is a point counter that increases every time you grab/trigger grab an object. Once you reach 5 points (first scene) or 10 points (second scene) you will transport to the next scene. Each scene also has instructions on a world space canvas on one of the walls.

- In the first scene, you can grab objects using either grab button on the sides of the controllers. There will be some objects that have physics (fall and roll around when you drop them) and objects without physics (stay floating after you let go). 
- In the second scene, you can grab objects, once close enough to them, with the trigger press button on the back of either controller. 
- In the third scene, you can compare normal movement with teleportation movement:
	- With the left joystick, you can use the normal sliding movement.
	- With the right joystick, you can use the teleportation ray to move. 


## MODIFYING MOVEMENT
If you want to modify movement, here are a few separate ways to get started.

### SWITCHING BETWEEN TELEPORTATION/SLIDING MOVEMENT
- Navigate to the camera rig in your scene (likely [BuildingBlock] Camera Rig).
- Then go to its children, and find "[BuildingBlock] OVRInteractionComprehensive" (which should get added when you add any sort of interaction - grab, teleport, raycast, etc.)
- You can change which method of movement is used by navigating to LeftInteractions or RightInteractions (depending which controller you want to change).
- Find the LeftInteractions or RightInteractions child called "Controller" then expand its child "LocomotionControllerInteractorGroup"
- Sliding movement is the child called "ControllerSlideInteractor" and Teleportation movement is called "TeleportControllerInteractor" - You can play around with these and see what it changes in your project
- It should look something like this in the hierarchy. 


<img width="312" height="780" alt="Screenshot 2026-03-16 171335" src="https://github.com/user-attachments/assets/8b973a6c-4277-4c72-b6b3-8c4ffd2dfa47" />


> Note: I recommend not enabling both for one controller. If you try to move forward with sliding movement, it will also shoot a teleport ray, and then the player may move to an undesired location. 

### ADDING MOVEMENT TO OTHER BUTTONS (i.e., x and y buttons) 
Movement is controlled by mapping different buttons on the Meta Quest controllers to actions using Unity's input system, specifically the InputSystem_Actions file. To add new actions:
- Open the InputSystem_Actions file
- Find "Actions" (should be at the top) and then click the plus button next to it.

<img width="730" height="598" alt="Screenshot 2026-03-16 171500" src="https://github.com/user-attachments/assets/375f503c-a65d-4b69-854a-8ad81117ae34" />


If you wanted to create actions that map to the x and y buttons for up and down movement:
- Add a MoveUp and MoveDown action. 
- On the left, there is the action properties panel. Make sure action type is set to "Button"
- Right click the action and find "AddBinding"
	- Go to where it says <NoBinding>. Click this.


    - <img width="733" height="603" alt="Screenshot 2026-03-16 171512" src="https://github.com/user-attachments/assets/ba034edd-d208-40e7-9677-08ffe945152c" />


	- In the left panel, go to path, and then XRController and then XRController Left Hand and then Optional Controls.
		- primaryButton is the X button, secondaryButton is the Y button
		- Add either one depending on your goal, typically Y for move up and X for move down.
 
 
        - <img width="778" height="606" alt="Screenshot 2026-03-16 171536" src="https://github.com/user-attachments/assets/731ad31a-a960-4c4d-89a1-b9d4fcad0b99" />

		
- Then you can create a script to control what happens when these buttons are pressed.
	- See Scripts > Example Scripts > XYButtonMovement
	- You can attach this to your [BuildingBlock] Camera Rig and set the references in the inspector to the input actions created above.
	- If you press X it should log to the console "Moving Up" and if you press Y it should log to the console "Moving Down" - You can replace this with logic to actually do something to the player here if desired. 


## PROJECT INSTALLATION
You can follow the following steps to set-up the project or watch a video tutorial [here](https://www.youtube.com/watch?v=tr1_z3OURKc).

## PROJECT REQUIREMENTS
In order to open this project in Unity, you will need:
- Unity Version 6000.1.17f1
- Meta XR All-in-One SDK* 83.0.1
  - *THE SDK SHOULD BE AUTOMATICALLY INCLUDED WHEN THIS CODE IS DOWNLOADED, but if you want to be safe, you can add it to your library from the Unity Asset Store [HERE](https://assetstore.unity.com/packages/tools/integration/meta-xr-all-in-one-sdk-269657) before downloading the project. MAKE SURE YOU USE VERSION **83.0.1**

- In order to test this project in your VR headset via Unity
  - You will need to connect your headset to your PC via Meta Horizon Link
    - Instructions to set-up Meta Horizon Link can be found [here](https://www.meta.com/help/quest/1517439565442928/).
  - For development with Unity, once you've installed Meta Horizon Linked and connected your headset to your PC, navigate to Settings > General and find "Unknown Sources." Make sure this is enabled. 

## PROJECT FIXES UPON OPENING THE PROJECT FOR THE FIRST TIME
There may be a few errors upon opening the project for the first time after installation. If this is the case, I recommend NOT opening the project in safe mode.

1. One error you may receieve is:

> Library\PackageCache\com.meta.xr.sdk.core@*\Editor\MetaXRSimulator\XRSimInstallationDetector.cs(87,29): error CS0246: The type or namespace name 'WindowsXRSimInstallationDetector' could not be found (are you missing a using directive or an assembly reference?)

In order to fix this, navigate to the directory storing your project. Navigate to Library > Package Cache > com.meta.xr.sdkcore@*/Editor/MetaXRSimulator/XRSimInstallationDetector.cs
(Where the asterisk is may be a different number) Locate the **private static IXRSimInstallationDetector GetDetector()** method and replace it with

> private static IXRSimInstallationDetector GetDetector()
> {
> return _detector ??= new UnsupportedPlatformDetector();
> }

- Save the file and then close and reopen the project. The error should resolve. Meta switched the simulator from a Unity package to a standalone application after version 81, which seems to be causing this issue. If you plan to use the simulator, this issue may resolve or you may need to find another work around. You may want to save the code initially in the **GetDetector()** method if you think you may use the simulator in the future.
- IF YOU EVER DELETE THE LIBRARY FOLDER (to refresh it) OR UNINSTALL/REINSTALL THE PROJECT, you must to repeat this step.

2. Another possible error you may receieve is:
> Library\PackageCache\com.unity.collab-proxy@*\Editor\PlasticApp.cs(80,13): error CS0103: The name 'WaitForPendingOperations' does not exist in the current context

This is due to Unity's version control, which you likely won't need for this project, so we can remove the package. Navigate to Window > Package Management > Package Manager
Scroll down and find "Version Control." Click on it and hit remove. Restart your project if necessary. This should fix the error. 


## REFERENCES
This project used the following references to set-up the code:
- [Setting up the project and camera rig](https://www.youtube.com/watch?v=8ejKIx2B3B8)
- [Setting up interactions using building blocks](https://www.youtube.com/watch?v=23WUfV1U6mQ&list=PL4g4CxkYXn3vpXTtSLPvrRRN4O15lNTEY)
- [Setting up teleportation building block](https://www.youtube.com/watch?v=a3ojjAIZCmk)
- [Simple day/night cycle](https://www.youtube.com/watch?v=L4t2c1_Szdk&t=764s) *this tutorial also talks about adding moonlight, which is not implemented in this project as of now and may be helpful :) 


