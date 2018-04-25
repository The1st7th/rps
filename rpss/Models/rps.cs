using System.Collections.Generic;
using System;

namespace rpsgame.Models
{
  public class rps
  {
    private string _player1;
    private string _player2;
    Dictionary<string, int> game = new Dictionary<string,int>() { {"rock", 1}, {"paper", 2}, {"scissor", 3}};

    public rps(string player1, string player2)
    {
      _player1 = player1;
      _player2 = player2;
    }

    public string rpsgame(){
       if(game[_player1] > game[_player2] && game[_player1] != 3 )
        return "player1 wins";

       if (game[_player1] == game[_player2] )
       return "draw";

       if(game[_player1] == 1 && game[_player2] == 3)
       return "player1 wins";

       else
        return "player2 wins";

    }

  }
}
