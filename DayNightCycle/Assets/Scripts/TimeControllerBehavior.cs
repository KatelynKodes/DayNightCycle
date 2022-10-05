using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeControllerBehavior : MonoBehaviour
{
    private float _hoursInDay = 24.0f;
    private float _minutesInHour = 60.0f;
    private float _currHour = 0;
    private float _prevHour = 0;
    private float _currMinute = 0;
    private float _debugMinChecker;

    private bool _hourChanged = false;

    public float getCurrHour { get { return _currHour; } }
    public float getCurrMinute { get { return _currMinute; } }
    public bool HourChanged { get { return _hourChanged; } private set { _hourChanged = value; } }


    private void Update()
    {
        _debugMinChecker += Time.smoothDeltaTime / 2;
        _currMinute = (int)_debugMinChecker;

        if (_currMinute == _minutesInHour)
        {
            HourChanged = true;
            ChangeHour();
            _currMinute = 0.0f;
            _debugMinChecker = 0.0f;
        }
    }

    private void ChangeHour()
    {
        if (HourChanged)
        {
            _prevHour = _currHour;

            if (_currHour == _hoursInDay)
                _currHour = 0.0f;
            else
                _currHour++;

            HourChanged = false;
        }
    }

}
