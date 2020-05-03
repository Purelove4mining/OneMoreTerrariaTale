using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.Items.Drops
{
	public class EarthChunk : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Earth Chunk");
			Tooltip.SetDefault("Smells like Mmmm a ¿Cave?");
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = 4000;
			item.rare = 4;
		}
    }
}		