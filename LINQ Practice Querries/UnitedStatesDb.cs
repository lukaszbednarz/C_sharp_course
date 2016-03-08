using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ_Practice_Querries
{
    static class UnitedStatesDb
    {

        public static List<State> States { get { return states; } }

        static List<State> states = new List<State>()

    {

        new State() { PostalCode="AL", Name="Alabama", Capital="Montgomery", Population=4599000},

        new State() { PostalCode="AK", Name="Alaska", Capital="Juneau", Population=670000},

        new State() { PostalCode="AZ", Name="Arizona", Capital="Phoenix", Population=6166000},

        new State() { PostalCode="AR", Name="Arkansas", Capital="Little Rock", Population=2811000},

        new State() { PostalCode="CA", Name="California", Capital="Sacramento", Population=36458000},

        new State() { PostalCode="CO", Name="Colorado", Capital="Denver", Population=4753000},

        new State() { PostalCode="CT", Name="Connecticut", Capital="Hartford", Population=3505000},

        new State() { PostalCode="DE", Name="Delaware", Capital="Dover", Population=853000},

        new State() { PostalCode="DC", Name="District of Columbia", Capital="Washington", Population=582000},

        new State() { PostalCode="FL", Name="Florida", Capital="Tallahassee", Population=18090000},

        new State() { PostalCode="GA", Name="Georgia", Capital="Atlanta", Population=9364000},

        new State() { PostalCode="HI", Name="Hawaii", Capital="Honolulu", Population=1285000},

        new State() { PostalCode="ID", Name="Idaho", Capital="Boise", Population=1466000},

        new State() { PostalCode="IL", Name="Illinois", Capital="Springfield", Population=12832000},

        new State() { PostalCode="IN", Name="Indiana", Capital="Indianapolis", Population=6314000},

        new State() { PostalCode="IA", Name="Iowa", Capital="Des Moines", Population=2982000},

        new State() { PostalCode="KS", Name="Kansas", Capital="Topeka", Population=2764000},

        new State() { PostalCode="KY", Name="Kentucky", Capital="Frankfort", Population=4206000},

        new State() { PostalCode="LA", Name="Louisiana", Capital="Baton Rouge", Population=4288000},

        new State() { PostalCode="ME", Name="Maine", Capital="Augusta", Population=1322000},

        new State() { PostalCode="MD", Name="Maryland", Capital="Annapolis", Population=5616000},

        new State() { PostalCode="MA", Name="Massachusetts", Capital="Boston", Population=6437000},

        new State() { PostalCode="MI", Name="Michigan", Capital="Lansing", Population=10096000},

        new State() { PostalCode="MN", Name="Minnesota", Capital="St. Paul", Population=5167000},

        new State() { PostalCode="MS", Name="Mississippi", Capital="Jackson", Population=2911000},

        new State() { PostalCode="MO", Name="Missouri", Capital="Jefferson City", Population=5843000},

        new State() { PostalCode="MT", Name="Montana", Capital="Helena", Population=945000},

        new State() { PostalCode="NE", Name="Nebraska", Capital="Lincoln", Population=1768000},

        new State() { PostalCode="NV", Name="Nevada", Capital="Carson City", Population=2496000},

        new State() { PostalCode="NH", Name="New Hampshire", Capital="Concord", Population=1315000},

        new State() { PostalCode="NJ", Name="New Jersey", Capital="Trenton", Population=8725000},

        new State() { PostalCode="NM", Name="New Mexico", Capital="Santa Fe", Population=1955000},

        new State() { PostalCode="NY", Name="New York", Capital="Albany", Population=19306000},

        new State() { PostalCode="NC", Name="North Carolina", Capital="Raleigh", Population=8857000},

        new State() { PostalCode="ND", Name="North Dakota", Capital="Bismarck", Population=636000},

        new State() { PostalCode="OH", Name="Ohio", Capital="Columbus", Population=11478000},

        new State() { PostalCode="OK", Name="Oklahoma", Capital="Oklahoma City", Population=3579000},

        new State() { PostalCode="OR", Name="Oregon", Capital="Salem", Population=3701000},

        new State() { PostalCode="PA", Name="Pennsylvania", Capital="Harrisburg", Population=12441000},

        new State() { PostalCode="RI", Name="Rhode Island", Capital="Providence", Population=1068000},

        new State() { PostalCode="SC", Name="South Carolina", Capital="Columbia", Population=4321000},

        new State() { PostalCode="SD", Name="South Dakota", Capital="Pierre", Population=782000},

        new State() { PostalCode="TN", Name="Tennessee", Capital="Nashville", Population=6039000},

        new State() { PostalCode="TX", Name="Texas", Capital="Austin", Population=23508000},

        new State() { PostalCode="UT", Name="Utah", Capital="Salt Lake City", Population=2550000},

        new State() { PostalCode="VT", Name="Vermont", Capital="Montpelier", Population=624000},

        new State() { PostalCode="VA", Name="Virginia", Capital="Richmond", Population=7643000},

        new State() { PostalCode="WA", Name="Washington", Capital="Olympia", Population=6396000},

        new State() { PostalCode="WV", Name="West Virginia", Capital="Charleston", Population=1818000},

        new State() { PostalCode="WI", Name="Wisconsin", Capital="Madison", Population=5557000},

        new State() { PostalCode="WY", Name="Wyoming", Capital="Cheyenne", Population=515000},

    };

    }

}
