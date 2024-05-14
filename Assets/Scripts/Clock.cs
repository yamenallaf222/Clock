using UnityEngine;
using System;
public class Clock : MonoBehaviour
{

    const float hoursToDegrees = -30.0f, minutesToDegrees = -6f, secondsToDegrees = -6f;

    [SerializeField]
    Transform hoursPivot, minutesPivot, secondsPivot;

    void Awake()
    {
        DateTime time = DateTime.Now;

        hoursPivot.localRotation = Quaternion.Euler(0.0f, 0.0f, hoursToDegrees * time.Hour);
        
        minutesPivot.localRotation = Quaternion.Euler(0.0f, 0.0f, minutesToDegrees * time.Minute);

        secondsPivot.localRotation = Quaternion.Euler(0.0f, 0.0f, secondsToDegrees * time.Second);

    }

    void Update()
    {
        Debug.Log(DateTime.Now.TimeOfDay);
        TimeSpan time = DateTime.Now.TimeOfDay;

        hoursPivot.localRotation = Quaternion.Euler(0.0f, 0.0f, hoursToDegrees * (float) time.TotalHours);

        minutesPivot.localRotation = Quaternion.Euler(0.0f, 0.0f, minutesToDegrees * (float) time.TotalMinutes);

        secondsPivot.localRotation = Quaternion.Euler(0.0f, 0.0f, secondsToDegrees * (float) time.TotalSeconds);

    }



}