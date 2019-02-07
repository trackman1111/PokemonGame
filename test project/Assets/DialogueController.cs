using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueController : MonoBehaviour
{
    private Queue<string> sentence;
    public Text nameText;
    public Text dialogueText;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        sentence = new Queue<string>();
    }
    public void StartDialogue(Dialogue dialogue)
    {
        animator.SetBool("IsOpen", true);
        Debug.Log("Starting convo with " + dialogue.name);

        nameText.text = dialogue.name;

        sentence.Clear();

        foreach (string sentences in dialogue.sentences)
        {
            sentence.Enqueue(sentences);
        }

        DisplayNextSentence();
    }
    public void DisplayNextSentence()
    {
        if ( sentence.Count == 0)
        {
            EndDialogue();
            return;
        }
        string sentences = sentence.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentences));
    }
    IEnumerator TypeSentence (string sentences)
    {
        dialogueText.text = "";
        foreach (char letter in sentences.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(.02f);
        }
    }
    void EndDialogue()
    {
        Debug.Log("end convo");
        animator.SetBool("IsOpen", false);
    }
   
}
