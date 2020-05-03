using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace Bleachmod.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class AntlionHelmet : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault ("Antlion Helmet");
			Tooltip.SetDefault("'You don't look pretty dangerous'"
			+ "\n The feelers are truly usefull, you can feel the enemies");
		}

		public override void SetDefaults() {
			item.width = 30;
			item.height = 28;
			item.value = 1500;
			item.rare = 2;
			item.defense = 3;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs) {
			return body.type == mod.ItemType("AntlionBreastplate") && legs.type == mod.ItemType("Antlionleggings");
		}
		
		public override void UpdateEquip(Player player) {
			player.detectCreature = true;
			
		}

		public override void UpdateArmorSet(Player player) {
			player.setBonus = "F'ant'astic!";
			player.statDefense += 3;
			player.maxFallSpeed -= 0.5f;
			player.noFallDmg = true;
			
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "AntlionBodyS", 2);
			recipe.AddIngredient(null, "AntlionEyeG", 2);
			recipe.AddIngredient(ItemID.AntlionMandible, 2);
			recipe.AddTile(null, "DessertIdol");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}