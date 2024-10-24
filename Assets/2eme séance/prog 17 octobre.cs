using JetBrains.Annotations;
using TMPro;
using UnityEngine;

public class prog17octobre : MonoBehaviour
{
    public TMP_Text messageText;
    public TMP_InputField numberInput;

    private int randomNumber;

    private void Start()
    {
        ResetGame();

    }

    public void Try()
    {
        if (string.IsNullOrWhiteSpace(numberInput.text) == true)

        {
            messageText.text = "Entre un truc valide wesh !";
            numberInput.text = "";
            return;
        }

        if (int.TryParse(numberInput.text, out int nombredujoueur))
        {

            if (nombredujoueur == randomNumber)
            { messageText.text = "GOOD JOB"; }

            else if (nombredujoueur > randomNumber)

            { messageText.text = "moins !"; }

            else if (nombredujoueur < randomNumber)

            { messageText.text = "plus !"; }



            else
            { 
                messageText.text = "Entre un truc valide wesh !";
                numberInput.text = "";
            }
        }
    }
    public void ResetGame()

    {
        randomNumber = Random.Range(1, 100 + 1);
        Debug.Log("Generated number: " + randomNumber);
        messageText.text = "Devine le nombre ou je te tape !"; 
    }
}





