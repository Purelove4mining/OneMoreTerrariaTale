using Bleachmod.Items; 
using Bleachmod.NPCs;
using Bleachmod.Buffs;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;


namespace Bleachmod {
	
	public class ExamplePlayer : ModPlayer{

        public bool KaozuWisp;
		public bool DarkFlames = false;
		public bool AridTouch = false;
	    public bool KaozuFlux = false;
		public bool CoolBurn = false;
		public bool Thorned = false;
			
		public override void ResetEffects() {
			DarkFlames = false;
			KaozuWisp = false;
			AridTouch = false;
			KaozuFlux = false;
			CoolBurn = false;
		    Thorned = false;
		}

      		
		
		public override void UpdateLifeRegen() {

            
			if (DarkFlames) {
				// These lines zero out any positive lifeRegen. This is expected for all bad life regeneration effects.
				if (player.lifeRegen > 0) {
					player.lifeRegen = 0;
				}
				player.lifeRegenTime = 0;
				// lifeRegen is measured in 1/2 life per second. Therefore, this effect causes 3 life lost per second.
				player.lifeRegen -= 6;
				
}
           if (CoolBurn) {
				// These lines zero out any positive lifeRegen. This is expected for all bad life regeneration effects.
				if (player.lifeRegen > 0) {
					player.lifeRegen = 0;
				}
				player.lifeRegenTime = 0;
				// lifeRegen is measured in 1/2 life per second. Therefore, this effect causes 5 life lost per second.
				player.lifeRegen -= 10;
				
}
		   if (KaozuFlux) {
				// These lines zero out any positive lifeRegen. This is expected for all bad life regeneration effects.
				if (player.lifeRegen > 0) {
					player.lifeRegen = 0;
				}
				player.lifeRegenTime = 600;
				// lifeRegen is measured in 1/2 life per second. Therefore, this effect causes 2 life lost every minute.
				player.lifeRegen -= 4;
}

} 	
         public override void DrawEffects(PlayerDrawInfo drawInfo, ref float r, ref float g, ref float b, ref float a, ref bool fullBright) { //this is to make dust appear in the debuff or buff
			if (DarkFlames) {
				if (Main.rand.NextBool(4) && drawInfo.shadow == 0f) {
					int dust = Dust.NewDust(drawInfo.position - new Vector2(2f, 2f), player.width + 4, player.height + 4, mod.DustType("Darkness"), player.velocity.X * 0.4f, player.velocity.Y * 0.4f, 100, default(Color), 3f);
					Main.dust[dust].noGravity = true;
					Main.dust[dust].velocity *= 1.8f;
					Main.dust[dust].velocity.Y -= 0.9f;
					Main.playerDrawDust.Add(dust);
				}
				r *= 0.7f;
				g *= 0.7f;
				b *= 0.7f;
				fullBright = true;
			}
			if (CoolBurn) {
				if (Main.rand.NextBool(4) && drawInfo.shadow == 0f) {
					int dust = Dust.NewDust(drawInfo.position - new Vector2(2f, 2f), player.width + 4, player.height + 4, mod.DustType("Sunflames"), player.velocity.X * 0.4f, player.velocity.Y * 0.4f, 100, default(Color), 3f);
					Main.dust[dust].noGravity = true;
					Main.dust[dust].velocity *= 2.0f;
					Main.dust[dust].velocity.Y -= 1.0f;
					Main.playerDrawDust.Add(dust);
				}
				r *= 0.7f;
				g *= 0.7f;
				b *= 0.7f;
				fullBright = true;
			}
			if (AridTouch) {
				if (Main.rand.NextBool(4) && drawInfo.shadow == 0f) {
					int dust = Dust.NewDust(drawInfo.position - new Vector2(2f, 2f), player.width + 4, player.height + 4, mod.DustType("SandDust"), player.velocity.X * 0.4f, player.velocity.Y * 0.4f, 100, default(Color), 3f);
					Main.dust[dust].noGravity = true;
					Main.dust[dust].velocity *= 2.0f;
					Main.dust[dust].velocity.Y -= 2.2f;
					Main.playerDrawDust.Add(dust);
				}
				r *= 0.7f;
				g *= 0.7f;
				b *= 0.7f;
				fullBright = true;
			}
}
}
}