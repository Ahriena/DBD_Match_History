# DBD MATCH HISTORY APP

App used to store recent killer and survivor games, as well as record statistics, such as kill or escape rate, of perks, items, character, etc.

Written in C# using XAML forms for the frontend.

Features I plan to include:
  * Every Page:
    * Hover over perk / addon / item for a popup description
  * Recent Games, seperate pages for killer and survivor
    * All 5 characters
    * All Perks, addons, and items
    * Offering
    * Who lived, who died
    * Who the player character was (Whose POV the game was recorded from)
    * Game duration
    * Date / Time the game was played
    * Map name
    * Patch played
    * If I can find a method of doing so, a graph indicating when hooks were performed and gens were completed
## APPROXIMATE ROUGH DRAFT
![Match_History_Picture](https://user-images.githubusercontent.com/107670858/210290661-1d96ffaf-24fd-4f18-aad9-934009ebbec1.png)

      
  * A page for statistics, seperate pages for killer and survivor
    * Killer / Survivor kill / survival rate
      * Includes alternate skins for survivors
    * Perk kill / survival rate
    * Item survival rate
    * Addon kill / survival rate
    * Lookup feature for all of the above
  * Shrine of Secrets tab
    * Data taken from https://dbd.tricky.lol/api
  * Perk randomizer tab
  * All recent games tab
    * Information displayed is more consolidated, but has more / older games stored.

Currently developing the backend so I have a more concrete method of storing games rather than just randomizing all data.

Hopefully BHVR will give me an API I can work with to directly download and store game data, but we'll see =)

Very much a work in progress! I'm mostly doing this to get experience developing larger scale applications. If there's any features that sound like a good idea don't hesitate to contact me; I can't promise anything, but I'll see what I can do.
Discord: Ahriena #1309

