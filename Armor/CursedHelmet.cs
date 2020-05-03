using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace Bleachmod.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class CursedHelmet : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault ("Cursed Helmet");
			Tooltip.SetDefault("A few more eyes is never bad");
		}

		public override void SetDefaults() {
			item.width = 34;
			item.height = 29;
			item.value = 1500;
			item.rare = 2;
			item.defense = 17;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs) {
			return body.type == mod.ItemType("CursedBreastplate") && legs.type == mod.ItemType("Cursedleggings");
		}
		
		public override void UpdateEquip(Player player) {
			
		}

		public override void UpdateArmorSet(Player player) {
			player.setBonus = "Your one with the curse";
			player.statDefense += 10;
			
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Cursedbar", 15);
			recipe.AddTile(null, "MetalWorker");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}