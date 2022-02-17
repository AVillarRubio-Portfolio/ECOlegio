using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using uAdventure.Runner;
using uAdventure.Core;

public class MyTimer : MonoBehaviour {

    List<Timer> timers_;
    Timer myTimer_;
    TimerController.TimerVars timerVars_;

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        timers_ = Game.Instance.GameState.GetTimers();
        myTimer_ = timers_[0];
        TimerController.Instance.GetTimerVars().TryGetValue(myTimer_, out timerVars_);
        myTimer_.setTime((long)timerVars_.currentTime);
	}
}
