﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    public class AnimalGroupName
    {
        /*
         * Given the name of an animal, return the name of a group of that animal
         * (e.g. "Elephant" -> "Herd", "Rhino" - "Crash").  
         * 
         * The animal name should be case insensitive so "elephant", "Elephant", and 
         * "ELEPHANT" should all return "herd". 
         * 
         * If the name of the animal is not found, null, or empty, return "unknown". 
         * 
         * Rhino -> Crash
         * Giraffe -> Tower
         * Elephant -> Herd
         * Lion -> Pride
         * Crow -> Murder
         * Pigeon -> Kit
         * Flamingo -> Pat
         * Deer -> Herd
         * Dog -> Pack
         * Crocodile -> Float
         *
         * animalGroupName("giraffe") → "Tower"
         * animalGroupName("") -> "unknown"         
         * animalGroupName("walrus") -> "unknown"
         * animalGroupName("Rhino") -> "Crash"
         * animalGroupName("rhino") -> "Crash"
         * animalGroupName("elephants") -> "unknown"
         * 
         */

        public string AnimalGroup(string animalName)
        {
            Dictionary<string, string> animal = new Dictionary<string, string>()
            {
                {"rhino", "Crash" },
                {"giraffe", "Tower" },
                {"elephant", "Herd" },
                {"lion", "Pride" },
                {"crow", "Murder"},
                {"pigeon", "Kit" },
                {"flamingo", "Pat" },
                {"deer", "Herd" },
                {"dog", "Bark" },
                {"crocodile", "Float" },
            };

            if(animal.ContainsKey(animalName.ToLower()))
            {
                return animal[animalName.ToLower()];
            }

            else
            {
                return "unknown";
            }
            
        }
    }
}
