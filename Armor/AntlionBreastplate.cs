using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class AntlionBreastplate : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			DisplayName.SetDefault("Antlion Breastplate");
			Tooltip.SetDefault("Its hardier than it looks!"
				+ "\n+15% MinSpeed"
				+ "\nYour arms turn into Fangs... +5% MeleeDamage");
		}

		public override void SetDefaults() {
			item.width = 30;
			item.height = 20;
			item.value = 1500;
			item.rare = 2;
			item.defense = 3;
		}

		public override void UpdateEquip(Player player) {
			player.pickSpeed += 0.15f;
			player.meleeDamage += 0.05f;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "AntlionBody", 4);
			recipe.AddIngredient(null, "AntlionBodyS", 3);
			recipe.AddIngredient(null, "AntlionWings", 1);
			recipe.AddIngredient(ItemID.AntlionMandible, 6);
			recipe.AddTile(null, "DessertIdol");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}