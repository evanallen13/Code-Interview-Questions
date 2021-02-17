using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _282_RansomNote
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            bool result = false;

            List<char> magazineList = new List<char>();
            magazineList.AddRange(magazineList);


            char[] ransomNoteArr = ransomNote.ToCharArray();


            foreach(char chr in ransomNoteArr)
            {

            }

            return result;
        }
    }
}
