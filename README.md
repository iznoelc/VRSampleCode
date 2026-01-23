# VRSampleCode
This is sample code created for a VR development with Unity course at New College of Florida. The intention of this code is to demonstrate the basics of building a VR project in Unity using the new Meta XR SDKs and demonstrate the capabilities of the building blocks (such as grab interactions and camera rig) with a few extra basic Unity features (such as switching scenes and a day/night cycle). 

## PROJECT OVERVIEW
See a short playthrough of this project [here](https://drive.google.com/file/d/1-6Fometqpo91JHnKgByfp0osla4wwLHk/view?usp=sharing).

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
- [Simple day/night cycle](https://www.youtube.com/watch?v=3M1W6cT98RM)


