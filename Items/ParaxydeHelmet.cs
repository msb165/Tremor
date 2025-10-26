﻿using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class ParaxydeHelmet:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 38;
			Item.height = 22;

			Item.value = 10000;
			Item.rare = 5;
			Item.defense = 15;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Paraxyde Helmet");
			/* Tooltip.SetDefault("12% increased magic damage\n" +
"16% increased melee damage"); */
		}

		public override void UpdateEquip(Player player)
		{
			player.GetDamage(DamageClass.Magic) += 0.12f;
			player.GetDamage(DamageClass.Melee) += 0.16f;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<ParaxydeBreastplate>() && legs.type == ModContent.ItemType<ParaxydeGreaves>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Shadow knives will fall on your target for extra damage";
			player.GetModPlayer<TremorPlayer>().onHitShadaggers = true;
		}

		public override void ArmorSetShadows(Player player)
		{
			player.armorEffectDrawOutlines = true; //�।��� ����஢����
			player.armorEffectDrawShadow = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<ParaxydeShard>(), 12);
			recipe.SetResult(this);
			recipe.AddTile(ModContent.TileType<Tiles.AlchematorTile>());
			recipe.AddRecipe();
		}
	}
}
