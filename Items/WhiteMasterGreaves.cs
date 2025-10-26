using System;
using System.Linq;
using Terraria;
using Terraria.ModLoader;
using Tremor.Items.Souls;
using Tremor.NPCs.Bosses.NovaPillar.Items.Armor;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Legs)]
	public class WhiteMasterGreaves:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.width = 22;
			Item.height = 18;
			Item.value = 50000;
			Item.rare = 11;
			Item.defense = 24;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("White Master Greaves");
			/* Tooltip.SetDefault("Massively increases alchemical critical chance as health lowers\n" +
"10% increased alchemical critical strike chance\n" +
"Increases life regeneration while moving\n" +
"35% increased movement speed"); */
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed += 0.35f;
			player.maxRunSpeed += 0.35f;
			if (Math.Abs(player.velocity.Length()) > 0f)
			{
				player.lifeRegen += 6;
			}
			player.GetModPlayer<MPlayer>().alchemicalCrit += 10;
			var critIncreases = new[]
			{
				new[]{player.statLifeMax2, 10},
				new[]{400, 15},
				new[]{300, 20},
				new[]{200, 25},
			};
			foreach (int[] increase in critIncreases)
			{
				if (player.statLife <= increase[0])
					player.GetModPlayer<MPlayer>().alchemicalCrit += increase[1];
			}
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<BrokenHeroArmorplate>(), 1);
			recipe.AddIngredient(ModContent.ItemType<NovaLeggings>(), 1);
			recipe.AddIngredient(ModContent.ItemType<Aquamarine>(), 6);
			recipe.AddIngredient(ModContent.ItemType<SoulofFight>(), 8);
			recipe.AddIngredient(ModContent.ItemType<Phantaplasm>(), 4);
			recipe.SetResult(this);
			recipe.AddTile(412);
			recipe.AddRecipe();
		}
	}
}
