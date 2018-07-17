using System;
using System.Collections.Generic;
using System.Linq;

namespace WordSearch.Models
{
  public class RepeatCounter
  {
      private string _userWriting;
      private string _userWord;
      public int _repeatCount = 0;
      public string[] userSplit;
      public string _returnError = "ONE OR MORE ENTRIES EMPTY/NULL, PLEASE TRY AGAIN!";

      public RepeatCounter(string newUserWord, string newUserWriting)
      {
        _userWriting = newUserWriting;
        _userWord = newUserWord;
      }
      public string GetUserWriting()
      {
        return _userWriting;
      }
      public string GetUserWord()
      {
        return _userWord;
      }
      public string IsItNull()
      {
        if(String.IsNullOrEmpty(_userWord) || String.IsNullOrEmpty(_userWriting))
        {
          return _returnError;
        } else
        {
          return _userWriting;
        }
      }
      public int wordCountProcess()
      {
        string[] userSplit = _userWriting.Split();
        int foundNumbers = 0;
        for(int i = 0; i < userSplit.Length; i++)
          {
            if (userSplit[i] == _userWord + "." || userSplit[i] == _userWord + "," || userSplit[i] == _userWord + "!" || userSplit[i] == _userWord + "?" || userSplit[i] == _userWord)
            {
              foundNumbers += 1;
            }
          }
        _repeatCount = foundNumbers;
        return _repeatCount;
      }
  }
}
