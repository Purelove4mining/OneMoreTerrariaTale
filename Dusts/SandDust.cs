using Terraria;
using Terraria.ModLoader;

namespace Bleachmod.Dusts
{
	public class SandDust : ModDust
	{
		public override void OnSpawn(Dust dust) {
			dust.noGravity = true;
		}
	}
}