using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.Items.Accesorios
{
	public class Divineheart : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault ("Divine Heart");
			Tooltip.SetDefault("The great bless has chosen a new warrior" 
			+"\n blind faith is the worse curse");
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 20;
			item.accessory = true;
			item.value = 10000;
			item.rare = 6;
		}

		public override void UpdateAccessory(Player player, bool HideVisual) {
            player.meleeDamage += 0.15f;
			player.thrownDamage += 0.15f;
			player.rangedDamage += 0.15f;
			player.minionDamage += 0.15f;
			player.magicDamage += 0.15f;
			player.manaCost = 0.85f;
			player.statManaMax2 += 100;
			player.lifeForce = true;
			player.lifeMagnet = true;
			player.lifeRegen += 3;
            player.maxMinions += 2;
         	
           	}

		
	}
}
