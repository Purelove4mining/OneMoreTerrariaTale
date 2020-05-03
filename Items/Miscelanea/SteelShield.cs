using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace Bleachmod.Items
{
	[AutoloadEquip(EquipType.Shield)]
	public class SteelShield : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault ("Steel Shield");
			Tooltip.SetDefault("Showing love for kitties and also provides defense!");
				
		}

		public override void SetDefaults() {
			item.width = 24;
			item.height = 28;
			item.value = 10000;
			item.rare = 2;
			item.accessory = true;
		
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
			
			player.statDefense += 4;
			
	
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Steelbar", 12);
			recipe.AddTile(null, "MetalWorker");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
