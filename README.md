# EnigmaMachine
Program that simulates the behaviour of an Enigma Machine.

In this solution, the logical flow of the encryption of a letter is exactly the same as in a real Enigma Machine. 
In other words, we could say that the encryption method is exactly the same, but made through software instead of hardware. 
(See image in [Other resources](https://github.com/ferancona/EnigmaMachine#other-resources))

## Features
- Encrypt and decrypt messages simetrically
- Modify the rotors configuration
	- Choose 3 out of 5 rotors
	- Change the position of any rotor
- Modify the plugboard configuration

## Design
The Object-Oriented design allowed for a neat level of abstraction, facilitating the usage of the Enigma Machine object.
The encryption/decryption of a letter can be achieved through a method:
```C#
string outLetter = machine.EncodeLetter("a")
```

## Other resources
Enigma's Logical Flowchart: 
<div style="text-align:center"><img src="http://www.rotilom.com/juin44/enigma/principe_en.jpg" /></div>

Numberphile's [video] explains how the Enigma Machine works and provides some background history.

[//]: #
[diagram]: http://www.rotilom.com/juin44/enigma/principe_en.jpg "Enigma's Logical Flowchart"
[video]: <https://www.youtube.com/watch?v=G2_Q9FoD-oQ&ab_channel=Numberphile>