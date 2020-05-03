using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.Items.Placeable
{
	public class Lunamnita : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Lunamnita Bar");
			Tooltip.SetDefault("Shines gently");
			ItemID.Sets.SortingPriorityMaterials[item.type] = 59;
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = 8000;
			item.rare = 2;
			item.useStyle = 1;
			item.useTurn = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.autoReuse = true;
			item.consumable = true;
			item.createTile = mod.TileType("LunamnitaBar");
			item.placeStyle = 0;
		}
		
}
}		