using Terraria;
using Terraria.ModLoader;
using Tremor.Items.Steel;

namespace Tremor.Items.Berserker
{
	[AutoloadEquip(EquipType.Head)]
	public class BerserkerHelmet : ModItem
	{

		public override void SetDefaults()
		{

			item.width = 32;
			item.height = 26;

			item.value = 400;
			item.rare = 2;
			item.defense = 5;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Berserker Helmet");
			Tooltip.SetDefault("15% increased melee speed");
		}

		public override void UpdateEquip(Player player)
		{
			player.meleeSpeed += 0.15f;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<BerserkerChestplate>() && legs.type == ModContent.ItemType<BerserkerGreaves>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Summons a Rotating Sword to fight for you";
			player.AddBuff(ModContent.BuffType<Buffs.BerserkerBuff>(), 2);
		}

		public override void ArmorSetShadows(Player player)
		{
			player.armorEffectDrawOutlines = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<SteelBar>(), 16);
			recipe.AddIngredient(ModContent.ItemType<MinotaurHorn>(), 1);
			recipe.AddIngredient(ModContent.ItemType<EarthFragment>(), 8);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();
		}
	}
}
