using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.LivingWood
{
	[AutoloadEquip(EquipType.Head)]
	public class LivingWoodMask:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 34;
			Item.height = 26;

			Item.value = 200;
			Item.rare = 1;
			Item.defense = 1;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Living Wood Mask");
			// Tooltip.SetDefault("4% increased minion damage");
		}

		public override void UpdateEquip(Player player)
		{
			player.GetDamage(DamageClass.Summon) += 0.04f;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<LivingWoodBreastplate>() && legs.type == ModContent.ItemType<LivingWoodGreaves>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Increases your max number of minions";
			player.maxMinions += 1;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.Wood, 20);
			recipe.SetResult(this);
			recipe.AddTile(304);
			recipe.AddRecipe();
		}

	}
}
