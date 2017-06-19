# TrustPilot Challenge - BackEnd

This is my solution to the Anagram challenge. 

### Intro
I made an Algorithm based on the C# language. I choose this language because have a good memory management, is OOP, is a strong type language which is good for avoid errors or bugs, Visual Studio IDE is very good for compiling and debug processing.  

### Tools

I used Visual Studio for Mac.

### The strategy

My thought was to make the Algorithm which works efficiently and performance optimised. In the beginning I was thinking to use a simple Dictionary attack. However, this solution was not good for the performance just the dictionary attack will consume time. With a glossary of more than 100000 words of which you must select 3 words in the right order, the total number of posible right combination is 100000^3. I realised this was not a good idea.

My strategy then was to reduce the possibilities of the right words. So my assumption was that:

- The magic words should contain letters included in the anagram and minimum be the same length as the anagram phrase is.  

Then, the possibilities become less and more manageable. 

At this point, I'm saving the possible candidates inside a dictionary and comparing with the Anagram words. 

An example:

If we have an Anagram like this: "Jack Hill Climp".
The algorithm is checking in the dictionary a minimum word with 4 characters (Jack = 4), then check the second word with 4 characters and last checking for a word with 5 characters. Here, the program check and pick the best match for the HASH code from the dictionary words.

So, is it fast? 

Yes, it is. I put the data into a rainbow file written in one line only, and fetching the data from the rainbow file, only one line instead of 100000+ lines. That make the algorithm computing fast.  

### How it works

The program has an input which is a combination of two variables, Anagram and TargetHash. The output if the magic words are found, print it else nothing found.

The steps:

1. The program makes Rainbow.txt file with Three Anagram words.
2. After the step one, the program gets all the data from the file Rainbow.txt, and this data is saved into HoldAllData Variable.
3. Very important step is to find Magic words, the
HoldAllData variable and the TargetHash pass to the function SearchString();
4. Last step is SearchString() in which TargetHAsh & HoldAllData are compared with each other. If any magic word it is found it is returning the position where the magic words are found, else return nothing found!









