using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Bleachmod.Buffs;

namespace Bleachmod.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class DarkMagehood : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault ("DarkMage Hood");
			Tooltip.SetDefault("Dark toughs.." + 
			"\n your vision yields, your mind expands"+
			"\n +1 minion -10% ManaCost");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 1000;
			item.rare = 3;
			
		}
		public override void UpdateEquip(Player player) {
			player.manaCost = 0.9f;
			player.maxMinions += 1;
            player.statLifeMax2 -=	25;		
			player.blackout = true;
			
		}

		public override bool IsArmorSet(Item head, Item body, Item legs) {
			return body.type == mod.ItemType("DarkMagerobe");
		}

		public override void UpdateArmorSet(Player player) {
			player.setBonus = "The dark is your allie";
			player.AddBuff(ModContent.BuffType<Buffs.DarkFlame>(),1, true);
			
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Darkmanastar", 1);
			recipe.AddIngredient(ItemID.Silk, 12);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}