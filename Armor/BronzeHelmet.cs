using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace Bleachmod.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class BronzeHelmet : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault ("Bronze Helmet");
			Tooltip.SetDefault("'it don't get the form you want'");
		}

		public override void SetDefaults() {
			item.width = 30;
			item.height = 28;
			item.value = 1500;
			item.rare = 2;
			item.defense = 1;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs) {
			return body.type == mod.ItemType("BronzeBreastplate") && legs.type == mod.ItemType("Bronzeleggings");
		}
		
		public override void UpdateEquip(Player player) {
			player.detectCreature = true;
		}

		public override void UpdateArmorSet(Player player) {
			player.setBonus = "Set Bonus +4 Armor";
			player.statDefense += 3;
			
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Bronzebar", 10);
			recipe.AddTile(null, "MetalWorker");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}