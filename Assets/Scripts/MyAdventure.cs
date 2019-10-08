using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAdventure : MonoBehaviour
{
    private enum States
    {
        start,
        deel1,
        deel2,
        ga,
        kind,
        help,
        blijf,
        piloot,
        vrouw,
        kalm,
        niets,
        rust,
        schot,
        merk,
        hoofd,
        gat,
        onderzoek,
        springnee,
        springzeil,
        springzeilja,
        springzeilnee
    }
    private States currentStates = States.start;
    private bool OpOnderzoek;


    // Start is called before the first frame update
    void Start()

    {
        showmainmenu();
    }
    // Update is called once per frame
    void Update()
    {
        print(currentStates);
    }
    void OnUserInput(string input)
    {
        if (currentStates == States.start)
        {
            if (input == "start")
                StartIntro();
        }
        else if (currentStates == States.deel1)
        {
            if (input == "deel1")
            {
                deel1();
            }
        }
        else if (currentStates == States.deel2)
        {
            if (input == "ja")
            {
                ja();
            }
            if (input == "nee")
            {
                nee();
            }
            if (input == "onderzoek")
            {
                onderzoek();
            }
        }
        else if (currentStates == States.kind)
        {
            if (input == "kind")
            {
                kind();
            }

        }else if(currentStates == States.onderzoek)
        {
            if(input == "ga")
            {
                nee();
            }
        }
        else if (currentStates == States.ga)
        {
            if (input == "help")
            {
                help();
            }
            if (input == "blijf")
            {
                blijf();
            }
        }
        else if (currentStates == States.vrouw)
        {
            if (input == "vrouw")
            {
                vrouw();
            }

        }
        else if (currentStates == States.rust)
        {
            if (input == "kalm")
            {
                kalm();
            }
            if (input == "niets")
            {
                niets();
            }
        }

        else if (currentStates == States.schot)
        {
            if (input == "schot")
            {
                schot();
            }

            else if (currentStates == States.merk)
            {
                if (input == "merk")
                {
                    merk();
                }
            }
            else if (currentStates == States.hoofd)
            {
                if (input == "hoofd")
                {
                    hoofd();
                }
            }
            else if (currentStates == States.piloot)
            {
                if (input == "piloot")
                {
                    piloot();
                }


            }else if(currentStates == States.springnee)
            {
                if(input == "kind")
                {

                }else if(input == "gat" && OpOnderzoek)
                {

                }
            }


        }
    }

        void StartIntro()
        {
            Terminal.ClearScreen();
            Terminal.WriteLine("het was een normale dag");
            Terminal.WriteLine("je reisde veel maar");
            Terminal.WriteLine("nu was het anders");
            Terminal.WriteLine("");
            Terminal.WriteLine("je bent rustig aan het");
            Terminal.WriteLine("lezen..... maar wat hoor");
            Terminal.WriteLine("ik nu  het is het vliegtuig");
            Terminal.WriteLine("help hem te overleven");
            Terminal.WriteLine("");
            Terminal.WriteLine("typ deel1 om veder te gaan");
            currentStates = States.deel1;

        }


        void deel1()
        {
            Terminal.ClearScreen();
            Terminal.WriteLine("je zit op een vliegtuig dat op");
            Terminal.WriteLine("het punt staat van instorten");
            Terminal.WriteLine("het laadruim sprinkt open");
            Terminal.WriteLine("ga je er uit springen");
            Terminal.WriteLine("");
            Terminal.WriteLine("type ja om te springen");
            Terminal.WriteLine("type nee om te blijfen zitten");
            Terminal.WriteLine("type onderzoek om te onderzoeken");
            currentStates = States.deel2;

        }
        void ja()
        {
            Terminal.ClearScreen();
            Terminal.WriteLine("je valt hard naar beneden maar je ");
            Terminal.WriteLine("hebt er niet goed over naagedacht");
            Terminal.WriteLine("je ziet land en je klalt tegen");
            Terminal.WriteLine("een rots aan en je gaat dood");
            Terminal.WriteLine("");
            Terminal.WriteLine("");
            Terminal.WriteLine("");
            currentStates = States.start;

        }



    void nee()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("je blijft zitten maar je merkt");
        Terminal.WriteLine("dat het steets erger wordt");
        Terminal.WriteLine("je ziet opeens dat er een groot gat");
        Terminal.WriteLine("zit in het vliegtuig");
        Terminal.WriteLine("");
        Terminal.WriteLine("");
        Terminal.WriteLine("");
        Terminal.WriteLine("");
        Terminal.WriteLine("type kind om verder te gaan");
        if (OpOnderzoek)
        {
            Terminal.WriteLine("type Gat om naar het ");
            Terminal.WriteLine("gat te lopen ");
        }
        currentStates = States.springnee;
    }


        void Gat()
        {
            Terminal.ClearScreen();
            Terminal.WriteLine("je kijkt naar beneden");
            Terminal.WriteLine("je twijfelt of je gaat");
            Terminal.WriteLine("springen met het zijl");
            Terminal.WriteLine("");
            Terminal.WriteLine("");
            Terminal.WriteLine("type Spring om met het zijl te springen");
            Terminal.WriteLine("type staan om te blijfen staan");
            currentStates = States.gat;

        }


        void onderzoek()
        {
            Terminal.ClearScreen();
            Terminal.WriteLine("je kijkt om je heen en je ziet een kist ");
            Terminal.WriteLine("je maakt die kist open en je ziet een   zeil");
            Terminal.WriteLine("je neemt hem mee en je gaat weer zitten");
            Terminal.WriteLine("");
            Terminal.WriteLine("");
            Terminal.WriteLine("type ga om verder te gaan");
            Terminal.WriteLine("");
            OpOnderzoek = true;
            currentStates = States.onderzoek;
        }


        void kind()
        {
            Terminal.ClearScreen();
            Terminal.WriteLine("bij het gat zit een kind ");
            Terminal.WriteLine("je ziet dat de riem van");
            Terminal.WriteLine("het kind het niet");
            Terminal.WriteLine("lang meer houd");
            Terminal.WriteLine("");
            Terminal.WriteLine("type help om het kind te helpen");
            Terminal.WriteLine("type blijf om te blijfen ziten en");
            Terminal.WriteLine("het kind aan zijn lot over te laten");
            currentStates = States.ga;
        }



        void help()
        {
            Terminal.ClearScreen();
            Terminal.WriteLine("je staat op en je loopt naar het kind");
            Terminal.WriteLine(" maar je bent te laat");
            Terminal.WriteLine("de riem schiet los en het kind vliegt met een ruk uit het vliegtuig");
            Terminal.WriteLine("je weet nog net het kind met een hand te pakken");
            Terminal.WriteLine("er valt een kofer op je hand en jullie vliegen er samen uit en jullie gaan dood");
            Terminal.WriteLine("");
            Terminal.WriteLine("");
            currentStates = States.start;



        }

        void blijf()
        {
            Terminal.ClearScreen();
            Terminal.WriteLine("je voelt je schuildig");
            Terminal.WriteLine("maar je blijft leven");
            Terminal.WriteLine("de riem schiet los van ");
            Terminal.WriteLine("het kind en hij vliegt er uit");
            Terminal.WriteLine("de rest van de reizergers gooien");
            Terminal.WriteLine("groote spullen zodat het gat dicht is");
            Terminal.WriteLine("");
            Terminal.WriteLine("");
            Terminal.WriteLine("type piloot om veder te gaan");
            Terminal.WriteLine("");
            currentStates = States.piloot;



        }

        void piloot()
        {
            Terminal.ClearScreen();
            Terminal.WriteLine("de piloot opent de deur van de");
            Terminal.WriteLine("kokpit en roept het is voor nu onder controlen");
            Terminal.WriteLine("we landen zo snel mogelijk");
            Terminal.WriteLine("bij het dichts bijzijde vliegveld");
            Terminal.WriteLine("");
            Terminal.WriteLine("type vrouw om veder te gaan");
            Terminal.WriteLine("");
            currentStates = States.vrouw;

        }

        void vrouw()
        {
            Terminal.ClearScreen();
            Terminal.WriteLine("je ziet een vrouw");
            Terminal.WriteLine("maar ze ziet er bang uit");
            Terminal.WriteLine("wat zal ik doen");
            Terminal.WriteLine("");
            Terminal.WriteLine("type kalm om haar te kalmeren");
            Terminal.WriteLine("type niets om niets te doen");
            Terminal.WriteLine("");
            currentStates = States.rust;

        }

        void kalm()
        {
            Terminal.ClearScreen();
            Terminal.WriteLine("je loopt rustig naar haar toe");
            Terminal.WriteLine("maar je ziet iets in haar hand");
            Terminal.WriteLine("als je dichter bij bent zie je het....");
            Terminal.WriteLine("");
            Terminal.WriteLine("BANG...");
            Terminal.WriteLine("");
            Terminal.WriteLine("type wat om veder te gaan");
            currentStates = States.schot;

        }
       
        void schot()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("je hoord veel geluid");
        Terminal.WriteLine("je wordt rustig wakker");
        Terminal.WriteLine("gelukking is het maar");
        Terminal.WriteLine("een scham wond");
        Terminal.WriteLine("");
        Terminal.WriteLine("type merk om veder te gaan");
        Terminal.WriteLine("");
        currentStates = States.merk;
    }


    void merk()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("ondertussen merk je ");
        Terminal.WriteLine("dat het vliegtuig is");
        Terminal.WriteLine("neergestort en dat je");
        Terminal.WriteLine("het hebt overleeft");
        Terminal.WriteLine("");
        Terminal.WriteLine("type start om tereug te gaan");
        Terminal.WriteLine("");
        currentStates = States.start;
    }

    void niets()
        {
            Terminal.ClearScreen();
            Terminal.WriteLine("de vrouw kijkt je bang aan");
            Terminal.WriteLine("ze loopt naar je toe");
            Terminal.WriteLine("ze kijkt je aan en");
            Terminal.WriteLine("schiet je door je hoofd");
            Terminal.WriteLine("");
            Terminal.WriteLine("");
            Terminal.WriteLine("");
            currentStates = States.hoofd;

        }

        void hoofd()
        {
            Terminal.ClearScreen();
            Terminal.WriteLine("de vrouw kijkt je bang aan");
            Terminal.WriteLine("ze loopt naar je toe");
            Terminal.WriteLine("ze kijkt je aan en");
            Terminal.WriteLine("schiet je door je hoofd");
            Terminal.WriteLine("");
            Terminal.WriteLine("JE HEBT HET NIET OVERLEEFD");
            Terminal.WriteLine("");
            Terminal.WriteLine("type start om tereug te gaan");
            Terminal.WriteLine("");
            currentStates = States.start;

        }

        void showmainmenu()
        {
            Terminal.WriteLine("welkom bij dubbel fly");
            Terminal.WriteLine("");
            Terminal.WriteLine("je gaat weer op zaken reis maar");
            Terminal.WriteLine("nu was het anders");
            Terminal.WriteLine("je bent een aardig persoon maar soms ");
            Terminal.WriteLine("wordt dat niet goed uit betaalt");
            Terminal.WriteLine("");
            Terminal.WriteLine("LET OP SURVIVE");
            Terminal.WriteLine("");
            Terminal.WriteLine("druk start om te beginnen");
        }
    }


    

    
    



