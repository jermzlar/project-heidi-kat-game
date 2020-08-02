INCLUDE Transitions
INCLUDE Hospital Ward
INCLUDE MNC_lin
INCLUDE MNC_Sunday
INCLUDE The Discovery
INCLUDE Fighting







VAR player_name = "Butts"
VAR pronoun_she = "she"
VAR pronoun_hers = "hers"
VAR pronoun_her = "her"
VAR gender_person = "woman"
VAR gender_females = "female"

VAR combat_skill = 50
VAR medicine_skill = 50
VAR technology_skill = 50
VAR ingenuity_skill = 50
VAR charm_skill = 50

VAR rel_sunday = 50
VAR rel_lin = 50

VAR compassion_selfserve = 50
VAR communal_independent = 50
VAR logical_creative = 50
VAR optimist_pessimist = 50

VAR whos_talking = "nobody"
VAR character_a = "none"
VAR character_b = "none"
VAR background = "background"
VAR whos_talking_button = "nobody"

~background = "space station"
~whos_talking = "nobody"
-> intro
=== function came_from(-> x) 
	~ return TURNS_SINCE(x) == 0
	
== intro ==

~background = "bedroom"

~whos_talking = "nobody"
You don't remember how it happened, nor do you know what caused it. All you know is that there was a powerful explosion, and now here you are, laying on the floor of your bedroom in your uniform with what feels like blood seeping out of your head.
You try to think back to the last thing you can remember...

~whos_talking = "nobody"
Three months ago you were hired by Elysium, the system-wide corporation responsible for manufacturing everything from the coffee maker in your bedroom to the bio-weapons used in the Jenusian-Terran war of '83.

~whos_talking = "nobody"
Upon your recruitment you were assigned to one of the company's space stations: 9068 Cassiopeiae II, or Cassio as it was commonly referred to. Elysium owns and operates this station, or at least they do in theory. From what you have seen so far, their oversight leaves much to be desired.

~whos_talking = "nobody"
What is it you do here? 

    ~whos_talking_button = "nobody"
    * (scientist) [I'm a scientist.]
        ~ingenuity_skill += 10
        ~technology_skill += 5
        You work as a scientist and spend your time in the Laboratory of the space station, where you conduct experiments pertaining to the atmosphere and make-up of the gas giant the station orbits.
        You're glad you weren't in the lab when the disaster struck, otherwise you would have been more severely injured.
        
    ~whos_talking_button = "nobody"
    * (security) [I'm in security.]
        ~combat_skill += 15
        You've always been larger and stronger than average, so it was a natural fit to find employment as a security officer.
        You're glad you weren't in the armory of Station Security when the explosion occurred, otherwise you'd probably be pulp right about now.

    ~whos_talking_button = "nobody"
    * (doctor) [I'm a doctor.]
        ~medicine_skill += 15
        You work in the emergency room of the hospital ward tending to those with traumatic injuries or severe illness.
        It occurs to you that you are likely needed there at the moment (although, you weren't scheduled to be).

    ~whos_talking_button = "nobody"
    * ( technician) [I work with technology.] <>
        ~ technology_skill +=  15
        Though you technically work in Operations, the reality is you could be found in a number of areas on the station on any given day. Troubleshooting and technical support are your specialty.
        You count yourself lucky that you weren't in one of the crawl spaces at the moment of the explosion, as it's likely you would have been crushed to death.

    ~whos_talking_button = "nobody"
    *(xenolinguist) [I work as a translator.]<>
        ~ charm_skill += 15
        Though technically employed by Elysium, you're currently contracted out by one of the shipping companies at the shuttle docks. They do business with a number of Jenusians, and you happen to speak both the formal and informal dialects of two of their languages (not to mention six Dead Earth languages).
        You thank your lucky stars that you weren't in the docking bay when the explosion hit considering the large amounts of hyper-reactive shuttle fuel stored there.

-
~whos_talking = "nobody"
Luckily, it had occured during your recreation period. You'd been in your bunk playing a cheap but addictive clicker game on your PDD. Could probably still be able to hear it if it weren't for the ringing in your ears. Technically, you aren't supposed to have games installed, but your co-workers have seen you fiddling with it previously and have yet to report it to your superiors.

~whos_talking = "nobody"
It occurs to you as you struggle to sit up and open your eyes that forbidden games on your Personal Data Device is the least of your worries. You should probably take stock of the situation.

    * [Check to see if those around me are OK.]
        ~compassion_selfserve -=10
    -> roommate
    
    * [Check my injuries in the mirror.]
        ~compassion_selfserve +=10
    -> check_injuries

    = roommate
    
    ~whos_talking = "nobody"
    You pull yourself to your feet and a wave of dizziness rushes over you. That head injury will probably need some attention at some point, but your first priority is checking on those around you, starting with your roommate.
    
     ~whos_talking = "nobody"
    Quarters are small on the space station by necessity, and so it takes nothing more than a cursory glance to locate your roommate. They're on the ground, not moving, with a sizeable piece of plasteel piping skewered through their mid-section.
    
     ~whos_talking_button = "nobody"
    * [See if there's anything I can do to help.]
        ~optimist_pessimist -= 15
        You kneel down beside your roommate and check their pulse, but feel nothing.
        Before you do anything else, you should probably check your PDD.
    -> check_pdd

    ~whos_talking_button = "nobody"
    * [It's useless, they're not even breathing.]
        ~optimist_pessimist += 15
        You ignore your roommate's lifeless body on the floor, and instead turn your attention to recovering your PDD.
    -> check_pdd


= check_injuries

~whos_talking = "nobody"
Fortunately, the mirror in the bathroom seems to have survived the explosion minus three sharp cracks running through it diagonally.

~whos_talking = "nobody"
You survey yourself in the mirror, noting your complexion is slightly ill. {doctor: The wound in your head looks worse than it is, but still needs tending to at some point} {not doctor: It's hard to tell if the wound in your head is serious or not.}

~whos_talking = "nobody"
Before you do anything else, you should probably check your PDD.

-> check_pdd

= check_pdd

You search the floor of your room for it, and discover it beneath some rubble. It appears to have compeltely reset in the wake of the concussive blast. You'll have to re-enter your information.

    * [Enter information.]
    -> enter_pdd_info

= enter_pdd_info

A dialog flashes on the screen of your PDD.

...

...

NAME DESIGNATION?

...

    +[Maral]
        ~player_name = "Maral"
    
    +[Jupiter]
        ~player_name = "Jupiter"

    +[Aran] 
        ~player_name = "Aran" 

    +[Sophin]
        ~player_name = "Sophin"

    +[Cressida]
        ~player_name = "Cressida"

    +[Thenry]
        ~player_name = "Thenry"

    +[Dane] 
        ~player_name = "Dane" 

...

...

-GENDER DESIGNATION?

...

    +(female) [Female]
        ~pronoun_she = "she"
        ~pronoun_hers = "hers"
        ~pronoun_her = "her"
        ~gender_person = "woman"
        ~gender_females = "female"

    +(male) [Male]
        ~pronoun_she = "he"
        ~pronoun_hers = "his"
        ~pronoun_her = "him"
        ~gender_person = "man"
        ~gender_females = "male"

    +(nonbinary) [Non-binary]
        ~pronoun_she = "they"
        ~pronoun_hers = "theirs"
        ~pronoun_her = "them"
        ~gender_person = "person"
        ~gender_females = "non-binary"

-[Review information.]
-> review

= review

[NAME DESIGNATION:] {player_name} \\\ [GENDER DESIGNATION:] {gender_person} ({pronoun_she}/{pronoun_her}/{pronoun_hers}) \\\ Is this correct?

    +[Yes.]
    ->priorities_and_skills
    
    +[No, I need to change something.]
    -> enter_pdd_info

= priorities_and_skills

~whos_talking = "nobody"
With that settled you tuck your PDD away in your pocket and consider your next move.

~whos_talking = "nobody"
You'll have to decide what your first priority will be.

    ~whos_talking_button = "nobody"
    * (help_scared_injured) [I'll help those who are scared or injured.]
        ~communal_independent -= 15
        ~compassion_selfserve -= 15
        People are going to need help getting out of here safely, and you'll be there to provide it.
    
    ~whos_talking_button = "nobody"
    * (get_tf_outta_here) [I want to get away from here as quickly as possible, and maybe take a few people with me.]
        ~communal_independent -= 15
        ~compassion_selfserve += 15
        Something serious happened to cause this much damage, and you don't want to stick around to find out exactly what it was. You're getting the hell out of here. If you find some people along the way who want to join you, so much the better for them.
    
    ~whos_talking_button = "nobody"
    * (find_out_wha_happe) [I need to find out what happened.]
        ~communal_independent += 15
        ~compassion_selfserve -= 15
        Something serious happened to cause this damage, and you need to know exactly what it was before you get out of here.
    
    ~whos_talking_button = "nobody"
    * (get_phat_loots) [I'm going to grab every valuable I can carry and take a shuttle to the nearest outpost.] 
        ~communal_independent += 15
        ~compassion_selfserve += 15
        This is a golden opportunity. You won't be taking advantage of people in their hour of need--you're going to steal directly from Cassio's corporate overlord, Elysium, before you get out of here.

-
~whos_talking = "nobody"
And what skills can you employ?

    ~whos_talking_button = "nobody"
    * (tech) [I have a knack for technology.]
        ~technology_skill += 15
        You're good with tech. You'll utilize the station's assets to achieve your goals quickly.
    
    ~whos_talking_button = "nobody"
    * (combat) [I'm extremely strong and have plenty of combat experience.]
        ~combat_skill += 15
        You're good in a fight. You'll take advantage of that to achieve your goals quickly.
    
    ~whos_talking_button = "nobody"
    * (medicine) [I'm very skilled in medicine.]
        ~medicine_skill += 15
        You've been formally trained in medicine, and you'll be able to use that to your advantage.
    
    ~whos_talking_button = "nobody"
    * (charm) [I've been known to be quite a charming person.]
        ~charm_skill += 15
        People love you, and if they don't love you they still (usually) do what you want them to; that will be to your advantage.
    
    ~whos_talking_button = "nobody"
    * (ingenuity) [I've been frequently described as a genius.]
        ~ingenuity_skill +=15
        Your intelligence is quite an asset, and it will get you where you want to go.

-
~whos_talking = "nobody"
Is there something else you're pretty good at?

    ~whos_talking_button = "nobody"
    *{not tech} [I'm also quite good with technology.]
        ~technology_skill += 10
        You rarely meet a device or piece of software that you haven't tinkered with at some point in your life.

    ~whos_talking_button = "nobody"
    *{not combat} [I'm pretty formidable in a fight.]
        ~combat_skill += 10
        You trained in a less-than-standard setting and so your technique is, well, unique; regardless, you can still kick the asses of most people you meet.
    
    ~whos_talking_button = "nobody"
    *(unconventional_medic) {not medicine and tech or charm or ingenuity} [I've got some skill in medicine.]
        ~medicine_skill += 10
        You know a good deal about medical science, though you weren't strictly taught in a standard setting.
    
    ~whos_talking_button = "nobody"
    *(combat_medic) {not medicine and combat} [I used to be a combat medic.]
        ~medicine_skill +=10
        When you served in the military, you were designated as a combat medic.
    
    ~whos_talking_button = "nobody"
    *{not charm} [I've got that certain je nais c'est quoi.]
        ~charm_skill +=10
        
        
    ~whos_talking_button = "nobody"
    *{not ingenuity} [I aced every class in school.]
        ~ingenuity_skill += 10
        You got straight A's in any subject you put your mind to.

-
~whos_talking = "nobody"
That will certainly be useful, too, you think to yourself.

~whos_talking = "nobody"
There's not much left to do in your room, so you cross the tiny space in three strides and open the door. Outside, the hallway is dimly lit, and it's apparent that the main power has been shut down and emergency lighting has been activated.

~whos_talking = "nobody"
You look around, trying to figure out where to go first, and decide you should head to station security. {security: It's likely they're expecting every officer to report in as soon as possible|They should have answers as to what's going on.}

-> MNC_sunday



