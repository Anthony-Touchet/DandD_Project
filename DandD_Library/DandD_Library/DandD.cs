using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace DandD_Library
{
    public class Character
    {
        JobandRace jobRace;
    }

    public class Ability
    {
        string name;        //What is the name of this ability
        string description; //What does this ability do?
        int cost;           //What does this ability cost
        int level;          //What level is this ability
        int range;          //How far can this ability reach?
    }
   
    public class JobandRace
    {
        //Race
        public string race;        //Primary race
        public string subrace;     //
        public int speed;          //How fast this character can move
        public int size;           //Size will be in feet
        public string alignment;   //How Does this character generally act
        public int age;            //How old is this character
        public List<Attribue> attribueIncreases;    //What attributes does this race increase

        //Job
        public int hitDiceRange;            //Range for the Hit Die
        public int hitPointsBonus;          //Hit point bonus for Job
        public string description;          //Description on Job
        public Attribue primaryAbility;     //The Primary Attribue for this Job
        public List<Attribue> savingThrows; //What attribues govern the saving throws for this class
        public List<Ability> abilities;     //What abilities does this class have
        public List<Armor> armorProficent;  //What kinds of armor is this job proficent at.
        //Method or Property to return profeicent Weapons.     //What Weapons is this class profesient in?
        public Tools toolProficent;         //What tools is this class profeicent in
    }
}