using UnityEngine;

public class Level
{
    private int[] _levelByExperience = new []{ 0, 300, 900, 2700, 6500, 14000, 23000, 34000, 48000, 64000, 85000, 100000, 
        120000, 140000, 165000, 195000, 225000, 265000, 305000, 355000 };

    private int _currentLevel;
    private int _currentExperience;

    public int CurrentLevel
    {
        get => _currentLevel + 1;
    }

    public int CurrentExperience
    {
        set => _currentExperience = value;
    }

    /// <summary>
    /// Set new experience and check if new level is reached
    /// </summary>
    /// <param name="value">
    /// Experience value
    /// </param>
    /// <returns>
    /// True if new level is reached
    /// </returns>
    private bool SetCurrentExperience(int value)
    {
        bool newLevelReached = false;
        if (_currentLevel < _levelByExperience.Length - 1)
        {
            _currentExperience += value;
            if (_currentExperience >= _levelByExperience[_currentLevel + 1])
            {
                _currentLevel++;
                newLevelReached = true;
                SetCurrentExperience(_currentExperience);
            }
        }
        return newLevelReached;
    }
}
