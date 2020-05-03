using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class ChaosBaneBreastplate : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			DisplayName.SetDefault("ChaosBane Breastplate");
			Tooltip.SetDefault("Let inner demon within you out");
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
			recipe.AddIngredient(null, "ChaosBanebar", 25);
			recipe.AddTile(null, "MetalWorker");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}