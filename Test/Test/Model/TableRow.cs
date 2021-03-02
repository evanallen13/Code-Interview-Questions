using System;
using System.Collections.Generic;
using System.Text;
using Test.Enum;

namespace Test.Model
{
    class TableRow
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public Language Language { get; set; }
        public string LanguageStr()
        {
            return Language.ToString();
        }
        public Difficulty Difficulty { get; set; }
        public String DifficultyBadge()
        {
            switch (Difficulty)
            {
                case Difficulty.Medium:
                    return "[![Generic badge](https://img.shields.io/badge/-Medium-yellow)](https://shields.io/";
                
                case Difficulty.Hard:
                    return "[![Generic badge](https://img.shields.io/badge/-Hard-red)](https://shields.io/)";

                default:
                    return "[![Generic badge](https://img.shields.io/badge/-Easy-brightgreen)](https://shields.io/)";

            }
        }

        public string CSharpUrl { get; set; }
    }
}
