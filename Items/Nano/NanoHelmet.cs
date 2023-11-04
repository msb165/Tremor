using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items.Nano
{
	[AutoloadEquip(EquipType.Head)]
	public class NanoHelmet:TremorModItem
	{

		public override void SetDefaults()
		{

			item.width = 32;
			item.height = 26;

			item.value = 60000;
			item.rare = 6;
			item.defense = 12;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Nano Helmet");
			Tooltip.SetDefault("Maximum mana increased by 60\n" +
"8% increased critical strike chance");
		}

		public override void UpdateEquip(Player player)
		{
			player.statManaMax2 += 60;
			player.GetCritChance(DamageClass.Generic) += 8;
			player.GetModPlayer<MPlayer>().alchemicalCrit += 8;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<NanoBreastplate>() && legs.type == ModContent.ItemType<NanoGreaves>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Summons a Nano Drone to fight for you";
			player.AddBuff(ModContent.BuffType<Buffs.NanoDronBuff>(), 2);
			player.nightVision = true;
			if (Math.Abs(player.velocity.X) + Math.Abs(player.velocity.Y) > 1f && !player.rocketFrame) // Makes sure the player is actually moving
			{
				for (int k = 0; k < 2; k++)
				{
					int index = Dust.NewDust(new Vector2(player.position.X - player.velocity.X * 2f, player.position.Y - 2f - player.velocity.Y * 2f), player.width, player.height, 226, 0f, 0f, 100, default(Color), 0.4f);
					Main.dust[index].noGravity = true;
					Main.dust[index].noLight = true;
					Dust dust = Main.dust[index];
					dust.velocity.X = dust.velocity.X - player.velocity.X * 0.5f;
					dust.velocity.Y = dust.velocity.Y - player.velocity.Y * 0.5f;
				}
			}
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<NanoBar>(), 12);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}
	}
}
