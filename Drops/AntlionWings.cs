using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.Items.Drops
{
	public class AntlionWings : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Antlion Swarmer Wings");
			Tooltip.SetDefault("They're not strong enough to make you fly");
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = 400;
			item.rare = 2;
		}
    }
}		