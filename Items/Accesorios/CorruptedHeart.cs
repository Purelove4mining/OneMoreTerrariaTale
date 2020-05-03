using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.Items.Accesorios
{
	public class CorruptedHeart : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault ("Corrupted Heart");
			Tooltip.SetDefault("You're one with the curse putrid one"
			+"\n A Dark desire just brings Dark things..");
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 20;
			item.accessory = true;
			item.value = 10000;
			item.rare = 6;
		}

		public override void UpdateAccessory(Player player, bool HideVisual) {

                player.meleeDamage += 0.30f;
                player.thrownDamage -= 0.25f;
                player.minionDamage += 0.25f;
			    player.magicDamage += 0.25f;
                player.manaCost += 1.15f; 
				player.meleeSpeed -= 0.50f;
				player.maxMinions = 3;
				player.enemySpawns = true;				
				player.AddBuff(73,100000,true);
                player.AddBuff(20,100000,true);
                player.buffImmune[BuffID.CursedInferno] = true;		
                player.statLifeMax2 -=	50;
                				
			} 
			
		
	}
}
