# BLUEPRINTS FOR HEADS-TAILS OR HIGHER_LOWER

## Essentials

User gets the oppurtunity to play two games, which are, heads or tails and higher or number.

## Non-Essentials

## Entities

## Flow Chart

0. User gets to pick between heads or tails, higher/lower.  
    **PSEUDO**
     ````
      console.ask (Do you want to play heads/tails or higher/lower, 1 for h/t, 2 for h/l)
      ```
     ````
1. Higher/Lower
     - Display to user : Guess a number between 1 and 10.
     - Generate a number between 1 and 10.
     - Request player for number to choose.
     - check if player number is higher or lower than THE number and display correspondly.
     - check if player has reached maximum number of guesses and if they do, user loses.
     - if number guessed is right, player wins.
2. Heads/Tails
     - Display to user : Guess between Heads or Tails
     - Computer picks between heads or tails
     - Request player to choose between heads or tails
     - Convert to uppercase (to prevent wrong case sensitive mismatch)
     - Display error if user input isnt directly correct with required input.
     - if user guess is an acceptable answer, check if it matches with wha the computer chose
     - Display win/lose condition.
3. Repeat task 0.
