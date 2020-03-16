using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text textComponent;
    [SerializeField] State statingState;
    // int[] oddNumbers = {1,3,5,7,9};
    // Start is called before the first frame update
    State state; 
    void Start()
    {
        state = statingState;
        textComponent.text = state.GetStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        //throw new NotImplementedException();
        var nextStates = state.GetNextStates();
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = nextStates[0];
        } 
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = nextStates[1];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            state = nextStates[2];
        }

        textComponent.text = state.GetStateStory();

    }
}
