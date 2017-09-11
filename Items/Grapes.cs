using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;



namespace Tropics.Items
{
    public class Grapes : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Grapes");
			Tooltip.SetDefault("Increases your max amount of minions by 1 for 3 minutes\nHeals 20 HP");
		}

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 30;
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
		   player.HealEffect(20);
		   player.AddBuff(BuffID.Summoning, 3600 * 3);
		   return true;
        }
    }
}
