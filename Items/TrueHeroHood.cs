using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class TrueHeroHood:TremorModItem
	{

		public override void SetDefaults()
		{

			item.width = 32;
			item.height = 26;
			item.value = 25000;

			item.rare = 0;
			item.defense = 15;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("True Hero Hood");
			Tooltip.SetDefault("Gives one of three true blades");
		}

		public override void ModifyTooltips(List<TooltipLine> tooltips)
		{
			tooltips[0].OverrideColor = new Color(238, 194, 73);
		}

		public override void UpdateEquip(Player player)
		{
			player.AddBuff(ModContent.BuffType<Buffs.FirstTrueBlade>(), 2);
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<TrueHeroShirt>() && legs.type == ModContent.ItemType<TrueHeroPants>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Increases maximum defense by 20";
			player.statDefense += 20;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(247, 1);
			recipe.AddIngredient(ModContent.ItemType<GiantShell>(), 1);
			recipe.AddIngredient(ModContent.ItemType<BrokenHeroArmorplate>(), 1);
			recipe.AddIngredient(ModContent.ItemType<TrueEssense>(), 5);
			recipe.SetResult(this);
			recipe.AddTile(412);
			recipe.AddRecipe();
		}
	}
}
