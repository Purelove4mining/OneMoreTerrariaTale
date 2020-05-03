using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace Bleachmod.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class SteelHelmet : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault ("Steel Helmet");
			Tooltip.SetDefault("It's kinda like a heavy hat");
		}

		public override void SetDefaults() {
			item.width = 30;
			item.height = 28;
			item.value = 1500;
			item.rare = 2;
			item.defense = 3;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs) {
			return body.type == mod.ItemType("SteelBreastplate") && legs.type == mod.ItemType("Steelleggings");
		}
		
		public override void UpdateEquip(Player player) {
			
		}

		public override void UpdateArmorSet(Player player) {
			player.setBonus = "Set Bonus +4 Armor" +"+5% meleeDamage -10% movementSpeed";
			player.statDefense += 4;
			player.accRunSpeed -= 0.1f;
			player.meleeDamage += 0.05f;
			
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