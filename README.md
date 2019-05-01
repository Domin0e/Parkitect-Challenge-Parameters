# Parkitect-Challenge-Parameters
A simple applet for Inspiration in the Theme Park Simulator Game Parkitect.

Download the latest Release version, unzip the archive and launch ParkParams.exe, it is that easy!


# Lists
## How are they used?
*Themes.txt* is the list the park theme is chosen from. It does not require any other lists to function.
*Modifiers.txt* is the **base list** for modificators. It has entries which require further decisions.

**Ride Requirement** uses the *Ride.txt* list to choose a Ride.
**Centerpiece Requirement** uses the *Centerpiece.txt* list. the 'Ride' option will choose a Ride from *Ride.txt* to replace itself with.
**Build Requirement** uses the *Build Requirements.txt* list to choose a required build.
**Guest Modifier** uses the *Guest Modificators.txt* list to choose the Guest Modificator.

## Adding your own entries.
You can add entries to any of those lists by opening them with your Text Editor of choice and adding new lines.


# How to Use the Parameters the applet gives me?
Open Parkitect and open a Park of your choice, or create a new Scenario, which is basically required as soon as Weather, Temperature or Guests are modified, and adjust things accordingly. Personally, I use a 50x53 custom scenario as a template. You can find it in the Steam Workshop: https://steamcommunity.com/workshop/filedetails/?id=1728948758
