using System;
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
			Tooltip.SetDefault("");
		}
        public override void SetDefaults()
        {
            item.width = 36;
            item.height = 36;
            item.maxStack = 999;
            item.rare = 5;
            item.useAnimation = 45;
            item.useTime = 45;
            item.useStyle = 4;
            item.UseSound = SoundID.Item44;
            item.consumable = true;
        }

        public override bool UseItem(Player player)
        {
           player.statLife += 30;
		   player.HealEffect(30);
		   player.AddBuff(BuffID.PotionSickness, 3600);
		   return true;
        }
    }
}
