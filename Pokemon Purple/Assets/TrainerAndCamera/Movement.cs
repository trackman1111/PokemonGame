using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator anim;
    private Trainer mainCharacter;
    public SpriteRenderer sr;
    public Sprite leftIdle;
    public Sprite rightIdle;
    public Sprite upIdle;
    public Sprite downIdle;
    public Tilemap walkable;
    public Sprite bush;
    public GameObject optionsMenuController;
    private CanvasManager canMan;
    private bool hasChecked = false;
    private Vector3 desiredPosition;
    private Vector3 previousPosition;
    private int currDirection;
    private float interpolationSpeed = 5F;
    private bool stasis = false;
    private PokemonData pokeData;
    private string pokeName;
    private bool teleporting;
    // Start is called before the first frame update
    void Start()
    {
        mainCharacter = GetComponent<Trainer>();
        desiredPosition = transform.position;
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = upIdle;
        currDirection = 0;
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        pokeData = new PokemonData();
        canMan = optionsMenuController.GetComponent<CanvasManager>();
        teleporting = false;

    }
    void Update()
    {

        bool onBush;
        if (walkable.GetSprite(new Vector3Int((int)(transform.position.x - .5), (int)transform.position.y - 1, 0)) == null)
        {
            onBush = false;
        }
        else
        {
            onBush = walkable.GetSprite(new Vector3Int((int)(transform.position.x - .5), (int)transform.position.y - 1, 0)).Equals(bush);
        }

        if (onBush && transform.position == desiredPosition && !hasChecked)
        {
            pokeName = pokeData.getWildPokemon();
            if ( Random.value < pokeData.getChances(pokeName) )
            {
                canMan.startBattle( pokeName );
                print("You have encountered a " + pokeName + "!");

            }
            hasChecked = true;
        }
        else if(transform.position != desiredPosition)
        {
            hasChecked = false;
        }
        if (canMan.getCaught() )
        {
            mainCharacter.addPokemon(pokeName);
            canMan.setCaught(false);
        }

        //else
        //{
        //    print("NOT BUSH");
        //}
        if (stasis == false)
        {
            anim.enabled = true;
            KeyInput();
            transform.position = Vector3.MoveTowards(transform.position, desiredPosition, interpolationSpeed * Time.deltaTime);
        }
        else
        {
            anim.enabled = false;
            if (currDirection == 0)
            {
                sr.sprite = upIdle;
            }
            else if (currDirection == 1)
            {
                sr.sprite = rightIdle;
            }
            else if (currDirection == 2)
            {
                sr.sprite = downIdle; ;
            }
            else if (currDirection == 3)
            {
                sr.sprite = leftIdle;
            }
            rb.velocity = new Vector3(0, 0, 0);
        }


    }
    void KeyInput()
    {
        if (transform.position == desiredPosition)
        {
            if (Input.GetKey(KeyCode.W))
            {
                anim.enabled = true;
                desiredPosition += Vector3.up;
                previousPosition = transform.position;
                anim.SetInteger("TrainerWalking", 0);
                currDirection = 0;
            }
            else if (Input.GetKey(KeyCode.D))
            {
                anim.enabled = true;
                desiredPosition += Vector3.right;
                previousPosition = transform.position;
                anim.SetInteger("TrainerWalking", 1);
                currDirection = 1;
            }
            else if (Input.GetKey(KeyCode.S))
            {
                anim.enabled = true;
                desiredPosition += Vector3.down;
                previousPosition = transform.position;
                anim.SetInteger("TrainerWalking", 2);
                currDirection = 2;
            }
            else if (Input.GetKey(KeyCode.A))
            {
                anim.enabled = true;
                desiredPosition += Vector3.left;
                previousPosition = transform.position;
                anim.SetInteger("TrainerWalking", 3);
                currDirection = 3;
            }
            else
            {
                anim.enabled = false;
                if (currDirection == 0)
                {
                    sr.sprite = upIdle;
                }
                else if (currDirection == 1)
                {
                    sr.sprite = rightIdle;
                }
                else if (currDirection == 2)
                {
                    sr.sprite = downIdle; ;
                }
                else if (currDirection == 3)
                {
                    sr.sprite = leftIdle;
                }
                rb.velocity = new Vector3(0, 0, 0);
            }
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!teleporting)
        {
            if (currDirection == 0)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y - .1f, -1);
            }
            if (currDirection == 1)
            {
                transform.position = new Vector3(transform.position.x - .1f, transform.position.y, -1);
            }
            if (currDirection == 2)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + .1f, -1);
            }
            if (currDirection == 3)
            {
                transform.position = new Vector3(transform.position.x + .1f, transform.position.y, -1);
            }
  
            desiredPosition = previousPosition;
        }
        else
        {
            teleporting = false;
        }

    }
    public void setStasis(bool given)
    {
        stasis = given;
    }
    public void setPosition(float xCoord, float yCoord)
    { 
        transform.position = new Vector3(xCoord, yCoord, -1f);
        desiredPosition = new Vector3(xCoord, yCoord, -1f);
        teleporting = true;
    }

}

