using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockBehavior : MonoBehaviour
{
    [SerializeField]
    private TimeControllerBehavior _timeController;
    private Text _clockText;
    private string _AMPM = "AM";

    Dictionary<int, string> _minDisplay = new Dictionary<int, string>()
    {
        [0] = "00",
        [1] = "01",
        [2] = "02",
        [3] = "03",
        [4] = "04",
        [5] = "05",
        [6] = "06",
        [7] = "07",
        [8] = "08",
        [9] = "09"
    };

    Dictionary<int, string> _hourDisplay = new Dictionary<int, string>()
    {
        [0] = "12",
        [13] = "1",
        [14] = "2",
        [15] = "3",
        [16] = "4",
        [17] = "5",
        [18] = "6",
        [19] = "7",
        [20] = "8",
        [21] = "9",
        [22] = "10",
        [23] = "11"
    };

    private void Awake()
    {
        _clockText = GetComponent<Text>(); 
    }

    private void Update()
    {
        if (_timeController.getCurrHour >= 12)
            _AMPM = "PM";
        else
            _AMPM = "AM";

        _clockText.text = ConvertHour((int)_timeController.getCurrHour) + ":" + ConvertMin((int)_timeController.getCurrMinute) + 
            " " + _AMPM;
    }

    private string ConvertMin(int indexNum)
    {
        if (indexNum < 10)
            return _minDisplay[indexNum];
        else
            return indexNum.ToString();
    }

    private string ConvertHour(int indexNum)
    {
        if (indexNum == 0 || indexNum > 12)
            return _hourDisplay[indexNum];
        else
            return indexNum.ToString();
    }
}
