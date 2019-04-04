using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PokemonCanvasScript : MonoBehaviour
{
    // All the objects that I use to make canvas look ice 


    public TextMeshProUGUI p1name;
    public TextMeshProUGUI p1lvl;
    public TextMeshProUGUI p1hp;
    public Image p1image;

    public TextMeshProUGUI p2name;
    public TextMeshProUGUI p2lvl;
    public TextMeshProUGUI p2hp;
    public Image p2image;

    public TextMeshProUGUI p3name;
    public TextMeshProUGUI p3lvl;
    public TextMeshProUGUI p3hp;
    public Image p3image;

    public TextMeshProUGUI p4name;
    public TextMeshProUGUI p4lvl;
    public TextMeshProUGUI p4hp;
    public Image p4image;

    public TextMeshProUGUI p5name;
    public TextMeshProUGUI p5lvl;
    public TextMeshProUGUI p5hp;
    public Image p5image;

    public TextMeshProUGUI p6name;
    public TextMeshProUGUI p6lvl;
    public TextMeshProUGUI p6hp;
    public Image p6image;

    public TextMeshProUGUI description;

    public GameObject pokePanel;
    public Trainer trainer;

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

    Pokemon[] pokemon;
    public GameObject pokemonCanvas;

    int pok1;
    int pok2;
    int revPoke;
    private bool pressed;
    private bool firstPicked;
    private bool secondPicked;
    public bool revived;
    public GameObject battleCanvas;

    // Start is called before the first frame update
    void Start()
    {
        // Sets all the texts to "" and the images alpha to 0, making it invisable 
        pressed = false;
        firstPicked = false;
        revived = true;
        pok1 = 0;
        pok2 = 0;
        revPoke = 0;
        pokemon = trainer.pokemon;

        p1name.text = "";
        p1lvl.text =  "";
        p1hp.text = "";
        p1image.GetComponent<Image>();
        p1image.GetComponent<SpriteRenderer>();

        // a temp color with 0 alpha, used to set all 6 images to transparent.
        Color temp = p1image.color;
        temp.a = 0;
        p1image.color = temp;

        p2name.text = "";
        p2lvl.text = "";
        p2hp.text = "";
        p2image.GetComponent<Image>();
        p2image.GetComponent<SpriteRenderer>();
        p2image.color = temp;

        p3name.text = "";
        p3lvl.text = "";
        p3hp.text = "";
        p3image.GetComponent<Image>();
        p3image.GetComponent<SpriteRenderer>();
        p3image.color = temp;

        p4name.text = "";
        p4lvl.text = "";
        p4hp.text = "";
        p4image.GetComponent<Image>();
        p4image.GetComponent<SpriteRenderer>();
        p4image.color = temp;

        p5name.text = "";
        p5lvl.text = "";
        p5hp.text = "";
        p5image.GetComponent<Image>();
        p5image.GetComponent<SpriteRenderer>();
        p5image.color = temp;


        p6name.text = "";
        p6lvl.text = "";
        p6hp.text = "";
        p6image.GetComponent<Image>();
        p6image.GetComponent<SpriteRenderer>();
        p6image.color = temp;
    }

    // Update is called once per frame
    void Update()
    {
        // if the canvas is open, check all this stuff. efficient
        if (pokePanel.activeSelf)
        {
            pokemon = trainer.pokemon;

            // FOR ALL OF THESE
            // if the name is "", then the pokemon doesnt exist, so i set all of the texts to "" and the image alpha to 0
            // if the pokemon does exist, sets all images and texts acordingly


            if (pokemon[0] == null)
            {
                p1name.text = "";
                p1lvl.text = "";
                p1hp.text = "";

                Color temp = p1image.color;
                temp.a = 0;
                p1image.color = temp;
            }
            else
            {
                p1name.text = pokemon[0].name + "";
                p1lvl.text = "Lvl " + pokemon[0].level;
                p1hp.text = pokemon[0].currHealth + "/" + pokemon[0].health;

                Color temp = p1image.color;
                temp.a = 255;
                p1image.color = temp;
                p1image.sprite = getImage(pokemon[0].name);
            }

            if (pokemon[1] == null)
            {
                p2name.text = "";
                p2lvl.text = "";
                p2hp.text = "";

                Color temp = p2image.color;
                temp.a = 0;
                p2image.color = temp;
            }
            else
            {
                p2name.text = pokemon[1].name;
                p2lvl.text = "Lvl " + pokemon[1].level;
                p2hp.text = pokemon[1].currHealth + "/" + pokemon[1].health;

                Color temp = p2image.color;
                temp.a = 255;
                p2image.color = temp;
                p2image.sprite = getImage(pokemon[1].name);
            }


            if (pokemon[2] == null)
            {
                p3name.text = "";
                p3lvl.text = "";
                p3hp.text = "";

                Color temp = p3image.color;
                temp.a = 0;
                p3image.color = temp;
            }
            else
            {
                p3name.text = pokemon[2].name;
                p3lvl.text = "Lvl " + pokemon[2].level;
                p3hp.text = pokemon[2].currHealth + "/" + pokemon[2].health;

                Color temp = p3image.color;
                temp.a = 255;
                p3image.color = temp;
                p3image.sprite = getImage(pokemon[2].name);
            }


            if (pokemon[3] == null)
            {
                p4name.text = "";
                p4lvl.text = "";
                p4hp.text = "";

                Color temp = p4image.color;
                temp.a = 0;
                p4image.color = temp;
            }
            else
            {
                p4name.text = pokemon[3].name;
                p4lvl.text = "Lvl " + pokemon[3].level;
                p4hp.text = pokemon[3].currHealth + "/" + pokemon[3].health;

                Color temp = p4image.color;
                temp.a = 255;
                p4image.color = temp;
                p4image.sprite = getImage(pokemon[3].name);
            }


            if (pokemon[4] == null)
            {
                p5name.text = "";
                p5lvl.text = "";
                p5hp.text = "";

                Color temp = p5image.color;
                temp.a = 0;
                p5image.color = temp;
            }
            else
            {
                p5name.text = pokemon[4].name;
                p5lvl.text = "Lvl " + pokemon[4].level;
                p5hp.text = pokemon[4].currHealth + "/" + pokemon[4].health;

                Color temp = p5image.color;
                temp.a = 255;
                p5image.color = temp;
                p5image.sprite = getImage(pokemon[4].name);
            }


            if (pokemon[5] == null)
            {
                p6name.text = "";
                p6lvl.text = "";
                p6hp.text = "";

                Color temp = p6image.color;
                temp.a = 0;
                p6image.color = temp;
            }
            else
            {
                p6name.text = pokemon[5].name;
                p6lvl.text = "Lvl " + pokemon[5].level;
                p6hp.text = pokemon[5].currHealth + "/" + pokemon[5].health;

                Color temp = p6image.color;
                temp.a = 255;
                p6image.color = temp;
                p6image.sprite = getImage(pokemon[5].name);
            }
        }

        // DONE SETTING TEXTS

        // SWAP USING I

        if (Input.GetKeyDown(KeyCode.I))
        {
            if (pokemon[1] != null)
            {
                pressed = true;
                description.text = ("Use 1-6 to highlight a pokemon to swap, then press Right Shift to confirm selection");
            }
            else
            {
                description.text = ("Not enough Pokemon to swap.");
            }
        }


        if (pressed)
        {
            pickPoke1();
        }

        if (firstPicked)
        {
            pickPoke2();
        }

        if (!revived)
        {
            pickRevPoke();
        }
    }

    public void iDied()
    {
        firstPicked = true;
        pok1 = 1;
        description.text = "Select a pokemon to swap with " + trainer.pokemon[0].name;
        if (trainer.pokemon[0].currHealth != 0)
        {
            pokemonCanvas.SetActive(false);
        }
    }

    public void pickPoke1()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            pok1 = 1;
            description.text = pokemon[pok1 - 1].name + " is highlighted";
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            pok1 = 2;
            description.text = (pokemon[pok1 - 1].name + " is highlighted");
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            if (pokemon[2] != null)
            {
                pok1 = 3;
                description.text = (pokemon[pok1 - 1].name + " is highlighted");
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            if (pokemon[3] != null)
            {
                pok1 = 4;
                description.text = (pokemon[pok1 - 1].name + " is highlighted");
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            if (pokemon[4] != null)
            {
                pok1 = 5;
                description.text = (pokemon[pok1 - 1].name + " is highlighted");
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            if (pokemon[5] != null)
            {
                pok1 = 6;
                description.text = (pokemon[pok1 - 1].name + " is highlighted");
            }
        }

        if (Input.GetKeyDown(KeyCode.RightShift))
        {

            if (pok1 != 0 && pokemon[pok1 - 1] != null)
            {
                description.text = (pokemon[pok1 - 1].name + " was selected. Select the pokemon you would like to swap " + pokemon[pok1 - 1].name + " with");
                firstPicked = true;
                pok2 = 0;
                pressed = false;

            }
        }
    }

    public void pickPoke2()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            pok2 = 1;
            description.text = (pokemon[pok2 - 1].name + " is highlighted");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            pok2 = 2;
            description.text = (pokemon[pok2 - 1].name + " is highlighted");
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            if (pokemon[2] != null)
            {
                pok2 = 3;
                description.text = (pokemon[pok2 - 1].name + " is highlighted");
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            if (pokemon[3] != null)
            {
                pok2 = 4;
                description.text = (pokemon[pok2 - 1].name + " is highlighted");
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            if (pokemon[4] != null)
            {
                pok2 = 5;
                description.text = (pokemon[pok2 - 1].name + " is highlighted");
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            if (pokemon[5] != null)
            {
                pok2 = 6;
                description.text = (pokemon[pok2 - 1].name + " is highlighted");
            }
        }

        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            if (pok2 != 0 && pokemon[pok2 - 1] != null)
            {
                firstPicked = false;
                description.text = (pokemon[pok2 - 1].name + " was selected");


                if (pok1 != pok2)
                {
                    swapPokemon();
                }
                else
                {
                    description.text = ("Select two different pokemon to swap.");
                }
            }
        }
    }

    public void pickRevPoke()
    { 
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (pokemon[0] != null)
            {
                revPoke = 1;
                description.text = (pokemon[revPoke - 1].name + " is highlighted");
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (pokemon[1] != null)
            {
                revPoke = 2;
                description.text = (pokemon[revPoke - 1].name + " is highlighted");
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            if (pokemon[2] != null)
            {
                revPoke = 3;
                description.text = (pokemon[revPoke - 1].name + " is highlighted");
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            if (pokemon[3] != null)
            {
                revPoke = 4;
                description.text = (pokemon[revPoke - 1].name + " is highlighted");
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            if (pokemon[4] != null)
            {
                revPoke = 5;
                description.text = (pokemon[revPoke - 1].name + " is highlighted");
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            if (pokemon[5] != null)
            {
                revPoke = 6;
                description.text = (pokemon[revPoke - 1].name + " is highlighted");
            }
        }
        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            if (revPoke != 0)
            {
                if (trainer.pokemon[revPoke - 1].currHealth == 0)
                {
                    trainer.pokemon[revPoke - 1].heal();
                    description.text = (pokemon[pok2 - 1].name + " was Revived!");
                    revPoke = 0;
                    revived = true;
                }
                else
                {
                    description.text = "This pokemon is not dead. Select a different pokemon.";
                }
            }
        }
    }

    public void swapPokemon()
    {
        pok1--;
        pok2--;

        int movedPoke = pok1;
        int desiredPoke = pok2;

        if (battleCanvas.activeSelf)
        {
            if (movedPoke == 0)
            {
                BattleCanvasScript bcScript = battleCanvas.GetComponent<BattleCanvasScript>();
                bcScript.changeTitleText("Good Stuff " + pokemon[movedPoke].name + "!", 2);

                Invoke("printNewPoke", 2);
                Invoke("enemyTurnFight", 4);
            }
            else
            {
                Pokemon temp = pokemon[pok2];
                pokemon[pok2] = pokemon[pok1];
                pokemon[pok1] = temp;

                enemyTurnFight();
            }
        }
        else
        {
            Pokemon temp = pokemon[pok2];
            pokemon[pok2] = pokemon[pok1];
            pokemon[pok1] = temp;
        }

        pokemonCanvas.SetActive(false);
        description.text = "";
    }

    public void printNewPoke()
    {
        BattleCanvasScript bcScript = battleCanvas.GetComponent<BattleCanvasScript>();

        Pokemon temp = pokemon[pok2];
        pokemon[pok2] = pokemon[pok1];
        pokemon[pok1] = temp;

        bcScript.changeTitleText("Lets Go " + pokemon[0].name + "!", 2);
    }

    public void enemyTurnFight()
    {
        BattleCanvasScript bcScript = battleCanvas.GetComponent<BattleCanvasScript>();
        bcScript.enemyTurnFight();
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
