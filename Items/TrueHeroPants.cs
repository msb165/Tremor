using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Legs)]
	public class TrueHeroPants:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 22;
			Item.height = 18;
			Item.value = 25000;

			Item.rare = 0;
			Item.defense = 20;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("True Hero Pants");
			// Tooltip.SetDefault("Gives one of three true blades");
		}

		public override void ModifyTooltips(List<TooltipLine> tooltips)
		{
			tooltips[0].OverrideColor = new Color(238, 194, 73);
		}

		public override void UpdateEquip(Player player)
		{
			player.AddBuff(ModContent.BuffType<Buffs.ThirdTrueBlade>(), 2);
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(249, 1);
			recipe.AddIngredient(ModContent.ItemType<GiantShell>(), 1);
			recipe.AddIngredient(ModContent.ItemType<BrokenHeroArmorplate>(), 1);
			recipe.AddIngredient(ModContent.ItemType<TrueEssense>(), 3);
			recipe.SetResult(this);
			recipe.AddTile(412);
			recipe.AddRecipe();
		}
	}
}
