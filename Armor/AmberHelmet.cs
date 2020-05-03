using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace Bleachmod.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class AmberHelmet : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault ("Amber Mask");
			Tooltip.SetDefault("The orange gem bless you");
		}

		public override void SetDefaults() {
			item.width = 30;
			item.height = 28;
			item.value = 1500;
			item.rare = 2;
			item.defense = 3;
		}

				
		public override void UpdateEquip(Player player) {
			
		}


		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Steelbar", 15);
			recipe.AddTile(null, "MetalWorker");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}