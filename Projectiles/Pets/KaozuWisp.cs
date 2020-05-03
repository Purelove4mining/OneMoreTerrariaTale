using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Bleachmod;


namespace Bleachmod.Projectiles.Pets
{
	public class KaozuWisp : ModProjectile
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Kaozu Wisp"); 
			Main.projFrames[projectile.type] = 4;
			Main.projPet[projectile.type] = true;
		}

		public override void SetDefaults() {
			DisplayName.SetDefault("Kaozu Wisp"); 
			projectile.CloneDefaults(ProjectileID.ZephyrFish);
			aiType = ProjectileID.ZephyrFish;
		}

		public override bool PreAI() {
			Player player = Main.player[projectile.owner];
			player.zephyrfish = false; // Relic from aiType
			return true;
		}

		public override void AI() {
			Player player = Main.player[projectile.owner];
			ExamplePlayer modPlayer =  player.GetModPlayer<ExamplePlayer>();
			if (player.dead) {
				modPlayer.KaozuWisp = false;
			}
			if (modPlayer.KaozuWisp); {
				projectile.timeLeft = 2;
			}
		}
	}
}