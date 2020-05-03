using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class CursedBreastplate : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			DisplayName.SetDefault("Cursed Breastplate");
			Tooltip.SetDefault("Your body is absolutely corrupted");
		}

		public override void SetDefaults() {
			item.width = 35;
			item.height = 30;
			item.value = 1500;
			item.rare = 2;
			item.defense = 25;
		}

		public override void UpdateEquip(Player player) {
			
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Cursedbar", 25);
			recipe.AddTile(null, "MetalWorker");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}