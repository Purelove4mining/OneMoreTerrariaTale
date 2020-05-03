using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.Items.Accesorios
{
	public class NeonHeart : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault ("Neon Heart");
			Tooltip.SetDefault("With this the party will never end" 
			+"\n Your body emits and unstopable energy");
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
			player.meleeSpeed -= 0.25f; 
            player.thrownDamage -= 0.25f;
			player.rangedDamage += 0.25f;
			player.rangedCrit += 15;
			player.minionDamage -= 0.25f;
			player.magicDamage -= 0.25f;
			player.ammoCost80 = true;
			player.archery = true;
			player.AddBuff (3,10000,true);
			player.AddBuff (11,10000,true);
			player.wingTimeMax += 180;
			player.statLifeMax2 += 25;
        	player.AddBuff (199,10000,true);
			}

		
	}
}
