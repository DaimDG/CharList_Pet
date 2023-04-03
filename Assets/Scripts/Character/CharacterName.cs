using System;
using UnityEngine;

[CreateAssetMenu(fileName = "CharacterNames", menuName = "ScriptableObjects/CharacterNames", order = 1)]
public class CharacterName: ScriptableObject
{
    //Elf names block
    [SerializeField] private string[] elfMaleNames = {"Adran", "Aelar", "Aramil", "Arannis", "Aust", "Beiro", "Berrian", "Carric", 
        "Enialis", "Erdan", "Erevan", "Galinndan", "Hadarai", "Heian", "Himo", "Immeral", "Ivellios", "Laucian", 
        "Mindartis", "Paelias", "Peren", "Quarion", "Riardon", "Rolen", "Soveliss", "Thamior", "Tharivol", "Theren", 
        "Varis"};
    [SerializeField] private string[] elfFemaleNames = {
        "Adrie", "Althaea", "Anastrianna", "Andraste", "Antinua", "Bethrynna", "Birel",
        "Caelynn", "Drusilia", "Enna", "Felosial", "Ielenia", "Jelenneth", "Keyleth", "Leshanna", "Lia", "Meriele",
        "Mialee", "Naivara", "Quelenna", "Quillathe", "Sariel", "Shanairra", "Shava", "Silaqui", "Theirastra", "Thia",
        "Vadania", "Valanthe", "Xanaphia"
    };
    [SerializeField] private string[] elfFamilyNames = {"Amakiir (Gemflower)", "Amastacia (Starflower)", "Galanodel (Moonwhisper)", 
        "Holimion (Diamonddew)", "Ilphelkiir (Gemblossom)", "Liadon (Silverfrond)", "Meliamne (Oakenheel)", 
        "Nailo (Nightbreeze)", "Siannodel (Moonbrook)", "Xiloscient (Goldpetal)"};
    
    //Dragonborn names block
    [SerializeField] private string[] dragonbornMaleNames = {"Arjhan", "Balasar", "Bharash", "Donaar", "Ghesh", "Heskan",
        "Kriv", "Medrash", "Mehen", "Nadarr", "Pandjed", "Patrin", "Rhogar", "Shamash", "Shedinn", "Tarhun", "Torinn"};
    [SerializeField] private string[] dragonbornFemaleNames = {"Akra", "Biri", "Daar", "Farideh", "Harann", "Havilar",
        "Jheri", "Kava", "Korinn", "Mishann", "Nala", "Perra", "Raiann", "Sora", "Surina", "Thava", "Uadjit"};
    [SerializeField] private string[] dragonbornFamilyNames = {"Clethtinthiallor", "Daardendrian", "Delmirev",
        "Drachedandion", "Fenkenkabradon", "Kepeshkmolik", "Kerrhylon", "Kimbatuul", "Linxakasendalor", "Myastan",
        "Nemmonis", "Norixius", "Ophinshtalajiir", "Prexijandilin", "Shestendeliath", "Turnuroth", "Verthisathurgiesh",
        "Yarjerit"};
    
    //Dwarf names block
    [SerializeField] private string[] dwarfMaleNames = {"Adrik", "Alberich", "Baern", "Barendd", "Brottor", "Bruenor",
        "Dain", "Darrak", "Delg", "Eberk", "Einkil", "Fargrim", "Flint", "Gardain", "Harbek", "Kildrak", "Morgran",
        "Orsik", "Oskar", "Rangrim", "Rurik", "Taklinn", "Thoradin", "Thorin", "Tordek", "Traubon", "Travok", "Ulfgar",
        "Veit", "Vondal"};
    [SerializeField] private string[] dwarfFemaleNames = {"Amber", "Artin", "Audhild", "Bardryn", "Dagnal", "Diesa",
        "Eldeth", "Falkrunn", "Finellen", "Gunnloda", "Gurdis", "Helja", "Hlin", "Kathra", "Kristryd", "Ilde", "Liftrasa",
        "Mardred", "Riswynn", "Sannl", "Torbera", "Torgga", "Vistra"};
    [SerializeField] private string[] dwarfFamilyNames = {"Balderk", "Battlehammer", "Brawnanvil", "Dankil", "Fireforge",
        "Frostbeard", "Gorunn", "Holderhek", "Ironfist", "Loderr", "Lutgehr", "Rumnaheim", "Strakeln", "Torunn", "Ungart"};
    
    //Gnome names block
    [SerializeField] private string[] gnomeMaleNames = {"Alston", "Alvyn", "Boddynock", "Brocc", "Burgell", "Dimble",
        "Eldon", "Erky", "Fonkin", "Frug", "Gerbo", "Gimble", "Glim", "Jebeddo", "Kellen", "Namfoodle", "Orryn", "Roondar",
        "Seebo", "Sindri", "Warryn", "Wrenn", "Zook"};
    [SerializeField] private string[] gnomeFemaleNames = {"Bimpnottin", "Breena", "Caramip", "Carlin", "Donella", "Duvamil",
        "Ella", "Ellyjobell", "Ellywick", "Lilli", "Loopmottin", "Lorilla", "Mardnab", "Nissa", "Nyx", "Oda", "Orla",
        "Roywyn", "Shamil", "Tana", "Waywocket", "Zanna"};
    [SerializeField] private string[] gnomeFamilyNames = {"Beren", "Daergel", "Folkor", "Garrick", "Nackle", "Murnig", 
        "Ningel", "Raulnor", "Scheppen", "Timbers", "Turen"};
    
    //HalfElf names block (inherit from elf names)
    [SerializeField] private string[] halfElfMaleNames = {};
    [SerializeField] private string[] halfElfFemaleNames = {};
    [SerializeField] private string[] halfElfFamilyNames = {};
    
    //Halfling names block
    [SerializeField] private string[] halflingMaleNames = {"Alton", "Ander", "Cade", "Corrin", "Eldon", "Errich", "Finnan",
        "Garret", "Lindal", "Lyle", "Merric", "Milo", "Osborn", "Perrin", "Reed", "Roscoe", "Wellby"};
    [SerializeField] private string[] halflingFemaleNames = {"Andry", "Bree", "Callie", "Cora", "Euphemia", "Jillian",
        "Kithri", "Lavinia", "Lidda", "Merla", "Nedda", "Paela", "Portia", "Seraphina", "Shaena", "Trym", "Vani", "Verna"};
    [SerializeField] private string[] halflingFamilyNames = {"Brushgather", "Goodbarrel", "Greenbottle", "High-hill",
        "Hilltopple", "Leagallow", "Tealeaf", "Thorngage", "Tosscobble", "Underbough"};
    
    //HalfOrc names block
    [SerializeField] private string[] halfOrcMaleNames = {"Dench", "Feng", "Gell", "Henk", "Holg", "Imsh", "Keth", "Krusk",
        "Mhurren", "Ront", "Shump", "Thokk"};
    [SerializeField] private string[] halfOrcFemaleNames = {"Baggi", "Emen", "Engong", "Kansif", "Myev", "Neega", "Ovak",
        "Ownka", "Shautha", "Sutha", "Vola", "Volen", "Yevelda"};
    [SerializeField] private string[] halfOrcFamilyNames = {};
    
    //Human names block
    [SerializeField] private string[] humanMaleNames = {"Darvin", "Dorn", "Evendur", "Gorstag", "Grim", "Helm", "Malark",
        "Morn", "Randal", "Stedd", "Bor", "Fodel", "Glar", "Grigor", "Igan", "Ivor", "Kosef", "Mival", "Orel", "Pavel",
        "Sergor", "Ander", "Blath", "Bran", "Frath", "Geth", "Lander", "Luth", "Malcer", "Stor", "Taman", "Urth", "Aoth",
        "Bareris", "Ehput-Ki", "Kethoth", "Mumed", "Ramas", "So-Kehur", "Thazar-De", "Urhur", "Borivik", "Faurgar", "Jandar",
        "Kanithar", "Madislak", "Ralmevik", "Shaumar", "Vladislak", "An", "Chen", "Chi", "Fai", "Jiang", "Jun", "Lian",
        "Long", "Meng", "On", "Shan", "Shui", "Wen", "Anton", "Diero", "Marcon", "Pieron", "Rimardo", "Romero", "Salazar",
        "Umbero"};
    [SerializeField] private string[] humanFemaleNames = {"Arveene", "Esvele", "Jhessail", "Kerri", "Lureene", "Miri",
        "Rowan", "Shandri", "Tessele", "Alethra", "Kara", "Katernin", "Mara", "Natali", "Olma", "Tana", "Zora", "Amafrey",
        "Betha", "Cefrey", "Kethra", "Mara", "Olga", "Silifrey", "Westra", "Arizima", "Chathi", "Nephis", "Nulara",
        "Murithi", "Sefris", "Thola", "Umara", "Zolis", "Fyevarra", "Hulmarra", "Immith", "Imzel", "Navarra", "Shevarra",
        "Tammith", "Yuldra", "Bai", "Chao", "Jia", "Lei", "Mei", "Qiao", "Shui", "Tai", "Balama", "Dona", "Faila", "Jalana",
        "Luisa", "Marta", "Quara", "Selise", "Vonda"};
    [SerializeField] private string[] humanFamilyNames = {"Amblecrown", "Buckman", "Dundragon", "Evenwood", "Greycastle",
        "Tallstag", "Bersk", "Chernin", "Dotsk", "Kulenov", "Marsk", "Nemetsk", "Shemov", "Starag", "Brightwood", "Helder",
        "Hornraven", "Lackman", "Stormwind", "Windrivver", "Ankhalab", "Anskuld", "Fezim", "Hahpet", "Nathandem", "Sepret",
        "Uuthrakt", "Chergoba", "Dyernina", "Iltazyara", "Murnyethara", "Stayanoga", "Ulmokina", "Chien", "Huang", "Kao",
        "Kung", "Lao", "Ling", "Mei", "Pin", "Shin", "Sum", "Tan", "Wan", "Agosto", "Astorio", "Calabra", "Domine", "Falone",
        "Marivaldi", "Pisacar", "Ramondo"};
    
    //Tiefling names block
    [SerializeField] private string[] tieflingMaleNames = {"Akmenos", "Amnon", "Barakas", "Damakos", "Ekemon", "Iados",
        "Kairon", "Leucis", "Melech", "Mordai", "Morthos", "Pelaios", "Skamos", "Therai"};
    [SerializeField] private string[] tieflingFemaleNames = {"Akta", "Anakis", "Bryseis", "Criella", "Damaia", "Ea",
        "Kallista", "Lerissa", "Makaria", "Nemeia", "Orianna", "Phelaia", "Rieta"};
    [SerializeField] private string[] tieflingFamilyNames = {"Art", "Carrion", "Chant", "Creed", "Despair", "Excellence",
        "Fear", "Glory", "Hope", "Ideal", "Music", "Nowhere", "Open", "Poetry", "Quest", "Random", "Reverence", "Sorrow",
        "Temerity", "Torment", "Weary"};
}
