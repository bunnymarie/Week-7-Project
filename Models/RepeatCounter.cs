using System;
using Systen.Collections.Generic;

namespace WordSearch.Models
{
  public class RepeatCounter
  {
    private string _userWriting;
    private string[] _userSplit = userWord.Split();
    private string _userWord;
    private int _repeatCount = 0;

    public string GetUserWriting()
    {
      return _userWriting;
    }
    public void SetUserWriting(string newUserWriting)
    {
      _userWriting = newUserWriting;
    }
    public string GetUserWord()
    {
      return _userWord;
    }
    public void SetUserWord(string newUserWord)
    {
      _userWord = newUserWord;
    }
    public int GetRepeatCount()
    {
      return _repeatCount;
    }
    public string UserWritingSplit(string[] _userSplit, string _userWord, int _repeatCount)
    {
      for(int i = 0; i < _userSplit.Length; i++)
              {
                if (_userSplit[i] == _userWord + "." || _userSplit[i] == _userWord + "," || _userSplit[i] == _userWord + "!" || _userSplit[i] == _userWord + "?" || _userSplit[i] == _userWord)
                {
                  _repeatCount += 1;
                }
          return _userSplit;
      }
    }
  }
}
