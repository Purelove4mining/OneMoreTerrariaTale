using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.Items.Placeable
{
	public class Scaliumbar : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Scalium Bar");
			Tooltip.SetDefault("'Maybe not too powerfull but has amazing propietes!'");
			ItemID.Sets.SortingPriorityMaterials[item.type] = 50;
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = 600;
			item.rare = 3;
			item.useStyle = 1;
			item.useTurn = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.autoReuse = true;
			item.consumable = true;
			item.createTile = mod.TileType("Scaliumbar");
			item.placeStyle = 0;
		}
		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Scaliumore", 3 );
			recipe.AddTile(TileID.Hellforge);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}	