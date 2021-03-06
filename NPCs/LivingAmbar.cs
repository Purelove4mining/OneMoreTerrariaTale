using Bleachmod.Dusts;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.NPCs
{
	// Party Zombie is a pretty basic clone of a vanilla NPC. To learn how to further adapt vanilla NPC behaviors, see https://github.com/tModLoader/tModLoader/wiki/Advanced-Vanilla-Code-Adaption#example-npc-npc-clone-with-modified-projectile-hoplite
	public class LivingAmbar : ModNPC
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Living Ambar");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.GraniteFlyer];
		}

		public override void SetDefaults() {
			npc.width = 18;
			npc.height = 40;
			npc.damage = 20;
			npc.defense = 10;
			npc.lifeMax = 200;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = 300f;
			npc.knockBackResist = 0.8f;
			npc.aiStyle = 91;
			aiType = NPCID.GraniteFlyer;
			animationType = NPCID.GraniteFlyer;
			banner = Item.NPCtoBanner(NPCID.GraniteFlyer);
			bannerItem = Item.BannerToItem(banner);
		}
          
		 
		public override float SpawnChance(NPCSpawnInfo spawnInfo) {
		
			return SpawnCondition.DesertCave.Chance * 0.01f;
		
		}

		public override void HitEffect(int hitDirection, double damage) {
			for (int i = 0; i < 10; i++) {
				int dustType = Main.rand.Next(139, 143);
				int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, mod.DustType("AmberDust"));
				Dust dust = Main.dust[dustIndex];
				dust.velocity.X = dust.velocity.X + Main.rand.Next(-50, 51) * 0.01f;
				dust.velocity.Y = dust.velocity.Y + Main.rand.Next(-50, 51) * 0.01f;
				dust.scale *= 1f + Main.rand.Next(-30, 31) * 0.01f;
			}
		}
		
		public override void OnHitPlayer(Player player, int damage, bool crit) {
			if (Main.rand.NextBool(1)) {
				player.AddBuff(ModContent.BuffType<Buffs.AridTouch>(), 420, true);
			}
		}
	}
}
