using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.Items.Accesorios
{
	public class DeepHeart : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault ("Deep Heart");
			Tooltip.SetDefault("Voices of an eternal dream makes blue your thoughs" 
			+"\n The pression of the seas is nothing");
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 20;
			item.accessory = true;
			item.value = 10000;
			item.rare = 6;
		}

		public override void UpdateAccessory(Player player, bool HideVisual) {
			player.meleeDamage -= 0.25f;
			player.thrownDamage -= 0.25f;
			player.rangedDamage -= 0.10f;
			player.minionDamage += 0.15f;
			player.magicDamage += 0.25f;
			player.manaCost = 0.8f;
			player.statManaMax2 += 200;
			player.manaMagnet = true;
			player.maxMinions += 1;
			player.waterWalk2 = true;
			player.ignoreWater = true;
			player.gills = true;
        	player.statLifeMax2 += 50;
         	player.slow = true;
           	}

		
	}
}
