using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.Items.Placeable
{
	public class Scaliumore : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("It's almost like a scale..");
			ItemID.Sets.SortingPriorityMaterials[item.type] = 58;
		}

		public override void SetDefaults()
		{
			item.useStyle = 1;
			item.useTurn = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.autoReuse = true;
			item.maxStack = 999;
			item.consumable = true;
			item.createTile = mod.TileType("Scaliumore");
			item.width = 12;
			item.height = 12;
			item.value = 100;
			item.rare = 3;
		}
	}
}
