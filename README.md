# VRSampleCode - Balloon and Rocks
This is an extension of the VRSampleCode that implements a balloon that floats away when you release the trigger press and rocks that you can grab using the grab button and stack on top of each other.

To see a sample video, [click here](https://drive.google.com/file/d/16cFmlzVq5gyzOprVaA_lhXpdn6kuCETS/view?usp=sharing)

## IMPLEMENTING THE BALLOON
- See the FloatUp.cs script in Scripts > Balloon
  - This is a simple script that allows the balloon to float up.
 

**Add this script** to the balloon GameObject.
 

**In order to make the balloon trigger-grabbable:**
Right click the object in the scene hierarchy and then find "Interaction SDK" (make sure you also have the Interactions Rig building block in your scene). Then, click "Add Ray Grab Interaction"
<img width="883" height="978" alt="Screenshot 2026-03-29 125651" src="https://github.com/user-attachments/assets/39cdcab2-eb00-45e8-aa04-f4303b0a54bc" />


"Fix" and then "Fix All"
<img width="477" height="601" alt="Screenshot 2026-03-29 125814" src="https://github.com/user-attachments/assets/78a987cb-ecec-48f5-a14a-3ef0d8aca3a3" />


Now, you should be able to ray grab it.


**In order to do something upon release of an object:**
Go to the inspector of your ray grabble object. Add the "Interactable Unity Event Wrapper"
> When Unselect() is to do something when the player lets go of an object
<img width="491" height="819" alt="Screenshot 2026-03-29 130130" src="https://github.com/user-attachments/assets/c54129af-22e3-4f7e-8898-b8b325ec4138" />
By adding the "SetFloatUpToggle" to the When Unselect() event, we allow the balloon to float up when it is let go.


Then, in the Interactable Event Wrapper component, we need to drag the ISDK for our object into the "Interactable View" variable, which is this for our balloon (gets added every time you add an interaction like we did in the earlier steps)
<img width="225" height="61" alt="Screenshot 2026-03-29 130141" src="https://github.com/user-attachments/assets/cec0bcf2-e762-4802-9a4e-c9245b7b6c39" />


Now, the balloon will float up after it is released. 

## IMPLEMENTING THE ROCKS
For the rocks, we use the grab button instead of the trigger press button, so we need to add a grab interaction instead. Right click the object in the scene hierarchy, find "Interaction SDK" and then click "Add Grab Interaction" 
<img width="861" height="972" alt="Screenshot 2026-03-29 130530" src="https://github.com/user-attachments/assets/d7141163-5680-44ad-98ba-669f3bbb7278" />


Click "Fix All"
<img width="472" height="657" alt="image" src="https://github.com/user-attachments/assets/7a0185b5-8f3b-48fc-a50c-184259ae8330" />


Adding the grab interaction will add a collider to the rock if there isn't one already. Whether there is already one or it was added by the grab interaction, ensure "Is Trigger" is **not** checked, like so:
<img width="489" height="239" alt="Screenshot 2026-03-29 130720" src="https://github.com/user-attachments/assets/95ec7359-aef0-403d-a0ac-24154c81240f" />


Now, you will be able to grab the rocks with the grab button on the side of the controller and stack them.


## ASSET REFERENCES
- Low Poly Balloons: https://www.cgtrader.com/free-3d-models/various/various-models/red-blue-yellow-balloons
- Low Poly Rocks: https://assetstore.unity.com/packages/3d/environments/low-poly-rock-models-119245


