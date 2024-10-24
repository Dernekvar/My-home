using TMPro;
using UnityEngine;

public class DialoguePlayer : MonoBehaviour
{
    public GameObject DialogueBox;
    public Dialogueassets dialogueassets;
    public TMP_Text dialogueText;


    private int dialogueIndex;

    private void Start()
    {
        dialogueText.text = dialogueassets.dialogue[0];

}

void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
         dialogueIndex+= 1;

            if (dialogueIndex < dialogueassets.dialogue.Length)
            {
                dialogueText.text = dialogueassets.dialogue[dialogueIndex]; 
            }
            else
            {
                DialogueBox.gameObject.SetActive(false);
            }

}
    }
}
