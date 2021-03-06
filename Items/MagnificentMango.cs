﻿using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;



namespace Tropics.Items
{
    public class MagnificentMango : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Mango");
			Tooltip.SetDefault("Grants you Well Fed for 30 seconds\nHeals 30 HP");
		}

        public override void SetDefaults()
        {
            item.width = 36;
            item.height = 36;
            item.maxStack = 999;
            item.rare = 5;
            item.useAnimation = 20;
            item.useTime = 20;
            item.useStyle = 1;
            item.UseSound = SoundID.Item2;
            item.consumable = true;
        }

        public override bool UseItem(Player player)
        {
		   player.HealEffect(30);
		   player.AddBuff(BuffID.WellFed, 3600 / 2);
		   return true;
        }
    }
}
