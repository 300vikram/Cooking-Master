# Salad-Chef
Programming Test – Salad Chef (Unity)

time script - contains the countdown for both the players(named timep1 and time p2).
gameplay - This is the sole of all the scripts , it contains the variables used by other gameobjects to move and Destroy.
cookfood - This script contains all the functions for the pattie object, baking of the inner pattie and and movement on the
	   grills is monitored by this script.
bincontrol - Script contains the functions for the instantiating the topbun, bottom bun and pattie of the burger.
movesandwich - Script contains all the functions for the topbun of the burger , this script changes the vlue of the variable
	       of script cookfood and movetoppings.This script can be said as the parent for the cookfood and movetoppings
		script.
movetoppings - Script cotains the variables and functions for the movement of the bottom bun only. 
patron - Contains the order of the customer.
slider - This script contains the variables of changing the slider value over the player(Patron).

1. click the left mouse button for playing as the first player
2. Click the Right mouse button for playing as the Second player
3. Hover over the Game object with the mouse and press "Space Bar" In oreder to Delete the object(!Do not unnecessary 
   press SpaceBar)
   Press the R key to Reset the Destroy of Gameobject in case of any problem.
4. The customer stay time is indicated with a time bar on his head, customer stays as long as it stays green and the
   customer disappear after the bar turns complete red.
5. Both the players are Awarded 50 sec inorder to complete the game
6. If you give the customer wrong order then thre are -2 points Awarded. 
7. If you give the customer right order then 10 points are awarded.
8. Please Avoid pressing the space bar other then for deivering the order, this creates some bugs which I have to fix soon.

** for the simulation check purpose I have preset the customer orders

(CUSTOMER(1) = Burger)
(CUSTOMER(2) = Burger)
(CUSTOMER(3) = Hotdog)
(CUSTOMER(4) = Burger)
(CUSTOMER(5) = Burger)
(CUSTOMER(6) = Hotdog)

**just in case you want to check the score board