using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.Items.Placeable
{
	public class Steelbar : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Steel Bar");
			Tooltip.SetDefault("It's astonishing what a little of carbono can do");
			ItemID.Sets.SortingPriorityMaterials[item.type] = 59;
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = 200;
			item.rare = 3;
			item.useStyle = 1;
			item.useTurn = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.autoReuse = true;
			item.consumable = true;
			item.createTile = mod.TileType("Steelbar");
			item.placeStyle = 0;
		}
		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 20);
			recipe.AddIngredient(null, "Coal", 100);
	    	recipe.AddTile(null, "MetalWorker");
			recipe.SetResult(this, 10);
			recipe.AddRecipe(); 
		}
}
}		