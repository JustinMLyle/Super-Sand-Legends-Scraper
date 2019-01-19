using System;
using System.Collections.Generic;
using OverwatchAPI;
using OverwatchAPI.Data;
using OverwatchAPI.Extensions;

namespace OWSandLegends.Models

{
    public class PlayerRecord
    {

            public int ID { get; set; }
            public Player PlayerAccount { get; set; }
            public string StatName;
            public string StatValue;

        PlayerRecord() { 
        
        var allHeroesHealingDone = PlayerAccount.CasualStats.GetStatExact("All Heroes", "Assists", "Healing Done");
        IEnumerable<Stat> allHealingDoneStats = PlayerAccount.CasualStats.FilterByName("Healing Done");
        foreach(var stat in PlayerAccount.CasualStats)
            {
                string statHeroName = stat.HeroName;
                StatName = stat.Name;
                string statCategoryName = stat.CategoryName;
                double statValue = stat.Value;

            }
        }

}
}


