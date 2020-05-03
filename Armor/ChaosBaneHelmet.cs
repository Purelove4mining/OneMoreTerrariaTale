using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace Bleachmod.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class ChaosBaneHelmet : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault ("ChaosBane Helmet");
			Tooltip.SetDefault("Your Mind is not totally yours now");
		}

		public override void SetDefaults() {
			item.width = 34;
			item.height = 29;
			item.value = 1500;
			item.rare = 2;
			item.defense = 17;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs) {
			return body.type == mod.ItemType("ChaosBaneBreastplate") && legs.type == mod.ItemType("ChaosBaneleggings");
		}
		
		public override void UpdateEquip(Player player) {
			
		}

		public override void UpdateArmorSet(Player player) {
			player.setBonus = "Your Blood turns into ichor and your body annheles chaos";
			player.statDefense += 10;
			
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "ChaosBanebar", 15);
			recipe.AddTile(null, "MetalWorker");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}