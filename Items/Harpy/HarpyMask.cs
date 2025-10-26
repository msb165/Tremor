using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Harpy
{
	[AutoloadEquip(EquipType.Head)]
	public class HarpyMask:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 24;
			Item.height = 26;

			Item.value = 100;
			Item.rare = 2;
			Item.defense = 3;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Harpy Mask");
			// Tooltip.SetDefault("10% increased ranged damage");
		}

		public override void UpdateEquip(Player player)
		{
			player.GetDamage(DamageClass.Ranged) += 0.1f;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<HarpyChestplate>() && legs.type == ModContent.ItemType<HarpyLeggings>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Allows you to fall slowly";
			player.slowFall = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.Silk, 8);
			recipe.AddIngredient(ItemID.Feather, 4);
			recipe.SetResult(this);
			recipe.AddTile(18);
			recipe.AddRecipe();
		}

	}
}
