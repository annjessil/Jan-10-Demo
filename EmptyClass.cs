﻿using UnityEngine;
public class Hero : MonoBehaviour
{
    void Start()
    {
        /* TODO: create a variable of type int with name 'score', and assign
        a value of 20 to it */

        int score = 20;

        /* TODO: write an if-statement that checks the score (the variable
        you created above) is greater than 18. If so, print (using
        Debug.Log()) "You win!", otherwise, print "You lose" */


        if (score > 18) {
            Debug.log("You win!");
        } else {
            Debug.log("You lose!");
        }

        /* TODO: write a while-loop that checks if the score is greater than
        10. Inside the loop, decrement the score by 1 */

        while (score > 10)
        {
            score--;
        }

        /* TODO: write a for-loop that loops a total of 4 times, starting
        from 1, and in each loop adds the value of the counter variable
        to the score */

        for (int i = 1; i <= 4; i++)
        {
            score = score + i;
        }

        /* TODO: print out the final score to console */

        Debug.log(score);

    }
}
