﻿using System.Collections.Generic;
using GildedRose;
namespace GildedRose
{
    class Inventory
    {
        private readonly IEnumerable<Item> items;

        public Inventory(IEnumerable<Item> items)
        {
            this.items = items;
        }

        /// <summary>
        /// Items:
        /// "+5 Dexterity Vest"
        /// "Aged Brie"
        /// "Elixir of the Mongoose"
        /// "Sulfuras, Hand of Ragnaros"
        /// "Backstage passes to a TAFKAL80ETC concert"
        /// "Conjured Mana Cake"
        /// </summary>
        public void UpdateQuality()
        {
            foreach(var item in items)
            if (item.Name != ("Sulfuras, Hand of Ragnaros"))
            {
                    if (item.Name == "Sulfuras, Hand of Ragnaros")
                    {
                        item.Quality = 80;
                    }
                    item.SellIn--;
                    item.Quality--;
                if(item.Quality <= 50)
                    {   

                    if(item.Name == "Aged Brie")
                    {
                        item.Quality += 2;
                        if (item.SellIn <= 0)
                        {
                            item.Quality++;
                        }
                    }
                    
                    else if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
                    {
                        item.Quality+=2;
                        if(item.SellIn <= 10)
                        {
                            item.Quality++;
                            if(item.SellIn <= 5) 
                            {
                                item.Quality++;
                                if (item.SellIn <= 0)
                                {
                                    item.Quality = 0;
                                }
                            }
                        }
                    }
                    else if (item.Name.Contains ("Conjured"))
                    {
                        item.Quality--;
                            if(item.SellIn <= 0)
                            {
                                item.Quality-=2;
                            }
                    }
                    }
                    if(item.Quality >= 50)
                    {
                        item.Quality = 50;
                    }
                    if(item.Name != "Aged Brie" && item.Name != "Backstage passes to a TAFKAL80ETC concert" && !item.Name.Contains ("Conjured") && item.Name != "Sulfuras, Hand of Ragnaros")
                    {
                        if(item.SellIn <= 0)
                        {
                            item.Quality--;
                            
                        }
                    }
                    if(item.Quality <= 0)
                    {
                        item.Quality = 0;
                    }

                }



















            // TODO ...
            // Hint: Iterate through this.items and check Name property to access specific item
        }
    }
}
