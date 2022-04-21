## stack-queue-brackets

Given a string of brackets and characters, return true or false based on whether the brackets are valid.


![Screenshot (235)](https://user-images.githubusercontent.com/98957434/164362882-3b7bffbe-0302-4b67-b0be-5f387c861b7a.png)


## Approach & Efficiency

 used a stack to hold my left brackets, so I loop through my input string then I check if it's a left or right bracket so that the left ones will be push and each time I have a right one, I will check if the previous bracket is the same type as my current one, if yes, I will pop from my stack and continue.