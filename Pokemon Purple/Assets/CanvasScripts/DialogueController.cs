using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueController : MonoBehaviour
{
    private Queue<string> sentence;
    public Text nameText;
    public Text dialogueText;
    public GameObject visibility;
    public Animator animator;
    public NPC npc;
    private bool inDialogue;
    private bool isTrainer;
    // Start is called before the first frame update
    void Start()
    {
        sentence = new Queue<string>();
        animator = GetComponent<Animator>();
        sentence.Enqueue("dummy");
        inDialogue = false;
    }
    private void Update()
    {
        if ( inDialogue == true )
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                DisplayNextSentence();
            }
        }
       
    }
    public void StartDialogue(Dialogue dialogue, NPC sender, bool isTrainerGiven)
    {
        isTrainer = isTrainerGiven;
        inDialogue = true;
        npc = sender;
        visibility.SetActive(true);
        FindObjectOfType<Movement>().setStasis(true);
        //animator.SetBool("IsOpen", true);
        Debug.Log("Starting convo with " + dialogue.name);

        nameText.text = dialogue.name;

        sentence.Clear();

        foreach (string sentences in dialogue.sentences)
        {
            sentence.Enqueue(sentences);
        }

        DisplayNextSentence();
    }
    public void StartDialogue(Dialogue dialogue)
    {
        isTrainer = false;
        inDialogue = true;
        visibility.SetActive(true);
        FindObjectOfType<Movement>().setStasis(true);
        //animator.SetBool("IsOpen", true);
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
        inDialogue = false;
        Debug.Log("end convo");
        FindObjectOfType<Movement>().setStasis(false);
        // animator.SetBool("IsOpen", false);
        visibility.SetActive(false);
        if ( isTrainer == true)
        {
            npc.moveToBattle();
        }
        
        //if ( npc.isTrainer == true )
        //{
        //    npc.moveToBattle();
        //}
    }
   
}
