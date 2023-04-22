using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalCheck : MonoBehaviour
{

    public Text GoalCounter;
    public GameObject EndCanvas;
    int goals = 0;
    int maxGoals = 0;

    // Start is called before the first frame update
    void Start()
    {
        EndCanvas.SetActive(false);
        maxGoals = GameObject.FindGameObjectsWithTag("Ball").Length;
        GoalCounter.text = "Goals: " + goals.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        //Check if what is colliding with the goal is one of the balls 
        if (other.tag == "Ball")
        {
            goals += 1;
            GoalCounter.text = "Goals: " + goals.ToString();
            Destroy(other);
        }
    }

    void Update(){
        if(goals == maxGoals){
            EndCanvas.SetActive(true);
        }
    }
}
