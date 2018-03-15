using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DomovoiStateMachine : MonoBehaviour {

    private enum _eStates { Walk, Idle }
    private _eStates _state = _eStates.Walk;
	
	void Update () {
        StateMachine();
	}

    private void StateMachine()
    {
        switch (_state)
        {
            case _eStates.Walk:

                break;
            case _eStates.Idle:

                break;
        }
    }
}
