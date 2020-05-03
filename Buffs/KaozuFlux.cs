using Terraria;
using Terraria.ModLoader;
using Bleachmod.Items; 
using Bleachmod.NPCs;
using Bleachmod.Buffs;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace Bleachmod.Buffs
{
	public class KaozuFlux : ModBuff
	{	

   	public override void SetDefaults() {
			DisplayName.SetDefault("Kaozu Flux");
			Description.SetDefault("The DarkLord feeds of your energy"+
	        "\n You can't regen life +20% MagicDamage +10% manaCost");
			Main.debuff[Type] = false; //Add this so the nurse doesn't remove the buff when healing
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex) {
			
			player.bleed = true;
			player.magicDamage += 0.2f;
            player.manaCost = 1.1f;
			
			
		}
	}
}
	