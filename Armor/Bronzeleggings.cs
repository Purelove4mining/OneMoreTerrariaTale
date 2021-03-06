using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class Bronzeleggings : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Bronze leggings");
			Tooltip.SetDefault("light but hard");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 4;
		}

		public override void UpdateEquip(Player player) {
			
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Bronzebar", 15);
			recipe.AddTile(null, "MetalWorker");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}