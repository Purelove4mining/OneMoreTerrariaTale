using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.Items.Accesorios
{
	public class CrimsonHeart : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault ("Crimson Heart");
			Tooltip.SetDefault("Let Crimson finally consumes you"
			+"\n Deeply inside you know you'll never be satisfied");
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 20;
			item.accessory = true;
			item.value = 10000;
			item.rare = 6;
		}

		public override void UpdateAccessory(Player player, bool HideVisual) {

                player.meleeDamage += 0.20f;
                player.thrownDamage += 0.20f;
                player.rangedDamage += 0.20f;
			    player.minionDamage += 0.20f;
			    player.magicDamage += 0.20f;
                player.manaCost += 1.25f; 
				player.meleeSpeed += 0.25f;
				player.crimsonRegen = true;		
                player.enemySpawns = true;				
				player.AddBuff(76,100000,true);
                player.statDefense -= 20;
                player.buffImmune[BuffID.Ichor] = true;		
                player.statLifeMax2 -=	50;
                				
			} 
			
		
	}
}
