# _Word Search_

#### _A website to search words._

#### By _**Marie @BunnyMarie**_

## Description
_You are able to input a string words, and a single word. You are then able to use the single word to check the amount of times it appears in the string._

| Purpose | Input | Output |
| ------- | ----- | ------ |
| You input a string of words and it stores it in a variable to check against it. | "How are you? I hope to see you soon. I love you and miss you." | string userInput = "How are you? I hope to see you soon. I love you and miss you." |
| You input a word to check and it stores it in a variable to check with. | "you" | string userWord "you" |
| The program displays the amount of times you used the single word. | "How are you? I hope to see you soon. I love you and miss you." | "You used the word you four times." |
| The program only uses true uses of the word, not counting words hidden in words. | "Yourself." | Yourself does not count. |
| Returns an error message when one or more fields are empty. | Blank entry. | "ONE OR MORE ENTRIES EMPTY/NULL, PLEASE TRY AGAIN!" |


_>take string >split string >1+ if string[i] == single word > display result_

## Setup/Installation Requirements

* _Requires C#_
* _Requires ASP.Net Framework_
* _Navigate into main file via console_
* _Run "> dotnet run" in console to view tests_
* _Open "http://localhost:5000/" in browser, and follow app instructions._

## Known Bugs

_Case sensitive word searches only, not a bug! Just a rule!_

## Support and contact details

_Contact Marie/Bunny @bunnymarie on github and bunnymarie@protonmail.com for support, bugs, questions, and comments._

## Technologies Used

_Created using atom, code relies and uses elements from C#, ASP.NET, and Bootstrap._

### License
Copyright (c) 2016 **bunnymarie/rabbitmilk**
