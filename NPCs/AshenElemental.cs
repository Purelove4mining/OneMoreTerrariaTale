using Bleachmod.Dusts;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.NPCs
{
	// Party Zombie is a pretty basic clone of a vanilla NPC. To learn how to further adapt vanilla NPC behaviors, see https://github.com/tModLoader/tModLoader/wiki/Advanced-Vanilla-Code-Adaption#example-npc-npc-clone-with-modified-projectile-hoplite
	public class AshenElemental : ModNPC
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Ashen Elemental");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Wraith];
		}

		public override void SetDefaults() {
			npc.width = 18;
			npc.height = 40;
			npc.damage = 25;
			npc.defense = 15;
			npc.lifeMax = 150;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = 300f;
			npc.knockBackResist = 0.8f;
			npc.aiStyle = 22;
			aiType = NPCID.Wraith;
			animationType = NPCID.Wraith;
			banner = Item.NPCtoBanner(NPCID.Wraith);
			bannerItem = Item.BannerToItem(banner);
		}
          
		 
		public override float SpawnChance(NPCSpawnInfo spawnInfo) {
		
			return SpawnCondition.Underworld.Chance * 0.25f;
		
		}

		public override void HitEffect(int hitDirection, double damage) {
			for (int i = 0; i < 10; i++) {
				int dustType = Main.rand.Next(139, 143);
				int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, mod.DustType("Smoke"));
				Dust dust = Main.dust[dustIndex];
				dust.velocity.X = dust.velocity.X + Main.rand.Next(-50, 51) * 0.01f;
				dust.velocity.Y = dust.velocity.Y + Main.rand.Next(-50, 51) * 0.01f;
				dust.scale *= 1f + Main.rand.Next(-30, 31) * 0.01f;
			}
		}
		
		public override void OnHitPlayer(Player player, int damage, bool crit) {
			if (Main.rand.NextBool(1)) {
				player.AddBuff(BuffID.OnFire, 300, true);
			}
		}
	}
}
