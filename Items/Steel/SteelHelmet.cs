using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items.Steel
{
	[AutoloadEquip(EquipType.Head)]
	public class SteelHelmet:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 32;
			Item.height = 26;

			Item.value = 400;
			Item.rare = 1;
			Item.defense = 4;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Steel Helmet");
			// Tooltip.SetDefault("3% increased melee critical strike chance");
		}

		public override void UpdateEquip(Player player)
		{
			player.GetCritChance(DamageClass.Melee) += 3;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<SteelChestplate>() && legs.type == ModContent.ItemType<SteelGreaves>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Increased maximum defense by 10";
			player.statDefense += 10;
			player.moveSpeed -= 0.25f;
		}

		public override void ArmorSetShadows(Player player)
		{
			player.armorEffectDrawShadowSubtle = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<SteelBar>(), 12);
			recipe.AddIngredient(ModContent.ItemType<LeatherHat>(), 1);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();
		}
	}
}
