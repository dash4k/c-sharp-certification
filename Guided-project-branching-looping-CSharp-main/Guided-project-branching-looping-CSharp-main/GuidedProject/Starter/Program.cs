

// the ourAnimals array will store the following: 
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variables that support data entry
int maxPets = 8;
int currentPetIndex = 4;
string? readResult;
string menuSelection = "";

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6];

// TODO: Convert the if-elseif-else construct to a switch statement

// create some initial ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            break;
        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "loki";
            break;
        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "Puss";
            break;
        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "?";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
    }

    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
}

// display the top-level menu options

bool flag = true;

while (flag)
{
    Console.Clear();

    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
    Console.WriteLine(" 1. List all of our current pet information");
    Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
    Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
    Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
    Console.WriteLine(" 5. Edit an animal’s age");
    Console.WriteLine(" 6. Edit an animal’s personality description");
    Console.WriteLine(" 7. Display all cats with a specified characteristic");
    Console.WriteLine(" 8. Display all dogs with a specified characteristic");
    Console.WriteLine();
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

    readResult = Console.ReadLine();
    if (readResult != null)
    {
        menuSelection = readResult.ToLower();
    }

    switch (menuSelection)
    {
        case "1":
            displayAnimal(ourAnimals);
            pause();
            break;
        case "2":
            if (addAnimal()) Console.WriteLine("Animal added successfuly");
            else Console.WriteLine("An error was occured when adding new animal");
            pause();
            break;
        case "3":
            if (verifyAgeAndPhysical()) Console.WriteLine("Data updated successfuly");
            else Console.WriteLine("An error occured while trying to update the data");
            pause();
            break;
        case "4":
            break;
        case "5":
            break;
        case "6":
            break;
        case "7":
            break;
        case "8":
            break;
        case "exit":
        flag = false;
            break;
        default:
            break;
    }
}

void pause() {
    Console.WriteLine("Press the Enter key to continue");
    readResult = Console.ReadLine();
}

void displayAnimal(string[,] animals) {
    Console.Clear();
    Console.WriteLine($"Current animals in our care:\n");
    
    for (int i = 0; i < maxPets; i++)
    {
        Console.WriteLine($"Animal {i+1}");
        
        for (int j = 0; j < 6; j++)
        {
            Console.WriteLine(animals[i, j]);
        }
        
        Console.WriteLine();
    }
}

bool addAnimal() {
    bool continueAddingAnimal = true;
    bool flagAdd = true;

    if (currentPetIndex == maxPets)
    {
        return false;
    }

    while (continueAddingAnimal && currentPetIndex < maxPets)
    {
        while (flagAdd)
        {
            Console.Clear();
            Console.WriteLine("Please choose the pet's species:\n\n1. Cat\t2. Dog");
            readResult = Console.ReadLine();

            switch (readResult)
            {
                case "1":
                    animalSpecies = "cat";
                    flagAdd = false;
                    break;
                case "2":
                    animalSpecies = "dog";
                    flagAdd = false;
                    break;
                default:
                    Console.WriteLine("Please choose between dog and cat");
                    break;
            }        
        }

        if (animalSpecies == "dog") animalID = "d" + (currentPetIndex + 1);
        else animalID = "c" + currentPetIndex;

        flagAdd = true;

        while (flagAdd)
        {
            Console.Clear();
            Console.WriteLine($"Please enter the age of the {animalSpecies}, if the age is unknown, please enter \"?\" instead.");
            readResult = Console.ReadLine();

            if (readResult != null)
            {
                animalAge = readResult;
                flagAdd = false;
            }
        }

        flagAdd = true;

        while (flagAdd)
        {
            Console.Clear();
            Console.WriteLine($"Please enter the nickname of the {animalSpecies}, if it is unknown, please enter \"?\" instead.");
            readResult = Console.ReadLine();

            if (readResult != null)
            {
                if (readResult == "?") animalNickname = "tbd";
                else animalNickname = readResult;
                flagAdd = false;
            }
        }
        
        flagAdd = true;

        while (flagAdd)
        {
            Console.Clear();
            Console.WriteLine($"Please enter the Physical Description of the {animalSpecies}, if it is unknown, please enter \"?\" instead.");
            readResult = Console.ReadLine();

            if (readResult != null)
            {
                if (readResult == "?") animalPhysicalDescription = "tbd";
                else animalPhysicalDescription = readResult;
                flagAdd = false;
            }
        }
        
        flagAdd = true;

        while (flagAdd)
        {
            Console.Clear();
            Console.WriteLine($"Please enter the Personality Description of the {animalSpecies}, if it is unknown, please enter \"?\" instead.");
            readResult = Console.ReadLine();

            if (readResult != null)
            {
                if (readResult == "?") animalPersonalityDescription = "tbd";
                else animalPersonalityDescription = readResult;
                flagAdd = false;
            }
        }

        ourAnimals[currentPetIndex, 0] = "ID #: " + animalID;
        ourAnimals[currentPetIndex, 1] = "Species: " + animalSpecies;
        ourAnimals[currentPetIndex, 2] = "Age: " + animalAge;
        ourAnimals[currentPetIndex, 3] = "Nickname: " + animalNickname;
        ourAnimals[currentPetIndex, 4] = "Physical description: " + animalPhysicalDescription;
        ourAnimals[currentPetIndex, 5] = "Personality: " + animalPersonalityDescription;

        Console.Clear();
        Console.WriteLine($"Animal Added:\n");
        
        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(ourAnimals[currentPetIndex, i]);
        }

        currentPetIndex++;

        Console.WriteLine($"Do you want to continue adding more animal? {maxPets - (currentPetIndex + 1)} animal slot left.");
        Console.WriteLine("Enter \"y\" to continue, otherwise press enter to exit");
        readResult = Console.ReadLine();

        if (readResult != null && readResult.ToLower() == "y") continue;
        else continueAddingAnimal = false;
    }

    return true;
}

bool verifyAgeAndPhysical() {
    bool validInput = false;
    bool edited = false;
    int currentAnimalAge = 0;

    for (int i = 0; i < maxPets; i++)
    {
        if (ourAnimals[i, 0].Length > 6)
        {
            if (ourAnimals[i, 2][5] == '?' || ourAnimals[i, 2][5] == ' ')
            {
                while (!validInput)
                {
                    Console.Clear();
                    Console.WriteLine($"Enter the age for {ourAnimals[i, 0]}:");
                    readResult = Console.ReadLine();
    
                    if (int.TryParse(readResult, out currentAnimalAge)) validInput = true;
                    else Console.WriteLine("Please enter a valid pet age");
                    pause();
                }
    
                animalAge = currentAnimalAge.ToString();
                ourAnimals[i, 2] = "Age: " + animalAge;
    
                edited = true;
    
            }
    
            validInput = false;
    
            if (ourAnimals[i, 4].Length < 23 || ourAnimals[i, 4].Substring(23, 3) == "tbd")
            {
                while (!validInput)
                {
                    Console.Clear();
                    Console.WriteLine($"Enter the physical description for {ourAnimals[i, 0]}:");
                    readResult = Console.ReadLine();
        
                    if (readResult != null)
                    {
                        animalPhysicalDescription = readResult;
                        ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
                        edited = validInput = true;
                        
                    }
                    else Console.WriteLine("Please enter something for the physical description.");
                    pause();
                }
            }
        }
    }

    if (edited) return true;
    else return false;
}

// TODO: modify the function
bool verifyNicknameAndPersonality() {
    bool validInput = false;
    bool edited = false;
    int currentAnimalAge = 0;

    for (int i = 0; i < maxPets; i++)
    {
        if (ourAnimals[i, 0].Length > 6)
        {
            if (ourAnimals[i, 2][5] == '?' || ourAnimals[i, 2][5] == ' ')
            {
                while (!validInput)
                {
                    Console.Clear();
                    Console.WriteLine($"Enter the age for {ourAnimals[i, 0]}:");
                    readResult = Console.ReadLine();
    
                    if (int.TryParse(readResult, out currentAnimalAge)) validInput = true;
                    else Console.WriteLine("Please enter a valid pet age");
                    pause();
                }
    
                animalAge = currentAnimalAge.ToString();
                ourAnimals[i, 2] = "Age: " + animalAge;
    
                edited = true;
    
            }
    
            validInput = false;
    
            if (ourAnimals[i, 4].Length < 23 || ourAnimals[i, 4].Substring(23, 3) == "tbd")
            {
                while (!validInput)
                {
                    Console.Clear();
                    Console.WriteLine($"Enter the physical description for {ourAnimals[i, 0]}:");
                    readResult = Console.ReadLine();
        
                    if (readResult != null)
                    {
                        animalPhysicalDescription = readResult;
                        ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
                        edited = validInput = true;
                        
                    }
                    else Console.WriteLine("Please enter something for the physical description.");
                    pause();
                }
            }
        }
    }

    if (edited) return true;
    else return false;
}