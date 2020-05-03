using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Bleachmod.Buffs;

namespace Bleachmod.NPCs
{
	// Party Zombie is a pretty basic clone of a vanilla NPC. To learn how to further adapt vanilla NPC behaviors, see https://github.com/tModLoader/tModLoader/wiki/Advanced-Vanilla-Code-Adaption#example-npc-npc-clone-with-modified-projectile-hoplite
	public class DarkEye : ModNPC
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("unlucky watcher");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.DemonEye];
		}

		public override void SetDefaults() {
			npc.width = 18;
			npc.height = 40;
			npc.damage = 14;
			npc.defense = 8;
			npc.lifeMax = 68;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = 100f;
			npc.knockBackResist = 0.4f;
			npc.aiStyle = 2;
			aiType = NPCID.DemonEye;
			animationType = NPCID.DemonEye;
			banner = Item.NPCtoBanner(NPCID.DemonEye);
			bannerItem = Item.BannerToItem(banner);
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo) {
			return SpawnCondition.OverworldNightMonster.Chance * 0.05f;
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
			if (Main.rand.NextBool(4)) {
				player.AddBuff(ModContent.BuffType<Buffs.DarkFlames>(), 1200, true);
			}
		}
	}
}