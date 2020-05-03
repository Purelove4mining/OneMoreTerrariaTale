using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Bleachmod.Buffs;

namespace Bleachmod.NPCs
{
	// Party Zombie is a pretty basic clone of a vanilla NPC. To learn how to further adapt vanilla NPC behaviors, see https://github.com/tModLoader/tModLoader/wiki/Advanced-Vanilla-Code-Adaption#example-npc-npc-clone-with-modified-projectile-hoplite
	public class EvilBeing : ModNPC
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Evil Being");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.ShadowFlameApparition];
		}

		public override void SetDefaults() {
			npc.width = 18;
			npc.height = 52;
			npc.damage = 22;
			npc.defense = 8;
			npc.lifeMax = 110;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = 150f;
			npc.knockBackResist = 0.5f;
			npc.aiStyle = 86;
			aiType = NPCID.ShadowFlameApparition;
			animationType = NPCID.ShadowFlameApparition;
			banner = Item.NPCtoBanner(NPCID.ShadowFlameApparition);
			bannerItem = Item.BannerToItem(banner);
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo) {
			if(!NPC.downedBoss1)
			 {

			
			return SpawnCondition.Crimson.Chance * 0.2f;
			return 0f;
		}
         return 0f;
		
}
		public override void HitEffect(int hitDirection, double damage) {
			for (int i = 0; i < 10; i++) {
				int dustType = Main.rand.Next(139, 143);
				int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, mod.DustType("Darkness"));
				Dust dust = Main.dust[dustIndex];
				dust.velocity.X = dust.velocity.X + Main.rand.Next(-50, 51) * 0.01f;
				dust.velocity.Y = dust.velocity.Y + Main.rand.Next(-50, 51) * 0.01f;
				dust.scale *= 1f + Main.rand.Next(-30, 31) * 0.01f;
			}
		}
		public override void OnHitPlayer(Player player, int damage, bool crit) {
			if (Main.rand.NextBool(1)) {
				player.AddBuff(ModContent.BuffType<Buffs.DarkFlames>(), 1200, true);
			}
		}
	}
}
