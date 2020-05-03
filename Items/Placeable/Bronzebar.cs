using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.Items.Placeable
{
	public class Bronzebar : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Bronze Bar");
			Tooltip.SetDefault("Simple but usefull as you are");
			ItemID.Sets.SortingPriorityMaterials[item.type] = 59;
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = 80;
			item.rare = 2;
			item.useStyle = 1;
			item.useTurn = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.autoReuse = true;
			item.consumable = true;
			item.createTile = mod.TileType("Bronzebar");
			item.placeStyle = 0;
		}
		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TinBar, 2);
			recipe.AddIngredient(ItemID.CopperBar, 2);
			recipe.AddTile(null, "MetalWorker");
			recipe.SetResult(this, 1);
			recipe.AddRecipe(); 
		}
}
}		