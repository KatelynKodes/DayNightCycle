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
    private Color _nightColor;
    [SerializeField]
    private Color _dayColor;
    private float _timePassed;
    

    private void Update()
    {
        _camera.backgroundColor = Color.Lerp(_nightColor, _dayColor, Mathf.Lerp(0.0f, 1.0f, _timePassed));

        if (_timeController.getCurrHour < 12)
        {
            if (_timeController.HourIncreased())
                _timePassed += 0.1f;
        }
        else if (_timeController.getCurrHour > 12)
        {
            if (_timeController.HourIncreased())
                _timePassed -= 0.1f;
        }

    }
}
