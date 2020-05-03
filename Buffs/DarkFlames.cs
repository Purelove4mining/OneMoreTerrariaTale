using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Bleachmod.NPCs;
using Bleachmod.Dusts;

namespace Bleachmod.Buffs
{
	public class DarkFlames : ModBuff
	{	

   	public override void SetDefaults() {
			DisplayName.SetDefault("Kaozu Flames");
			Description.SetDefault("You feel an undescriptable pain");
			Main.debuff[Type] = false;
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
			longerExpertDebuff = true;
		}

		public override void Update(NPC npc, ref int buffIndex) {
			
		 npc.GetGlobalNPC<NPCsGlobal>().DarkFlames = true;
		 	
			
		}
		
		public override void Update(Player player, ref int buffIndex) {
			
		 player.GetModPlayer<ExamplePlayer>().DarkFlames = true;
		 	
	}
}
}	