using Bleachmod.Dusts;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.NPCs
{
	// Party Zombie is a pretty basic clone of a vanilla NPC. To learn how to further adapt vanilla NPC behaviors, see https://github.com/tModLoader/tModLoader/wiki/Advanced-Vanilla-Code-Adaption#example-npc-npc-clone-with-modified-projectile-hoplite
	public class BoxCactus : ModNPC
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Box Cactus");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Zombie];
		}

		public override void SetDefaults() {
			npc.width = 22;
			npc.height = 40;
			npc.damage = 13;
			npc.defense = 8;
			npc.lifeMax = 68;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = 100f;
			npc.knockBackResist = 0.5f;
			npc.aiStyle = 3;
			aiType = NPCID.SwampThing;
			animationType = NPCID.Zombie;
			banner = Item.NPCtoBanner(NPCID.Zombie);
			bannerItem = Item.BannerToItem(banner);
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo) {
			return SpawnCondition.OverworldDayDesert.Chance * 1.9f;
		}

		public override void HitEffect(int hitDirection, double damage) {
			for (int i = 0; i < 10; i++) {
				int dustType = Main.rand.Next(139, 143);
				int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, mod.DustType("Spines"));
				Dust dust = Main.dust[dustIndex];
				dust.velocity.X = dust.velocity.X + Main.rand.Next(-50, 51) * 0.01f;
				dust.velocity.Y = dust.velocity.Y + Main.rand.Next(-50, 51) * 0.01f;
				dust.scale *= 1f + Main.rand.Next(-30, 31) * 0.01f;
			}
		}
		public override void OnHitPlayer(Player player, int damage, bool crit) {
			if (Main.rand.NextBool(1)) {
				player.AddBuff(ModContent.BuffType<Buffs.Thorned>(), 300, true);
			}
		}
	}
}
	 