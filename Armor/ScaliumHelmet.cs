using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace Bleachmod.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class ScaliumHelmet : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault ("Scalium Helmet");
			Tooltip.SetDefault("Attaches to your body");
		}

		public override void SetDefaults() {
			item.width = 30;
			item.height = 28;
			item.value = 1500;
			item.rare = 2;
			item.defense = 5;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs) {
			return body.type == mod.ItemType("ScaliumBreastplate") && legs.type == mod.ItemType("Scaliumleggings");
		}
		
		public override void UpdateEquip(Player player) {
			
		}

		public override void UpdateArmorSet(Player player) {
			player.setBonus = "Set Bonus Inmunity to some debuff" + "Innhacend your abilities";
			player.buffImmune[BuffID.OnFire] = true;
			player.buffImmune[BuffID.Poisoned] = true;
			player.buffImmune[BuffID.Slow] = true;
			player.buffImmune[BuffID.BrokenArmor] = true;
			player.buffImmune[BuffID.Chilled] = true;
			player.jumpSpeedBoost += 1f;
			player.jumpBoost = true;
			player.accRunSpeed += 0.15f;
			player.maxRunSpeed += 0.15f;
			player.allDamage += 0.05f;
			
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Scaliumbar", 10);
			recipe.AddTile(null, "MetalWorker");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}