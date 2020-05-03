using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.Items
{
	public class KaozuWisp : ModItem
	{
		public override void SetStaticDefaults() {
			
			 DisplayName.SetDefault("Kaozu Wisp");
			 Tooltip.SetDefault("Summons a cute flying evil flame");
		}

		public override void SetDefaults() {
			item.CloneDefaults(ItemID.ZephyrFish);
			item.shoot = mod.ProjectileType("KaozuWisp");
			item.buffType = mod.BuffType("KaozuWisp");
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Darkmanastar", 5);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override void UseStyle(Player player) {
			if (player.whoAmI == Main.myPlayer && player.itemTime == 0) {
				player.AddBuff(item.buffType, 3600, true);
			}
		}
	}
}