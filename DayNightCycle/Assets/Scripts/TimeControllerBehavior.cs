using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeControllerBehavior : MonoBehaviour
{
    private float _hoursInDay = 24.0f;
    private float _minutesInHour = 60.0f;
    private float _currHour = 0;
    private float _currMinute = 0;
    private float _debugMinChecker;

    public float getCurrHour { get { return _currHour; } }
    public float getCurrMinute { get { return _currMinute; } }

    private void Update()
    {
        _debugMinChecker += Time.smoothDeltaTime / 2;
        _currMinute = (int)_debugMinChecker;

        if (_currMinute == _minutesInHour)
        {
            _currHour++;
            _currMinute = 0.0f;
            _debugMinChecker = 0.0f;
        }

        if (_currHour == _hoursInDay)
        {
            _currHour = 0.0f;
        }
    }

}
