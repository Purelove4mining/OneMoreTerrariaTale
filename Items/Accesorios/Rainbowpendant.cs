using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.Items.Accesorios
{
	public class Rainbowpendant : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault ("Raimbow pendant");
			Tooltip.SetDefault("Its beauty is only comparable to its power");
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 20;
			item.accessory = true;
			item.value = 5000;
			item.rare = 5;
		}

		public override void UpdateAccessory(Player player, bool Neck) {
		
		  
		  player.meleeDamage += 0.1f;
		  player.thrownDamage += 0.1f;
		  player.rangedDamage += 0.1f;
		  player.minionDamage += 0.1f;
		  player.magicDamage += 0.1f;
		  player.statManaMax2 += 50; 
		  player.statLifeMax2 += 25;
		  player.body = 1;
		  player.statDefense = 5;
          player.manaCost += 0.9f;	
          player.lifeRegen += 1;  		  
		  
         }		
	}
}	