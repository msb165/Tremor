using Terraria;
using Terraria.ModLoader;
using Tremor.Items.Ancient;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class GuardianHelmet:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.defense = 50;
			Item.width = 26;
			Item.height = 32;
			Item.value = 25000;
			Item.rare = 10;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Guardian Helmet");
			// Tooltip.SetDefault("");
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<GuardianBreastplate>() && legs.type == ModContent.ItemType<GuardianGreaves>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Decreases movement speed";
			player.moveSpeed -= 0.3f;
		}

		public override void ArmorSetShadows(Player player)
		{
			player.armorEffectDrawShadowLokis = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<AncientArmorPlate>(), 12);
			recipe.AddIngredient(ModContent.ItemType<Squorb>(), 1);
			recipe.SetResult(this);
			recipe.AddTile(412);
			recipe.AddRecipe();
		}
	}
}
