# Unity3D-Languager
A C# script for Unity that takes a string and changes it based on a dictionary and/or certain rules. Simple but effective way to create fake languages in chat and such.


#####################################

To use the script, simply call it using "Languager.ToCommon(text)" or "<>.ToEnochian(text)" from any script, and it will return
the converted string.

#####################################
The script includes two different "languages":

One being a modified version of Enochian(so called Angel language), which is more or less a fictional one, with some 
extended words for numbers, and changed some letters to avoid repeat in the latin/english alphabet conversion.
In this one, I have added a somewhat extention to somewhat reduce the size of words and make it low more:
  The code will check if the last character is the same with the current one, and if it is, it will only take the last letter
  of the translated character from the dictionary(if the dictionary is just one letter translated, it will use the same one).
  
      Example: W = Re, then www will return ree

The second one I named Common, but its actually a modified R'lyehian, another fictional language.
This one is a straight up letter swap, that also supports uppercase and lowercase letters.
  It should be the better one in terms of performance but might introduce very large words if not careful with the dictionary.

#####################################

There is also a clean template dictionary commented on the start of the code to make it easier for your own language conversion.

#####################################
#####################################
#####################################

And I gues thats it!

I know the code is probably not perfect, and not the fastest or most flexible one; but this is the first time I am creating such a code.
The inspiration came mainly from World of Warcraft, back in the days when I used to play a lot. I loved how they made the
languages differ from eachother depending on faction/race/etc. , so I wanted to try it out for myself!

#####################################

If you got any ideas upon improving the code, feel free to tell me. I would love to have more options in this.
