using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tropics.Items
{
    public class Apple : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Apple");
			Tooltip.SetDefault("Grants you swiftness for 1 minute\nHeals 60 HP");
		}

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 26;
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
		   player.HealEffect(60);
		   player.AddBuff(BuffID.Swiftness, 3600);
		   return true;
        }
    }
}
