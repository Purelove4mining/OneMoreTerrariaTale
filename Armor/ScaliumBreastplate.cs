using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class ScaliumBreastplate : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			DisplayName.SetDefault("Scalium Breastplate");
			Tooltip.SetDefault("Attaches to your body");
		}

		public override void SetDefaults() {
			item.width = 30;
			item.height = 20;
			item.value = 1500;
			item.rare = 2;
			item.defense = 9;
		}

		public override void UpdateEquip(Player player) {
			player.allDamage += 0.05f;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Scaliumbar", 25);
			recipe.AddTile(null, "MetalWorker");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}