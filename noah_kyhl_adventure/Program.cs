using Classes;
using System.Text.Json;

//Reads my json file!!!
string jsonDataPath = @"C:\Users\kyhln\Documents\GitHub\project-deliverable-2-noahKyhl\data\save.json"; // creates path to my student.json

string jsonSave;

/////////////////
    
Console.WriteLine("==============================================================================================\n==============================================================================================\nWelcome oh so dilegent Business App Development scholar, today you will embark on a journey. \nYou are looking for Nicholas Cage, the bearer of the unbearable weight of massive talent,\nbecause why not, haven't we all looked for a Nicholas Cage. Good luck.");
Console.WriteLine($"\n\nWhat is your name friend?");
string lol = Console.ReadLine();//don't do anything with this information
Console.WriteLine("\n==============================================================================================\nIt is great to meet you, Shrek. Is this name correct? Input yes or no.");
string lol2 = Console.ReadLine();//don't do anything with this information
Console.WriteLine("\n==============================================================================================\nGreat Shrek, it seems you input yes, so lets get started Shrek. Click Enter to Begin!");
string enter = Console.ReadLine();
Console.Clear(); // Clear the console before each new output
Random randomA = new Random();

Console.WriteLine("1. Start a new game");
Console.WriteLine("2. Load from save");

int choice = Convert.ToInt32(Console.ReadLine());

User Shrek;//New user is initiated

if (choice == 2)
{
    Shrek = LoadGame();//Save data is to be loaded

    if (Shrek == null)//If there is no data to load, start a new game
    {
        Console.WriteLine("No save file found. Starting a new game...");
        Shrek = new User("Shrek", 250, 10, 0, 250);
    }
    else
    {
        Console.WriteLine("Save file loaded. Resuming game...");
    }
}
else
{
    Console.WriteLine("Starting a new game...");
    Shrek = new User("Shrek", 250, 10, 0, 250);//Creates new user
}

bool bossDefeated = false;//variable to determine if game is won

while (Shrek.Health > 0 && Shrek.Energy > 0 && bossDefeated == false)//While user is alive, energized, and boss has not been defated the game goes on
{
    Stats();
    Console.WriteLine("\n\n\n\n\n\n==============================================================================================\nYou are making progress on your mystical quest to find Nick Cage\n\nThere appears 3 paths of uncertainty, which direction will you head?\n\n==============================================================================================");
    Console.WriteLine("\n1. Frolic into the direction of the wind\n2. Follow some odd footprints\n3. Tie a blindfold around your face and say Nicholas Cage 5 times! (the boss could approach, beware...)\n4. Gaze into the stars\n5. Abandon Quest\n\n");
    int direction = Convert.ToInt32(Console.ReadLine());//selects a action to take on the adventure
    int Encounter = randomA.Next(0, 101); //creates random variable 

    if (direction == 1)//Encounter NPC 50%, Merchant 25%, Oracle 25%
    {
        Console.Clear(); // Clear the console before each new output
        if (Encounter < 25)
        {
            Console.WriteLine("==============================================================================================\nYou suddenly smell capitalism....\n");
            Merchant();//Merchant encounter plays
        }
        else if (Encounter >= 25 && Encounter < 50)
        {
            Console.WriteLine("==============================================================================================\nYou suddenly feel like your being watched....\n");
            Oracle();//Oracle encounter plays
        }
        else
        {
            Console.WriteLine("==============================================================================================\nYou see a familar face in the distance....\n");
            Whack();//NPC encounter plays
        }
    }

    else if (direction == 2)//Encounter NPC 60%, Oracle 20%, Merchant 20%
    {
        Console.Clear(); // Clear the console before each new output
        if (Encounter < 33)
        {
            Console.WriteLine("==============================================================================================\nYou suddenly smell capitalism....\n");
            Merchant();//Merchant encounter plays
        }
        else if (Encounter >= 33 && Encounter < 66)
        {
            Console.WriteLine("==============================================================================================\nYou suddenly feel like your being watched....\n");
            Oracle();//Oracle encounter plays
        }
        else
        {
            Console.WriteLine("==============================================================================================\nYou see a familar face in the distance....\n");
            Whack();//NPC encounter plays
        }
    }

    else if (direction == 3)//Encounter Boss 40%, Oracle 20%, Merchant 40%
    {
        Console.Clear(); // Clear the console before each new output
        if (Encounter < 40)
        {
            Console.WriteLine("==============================================================================================\nYou suddenly smell capitalism....\n");
            Merchant();//Merchant encounter plays
        }
        else if (Encounter >= 40 && Encounter < 60)
        {
            Console.WriteLine("==============================================================================================\nYou suddenly feel like your being watched....\n");
            Oracle();//Oracle encounter plays
        }
        else 
        {
            Console.WriteLine("==============================================================================================\nYou hear a loud roar and booming footsteps....\n");
            BossB();//Boss encounter plays
        }
    }

    else if (direction == 4)//Nick Cage ascii art
    {
        Console.Clear(); // Clear the console before each new output
        Cage();//will be an image file?
    }

    else if (direction == 5)//Exit Program
    {
        Console.Clear(); // Clear the console before each new output
        Console.WriteLine("==============================================================================================\nYou have abandon your quest, depressing... Have a great rest of your day!!!");
        break;
    }

    else//Catches invalid inputs
    {
        Console.Clear(); // Clear the console before each new output
        Console.WriteLine("==============================================================================================\nInvalid input!");
        return;
    }

    if (Shrek.Health<=0)//Health runs out
    {
        Console.Clear(); // Clear the console before each new output
        Console.WriteLine("==============================================================================================\nYou have succumb to your wounds.\nGAME OVER!!! :(");
        break;
    }

    if (Shrek.Energy<=0)//Energy runs out
    {
        Console.Clear(); // Clear the console before each new output
        Console.WriteLine("==============================================================================================\nYou have succumb to exhaustion.\nGAME OVER!!! :(");
        break;
    }

}

/////////////////////////////////////////////////METHODS
void BossB()
{
    Console.WriteLine("Input enter");
    string io = Console.ReadLine();
    Console.Clear(); // Clear the console before each new output
    Console.WriteLine("\n==============================================================================================\nYou have spotted the Boss, oh ho, ha ha...");
    Boss evilBoss = new Boss();//Creates new boss

    Console.WriteLine($"\n\nYou have encountered {evilBoss.Name} on your quest to meet Nick Cage, and {evilBoss.Name} has crippled you with it's looming presence, and you are forced to face {evilBoss.Name}");
    
    while(evilBoss.Health > 0 && Shrek.Health > 0)//while Boss and Shrek are both alive
    {
        Console.WriteLine("Click Enter..");
        string enter2 = Console.ReadLine(); 
        Stats();
        Console.WriteLine($"###########################################################################################\n\n\n\n\n\n\n\nEnemy Stats:\n{evilBoss.Name}, Health: {evilBoss.Health}\n\n");
        int ogre = 0;
        while (ogre == 0)//before choice is made attack selection comes up... basically rock paper scissors logic, but with health, luck, energy, etc. variables at play
        {
            Console.WriteLine($"==============================================================================================\n{evilBoss.Name} challenges Shrek! Choose your move:");
            Console.WriteLine("1. Unlayer the Ogre");
            Console.WriteLine("2. Do the roar");
            Console.WriteLine("3. Be a swampy boy");
            ogre = Convert.ToInt32(Console.ReadLine()); //collects input from user
        }

        if (ogre != 1 && ogre != 2 && ogre != 3) //invalid input 
        {
             Console.Clear(); // Clear the console before each new output
            Console.WriteLine("==============================================================================================\nInvalid choice. Please choose 1, 2, or 3.");
            return;
        }

        int npcA = evilBoss.Attack();//Creates boss random attack

        if (ogre == npcA)//If the attacks balance out -> are the same number
        {
             Console.Clear(); // Clear the console before each new output
            Console.WriteLine($"==============================================================================================\nIt's a draw! {evilBoss.Name}'s attack {evilBoss.Pow} deflects your attack!");
            Shrek.Energy -= 10;//Shrek loses energy
        }
        else if ((ogre == 1 && npcA == 3) || (ogre == 2 && npcA == 1) || (ogre == 3 && npcA == 2))//If User won the rock paper scissors game
        {
             Console.Clear(); // Clear the console before each new output
            Console.WriteLine($"==============================================================================================\n{evilBoss.Name} is hit by Shrek's attack and their {evilBoss.Pow} misses Shrek entirely.");
            
            decimal powerB = 30 * Shrek.Luck; //adds critical hit based off luck
            decimal damage = 30 + powerB; //Adjusted critical hit

            evilBoss.TakeDamage(damage); //Boss takes damage
            Shrek.Energy -= 10; //shrek uses energy
            Shrek.Luck += .05m; //User gains luck, or confidence for hitting the target
        }
        else
        {
             Console.Clear(); // Clear the console before each new output
            Console.WriteLine($"==============================================================================================\n{evilBoss.Name} is too fast for Shrek and their {evilBoss.Pow} hits! Shrek roars a mighty ogre roar.");
            Shrek.Health -= 20; //Shrek loses health
            Shrek.Energy -= 10; //Shrek loses energy
        }
    }
    if (evilBoss.Health <= 0 && Shrek.Health > 0)
    {
        Console.Clear(); // Clear the console before each new output
        Console.WriteLine($"==============================================================================================\n\nYou have defeated {evilBoss.Name}, they cry in defeat and are vanquished, you see a silhouette in the distance, could it be?\n");
        Console.WriteLine($"You approach the mystery man, \"Nick Cage?\" you ask. Suddenly Mufasa appears from the sky \"There is no Nick Cage, Shrek, there never was\" Mufasa says, and then the clouds swallow him up... Maybe. Nick Cage was really the friends we made along the way?\n\n\nCongrats, Shrek, you WIN the game, you have found Nick Cage through self reflection and conquering your insecurities. Good man.");
        Console.WriteLine($"\n\nCONGRATS {lol}!!!!!!! See I knew your name all along!!!!!!");
        Console.WriteLine("This was Noah Kyhl's BMIS 365 Project, I hope you enjoyed :)\n==============================================================================================");
        bossDefeated = true; //Boss is defeated, game is won, loop ends
    }
}

void Cage()//image of Nick Cage displaying?
{
    Console.Clear(); // Clear the console before each new output
    Console.WriteLine("\n==============================================================================================\n*You look at the oddly Nick Cage-shaped stars*\nGame has been saved...");
    SaveGame(Shrek);
}

NPC CreateRandomWhackyCharacter()
{
    //Creates possible names and corresponding attacks for the NPC objects
    string[] names = { "Frodo Baggins", "Gandalf The Gray", "Big Dwarf Man", "Aristotle", "Donkey", "Batman", "Napolean Dynamite", "Elon Musk", "Yoda", "Darth Vader", "Jeff Bezos", "Pac Man", "1010000 Mark Zuckerberg 000010101", "Student Loans", "Sketchy Circus Clown"};
    string[] attack = { "Second Breakfast", "Wizarding Scheme", "Body Slam", "Philosophic Throttle", "Waffle Tussle", "Brooding Silence", "Tator Pocket", "Purchase the clothes off your back", "Crazed Lightsaber Rampage", "Reveal Parental Status", "2 Day Shipping", "waka waka", "ISHuman() = False", "Interest Payments", "*Unsettling Giggles*"};
   
    int health = new Random().Next(50, 101);//Random health between 50 and 100   

    int chance = new Random().Next(names.Length);//Random name and attack based on list of name length
    string name = names[chance];
    string pow = attack[chance];
    
    NPC whackyCharacter = new NPC(name, health, pow); //creates new NPC object
    return whackyCharacter;
}

User LoadGame()
{
    if (File.Exists(jsonDataPath))//if the file exists
    {
        string jsonString = File.ReadAllText(jsonDataPath);
        return JsonSerializer.Deserialize<User>(jsonString);//Deserializes the JSON content into a User object and returns it
    }

    return null;
}

void Merchant()
{
    /*Vending Machience Logic Yippie!!! These are the names of the products
    Each product is stored as an object from the Products class*/

    Products pro1 = new Products("Apple Pie", 4.69m, 0, 50, 0);
    Products pro2 = new Products("Battery Acid", 4.20m, 0, -25, 100);
    Products pro3 = new Products("Coffee", 4.50m, 0, 0, 50);
    Products pro4 = new Products("Hearty helping of steak", 10.0m, 0, 100, 100);
    Products pro5 = new Products("Questionable leftovers?", 4.44m, 0, 100, -25);

    List<Products> products = new List<Products> {pro1, pro2, pro3, pro4, pro5};//List storing every products object

    int exit = 2;//exit variable to end merchant visit

    decimal totalFin = 0;//Important global variable that continues adding up as program runs keeping track of cost of the cart

    do //do while keeping the merchant operating til "exit = 1"
    {
    Stats();//stats displayed

    Console.WriteLine($"==============================================================================================\nWelcome! You must be hungry and tired.\nI am the Merchant and I sell some tastey treats! Buy and use here at the shop before you head back out on your travels. I assure you, no negative side effects :)\nPlease place your order by selecting the product and subsequently providing the quantity desired.\n\nHere is the menu:");

    for (int i = 0; i < products.Count; i++) //For each product in my product list
    {
        Console.WriteLine($"\n| {i} | Product:  {products[i].Name}   | Price:  {products[i].Price}   | Your Quant:  {products[i].Quant}   | Health Benefits:  {products[i].Health}   | Energy Benefits:  {products[i].Energy}   |\n"); //This displays the final order information
    }

    Console.WriteLine("==============================================================================================\nWhat would you like to order?");

    int order = Convert.ToInt32(Console.ReadLine());//makes input a int value that will function as my if while indicating variable to take me down a certain path

    if (order >= 0 && order < products.Count) //product 1 selection path
    {
        Console.Clear(); // Clear the console before each new output

        Products selectedProduct = products[order]; //The selected product becomes the item the user selected with the order variable

        Console.WriteLine("==============================================================================================\nHow many would you like to order?"); 
        decimal quantity = Convert.ToDecimal(Console.ReadLine()); //creates a local quantity variable

        Console.WriteLine($"==============================================================================================\nYou want {quantity} of {selectedProduct.Name}"); //tells the user what they selected

        decimal total = quantity * selectedProduct.Price; //the quantity and price of selected product are added to the temporary local total

        selectedProduct.Quant += quantity; //adds temp quant to global quant variable

        totalFin += total; //adds temp total to global total

        Console.WriteLine($"==============================================================================================\nThe current total for your order is ${totalFin}\n"); //tells the user their global total

        Console.WriteLine("If you are finished ordering, please input 1; otherwise, if you would\nlike to add to your order, please input 2."); 

        exit = Convert.ToInt32(Console.ReadLine()); //gives user option to keep shopping or exit cart and get final total

        Console.WriteLine("\n==============================================================================================\nAdding to your order...");
    }

    else 
    {
        Console.Clear(); // Clear the console before each new output
        Console.WriteLine("==============================================================================================\nHey bud, you failed to select an option please try again if ya got the munchies."); //error exit option
    }

    } while (exit == 2);

    while (exit == 1)
    {
        Console.Clear(); // Clear the console before each new output
        Console.WriteLine("==============================================================================================\nHere is a summary of your final order:\n");
        for (int i = 0; i < products.Count; i++)  //For each product
        {
            Console.WriteLine($"| {i} | Product:  {products[i].Name}   | Quant:  {products[i].Quant}   |\n"); //This displays the final order information
        }
        Console.WriteLine($"==============================================================================================\nThe total cost for your order is ${totalFin}");//this displays total cost
        Console.WriteLine($"\nYour current wallet has ${Shrek.Wallet}");

        if (Shrek.Wallet < totalFin)//If User does not have the funds the user leaves the store
        {
            Console.Clear(); // Clear the console before each new output
            Console.WriteLine("==============================================================================================\nSorry you are too broke for this purchase, leave my store...");
            return;
        }

        else if (Shrek.Wallet >= totalFin)//If user does have the funds
        {
            Console.Clear(); // Clear the console before each new output
            Console.WriteLine("==============================================================================================\nSubtracting money from user account and applying items effects to Shrek's stats!");
            Shrek.Wallet -= totalFin;//expenses are subtracted from user's wallet
        

            for (int i = 0; i < products.Count; i++)  //For each product purchased 
            {
                Shrek.Health += products[i].Health * Convert.ToInt32(products[i].Quant);//add health benefits of the product to the user based on the quantity of the item purchased
                Shrek.Energy += products[i].Energy * Convert.ToInt32(products[i].Quant);//add energy benefits of the product to the user based on the quantity of the item purchased
            }
            break;
        }
    }

    if (exit != 2 && exit != 1) //If exit is not 1 or not 2
    {
        Console.Clear(); // Clear the console before each new output
        Console.WriteLine("==============================================================================================\nError!");//errors out
        return;
    }

}///End of Merchant

void Oracle()
{
    //Creates array for response pool below

    //start of the responses
    string[] text = {"Nicholas Cage thinks your", "Today is a day to", "Question yourself because", "This is an ideal time to"};

    //End of responses based on good, neutral, and bad
    string[] good = {"a pretty chill guy.", "Throw caution to the wind, you got this!", "your to good for Mr. Cage.", "unlayer your onion Shrek."};
    string[] neutral = {"a bagel", "explore and find random encounters.", "why not?", "drink some caffine."};
    string[] bad = {"your a sad pathetic lil bug.", "quit the game, you don't look like you can find Nick.", "...you just aint it Shrek.", "get out of MY swamp Shrek, you hypocrite."};

    int selection1; //Creates selection variable

    List<string> CarriedResponses = new List<string> {}; //creates empty array to store past convo

    double questionQuant = 0; //Global quantity if question variable

    decimal totalFin = 0m; //Works as a global variable that adds up your total price

    bool quest = false; //my bool for triggering "another question"

    string response;//this will be given through my method

    decimal luck = 0m;//creates a luck pool variable

    Console.Clear(); // Clear the console before each new output

    Console.WriteLine("==============================================================================================\nPlease be aware, I do charge $3.50 a question, and if you ask be ready to pay or I will be upset.");

    do 
    {
        Stats();//displays stats

        while (quest == false)//OG question
        {
            Console.WriteLine($"==============================================================================================\n1) Ask a question\n2) Review questions/responses\n3) Quit services and pay");
            break;
        } 

        while (quest == true)//Another question
        {
            Console.WriteLine($"==============================================================================================\n1) Ask another question\n2) Review questions/responses\n3) Quit services and pay");
            break;
        }

        selection1 = Convert.ToInt32(Console.ReadLine()); //selects if-else branch

        if (selection1 == 1)
        {
            Console.Clear(); // Clear the console before each new output

            questionQuant += 1;//adds 1 to global quant
            
            totalFin += 3.50m;//adds cost of question to global total

            Console.WriteLine("==============================================================================================\nWhat is your question, child?");//asks question 

            string question = Console.ReadLine();//uses input and stores it as question

            CarriedResponses.Add($"Question: {question}"); //adds question to list

            myResponse();//response is generated
            Console.WriteLine(response);

            CarriedResponses.Add($"Response: {response}"); //adds response to list

            Console.WriteLine();
            quest = true; //triggers loop
        }
        else if(selection1 == 2)
        {
            Console.Clear(); // Clear the console before each new output
            Console.WriteLine("==============================================================================================\nThe oracle knows all. Here are your fortunes to review:\n");
            storedResponses();//fortune history is diaplayed
        }
        else if(selection1 == 3)
        {
            Console.Clear(); // Clear the console before each new output
            Console.WriteLine("==============================================================================================\nThank you for visiting the mighty and incredibly awesome machine, myth, and legend, The Oracle. I hope you enjoyed your visit you silly human.\n");

            Console.WriteLine($"You asked {questionQuant} questions. You currently owe ${totalFin}. I accept all major credit cards from all major banks.\nI also accept praise and affirmation, does not count as payment though.\nClick 1 to pay and collect your fortune. 2 to quit and leave without any buffs.");
            
            int payOracle = Convert.ToInt32(Console.ReadLine());

            if (payOracle == 1 && Shrek.Wallet >= totalFin)//if they select to pay the oracle and they have the funds
            {
                Console.Clear(); // Clear the console before each new output
                Shrek.Wallet -= totalFin;//subtracts expense
                Console.WriteLine("==============================================================================================\nYou have paid me well, let your rightful fortune be placed apon you!");
                Shrek.Luck += luck;//adds good fortune
            }
            else if (payOracle == 2 || Shrek.Wallet < totalFin)//if they choose to leave or dont have the funds
            {
                Console.Clear(); // Clear the console before each new output
                Console.WriteLine("==============================================================================================\nYou have attempted to leave without paying or have insufficent funds, you have angered the oracle!\nBad Faith has been placed on you and your journey...");
                
                decimal curseA = Convert.ToDecimal(questionQuant);
                decimal curse = curseA * .05m;//curse is added based on the amount of questions asked
                Shrek.Luck -= curse;//curse is placed on user's luck
            }
            else 
            {
                Console.Clear(); // Clear the console before each new output
                Console.WriteLine("==============================================================================================\nYou have failed to either input a correct value or have insufficent funds, you have angered the oracle!\nBad Faith has been placed on you and your journey...");
                
                decimal curseA = Convert.ToDecimal(questionQuant);//error situation 
                decimal curse = curseA * .05m;//curse is added based on the amount of questions asked
                Shrek.Luck -= curse;//curse is placed on user's luck
            }
            //displays total quant and total fin in goodbye message
            break;
        } 
        else
        {
            Console.Clear(); // Clear the console before each new output
            Console.WriteLine("==============================================================================================\nERROR, ERROR, ERROR, Beep Boop Beep Boop. You have failed to provide correct input, if you are trying to quit, you suck. If you have a total, please input 3 to quit, if not your free to leave.");
        }

    }while(questionQuant>0);//if they have asked a queston the program will loop through until they quit

    ///methods for crystal ball

    string myResponse()
    {
        int switchRan = randomA.Next(0,3); //creates random variable for switch path
        int RanRan = randomA.Next(0,4); //creates random variable for text
        
        string goodbadneutral = "";//creates empty string variable to store eventual random

        switch(switchRan)
        {
            case 0:
            goodbadneutral = good[RanRan]; //picks a end task from good list
            luck += .10m;//stores good luck
            break;

            case 1:
            goodbadneutral = bad[RanRan]; //picks a end task from bad list
            luck -= .05m;//stores bad luck
            break;

            case 2:
            goodbadneutral = neutral[RanRan]; //picks a end task from neutral list
            break;
            
        } 

        response = $"{text[RanRan]} {goodbadneutral}"; 
        return response; //returns full message for response
    }

    void storedResponses()
    {
        foreach (string item in CarriedResponses) //print list history to read back past convo
        {
            Console.WriteLine($"\n{item}");
        }
    }
}

void SaveGame(User user)
{
    string jsonSave = JsonSerializer.Serialize(user, new JsonSerializerOptions {WriteIndented = true});// Serializes the user's current data into a JSON format with indentation for readability
    File.WriteAllText(jsonDataPath, jsonSave);//Writes the serialized JSON data to the json file through the file path
}

void Stats()
{
    //Keeps key survival variables in a reasonable range
    if (Shrek.Energy < 0) Shrek.Energy = 0;
    if (Shrek.Energy > 1000) Shrek.Energy = 1000;
    if (Shrek.Health < 0) Shrek.Health = 0;
    if (Shrek.Health > 1000) Shrek.Health = 1000;
    //displays stats of the user
    Console.WriteLine($"###################################################################################\nUser Stats:\n{Shrek.Name}, Health: {Shrek.Health}, Money: {Shrek.Wallet}, Luck: {Shrek.Luck}, Energy: {Shrek.Energy}\n");
}

void Whack()
{
    Console.Clear(); // Clear the console before each new output

    Console.WriteLine("Input enter");

    string enter3 = Console.ReadLine();

    NPC whackyCharacter = CreateRandomWhackyCharacter();//creates NPC

    Console.WriteLine($"==============================================================================================\nYou have encountered {whackyCharacter.Name} on your quest to meet Nick Cage, and {whackyCharacter.Name} has challenged you to a duel");
    
    while(whackyCharacter.Health > 0 && Shrek.Health > 0)//while both the NPC and User are alive
    {
        Console.WriteLine("Input enter");

        string enter4 = Console.ReadLine();

        Console.Clear(); // Clear the console before each new output 

        Stats();//stats displayed
        Console.WriteLine($"###################################################################################\n\n\n\n\n\n\n\nEnemy Stats:\n{whackyCharacter.Name}, Health: {whackyCharacter.Health}");//enemy stats displayed
        int ogre = 0;//functions as selection variable
        while (ogre == 0)
        {
            Console.WriteLine($"==============================================================================================\n{whackyCharacter.Name} challenges Shrek! Choose your move:");
            Console.WriteLine("1. Unlayer the Ogre");
            Console.WriteLine("2. Do the roar");
            Console.WriteLine("3. Be a swampy boy");
            ogre = Convert.ToInt32(Console.ReadLine());
            if (ogre != 1 && ogre != 2 && ogre != 3)//if one - three were not selected
            {
                Console.WriteLine("==============================================================================================\nInvalid choice. Please choose 1, 2, or 3.");//Invalid choice!
                return;
            }
        }

        int npcA = whackyCharacter.Attack();//generate random attack (rock, paper, scissors)

        if (ogre == npcA)//when both attacks are the same
        {
            Console.Clear(); // Clear the console before each new output
            Console.WriteLine($"==============================================================================================\nIt's a draw! {whackyCharacter.Name}'s {whackyCharacter.Pow} deflects your attack!");

            Shrek.Energy -= 10;//User lost energy
        }
        else if ((ogre == 1 && npcA == 3) || (ogre == 2 && npcA == 1) || (ogre == 3 && npcA == 2))//if User beats NPC at rock, paper, scissors
        {
            Console.Clear(); // Clear the console before each new output
            Console.WriteLine($"==============================================================================================\n{whackyCharacter.Name} is hit by Shrek's attack and their {whackyCharacter.Pow} misses Shrek entirely.");
            
            decimal powerB = 30 * Shrek.Luck; //adds critical hit based off luck
            decimal powerA = 30 + powerB; //critical and base attacks are combined

            whackyCharacter.TakeDamage(powerA);//NPC takes the damage accured

            Shrek.Energy -= 10;//User lost energy
            Shrek.Luck += .025m;//User gains luck, or confidence for hitting the target
        }
        else
        {
            Console.Clear(); // Clear the console before each new output
            Console.WriteLine($"==============================================================================================\n{whackyCharacter.Name} is too fast for Shrek and their {whackyCharacter.Pow} hits! Shrek roars a mighty ogre roar.");
            Shrek.Health -= 20;//Shrek loses health
            Shrek.Energy -= 10;//Shrel lost energy
        }
    }
    if (whackyCharacter.Health <= 0 && Shrek.Health > 0)
    {
        decimal yup = 10.00m;//creates variable for bonus
        yup *= Shrek.Luck;//bases bonus off luck
        yup += 10.00m;//adds base amount
        Shrek.Wallet += yup;//adds base and bonus to wallet
        Console.Clear(); // Clear the console before each new output
        Console.WriteLine($"\n==============================================================================================\nYou have defeated {whackyCharacter.Name}, they cry in defeat and give you some cash.");
    }
}



