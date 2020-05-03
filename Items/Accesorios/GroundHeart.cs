using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.Items.Accesorios
{
	public class GroundHeart : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault ("Ground Heart");
			Tooltip.SetDefault("While on the Underground there's nothing that can hide of you."
			+ "\nAn incredible fear resides on you.");
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 20;
			item.accessory = true;
			item.value = 10000;
			item.rare = 6;
		}

		public override void UpdateAccessory(Player player, bool HideVisual) {
			player.meleeDamage += 0.1f;
			player.thrownDamage += 0.25f;
			player.rangedDamage -= 0.25f;
			player.minionDamage -= 0.5f;
			player.magicDamage -= 0.5f;
			player.statDefense += 10; 
			player.AddBuff (104,100000, true);
			player.moveSpeed += 0.5f; 
	        player.jumpSpeedBoost += 1f;
			player.jumpBoost = true;
			player.findTreasure = true;
			player.detectCreature = true;
            player.statLifeMax2 += 50;	
           	player.blackout = true;
			player.blind = true;
			player.silence = true;
			}
         

	}
}
