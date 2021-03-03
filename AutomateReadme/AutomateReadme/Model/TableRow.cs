using System;
using System.Collections.Generic;
using System.Text;
using CreateReadMe.Enum;

namespace CreateReadMe.Model
{
    class TableRow
    {
        public string Number { get; set; }
        public string Name { get; set; }
        public List<Language> Languages = new List<Language>();

        public string Difficulty { get; set; }
        public String DifficultyBadge()
        {
            switch (Difficulty)
            {
                case "Medium":
                    return "[![Generic badge](https://img.shields.io/badge/-Medium-yellow)](https://shields.io/)";
                
                case "Hard":
                    return "[![Generic badge](https://img.shields.io/badge/-Hard-red)](https://shields.io/)";

                default:
                    return "[![Generic badge](https://img.shields.io/badge/-Easy-brightgreen)](https://shields.io/)";
            }
        }

        public string CSharpUrl { get; set; }
    }
}
