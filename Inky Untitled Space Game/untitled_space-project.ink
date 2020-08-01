INCLUDE Transitions
INCLUDE Hospital Ward
INCLUDE MNC_lin
INCLUDE MNC_Sunday
INCLUDE The Discovery
INCLUDE Fighting
INCLUDE css.style







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

A space station in a distant galaxy.
-> intro
=== function came_from(-> x) 
	~ return TURNS_SINCE(x) == 0
	
== intro ==
You don't remember how it happened, nor do you know what caused it. All you know is that there was an explosion of great force, and now you are here, laying on the floor of your bedroom in your uniform with what feels like blood seeping out of your head.
You try to think back to the last thing you can remember...
Three months ago you were hired by Elysium, the system-wide corporation responsible for manufacturing everything from the coffee maker in your bedroom to the bio-weapons used in the Jenusian-Terran war of '83.
Upon your hiring you were assigned to one of the company's own space stations: 9068 Cassiopeiae II, or Cassio as it was more often referred to. Elysium owns and operates the station, or at least they do in theory. So far, from what you have seen, their oversight leaves much to be desired.
What is it you do here?

* (scientist) [I'm a scientist.]

~ingenuity_skill += 10
~technology_skill += 5

You work as a scientist and spend your time in the Laboratory of the space station, where you conduct experiments pertaining to the atmosphere and make-up of the gas giant the station orbits.
You're glad you weren't in the lab when disaster struck, or else you'd probably have suffered more severe injury.

* (security) [I'm in security.]

~combat_skill += 15

You've always been larger and stronger than average, and it seemed like a natural fit for you to employ yourself first as a mercenary and later as a more respectable security officer.
You're glad you hadn't been in the armory of Station Security when the explosion occurred, otherwise you'd probably be pulp and nothing more.

* (doctor) [I'm a doctor.]

~medicine_skill += 15

You work in the emergency room of the Hospital Ward of the space station, tending to those with traumatic injuries or severe illness.
It occurs to you that you are very likely needed there at this moment; although, you weren't scheduled to be.

* ( technician) [I work with technology.] <>

~ technology_skill +=  15

Though you technically work in Operations, the reality is you might be found in any number of places on the station on any given day. Troubleshooting and technical support are your specialty.
You count yourself lucky that you weren't in one of the crawl spaces at the moment of the explosion, as it's very likely you would have been crushed to death.

*(xenolinguist) [I work as a translator.]<>

~ charm_skill += 15

Though you are technically employed by Elysium, you are contracted out by one of the shipping companies at the shuttle docks. They do business with a number of Jenusians, and you happen to speak both the formal and informal dialects of two of their languages (not to mention six Dead Earth languages).
You thank your lucky stars that you weren't in the docking bay when the explosion hit, considering the large amounts of hyper-reactive shuttle fuel stored there.

-Instead, it had been your recreation period. You'd been in your bunk playing a cheap but addictive clicker game on your PDD. Could probably still be able to hear it if it weren't for the ringing in your ears. Technically you aren't supposed to have games installed, but your co-workers have seen you fiddling with it previously and have yet to report it to your superiors.
It occurs to you as you sit up and open your eyes that forbidden games on your Personal Data Device are probably the least of your worries at this point in time. You should probably take stock of the situation.
* [Check to see if those around me are OK.] -> roommate
~compassion_selfserve -=10
* [Check my injuries in the mirror.] -> check_injuries
~compassion_selfserve +=10

= roommate
You pull yourself to your feet and a wave of dizziness rushes over you. That head injury will probably need some attention at some point, but your first priority is checking on those around you, starting with your roommate.
Quarters are small on the space station by necessity, and so it takes nothing more than a cursory glance around to locate your roommate. They're on the ground, not moving, with a sizeable piece of plasteel piping going through their mid-section.
+ [See if there's anything I can do to help.]
~optimist_pessimist -= 15
You kneel down beside your roommate and check their pulse, but feel nothing.
Well, it was worth trying.
Before you do anything else, you should probably check your PDD. <>
-> check_pdd
* [It's useless, they're not even breathing.]
~optimist_pessimist += 15
You ignore your roommate's lifeless body on the floor, and instead turn your attention to recovering your PDD.
-> check_pdd
TODO: add him/her/them switching for roommate


= check_injuries
Fortunately, the mirror in the bathroom seems to have survived the explosion mostly intact except for three sharp cracks running through it diagonally.
Surveying your reflection, you note your complexion is slightly ill, and the wound in your head {doctor: looks like a severe gash. You'll need to tend to this fairly soon or else you might lose consciousness.} {not doctor: is bleeding significantly, as head wounds usually do, so it's hard to tell if it's serious or not.}
Before you do anything else, you should probably check your PDD.
-> check_pdd

= check_pdd
You search the floor of your room for it and discover it beneath some rubble. It appears to have performed a hard reset in the wake of the concussive blast of the explosion. You'll have to re-enter some information.

* [Enter information.] -> enter_pdd_info

= enter_pdd_info

A diaglog flashes on the screen of your PDD.

...

...

NAME DESIGNATION?

*[Maral]
~player_name = "Maral"
*[Jupiter]
~player_name = "Jupiter"
*[Aran] 
~player_name = "Aran" 
*[Sophin]
~player_name = "Sophin"
*[Cressida]
~player_name = "Cressida"
*[Thenry]
~player_name = "Thenry"
*[Dane] 
~player_name = "Dane" 

...

...

-GENDER DESIGNATION?

*(female) [Female]
~pronoun_she = "she"
~pronoun_hers = "hers"
~pronoun_her = "her"
~gender_person = "woman"
~gender_females = "female"
*(male) [Male]
~pronoun_she = "he"
~pronoun_hers = "his"
~pronoun_her = "him"
~gender_person = "man"
~gender_females = "male"
*(nonbinary) [Non-binary]
~pronoun_she = "they"
~pronoun_hers = "theirs"
~pronoun_her = "them"
~gender_person = "person"
~gender_females = "non-binary"

-[Review information.] -> review

= review

NAME DESIGN: {player_name}
GENDER DESIGNATION: {gender_person} ({pronoun_she}/{pronoun_her}/{pronoun_hers})

Is this correct?

*[Yes.] ->priorities_and_skills
*[No, I need to change something.] -> enter_pdd_info

->priorities_and_skills

= priorities_and_skills

With that settled you tuck your PDD away and consider your next move.

You'll have to decide what your first priority will be.

* (help_scared_injured) [I'll help those who are scared or injured.]
~communal_independent -= 15
~compassion_selfserve -= 15
People are going to need help out there, and you'll be one of the first people on the scene to provide it.
* (get_tf_outta_here) [I want to get away from here as quickly as possible, and maybe take a few people with me.]
~communal_independent -= 15
~compassion_selfserve += 15
Something serious happened to cause this much damage, and you don't want to stick around to find out exactly what it was. You're getting the hell out of here. If you find some people along the way who want to join you, so much the better for them.
* (find_out_wha_happe) [I need to find out what happened.]
~communal_independent += 15
~compassion_selfserve -= 15
Something serious happened to cause this damage, and you need to know exactly what it was. The people of this station deserve as much.
* (get_phat_loots) [I'm going to grab every valuable I can carry and take a shuttle to the nearest outpost.]  //++self-serving +independent
~communal_independent += 15
~compassion_selfserve += 15
This is a golden opportunity that you don't want to miss. You won't be taking advantage of people in their hour of need; no, you're going to steal directly from the source: Cassio's corporate overlord, Elysium.

-And what skills will you employ to achieve this goal?

* (tech) [I have a knack for technology.]
~technology_skill += 15
You're good with tech. You'll make this station talk and tell you {help_scared_injured: how you can help best}{get_tf_outta_here: the best way to get out of this mess}{find_out_wha_happe: exactly what happened}{get_phat_loots: where you can find the most valuable loot}.
* (combat) [I'm extremely strong and have plenty of combat experience.] //++combat
You're good in a fight. You'll take advantage of that so you can {help_scared_injured: protect people and get them to safety} {get_tf_outta_here: stop anyone who gets in the way of you leaving}{find_out_wha_happe: figure out what caused this and stop it from getting worse}{get_phat_loots: introduce anyone who gets in the way of my plan to my two fists}.
~combat_skill += 15
* (medicine) [I'm very skilled in medicine.] //++medicine
You've been formally trained in medicine, and you'll be able to {help_scared_injured: tend to those who have been injured at ground zero}{get_tf_outta_here: heal anyone you come across before you get out of here, and maybe they can offer help}{find_out_wha_happe: determine the cause of the explosion by examining the injuries of those at ground zero}{get_phat_loots: heal myself so I'll be better able to grab the expensive stuff and get out of here}.
~medicine_skill += 15
* (charm) [I've been known to be quite a charming person.] //++charm
With your social aptitude you can {help_scared_injured: calm anyone who's experiencing emotional distress}{get_tf_outta_here: probably weasel your way onto a departing shuttle, if there are any left}{find_out_wha_happe or get_phat_loots: talk to the survivors and find out if anyone {find_out_wha_happe: knows anything about what happened}{get_phat_loots: has any valuable personal belongings I can convince them to part with}}.
~charm_skill += 15
* (ingenuity) [I've been frequently described as a genius.] //++ingenuity
Your intelligence will lead you to {help_scared_injured: solve any logistical issues with tending to those affected}{get_tf_outta_here: find the best way off of this station}{find_out_wha_happe: figure out what went wrong here, and maybe even how it can be prevented in the future}{get_phat_loots: profits beyond your wildest dreams, if you play your cards right.}
~ingenuity_skill +=15

-Is there something else you're pretty good at?

*{not tech} [I'm also quite good with technology.]
~technology_skill += 10
You rarely meet a device or piece of software that you haven't tinkered with at some point in your life.
*{not combat} [I'm pretty formidable in a fight.]
~combat_skill += 10
You trained in a less-than-standard setting and so your technique is, well, unique; regardless, you can still kick the asses of most people you meet.
*(unconventional_medic) {not medicine and tech or charm or ingenuity} [I've got some skill in medicine.]
~medicine_skill += 10
You know a good deal about medical science, though you weren't strictly taught in a standard setting.
*(combat_medic) {not medicine and combat} [I used to be a combat medic.]
~medicine_skill +=10
When you served in the military, you were designated as a combat medic. 
*{not charm} [I've got that certain je nais c'est quoi.]
~charm_skill +=10
People love you, and if they don't love you they still (usually) do what you want them to.
*{not ingenuity} [I aced every class in school.]
~ingenuity_skill += 10
You got straight A's in any subject you put your mind to.

-That will certainly be useful, too, you think to yourself.

There's not much left to do in your room, so you cross the tiny space in three strides and open the door. Outside, the hallway is dimly lit, and it's apparent that the main power has been shut down and emergency lighting has been activated.

You look around, trying to figure out where to go first.

You decide you should head to station security. {security: It's likely they're expecting every officer to report in as soon as possible|They should have answers as to what's going on.}
->MNC_sunday



