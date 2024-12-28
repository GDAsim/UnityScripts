using UnityEngine;

public class TimerExample : MonoBehaviour
{
    //Static Instance - So that Everyone can Access it
    public static TimerExample instance = null;

    public Timer StartEndTimer;
    public Timer IntervalTimer;

    void Start()
    {
        StartEndTimer = Timer.CreateNew("Timer");
        StartEndTimer.transform.parent = transform;
        StartEndTimer.Setup(0, 1f, Timer.TimerType.StartEnd);

        IntervalTimer = Timer.CreateNew("Timer");
        IntervalTimer.transform.parent = transform;
        IntervalTimer.Setup(1f, Mathf.Infinity, Timer.TimerType.Interval);
    }
     
    void Update()
    {
        if (StartEndTimer.CounterHit)
        {
            print("start end hit");
            StartEndTimer.Reset();
        }
        if (IntervalTimer.CounterHit)
        {
            print("interval hit");
        }
    }
}