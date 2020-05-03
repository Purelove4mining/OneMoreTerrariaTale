using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bleachmod.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	internal class DarkMagerobe : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault ("DarkMage Robe");
			Tooltip.SetDefault("Your body is one with the mana" 
			+"\n The power consumes a little it"
			+"\n +40 mana, +10% Magic damage");
		}
		
		public override void SetDefaults() {
			item.width = 18;
			item.height = 14;
			item.rare = 3;
			item.vanity = true;
		}
		
		
		public override void UpdateEquip(Player player) {
			player.magicDamage += 0.1f;
			player.statManaMax2 += 40;
			player.statLifeMax2 -= 25;
			player.manaMagnet = true;
			
		}
		

		public override void SetMatch(bool male, ref int equipSlot, ref bool robes) {
			robes = true;
			equipSlot = mod.GetEquipSlot("DarkMagerobe_Legs", EquipType.Legs);
			
		}

		public override void DrawHands(ref bool drawHands, ref bool drawArms) {
			drawHands = true;

        
        }
		
		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Darkmanastar", 2);
			recipe.AddIngredient(ItemID.Robe);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
}
}

	
	

