using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Generation;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.World.Generation;

namespace Bleachmod.Tiles
{
	public class DessertIdol : ModTile
	{
		public override void SetDefaults() {
			Main.tileFrameImportant[Type] = true;
			Main.tileObsidianKill[Type] = true;

			TileObjectData.newTile.CopyFrom(TileObjectData.Style2xX);
			TileObjectData.addTile(Type);
			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Dessert Idol");
			AddMapEntry(new Color(255, 113, 3), name);
			dustType = 11;
			disableSmartCursor = true;
		}

		public override void KillMultiTile(int i, int j, int frameX, int frameY) {
			Item.NewItem(i * 16, j * 16, 32, 48, ModContent.ItemType<DessertIdolItem>());
		}


	public class DessertIdolItem : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Dessert Idol");
			Tooltip.SetDefault ("A forgotten memory of ancients times"
			+ "\n Used to Craft AridStuff");
		}

		public override void SetDefaults() {
			item.CloneDefaults(ItemID.ArmorStatue);
			item.createTile = ModContent.TileType<DessertIdol>();
			item.placeStyle = 0;
			item.value = 1000;
			item.width = 26;
			item.height = 32;
		}
	}

	
}
}