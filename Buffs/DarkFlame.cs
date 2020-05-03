using Terraria;
using Terraria.ModLoader;

namespace Bleachmod.Buffs
{
	public class DarkFlame : ModBuff
	{	

   	public override void SetDefaults() {
			DisplayName.SetDefault("Kaozu Shield");
			Description.SetDefault("A fragment of your soul covers you");
			Main.debuff[Type] = false; //Add this so the nurse doesn't remove the buff when healing
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex) {
			
			player.statDefense += 5;
			
			
			
			
		}
	}
}
	