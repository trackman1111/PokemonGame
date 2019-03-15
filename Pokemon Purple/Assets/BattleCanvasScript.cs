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

    public Image enemyImage;
    public Image allyImage;

    public GameObject pokemon;
    public GameObject bag;
    public GameObject battle;

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
    private PokemonData pokeData;
    private int cursor;

    // Start is called before the first frame update
    void Start()
    {
        cm = canvasManager.GetComponent<CanvasManager>();
        pokeData = new PokemonData();

        fightButtonText.text = "-> FIGHT";
        runButtonText.text = "RUN";
        bagButtonText.text = "BAG";
        pokemonButtonText.text = "POKEMON";
        cursor = 1;
    }

    // Update is called once per frame
    void Update()
    {
        setArrow();

        if ( t.pokemon[0] != null )
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
            titleText.text = "What will \n" + ally.name + " do?";

            allyImage.sprite = getImage(ally.name);
            enemyImage.sprite = getImage(enemy.name);
        }

        if ( Input.GetKeyDown(KeyCode.RightArrow) && (cursor == 1 || cursor == 3))
        {
            cursor++;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && (cursor == 2 || cursor == 4))
        {
            cursor--;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && cursor > 2)
        {
            cursor-=2;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) && cursor < 3)
        {
            cursor+=2;
        }

        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            if (cursor == 1)
            {
                catchPokemon();
            }
            else if (cursor == 2)
            {
                bagBattle();
            }
            else if (cursor == 3)
            {
                pokemonBattle();
            }
            else if (cursor == 4)
            {
                exitBattle();
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape) && (fightButtonText.text.Equals(ally.moveOne) || bagButtonText.text.Equals(ally.moveTwo)))
        {
            cursor = 1;
            fightButtonText.text = "-> FIGHT";
            bagButtonText.text = "BAG";
            pokemonButtonText.text = "POKEMON";
            runButtonText.text = "RUN";
            titleText.text = "What will \n" + ally.name + " do?";
        }
    }

    public void setEnemy(Pokemon enemy)
    {
        this.enemy = enemy;
    }

    // ON FIGHT BUTTON CLICK

    public void catchPokemon()
    {
        cursor = 1;
        if (fightButtonText.text.Equals("-> FIGHT"))
        {
            fightButtonText.text = "-> " + ally.moveOne;
            bagButtonText.text = ally.moveTwo;
            pokemonButtonText.text = ally.moveThree;
            runButtonText.text = ally.moveFour;
        }
        else
        {
            bc.applyMove(ally.moveOne);

            fightButtonText.text = "-> FIGHT";
            runButtonText.text = "RUN";
            bagButtonText.text = "BAG";
            pokemonButtonText.text = "POKEMON";
        }
    }

    // ON BAG BUTTON CLICK

    public void bagBattle()
    {
        if (bagButtonText.text.Equals("-> BAG"))
        {
            bag.SetActive(true);
        }
        else
        {
            bc.applyMove(ally.moveTwo);

            cursor = 1;
            fightButtonText.text = "-> FIGHT";
            runButtonText.text = "RUN";
            bagButtonText.text = "BAG";
            pokemonButtonText.text = "POKEMON";
        }
    }

    // ON POKEMON BUTTON CLICK

    public void pokemonBattle()
    {
        if (pokemonButtonText.text.Equals("-> POKEMON"))
        {
            pokemon.SetActive(true);
        }
        else
        {
            bc.applyMove(ally.moveThree);

            cursor = 1;
            fightButtonText.text = "-> FIGHT";
            runButtonText.text = "RUN";
            bagButtonText.text = "BAG";
            pokemonButtonText.text = "POKEMON";
        }
    }

    // ON RUN BUTTON CLICK

    public void exitBattle()
    {
        if (runButtonText.text.Equals("-> RUN"))
        {
            battle.SetActive(false);
            pokemon.SetActive(false);
            bag.SetActive(false);
            cm.inBattle = false;
            FindObjectOfType<Movement>().setStasis(false);
        }
        else
        {
            bc.applyMove(ally.moveFour);

            cursor = 1;
            fightButtonText.text = "-> FIGHT";
            runButtonText.text = "RUN";
            bagButtonText.text = "BAG";
            pokemonButtonText.text = "POKEMON";
        }
    }

    public void startBattle(Pokemon poke)
    {
        bc = new BattleControl(poke, t);
    }

    public void setArrow()
    {
        if (fightButtonText.text.Equals("FIGHT") || bagButtonText.text.Equals("BAG"))
        {
            if (cursor == 1)
            {
                fightButtonText.text = "-> FIGHT";
                bagButtonText.text = "BAG";
                pokemonButtonText.text = "POKEMON";
                runButtonText.text = "RUN";
            }
            else if (cursor == 2)
            {
                fightButtonText.text = "FIGHT";
                bagButtonText.text = "-> BAG";
                pokemonButtonText.text = "POKEMON";
                runButtonText.text = "RUN";

            }
            else if (cursor == 3)
            {
                fightButtonText.text = "FIGHT";
                bagButtonText.text = "BAG";
                pokemonButtonText.text = "-> POKEMON";
                runButtonText.text = "RUN";
            }
            else if (cursor == 4)
            {
                fightButtonText.text = "FIGHT";
                bagButtonText.text = "BAG";
                pokemonButtonText.text = "POKEMON";
                runButtonText.text = "-> RUN";
            }
        }
        else
        {
            if (cursor == 1)
            {
                fightButtonText.text = "-> " + ally.moveOne;
                bagButtonText.text = ally.moveTwo;
                pokemonButtonText.text = ally.moveThree;
                runButtonText.text = ally.moveFour;
            }
            else if (cursor == 2)
            {
                fightButtonText.text = ally.moveOne;
                bagButtonText.text = "-> " + ally.moveTwo;
                pokemonButtonText.text = ally.moveThree;
                runButtonText.text = ally.moveFour;
            }
            else if (cursor == 3)
            {
                fightButtonText.text = ally.moveOne;
                bagButtonText.text = ally.moveTwo;
                pokemonButtonText.text = "-> " + ally.moveThree;
                runButtonText.text = ally.moveFour;
            }
            else if (cursor == 4)
            {
                fightButtonText.text = ally.moveOne;
                bagButtonText.text = ally.moveTwo;
                pokemonButtonText.text = ally.moveThree;
                runButtonText.text = "-> " + ally.moveFour;
            }
        }
    }

        public Sprite getImage(string name)
    {
        if (name.Equals("Treecko"))
        {
            return tree;
        }
        else if (name.Equals("Grovyle"))
        {
            return grov;
        }
        else if (name.Equals("Sceptile"))
        {
            return scep;
        }
        else if (name.Equals("Torchic"))
        {
            return torc;
        }
        else if (name.Equals("Combusken"))
        {
            return comb;
        }
        else if (name.Equals("Blaziken"))
        {
            return blaz;
        }
        else if (name.Equals("Mudkip"))
        {
            return mudk;
        }
        else if (name.Equals("Marshtomp"))
        {
            return mars;
        }
        else if (name.Equals("Swampert"))
        {
            return swam;
        }
        else if (name.Equals("Poochyena"))
        {
            return pooc;
        }
        else if (name.Equals("Mightyena"))
        {
            return migh;
        }
        else if (name.Equals("Zigzagoon"))
        {
            return zigz;
        }
        else if (name.Equals("Linoone"))
        {
            return lino;
        }
        else if (name.Equals("Wurmple"))
        {
            return wurm;
        }
        else if (name.Equals("Silicoon"))
        {
            return sili;
        }
        else if (name.Equals("Beautifly"))
        {
            return beau;
        }
        else if (name.Equals("Cascoon"))
        {
            return casc;
        }
        else if (name.Equals("Dustox"))
        {
            return dust;
        }
        else if (name.Equals("Lotad"))
        {
            return lota;
        }
        else if (name.Equals("Lombre"))
        {
            return lomb;
        }
        else if (name.Equals("Ludicolo"))
        {
            return ludi;
        }
        else if (name.Equals("Seedot"))
        {
            return seed;
        }
        else if (name.Equals("Nuzleaf"))
        {
            return nuzl;
        }
        else if (name.Equals("Shiftry"))
        {
            return shif;
        }
        else if (name.Equals("Nincada"))
        {
            return ninc;
        }
        else if (name.Equals("Ninjask"))
        {
            return ninj;
        }
        else if (name.Equals("Shedinja"))
        {
            return shed;
        }
        else if (name.Equals("Taillow"))
        {
            return tail;
        }
        else if (name.Equals("Swellow"))
        {
            return swel;
        }
        else if (name.Equals("Shroomish"))
        {
            return shro;
        }
        else if (name.Equals("Breloom"))
        {
            return brel;
        }
        else if (name.Equals("Spinda"))
        {
            return spin;
        }
        else if (name.Equals("Wingull"))
        {
            return wing;
        }
        else if (name.Equals("Pelipper"))
        {
            return peli;
        }
        else if (name.Equals("Surskit"))
        {
            return surs;
        }
        else if (name.Equals("Masquerain"))
        {
            return masq;
        }
        else if (name.Equals("Wailmer"))
        {
            return wailm;
        }
        else if (name.Equals("Wailord"))
        {
            return waill;
        }
        else if (name.Equals("Skitty"))
        {
            return skit;
        }
        else if (name.Equals("Delcatty"))
        {
            return delc;
        }
        else if (name.Equals("Kecleon"))
        {
            return kecl;
        }
        else if (name.Equals("Baltoy"))
        {
            return balt;
        }
        else if (name.Equals("Claydol"))
        {
            return clay;
        }
        else if (name.Equals("Nosepass"))
        {
            return nose;
        }
        else if (name.Equals("Torkoal"))
        {
            return tork;
        }
        else if (name.Equals("Sableye"))
        {
            return sabl;
        }
        else if (name.Equals("Barboach"))
        {
            return barb;
        }
        else if (name.Equals("Whiscash"))
        {
            return whisc;
        }
        else if (name.Equals("Luvdisc"))
        {
            return luvd;
        }
        else if (name.Equals("Corphish"))
        {
            return corp;
        }
        else if (name.Equals("Crawdaunt"))
        {
            return craw;
        }
        else if (name.Equals("Feebas"))
        {
            return feeb;
        }
        else if (name.Equals("Milotic"))
        {
            return milo;
        }
        else if (name.Equals("Carvanha"))
        {
            return carv;
        }
        else if (name.Equals("Sharpedo"))
        {
            return shar;
        }
        else if (name.Equals("Trapinch"))
        {
            return trap;
        }
        else if (name.Equals("Vibrava"))
        {
            return vibr;
        }
        else if (name.Equals("Flygon"))
        {
            return flyg;
        }
        else if (name.Equals("Makuhita"))
        {
            return maku;
        }
        else if (name.Equals("Hariyama"))
        {
            return hari;
        }
        else if (name.Equals("Electrike"))
        {
            return elec;
        }
        else if (name.Equals("Manectric"))
        {
            return mane;
        }
        else if (name.Equals("Numel"))
        {
            return nume;
        }
        else if (name.Equals("Camerupt"))
        {
            return came;
        }
        else if (name.Equals("Spheal"))
        {
            return sphe;
        }
        else if (name.Equals("Sealeo"))
        {
            return seal;
        }
        else if (name.Equals("Walrein"))
        {
            return walr;
        }
        else if (name.Equals("Cacnea"))
        {
            return cacn;
        }
        else if (name.Equals("Cacturne"))
        {
            return cact;
        }
        else if (name.Equals("Snorunt"))
        {
            return snor;
        }
        else if (name.Equals("Glalie"))
        {
            return glal;
        }
        else if (name.Equals("Lunatone"))
        {
            return luna;
        }
        else if (name.Equals("Solrock"))
        {
            return solr;
        }
        else if (name.Equals("Azurill"))
        {
            return azuri;
        }
        else if (name.Equals("Spoink"))
        {
            return spoi;
        }
        else if (name.Equals("Grumpig"))
        {
            return grum;
        }
        else if (name.Equals("Plusle"))
        {
            return plus;
        }
        else if (name.Equals("Minun"))
        {
            return minu;
        }
        else if (name.Equals("Mawile"))
        {
            return mawi;
        }
        else if (name.Equals("Meditite"))
        {
            return medit;
        }
        else if (name.Equals("Medicham"))
        {
            return medic;
        }
        else if (name.Equals("Swablu"))
        {
            return swab;
        }
        else if (name.Equals("Altaria"))
        {
            return alta;
        }
        else if (name.Equals("Wynaut"))
        {
            return wyna;
        }
        else if (name.Equals("Duskell"))
        {
            return dusk;
        }
        else if (name.Equals("Dusclops"))
        {
            return dusc;
        }
        else if (name.Equals("Roselia"))
        {
            return rose;
        }
        else if (name.Equals("Slakoth"))
        {
            return slako;
        }
        else if (name.Equals("Vigorath"))
        {
            return vigo;
        }
        else if (name.Equals("Slaking"))
        {
            return slaki;
        }
        else if (name.Equals("Gulpin"))
        {
            return gulp;
        }
        else if (name.Equals("Swalot"))
        {
            return swal;
        }
        else if (name.Equals("Tropius"))
        {
            return trop;
        }
        else if (name.Equals("Whismur"))
        {
            return whism;
        }
        else if (name.Equals("Loudred"))
        {
            return loud;
        }
        else if (name.Equals("Exploud"))
        {
            return expl;
        }
        else if (name.Equals("Clampearl"))
        {
            return clam;
        }
        else if (name.Equals("Huntail"))
        {
            return hunt;
        }
        else if (name.Equals("Absol"))
        {
            return abso;
        }
        else if (name.Equals("Shuppet"))
        {
            return shup;
        }
        else if (name.Equals("Banette"))
        {
            return bane;
        }
        else if (name.Equals("Seviper"))
        {
            return sevi;
        }
        else if (name.Equals("Zangoose"))
        {
            return zang;
        }
        else if (name.Equals("Relicanth"))
        {
            return reli;
        }
        else if (name.Equals("Aron"))
        {
            return aron;
        }
        else if (name.Equals("Lairon"))
        {
            return lair;
        }
        else if (name.Equals("Aggron"))
        {
            return aggr;
        }
        else if (name.Equals("Castform"))
        {
            return cast;
        }
        else if (name.Equals("Volbeat"))
        {
            return volb;
        }
        else if (name.Equals("Illumise"))
        {
            return illu;
        }
        else if (name.Equals("Lileep"))
        {
            return lile;
        }
        else if (name.Equals("Cradily"))
        {
            return crad;
        }
        else if (name.Equals("Anorith"))
        {
            return anor;
        }
        else if (name.Equals("Armaldo"))
        {
            return arma;
        }
        else if (name.Equals("Ralts"))
        {
            return ralt;
        }
        else if (name.Equals("Kirlia"))
        {
            return kirl;
        }
        else if (name.Equals("Gardevoir"))
        {
            return gard;
        }
        else if (name.Equals("Bagon"))
        {
            return bago;
        }
        else if (name.Equals("Salamance"))
        {
            return sala;
        }
        else if (name.Equals("Beldum"))
        {
            return beld;
        }
        else if (name.Equals("Metang"))
        {
            return metan;
        }
        else if (name.Equals("Metagross"))
        {
            return metag;
        }
        else if (name.Equals("Regirock"))
        {
            return regir;
        }
        else if (name.Equals("Regice"))
        {
            return regic;
        }
        else if (name.Equals("Registeel"))
        {
            return regis;
        }
        else if (name.Equals("Kyogre"))
        {
            return kyog;
        }
        else if (name.Equals("Groudon"))
        {
            return grou;
        }
        else if (name.Equals("Rayquaza"))
        {
            return rayq;
        }
        else
        {
            return other;
        }
    }
}
