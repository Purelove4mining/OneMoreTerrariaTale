using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.Items.Accesorios
{
	public class MagmaHeart : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault ("Magma Heart");
			Tooltip.SetDefault("Magma runs through your veins, you're one with the fire"
			+"\n You'll never be calm");
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 20;
			item.accessory = true;
			item.value = 10000;
			item.rare = 6;
		}

		public override void UpdateAccessory(Player player, bool HideVisual) {
			player.meleeDamage += 0.2f;
			player.meleeSpeed += 0.15f; 
            player.thrownDamage -= 0.25f;
			player.rangedDamage -= 0.25f;
			player.minionDamage -= 0.25f;
			player.magicDamage += 0.1f;
			player.onHitRegen = true;
			player.lavaImmune = true; 
			player.breathCD = 1000; 
			player.buffImmune[BuffID.OnFire] = true;
			player.magmaStone = true;
			player.ignoreWater = true;
			player.statLifeMax2 += 50; 
			player.statDefense -= 10; 
					
			}

		
	}
}
