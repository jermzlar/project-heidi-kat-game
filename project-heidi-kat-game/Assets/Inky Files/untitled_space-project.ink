INCLUDE Transitions
INCLUDE Hospital Ward
INCLUDE The Discovery
INCLUDE Fighting
INCLUDE MNC_lin
INCLUDE MNC_Sunday
INCLUDE MNC_tliari
INCLUDE MNC_kavert
INCLUDE MNC_fox
INCLUDE MNC_minaloushe
INCLUDE LOC_atrium
INCLUDE LOC_security
INCLUDE LOC_dockingbay
INCLUDE LOC_operations
INCLUDE Escape Pod Bay
INCLUDE Escape Pod

















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
VAR character_a = "nobody"
VAR character_b = "nobody"
VAR background = "background"
VAR whos_talking_button = "nobody"

VAR music_cue = "none"
VAR sound_cue = "none"

~background = "space station"
~whos_talking = "nobody"

-> intro
=== function came_from(-> x) 
	~ return TURNS_SINCE(x) == 0
	
== intro ==

~background = "bedroom"
~music_cue = "opener"

~whos_talking = "nobody"
You don't remember the moment itself. All you know is there was a sound like a shuttle taking off next to your head--a catastrophic explosion, and now here you are, laying on the floor of your bedroom in your uniform with what feels like blood seeping out of your head.

~whos_talking = "nobody"
You try to think back to the last thing you can remember...

~whos_talking = "nobody"
Three months ago you were hired by the Pandit-Warbeck Corporation, the system-wide industrial monolith responsible for everything from the coffee maker in your bedroom to the biochemical weapons that concluded the Jenusian-Terran war of '83.

~whos_talking = "nobody"
Upon your recruitment you were assigned to one of the company's space stations: 9068 Cassiopeiae II, or Cassio as it was commonly referred to. Pandit-Warbeck nominally owns and operates the station, but from what you have seen, their oversight leaves much to be desired.

~whos_talking = "nobody"
What is it you do here? 

    ~whos_talking_button = "nobody"
    * (scientist) [I'm a scientist.]
        ~ingenuity_skill += 10
        ~technology_skill += 5
        You work as an astrochemist and spend your time in one or other of the space station's laboratories, where you conduct experiments analyzing the atmosphere and body of the gas giant the station orbits for precious elements and how to extract them. 
        
    ~whos_talking_button = "nobody"
    * (security) [I'm in security.]
        ~combat_skill += 15
        You've always been stronger and quicker with your hands than most, so it seemed like a natural fit to pursue physical work. Punching people as needed punching, restraining them as needed restraining, and being intimidating enough that you can stop a lot of fights before they start. Work as a security officer is a little more stable and respectable than some of your previous jobs.

    ~whos_talking_button = "nobody"
    * (doctor) [I'm a doctor.]
        ~medicine_skill += 15
        You work in the Trauma Ward of your section's medical bay, tending mostly to the results of drunken, rowdy spacefarer antics, or the mangled limbs and chemical burns that plague gas miners.

    ~whos_talking_button = "nobody"
    * (technician) [I work with technology.] <>
        ~ technology_skill +=  15
        You work in Section Operations, and as such you might be found in any number of places on the section on any given day. Troubleshooting and technical support are your specialty; having long since given up on the idea of preventing glitches and malfunctions in a place as decrepit as this, you are resigned to reacting to issues as they come up.

    ~whos_talking_button = "nobody"
    *(xenolinguist) [I work as a translator.]<>
        ~ charm_skill += 15
        Though you are technically employed by Pandit-Warbeck, you are contracted out to Astralogistics, a moderate-sized shipping company headquartered at the shuttle docks. They do business with a number of Jenusians, and you speak both the formal and informal dialects of two of their languages (not to mention six Dead Earth languages).

-
~whos_talking = "nobody"
You register a few things as your senses return one by one: your world, turned black from the impact, now glows red under emergency lightning. Your mouth tastes like smokey, metallic blood. Echoes of thunder still ring in your ears. Finally, each limb shoots sharp, chaotic aches in all directions as you laboriously unfold from the unnatural position you lie in, several feet from the bed you were on a distant moment ago. Dust is everywhere; it's settled upon the personal effects that now litter the floor.
{scientist: You're glad you weren't in the lab when disaster struck, or else flying chemicals and equipment could have been the end of you.}
{security: You're glad you hadn't been in the Section armory, otherwise you'd probably have been pulped by flying riot equipment or on intimate terms with a concussion grenade chain reaction.}
{doctor: It occurs to you that you are very likely needed desperately in the medical bay. You weren't scheduled to be there now, but a medic's life is never a predictable one.}
{technician: You count yourself lucky that you weren't in one of the crawl spaces, as it's very likely you would have been crushed to death, or worse, trapped.}
{xenolinguist: You thank your lucky stars (which you consider to be the Pleiades cluster) that you weren't in the Astralogistics docking area. Considering how much hyper-reactive shuttle fuel is stored there, it might even have been the source of the blast.}

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

~sound_cue = "boopbeepboop 1"

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
        ~gender_females = "individual"

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
        This is a golden opportunity. You won't be taking advantage of people in their hour of need--you're going to steal directly from Cassio's corporate overlord, Pandit-Warbeck, before you get out of here.

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
        You're good in a fight, though you trained in a less-than-standard setting, and so your technique is--well, unique. Regardless, you can still be formidable in combat.
    
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
You look around and try to figure out where to go first.

    ~whos_talking_button = "nobody"
    *{not security}[I will go to Station Security first; they'll have answers.]
        You decide to head to station security. They should have answers as to what's going on.
        -> MNC_sunday
    
    ~whos_talking_button = "nobody"
    *{not technician}[I should go to Operations first; they'll know what's going on.]
        You decide to head to operations. You're sure they'll have answers as to what's going on.
        -> MNC_kavert
        
     ~whos_talking_button = "nobody"
     *{get_phat_loots}[I bet there's some unguarded cargo in the docking bay...]
        With your primary concern in this moment being the acquisition of Pandit-Warbeck's assets for your own personal gain, you're certain there's going to be some unguarded cargo that would fetch a good price on the grey market. You'll just have to find it.
        With that decided, you begin to head in the direction of the shuttle port and adjoining docking bays.
        ->MNC_fox
    
    ~whos_talking_button = "nobody"
    *[I need to go to the hospital ward first and take care of my injury.]
        You're certain this head wound is going to need some tending, so you decide to head to the hospital ward first. {doctor or combat_medic or unconventional_medic or medicine: There you'll be able to see what the damage is and take care of it. They'll likely be needing your help there, too|There should hopefully be someone there who can help you. If not, well, you'll figure something out}.
        ->MNC_minaloushe
        
    ~whos_talking_button = "nobody"
    *[First things first, I need to report for duty.]
    
        {scientist:
        Most people wouldn't understand, but your primary concern in spite of everything right now is the state of the lab and adjoining atrium. There are ongoing experiments there worth hundreds of thousands of credits, and you feel it is your duty to look after them in a disaster, or at the very least recover the research that's been done.
        -> MNC_tliari
        }
        
        {xenolinguist:
        There's likely a host of Jenusians in the shuttle port right now trying to navigate their way off the station in the middle of an emergency. Your services as a xenolinguist will certainly be needed, so you decide to make for the shuttle port.
        ->MNC_fox
        }
        
        {security:
        It's likely they're expecting every officer to report in as soon as possible, so you decide to make for Station Security. They should have answers as to what's going on, too.
        -> MNC_sunday
        }
        {technician:
        With emergency power on, you know there's more than one station system down after the expolosion, and Stations Ops probably needs your expertise at the moment. You decide to make for Operations, and hope they'll also have answers as to what's going on.
        ->MNC_kavert
        }
        {doctor:
        With everything going on, youre certain the emergency ward is chaos at the moment. In light of this disaster, they'll need you now more than ever. You decide to make for the hospital and see what you can do to help.
        ->MNC_minaloushe
        }
        
        
        




~music_cue = "music fade"
-> MNC_sunday



