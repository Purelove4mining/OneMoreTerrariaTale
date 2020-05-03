using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Bleachmod.NPCs;
using Bleachmod.Dusts;

namespace Bleachmod.Buffs
{
	public class CoolBurn : ModBuff
	{	

   	public override void SetDefaults() {
			DisplayName.SetDefault("Cool Burn");
			Description.SetDefault("Loosing life.. With style!");
			Main.debuff[Type] = false;
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
			longerExpertDebuff = true;
		}

		
		public override void Update(Player player, ref int buffIndex) {
			
		 player.GetModPlayer<ExamplePlayer>().CoolBurn = true;
		 	
	}
}
}	