using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class SteelBreastplate : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			DisplayName.SetDefault("Steel Breastplate");
			Tooltip.SetDefault("Hard as heavy");
		}

		public override void SetDefaults() {
			item.width = 30;
			item.height = 20;
			item.value = 1500;
			item.rare = 2;
			item.defense = 5;
		}

		public override void UpdateEquip(Player player) {
			
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Steelbar", 30);
			recipe.AddTile(null, "MetalWorker");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}