using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRichList {
    class Main {
        Categories presidents = new Categories("US Presidents", new string[] {"George Washington", "John Adams",
            "Thomas Jefferson", "James Madison", "James Monroe", "John Quincy Adams", "Andrew Jackson", "Martin van Buren",
            "William Harrison", "John Tyler", "James Polk", "Zachary Taylor", "Millard Fillmore", "Franklin Pierce",
            "James Buchanan", "Abraham Lincoln", "Andrew Johnson", "Ulysses Grant", "Rutherford Hayes", "James Garfield",
            "Chester Arthur", "Grover Cleveland", "Benajmin Harrison", "William McKinley", "Theodore Roosevelt",
            "William Howard Taft", "Woodrow Wilson", "Warren Harding", "Calvin Coolidge", "Herbert Hoover",
            "Franklin D. Roosevelt", "Harry Truman", "Dwight D. Eisenhower", "John F. Kennedy", "Lyndon B. Johnson",
            "Richard Nixon", "Gerald Ford", "Jimmy Carter", "Ronald Reagan", "George Bush", "Bill Clinton",
            "George W. Bush", "Barack Obama", "Donald Trump", "Joe Biden"});

        Categories neighborsGermany = new Categories("Neighboring countries of Germany", new string[] {"Denmark", "Belgium",
        "Nehterlands", "Luxembourg", "France", "Switzerland", "Austria", "Czech Republic", "Poland"});

        Categories usStates = new Categories("US States", new string[] {"Alabama", "Alaska", "Arizona", "Arkansas",
            "California", "Colorado", "Connecticut", "Delaware", "Florida", "Georgia", "Hawaii", "Idaho", "Illinois",
        "Indiana", "Iowa", "Kansas", "Kentucky", "Louisiana", "Maine", "Maryland", "Massachusetts", "Michigan", "Minnesota",
        "Mississippi", "Missouri", "Montana", "Nebraska", "Nevada", "New Hampshire", "New Jersey", "New Mexico", "New York",
        "North Carolina", "North Dakota", "Ohio", "Oklahoma", "Oregon", "Pennsylvania", "Rhode Island", "South Carolina",
        "South Dakota", "Tennessee", "Texas", "Utah", "Vermont", "Virginia", "Washington", "West Virginia", "Wisconsin",
        "Wyoming"});

        Categories countriesWithB = new Categories("Countries that start with B", new string[] {"Bahamas", "Bahrain", 
        "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bhutan", "Bolivia", "Bosnia and Herzegovina", 
        "Botswana", "Brazil", "Brunei", "Bulgaria", "Burkina Faso", "Burundi"});

        Categories countriesWithS = new Categories("Countries that start with S", new string[] {"Saint Kitts and Nevis", 
            "Saint Lucia", "Saint Vincent and the Grenadines", "Samoa", "San Marino", "Sao Tome and Principe",
            "Saudi Arabia", "Senegal", "Serbia", "Seychelles", "Sierra Leone", "Singapore", "Slovakia", "Slovenia", 
        "Solomon Islands", "Somalia", "South Africa", "South Korea", "South Sudan", "Spain", "Sri Lanka", "Sudan", 
        "Suriname", "Sweden", "Switzerland", "Syria"});

        /* other categories to add: 
         * Bundeskanzler, Bundespraesidenten, Monopoly squares, military alphabet, presents 12 days of Christmas,
         * German Bundeslaender, James Bond movies, orchestra instruments
         */ 
    }
}
