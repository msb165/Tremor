using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Magmonium;
using Tremor.Items.Souls;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Legs)]
	public class HadesGreaves:TremorModItem
	{

		public override void SetDefaults()
		{

			item.width = 22;
			item.height = 18;
			item.value = 500;

			item.rare = 250000;
			item.defense = 42;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hades Greaves");
			Tooltip.SetDefault("Increases movement speed\n" +
"Allows to dash\n" +
"Double tap a direction\n" +
"Allows you to walk on liquids");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<InfernoSoul>(), 7);
			recipe.AddIngredient(ModContent.ItemType<MagmoniumGreaves>(), 1);
			recipe.AddIngredient(ModContent.ItemType<FireFragment>(), 17);
			recipe.AddIngredient(ModContent.ItemType<Phantaplasm>(), 10);
			recipe.AddIngredient(ItemID.LivingFireBlock, 8);
			recipe.SetResult(this);
			recipe.AddTile(ModContent.TileType<Tiles.StarvilTile>());
			recipe.AddRecipe();
		}

		public override void ModifyTooltips(List<TooltipLine> tooltips)
		{
			tooltips[0].OverrideColor = new Color(238, 194, 73);
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed += 0.8f;
			player.dash = 1;
			player.waterWalk = true;
		}
	}
}
