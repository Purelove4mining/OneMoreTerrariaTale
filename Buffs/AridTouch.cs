using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Bleachmod.NPCs;
using Bleachmod.Dusts;

namespace Bleachmod.Buffs
{
	public class AridTouch : ModBuff
	{	

   	public override void SetDefaults() {
			DisplayName.SetDefault("Arid Touch");
			Description.SetDefault("The sand makes a bad joke");
			Main.debuff[Type] = false; //this is turn false to can look at it in the buffs, using "Hero's mod", turn true to make it actually a debuff  
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
			longerExpertDebuff = true;
		}

		public override void Update(NPC npc, ref int buffIndex) { //this is to can inflict the debuff to a NPC
			
		 npc.GetGlobalNPC<NPCsGlobal>().AridTouch = true; //see "NPCsGlobal.cs" to give a look at the code 
		 	
			
		}
		
		public override void Update(Player player, ref int buffIndex) {  //this is to can inflict the debuff to the player 
			
		 player.GetModPlayer<ExamplePlayer>().AridTouch = true; //see "ExamplePlayer.cs" to give a look at the code
		 player.statDefense -= 5;                               
		 player.moveSpeed -= 0.20f; 
	}
}
}	