using UnityEngine;

public class DiceRoll : MonoBehaviour
{
    
    public void RollDice()
    {
        
        int diceResult = Random.Range(1, 7);

        
        Debug.Log("You rolled a: " + diceResult);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RollDice();
        }
    }
}
