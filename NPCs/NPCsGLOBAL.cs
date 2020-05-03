using Microsoft.Xna.Framework;
using Terraria; 
using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.NPCs 

{
	 public class NPCsGlobal : GlobalNPC 
          {
			  public override bool InstancePerEntity => true;
			  
			  public bool DarkFlames;
			  public bool AridTouch;
			  
			  
			public override void ResetEffects(NPC npc) {
			DarkFlames = false;
			AridTouch = false;
		
		
		    }
			
            public override void UpdateLifeRegen(NPC npc, ref int damage) {

            
			if (DarkFlames) {
				if (npc.lifeRegen > 0) {
					npc.lifeRegen = 0;
				}
				npc.lifeRegen -= 60;
				if (damage < 3) {
					damage = 3;
				}
			}
			
			
			
			
			
}
			public override void DrawEffects(NPC npc, ref Color drawColor) {
			if (DarkFlames) {
				if (Main.rand.Next(4) < 3) {
					int dust = Dust.NewDust(npc.position - new Vector2(2f, 2f), npc.width + 4, npc.height + 4, mod.DustType("Darkness"), npc.velocity.X * 0.4f, npc.velocity.Y * 0.4f, 100, default(Color), 3.5f);
					Main.dust[dust].noGravity = true;
					Main.dust[dust].velocity *= 2.2f;
					Main.dust[dust].velocity.Y -= 0.9f;
					if (Main.rand.NextBool(4)) {
						Main.dust[dust].noGravity = false;
						Main.dust[dust].scale *= 0.2f;
					}
				}
				Lighting.AddLight(npc.position, 0.1f, 0.2f, 0.7f);
			}
		
		
		
			if (AridTouch) {
				if (Main.rand.Next(4) < 3) {
					int dust = Dust.NewDust(npc.position - new Vector2(2f, 2f), npc.width + 4, npc.height + 4, mod.DustType("SandDust"), npc.velocity.X * 0.4f, npc.velocity.Y * 0.4f, 100, default(Color), 3.5f);
					Main.dust[dust].noGravity = true;
					Main.dust[dust].velocity *= 0.2f;
					Main.dust[dust].velocity.Y += 2.2f;
					if (Main.rand.NextBool(4)) {
						Main.dust[dust].noGravity = false;
						Main.dust[dust].scale *= 0.1f;
					}
				}
				
			}
			}
		
} 


	





}
