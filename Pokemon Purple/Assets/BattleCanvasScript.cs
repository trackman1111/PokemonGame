using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BattleCanvasScript : MonoBehaviour
{
    public Sprite tree;
    public Sprite grov;
    public Sprite scep;
    public Sprite torc;
    public Sprite comb;
    public Sprite blaz;
    public Sprite mudk;
    public Sprite mars;
    public Sprite swam;
    public Sprite pooc;
    public Sprite migh;
    public Sprite zigz;
    public Sprite lino;
    public Sprite wurm;
    public Sprite sili;
    public Sprite beau;
    public Sprite casc;
    public Sprite dust;
    public Sprite lota;
    public Sprite lomb;
    public Sprite ludi;
    public Sprite seed;
    public Sprite nuzl;
    public Sprite shif;
    public Sprite ninc;
    public Sprite ninj;
    public Sprite shed;
    public Sprite tail;
    public Sprite swel;
    public Sprite shro;
    public Sprite brel;
    public Sprite spin;
    public Sprite wing;
    public Sprite peli;
    public Sprite surs;
    public Sprite masq;
    public Sprite wailm;
    public Sprite waill;
    public Sprite skit;
    public Sprite delc;
    public Sprite kecl;
    public Sprite balt;
    public Sprite clay;
    public Sprite nose;
    public Sprite tork;
    public Sprite sabl;
    public Sprite barb;
    public Sprite whisc;
    public Sprite luvd;
    public Sprite corp;
    public Sprite craw;
    public Sprite feeb;
    public Sprite milo;
    public Sprite carv;
    public Sprite shar;
    public Sprite trap;
    public Sprite vibr;
    public Sprite flyg;
    public Sprite maku;
    public Sprite hari;
    public Sprite elec;
    public Sprite mane;
    public Sprite nume;
    public Sprite came;
    public Sprite sphe;
    public Sprite seal;
    public Sprite walr;
    public Sprite cacn;
    public Sprite cact;
    public Sprite snor;
    public Sprite glal;
    public Sprite luna;
    public Sprite solr;
    public Sprite azuri;
    public Sprite spoi;
    public Sprite grum;
    public Sprite plus;
    public Sprite minu;
    public Sprite mawi;
    public Sprite medit;
    public Sprite medic;
    public Sprite swab;
    public Sprite alta;
    public Sprite wyna;
    public Sprite dusk;
    public Sprite dusc;
    public Sprite rose;
    public Sprite slako;
    public Sprite vigo;
    public Sprite slaki;
    public Sprite gulp;
    public Sprite swal;
    public Sprite trop;
    public Sprite whism;
    public Sprite loud;
    public Sprite expl;
    public Sprite clam;
    public Sprite hunt;
    public Sprite gore;
    public Sprite abso;
    public Sprite shup;
    public Sprite bane;
    public Sprite sevi;
    public Sprite zang;
    public Sprite reli;
    public Sprite aron;
    public Sprite lair;
    public Sprite aggr;
    public Sprite cast;
    public Sprite volb;
    public Sprite illu;
    public Sprite lile;
    public Sprite crad;
    public Sprite anor;
    public Sprite arma;
    public Sprite ralt;
    public Sprite kirl;
    public Sprite gard;
    public Sprite bago;
    public Sprite shel;
    public Sprite sala;
    public Sprite beld;
    public Sprite metan;
    public Sprite metag;
    public Sprite regir;
    public Sprite regic;
    public Sprite regis;
    public Sprite kyog;
    public Sprite grou;
    public Sprite rayq;
    public Sprite latia;
    public Sprite latio;
    public Sprite other;

    public Sprite pokeballSprite;
    public Sprite greatballSprite;
    public Sprite ultraBallSprite;
    public Sprite masterBallSprite;

    public Image enemyImage;
    public Image allyImage;

    public GameObject pokemon;
    public GameObject bag;
    public GameObject battle;

    public GameObject fightButton;
    public GameObject bagButton;
    public GameObject pokemonButton;
    public GameObject runButton;

    public Text fightButtonText;
    public Text bagButtonText;
    public Text runButtonText;
    public Text pokemonButtonText;

    public GameObject battleCanvas;
    public GameObject canvasManager;
    private CanvasManager cm;

    public TextMeshProUGUI allyLevel;
    public TextMeshProUGUI enemyLevel;
    public TextMeshProUGUI allyNameText;
    public TextMeshProUGUI enemyNameText;
    public TextMeshProUGUI allyCurrHealth;
    public TextMeshProUGUI allyMaxHealth;
    public TextMeshProUGUI enemyHealth;
    public TextMeshProUGUI titleText;

    public Trainer t;

    private BattleControl bc;
    private bool caught;
    private Pokemon enemy;
    private Pokemon ally;
    private string enemyName;
    private int cursor;
    private int numShakes;
    public bool canMove;
    public string ballType;
    public bool isTrainer;
    public bool setToZero;
    public int damageAmount;
    public int currMove;
    private PokemonData pokeData;

    public int time;

    // Start is called before the first frame update
    public void Start()
    {
        cm = canvasManager.GetComponent<CanvasManager>();

        pokeData = new PokemonData();
        fightButtonText.text = "-> FIGHT";
        runButtonText.text = "RUN";
        bagButtonText.text = "BAG";
        pokemonButtonText.text = "POKEMON";
        titleText.text = "What will " + t.pokemon[0].name + " do?";
        ballType = "";
        cursor = 1;
        numShakes = 0;
        canMove = true;
        currMove = 0;
        time = 3;
    }

    // Update is called once per frame
    public void setTexts()
    {
        enemyNameText.text = enemy.name;
        ally = t.pokemon[0];

        allyNameText.text = ally.name;
        enemyNameText.text = enemy.name;
        allyLevel.text = ally.level + "";
        enemyLevel.text = enemy.level + "";
        allyCurrHealth.text = ally.currHealth + "";
        allyMaxHealth.text = ally.health + "";
        enemyHealth.text = enemy.currHealth + "/" + enemy.health;

        allyImage.sprite = getImage(ally.name);
        enemyImage.sprite = getEnemyImage(ballType);
    }

    public void Update()
    {
        setArrow();
        setTexts();

        if (canMove)
        {
            if (!bag.activeSelf && !pokemon.activeSelf)
            {
                if (Input.GetKeyDown(KeyCode.RightArrow) && (cursor == 1 || cursor == 3))
                {
                    cursor++;
                }
                if (Input.GetKeyDown(KeyCode.LeftArrow) && (cursor == 2 || cursor == 4))
                {
                    cursor--;
                }
                if (Input.GetKeyDown(KeyCode.UpArrow) && cursor > 2)
                {
                    cursor -= 2;
                }
                if (Input.GetKeyDown(KeyCode.DownArrow) && cursor < 3)
                {
                    cursor += 2;
                }
                if (canMove && Input.GetKeyDown(KeyCode.RightShift))
                {

                    switch (cursor)
                    {
                        case 1:
                            onFightButton();
                            break;
                        case 2:
                            onBagButton();
                            break;
                        case 3:
                            onPokemonButton();
                            break;
                        case 4:
                            onRunButton();
                            break;

                        default:
                            break;
                    }
                }
            }

            if (Input.GetKeyDown(KeyCode.Escape) && !fightButtonText.text.Equals("FIGHT"))
            {
                cursor = 1;
                fightButtonText.text = "-> FIGHT";
                bagButtonText.text = "BAG";
                pokemonButtonText.text = "POKEMON";
                runButtonText.text = "RUN";
            }
        }
    }

    // STARTING BATTLES

    public void startBattle(Pokemon poke)
    {
        bc = new BattleControl(poke, t, this);
        isTrainer = false;
    }

    public void startBattle(NPC enemyTrainer)
    {
        bc = new BattleControl(enemyTrainer, t, this);
        isTrainer = true;
        enemy = enemyTrainer.firstPokemon();
    }

    public void setEnemy(Pokemon enemy)
    {
        this.enemy = enemy;
    }

    // BUTTON TEXTS

    public void setArrow()
    {
        if (fightButtonText.text.Equals("FIGHT") || bagButtonText.text.Equals("BAG"))
        {
            switch (cursor)
            {
                case 1:
                    fightButtonText.text = "-> FIGHT";
                    bagButtonText.text = "BAG";
                    pokemonButtonText.text = "POKEMON";
                    runButtonText.text = "RUN";
                    break;
                case 2:
                    fightButtonText.text = "FIGHT";
                    bagButtonText.text = "-> BAG";
                    pokemonButtonText.text = "POKEMON";
                    runButtonText.text = "RUN";
                    break;
                case 3:
                    fightButtonText.text = "FIGHT";
                    bagButtonText.text = "BAG";
                    pokemonButtonText.text = "-> POKEMON";
                    runButtonText.text = "RUN";
                    break;
                case 4:
                    fightButtonText.text = "FIGHT";
                    bagButtonText.text = "BAG";
                    pokemonButtonText.text = "POKEMON";
                    runButtonText.text = "-> RUN";
                    break;

                default:
                    break;
            }
        }
        else
        {

            switch (cursor)
            {
                case 1:
                    fightButtonText.text = "-> " + ally.moveOne + "\t\t\t\t" + ally.currMoveOnePP + " / " + pokeData.getMovePower(ally.moveOne)[5] + "pp";
                    bagButtonText.text = ally.moveTwo + "\t\t\t\t" + ally.currMoveTwoPP + " / " + pokeData.getMovePower(ally.moveTwo)[5] + "pp";
                    pokemonButtonText.text = ally.moveThree + "\t\t\t\t" + ally.currMoveThreePP + " / " + pokeData.getMovePower(ally.moveThree)[5] + "pp";
                    runButtonText.text = ally.moveFour + "\t\t\t\t" + ally.currMoveFourPP + " / " + pokeData.getMovePower(ally.moveFour)[5] + "pp";
                    break;
                case 2:
                    fightButtonText.text = ally.moveOne + "\t\t\t\t" + ally.currMoveOnePP + " / " + pokeData.getMovePower(ally.moveOne)[5] + "pp";
                    bagButtonText.text = "-> " + ally.moveTwo + "\t\t\t\t" + ally.currMoveTwoPP + " / " + pokeData.getMovePower(ally.moveTwo)[5] + "pp";
                    pokemonButtonText.text = ally.moveThree + "\t\t\t\t" + ally.currMoveThreePP + " / " + pokeData.getMovePower(ally.moveThree)[5] + "pp";
                    runButtonText.text = ally.moveFour + "\t\t\t\t" + ally.currMoveFourPP + " / " + pokeData.getMovePower(ally.moveFour)[5] + "pp";
                    break;
                case 3:
                    fightButtonText.text = ally.moveOne + "\t\t\t\t" + ally.currMoveOnePP + " / " + pokeData.getMovePower(ally.moveOne)[5] + "pp";
                    bagButtonText.text = ally.moveTwo + "\t\t\t\t" + ally.currMoveTwoPP + " / " + pokeData.getMovePower(ally.moveTwo)[5] + "pp";
                    pokemonButtonText.text = "-> " + ally.moveThree + "\t\t\t\t" + ally.currMoveThreePP + " / " + pokeData.getMovePower(ally.moveThree)[5] + "pp";
                    runButtonText.text = ally.moveFour + "\t\t\t\t" + ally.currMoveFourPP + " / " + pokeData.getMovePower(ally.moveFour)[5] + "pp";
                    break;
                case 4:
                    fightButtonText.text = ally.moveOne + "\t\t\t\t" + ally.currMoveOnePP + " / " + pokeData.getMovePower(ally.moveOne)[5] + "pp";
                    bagButtonText.text = ally.moveTwo + "\t\t\t\t" + ally.currMoveTwoPP + " / " + pokeData.getMovePower(ally.moveTwo)[5] + "pp";
                    pokemonButtonText.text = ally.moveThree + "\t\t\t\t" + ally.currMoveThreePP + " / " + pokeData.getMovePower(ally.moveThree)[5] + "pp";
                    runButtonText.text = "-> " + ally.moveFour + "\t\t\t\t" + ally.currMoveFourPP + " / " + pokeData.getMovePower(ally.moveFour)[5] + "pp";
                    break;
                default:
                    break;
            }
        }
    }

    public void changeBackButtonTexts()
    {
        cursor = 1;
        fightButtonText.text = "-> FIGHT";
        runButtonText.text = "RUN";
        bagButtonText.text = "BAG";
        pokemonButtonText.text = "POKEMON";
    }

    // BUTTON STUFF-------------------------------------------------------------

    // ON FIGHT BUTTON CLICK

    public void onFightButton()
    {
        cursor = 1;

        if (fightButtonText.text.Equals("-> FIGHT"))
        {
            fightButtonText.text = "-> " + ally.moveOne + "\t" + ally.currMoveOnePP + " / " + pokeData.getMovePower(ally.moveOne)[5] + "pp";
            bagButtonText.text = ally.moveTwo;
            pokemonButtonText.text = ally.moveThree;
            runButtonText.text = ally.moveFour;
        }
        else
        {
            useMove(1, pokeData.getMovePower(ally.moveOne));
        }
    }

    // ON BAG BUTTON CLICK

    public void onBagButton()
    {
        if (bagButtonText.text.Equals("-> BAG"))
        {
            bag.SetActive(true);
        }
        else
        {
            useMove(2, pokeData.getMovePower(ally.moveTwo));
        }
    }

    // ON POKEMON BUTTON CLICK

    public void onPokemonButton()
    {
        if (pokemonButtonText.text.Equals("-> POKEMON"))
        {
            pokemon.SetActive(true);
        }
        else
        {
            useMove(3, pokeData.getMovePower(ally.moveThree));
        }
    }

    // ON RUN BUTTON CLICK

    public void onRunButton()
    {
        if (runButtonText.text.Equals("-> RUN"))
        {
            if (!isTrainer)
            {
                exitBattle();
            }
            else
            {
                print("You cannot run from a trainer!");
            }
        }
        else
        {
            useMove(4, pokeData.getMovePower(ally.moveFour));
        }
    }

    public void exitBattle()
    {
        ballType = "";
        battle.SetActive(false);
        pokemon.SetActive(false);
        bag.SetActive(false);
        cm.inBattle = false;
        FindObjectOfType<Movement>().setStasis(false);
    }

    // END OF BUTTON STUFF ----------------------------------------------------

    public void useMove(int num, double[] moveStats)
    {
        currMove = num;
        canMove = false;
        bool hasPP = false;

        switch (currMove)
        {
            case 1:
                if (ally.currMoveOnePP > 0)
                {
                    hasPP = true;
                    ally.currMoveOnePP--;
                    changeTitleText(ally.name + " used " + ally.moveOne + "!", time);
                }
                break;
            case 2:
                if (ally.currMoveTwoPP > 0)
                {
                    hasPP = true;
                    ally.currMoveTwoPP--;
                    changeTitleText(ally.name + " used " + ally.moveTwo + "!", time);
                }
                break;
            case 3:
                if (ally.currMoveThreePP > 0)
                {
                    hasPP = true;
                    ally.currMoveThreePP--;
                    changeTitleText(ally.name + " used " + ally.moveThree + "!", time);
                }
                break;
            case 4:
                if (ally.currMoveFourPP > 0)
                {
                    hasPP = true;
                    ally.currMoveFourPP--;
                    changeTitleText(ally.name + " used " + ally.moveFour + "!", time);
                }
                break;
            default:
                break;
        }

        if (hasPP)
        {
            buttonTransparent();
            Invoke("moveDamage", time);

            if (moveStats[1] != 0.0 && moveStats[2] != 0)
            {
                Invoke("printAllyAttBoost", time);
                Invoke("printAllyDefBoost", time*2);
                Invoke("enemyTurnFight", time*3);
            }
            else if (moveStats[1] != 0.0 && moveStats[2] == 0)
            {
                Invoke("printAllyDefBoost", time);
                Invoke("enemyTurnFight", time*2);
            }
            else if (moveStats[1] == 0.0 && moveStats[2] != 0)
            {
                Invoke("printAllyAttBoost", time);
                Invoke("enemyTurnFight", time*2);
            }
            else
            {
                Invoke("enemyTurnFight", time);
            }
        }
        else
        {
            changeTitleText("That move has no PP! Select another move.", time);
            canMove = false;
            Invoke("moveAgain", time);
        }
    }

    public void moveDamage()
    {
        switch (currMove)
        {
            case 1:
                bc.applyMove(ally.moveOne);
                break;
            case 2:
                bc.applyMove(ally.moveTwo);
                break;
            case 3:
                bc.applyMove(ally.moveThree);
                break;
            case 4:
                bc.applyMove(ally.moveFour);
                break;
            default:
                break;
        }
    }

    public void printAllyAttBoost() {
        changeTitleText("Your " + ally.name + "'s attack rose!", time);
    }
    public void printAllyDefBoost() {
        changeTitleText("Your " + ally.name + "'s defense rose!", time);
    }

    public void changeTitleText(string message, int timeShown)
    {
        titleText.text = message;
        Invoke("changeBackTitleText", timeShown);
    }

    public void changeBackTitleText()
    {
        titleText.text = "What will " + ally.name + " do?";
    }



    // USING ITEMS

    public void usePotion(string potionType)
    {
        changeTitleText("You used a " + potionType + "!", time);
        canMove = false;
        changeBackButtonTexts();
        buttonTransparent();

        switch (potionType)
        {
            case "Potion":
                Invoke("useRegularPotion", time);
                break;
            case "Super Potion":
                Invoke("useSuperPotion", time);
                break;
            case "Hyper Potion":
                Invoke("useHyperPotion", time);
                break;
            case "Max Potion":
                Invoke("useMaxPotion", time);
                break;
        }
    }

    public void useRegularPotion()
    {
        t.pokemon[0].addHealth(20);
        enemyTurnFight();
    }
    public void useSuperPotion()
    {
        t.pokemon[0].addHealth(50);
        enemyTurnFight();
    }
    public void useHyperPotion()
    {
        t.pokemon[0].addHealth(100);
        enemyTurnFight();
    }
    public void useMaxPotion()
    {
        t.pokemon[0].currHealth = t.pokemon[0].health;
        enemyTurnFight();
    }

    public void usePokeball(string ballType, bool caught)
    {
        changeTitleText("You threw a " + ballType + "!", 2);    //TIME HERE
        changeBackButtonTexts();
        buttonTransparent();
        canMove = false;
        this.ballType = ballType;

        if (caught)
        {
            Invoke("goodShake", 2); 
            Invoke("goodShake", 4);  
            Invoke("goodShake", 6);
        }
        else
        {
            Invoke("badShake", 2);   
            Invoke("badShake", 4);  
            Invoke("badShake", 6);    
        }
    }

    public void badShake()
    {
        shake();
        if (numShakes == 3)
        {
            numShakes = 0;  
            Invoke("itBrokeFree", 2);
            Invoke("enemyTurnFight", 5);  
            canMove = true;
        }
    }

    public void goodShake()
    {
        shake();
        if (numShakes == 3)
        {
            numShakes = 0;
            Invoke("itWasCaught", 2);
            t.addPokemon(enemy);
            Invoke("moveAgain", 5f);   
            Invoke("buttonVisible", 5f); 
            Invoke("exitBattle", 5f);    
        }
    }

    public void itBrokeFree()
    {
        changeTitleText("The wild " + enemy.name + " broke free!", 3);
        ballType = "";
    }

    public void itWasCaught()
    {
        changeTitleText("The wild " + enemy.name + " was Caught!", 3);
    }

    public void shake()
    {
        numShakes++;
        changeTitleText(numShakes + "...", 2); 
        Invoke("rotateLeft", 0.15f);   
        Invoke("rotateRight", 0.4f);     
        Invoke("rotateRight", 0.65f);
        Invoke("rotateLeft", 0.9f); 
    }
    public void rotateLeft()
    {
        enemyImage.transform.Rotate(new Vector3(0, 0, 20));
    }
    public void rotateRight()
    {
        enemyImage.transform.Rotate(new Vector3(0, 0, -20));
    }

    // END OF USING ITEMS----------------------------------------------------------------------------------

    // ENEMY USING MOVES

    public void enemyTurnFight()
    {
        bc.enemyTurnFight();
    }

    public void printEnemyMove(string move, double[] moveStats)
    {
        canMove = false;
        changeBackButtonTexts();
        changeTitleText("The wild " + enemy.name + " used " + move + "!", time);

        if (moveStats[1] == 0.0 && moveStats[2] == 0)
        {
            Invoke("moveAgain", time);
            Invoke("buttonVisible", time);
        }
        else if (moveStats[1] != 0.0 && moveStats[2] != 0)
        {
            Invoke("printEnemyAttBoost", time);
            Invoke("printEnemyDefBoost", time*2);
            Invoke("moveAgain", time*3);
            Invoke("buttonVisible", time*3);
        }
        else if (moveStats[1] != 0.0 && moveStats[2] == 0)
        {
            Invoke("printEnemyDefBoost", time);
            Invoke("moveAgain", time*2);
            Invoke("buttonVisible", time*2);
        }
        else if (moveStats[1] == 0.0 && moveStats[2] != 0)
        {
            Invoke("printEnemyAttBoost", time);
            Invoke("moveAgain", time*2);
            Invoke("buttonVisible", time*2);
        }
    }

    public void printEnemyAttBoost()
    {
        changeTitleText("The wild " + enemy.name + "'s attack rose!", time);
    }
    public void printEnemyDefBoost()
    {
        changeTitleText("The wild " + enemy.name + "'s defense rose!", time);
    }

    public void moveAgain()
    {
        canMove = true;
    }

    public void buttonTransparent()
    {
        fightButton.SetActive(false);
        bagButton.SetActive(false);
        pokemonButton.SetActive(false);
        runButton.SetActive(false);
    }
    public void buttonVisible()
    {
        fightButton.SetActive(true);
        bagButton.SetActive(true);
        pokemonButton.SetActive(true);
        runButton.SetActive(true);
    }

    // ALLY TAKING DAMAGE 

    public void takeDamage(bool setToZero, int amount)
    {
        this.setToZero = setToZero;
        damageAmount = amount;
        Invoke("lowerHealth", time);
    }
    public void lowerHealth()
    {
        if (!setToZero)
        {
            ally.currHealth -= damageAmount;
        }
        else
        {
            ally.currHealth = 0;
            Invoke("pickNewPoke", time);
        }
    }

    // IF YOUR POKEMON DIES

    public void pickNewPoke()
    {
        if (!allDead())
        {
            pokemon.SetActive(true);
            print("Select a new pokemon to swap with.");
            PokemonCanvasScript pcScript = pokemon.GetComponent<PokemonCanvasScript>();
            pcScript.iDied();
        }
    }

    public bool allDead()
    {
        bool isEmpty = true;

        for (int i = 0; i < t.pokemon.Length; i++)
        {
            if (t.pokemon[i] != null)
            {
                if (t.pokemon[i].currHealth != 0)
                {
                    isEmpty = false;
                }
            }
        }
        return isEmpty;
    }


    // PRINT FOR BattleControl 

    public void printForBC(string s)   {
        print(s);
    }

    // GETTING ALLY AND ENEMY IMAGES

    public Sprite getEnemyImage(string item)
    {
        switch (item)
        {
            case "Pokeball":
                return pokeballSprite;
            case "Great Ball":
                return greatballSprite;
            case "Ultra Ball":
                return ultraBallSprite;
            case "Master Ball":
                return masterBallSprite;

            default:
                return getImage(enemy.name);
        }
    }


    public Sprite getImage(string name)
    {
        switch (name)
        {
            case "Treecko":
                return tree;
            case "Grovyle":
                return grov;
            case "Sceptile":
                return scep;
            case "Torchic":
                return torc;
            case "Combusken":
                return comb;
            case "Blaziken":
                return blaz;
            case "Mudkip":
                return mudk;
            case "Marshtomp":
                return mars;
            case "Swampert":
                return swam;
            case "Poochyena":
                return pooc;
            case "Mightyena":
                return migh;
            case "Zigzagoon":
                return zigz;
            case "Linoone":
                return lino;
            case "Wurmple":
                return wurm;
            case "Silicoon":
                return sili;
            case "Beautifly":
                return beau;
            case "Cascoon":
                return casc;
            case "Dustox":
                return dust;
            case "Lotad":
                return lota;
            case "Lombre":
                return lomb;
            case "Ludicolo":
                return ludi;
            case "Seedot":
                return seed;
            case "Nuzleaf":
                return nuzl;
            case "Shiftry":
                return shif;
            case "Nincada":
                return ninc;
            case "Ninjask":
                return ninj;
            case "Shedninja":
                return shed;
            case "Taillow":
                return tail;
            case "Swellow":
                return swel;
            case "Shroomish":
                return shro;
            case "Breloom":
                return brel;
            case "Spinda":
                return spin;
            case "Wingull":
                return wing;
            case "Pelipper":
                return peli;
            case "Surskit":
                return surs;
            case "Masquerein":
                return masq;
            case "Wailmer":
                return wailm;
            case "Waillord":
                return waill;
            case "Skitty":
                return skit;
            case "Delcatty":
                return delc;
            case "Kecleon":
                return kecl;
            case "Baltoy":
                return balt;
            case "Claydol":
                return clay;
            case "Nosepass":
                return nose;
            case "Torkoal":
                return tork;
            case "Sableye":
                return sabl;
            case "Barboach":
                return barb;
            case "Whiscash":
                return whisc;
            case "Luvdisc":
                return luvd;
            case "Corphish":
                return corp;
            case "Crawdaunt":
                return craw;
            case "Feebas":
                return feeb;
            case "Milotic":
                return milo;
            case "Carvanha":
                return carv;
            case "Sharpedo":
                return shar;
            case "Trapinch":
                return trap;
            case "Vibrava":
                return vibr;
            case "Flygon":
                return flyg;
            case "Makuhita":
                return maku;
            case "Hariyama":
                return hari;
            case "Electrike":
                return elec;
            case "Manectric":
                return mane;
            case "Numel":
                return nume;
            case "Camerupt":
                return came;
            case "Spheal":
                return sphe;
            case "Sealeo":
                return seal;
            case "Walrein":
                return walr;
            case "Cacnea":
                return cacn;
            case "Cacturne":
                return cact;
            case "Snorunt":
                return snor;
            case "Glalie":
                return glal;
            case "Lunatone":
                return luna;
            case "Solrock":
                return solr;
            case "Azurill":
                return azuri;
            case "Spoink":
                return spoi;
            case "Grumpug":
                return grum;
            case "Plusle":
                return plus;
            case "Minun":
                return seal;
            case "Mawhile":
                return mawi;
            case "Meditite":
                return medit;
            case "Medicham":
                return medic;
            case "Swablu":
                return swab;
            case "Altaria":
                return alta;
            case "Wynaut":
                return wyna;
            case "Duskell":
                return dusk;
            case "Dusclops":
                return dusc;
            case "Roselia":
                return rose;
            case "Vigorath":
                return vigo;
            case "Slaking":
                return slaki;
            case "Gulpin":
                return gulp;
            case "Swalot":
                return swal;
            case "Tropius":
                return trop;
            case "Whismur":
                return whism;
            case "Loudred":
                return loud;
            case "Exploud":
                return expl;
            case "Clampearl":
                return clam;
            case "Huntail":
                return hunt;
            case "Absol":
                return abso;
            case "Shuppet":
                return shup;
            case "Banette":
                return bane;
            case "Seviper":
                return sevi;
            case "Zangoose":
                return zang;
            case "Relicanth":
                return reli;
            case "Aron":
                return aron;
            case "Lairon":
                return lair;
            case "Aggron":
                return aggr;
            case "Castform":
                return cast;
            case "Volbeat":
                return volb;
            case "Illumise":
                return illu;
            case "Lileep":
                return lile;
            case "Cradily":
                return crad;
            case "Anorith":
                return anor;
            case "Armaldo":
                return arma;
            case "Ralts":
                return ralt;
            case "Kirlia":
                return kirl;
            case "Gardevoir":
                return gard;
            case "Bagon":
                return bago;
            case "Shelgon":
                return shel;
            case "Salamence":
                return sala;
            case "Beldum":
                return beld;
            case "Metang":
                return metan;
            case "Metagross":
                return metag;
            case "Regirock":
                return regir;
            case "Regice":
                return regic;
            case "Registeel":
                return regis;
            case "Kyogre":
                return kyog;
            case "Groudon":
                return grou;
            case "Rayquaza":
                return rayq;

            default:
                return rayq;
        }
    }
}
