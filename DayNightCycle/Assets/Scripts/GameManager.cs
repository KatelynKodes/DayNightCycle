using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private TimeControllerBehavior _timeController;
    [SerializeField]
    private Camera _camera;
    [SerializeField]
    private Gradient _DayNightGradient;
    [SerializeField]
    private Color _nightColor;
    [SerializeField]
    private Color _dayColor;
    private float _timePassed;
    

    private void Update()
    {
        float currGradientColor = Mathf.Lerp(0.0f, 1.0f, _timePassed);
        _camera.backgroundColor = _DayNightGradient.Evaluate(currGradientColor);

        if (_timeController.getCurrHour < 12)
        {
            if (_timeController.HourChanged)
            { 
                _timePassed += 0.05f;
                _timeController.HourChanged = false;
            }
        }
        else if (_timeController.getCurrHour > 12)
        {
            if (_timeController.HourChanged)
            { 
                _timePassed -= 0.05f;
                _timeController.HourChanged = false;
            }
        }

    }
}
