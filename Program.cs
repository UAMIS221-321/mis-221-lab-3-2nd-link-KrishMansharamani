//start main
string enjoymentLevel = GetEnjoymentLevel();
string stadium = GetStadiumRecommendation(enjoymentLevel);
string game = GetGameRecommendation(stadium);
DisplayStadiumDetails (stadium,game);

//end of main



static string GetEnjoymentLevel (){
    Console.WriteLine ("What enjoyment level would you like ?\n Boring\n Average\n Fun\n Epic\n");
    return Console.ReadLine();
    }

static string GetStadiumRecommendation(string enjoymentLevel){
    if (enjoymentLevel == "Boring"){
        return ("Neyland Stadium");
    }
    else if (enjoymentLevel == "Average"){
        return ("Jordan-Hare Stadium");
    }
    else if (enjoymentLevel == "Fun"){
        return ("Tiger Stadium");
    }
    else {
        return ("Saban Field at Bryant-Denny Stadium");
    }
    }

    static string GetGameRecommendation(string stadium){
        if (stadium == "Neyland Stadium"){
            return ("vs Kent State");
        }
        else if (stadium == "Jordan-Hare Stadium"){
            return ("vs Kentucky");
        }
        else if (stadium == "Tiger Stadium"){
            return ("vs Alabama");
        }
        else {
            return ("vs Auburn");
        }   
    }

    static void DisplayStadiumDetails(string stadium, string game){
        Console.WriteLine($"Your desired stadium is {stadium} while playing {game}.\nThank you for using College Level Intro!");

    }
    

