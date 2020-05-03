using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class Antlionleggings : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Antlion leggings");
			Tooltip.SetDefault("'Aren't too confortable'"
				+ "\n10% increased movement speed");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 1000;
			item.rare = 2;
			item.defense = 3;
		}

		public override void UpdateEquip(Player player) {
			player.moveSpeed += 0.10f;
			player.maxRunSpeed += 0.10f;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "AntlionBody", 3);
			recipe.AddIngredient(null, "AntlionBodyS", 4);
			recipe.AddIngredient(ItemID.AntlionMandible, 4);
			recipe.AddTile(null, "DessertIdol");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}