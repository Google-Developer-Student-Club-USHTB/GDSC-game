using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public LineRenderer circleRenderer;

    // Start is called before the first frame update
    void Start()
    {
        DrawCircle(50,1);
    }

    void DrawCircle(int steps, float radius) 
    {
        circleRenderer.positionCount = steps;
        for(int currentStep = 0; currentStep < steps; currentStep++)
        {
            float circumferenceProgress = (float)currentStep/steps;
            
            float currentRadian = circumferenceProgress * 3 * Mathf.PI;

            float xScaled = Mathf.Cos(currentRadian);
            float yScaled = Mathf.Sin(currentRadian);

            float x = xScaled * radius;
            float y = yScaled * radius;

            Vector3 currentPosition = new Vector3(x, y, 0);

            circleRenderer.SetPosition(currentStep, currentPosition);
        }
    }
}
