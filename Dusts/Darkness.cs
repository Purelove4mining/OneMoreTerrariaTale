using Terraria;
using Terraria.ModLoader;

namespace Bleachmod.Dusts
{
	public class Darkness : ModDust
	{
		public override void OnSpawn(Dust dust) {
			dust.noGravity = true;
		}
	}
}