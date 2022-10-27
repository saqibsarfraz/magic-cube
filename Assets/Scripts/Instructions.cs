using UnityEngine;

[ExecuteInEditMode]
public class Instructions : MonoBehaviour
{

    private static bool isFolded = false;
    private static string instructionButtonLable = "Hide Instructions";
    private void OnGUI()
    {
        GUILayout.BeginVertical("box");

        if (!isFolded)
        {
            GUILayout.Label("> Interaction Points on X-Y-Z axis for stretching the Shape in three dimensions individually.");
            GUILayout.Label("> If Clicked on the point Object would stretch in that direction only.");
            GUILayout.Label("> If Clicked on the Object itself and Dragged, the object would rotate around its pivot in the direction the mouse/controller is moved.");
        }

        
        if (GUILayout.Button(instructionButtonLable, GUILayout.Width(Screen.width)))
        {
            isFolded = !isFolded;

            instructionButtonLable = isFolded ? "Show Instructions" : "Hide Instructions";
        }

        GUILayout.EndVertical();
        
    }
}
