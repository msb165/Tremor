using Terraria;
using Terraria.ModLoader;
using Tremor.Items.Steel;

namespace Tremor.Items.Afterlife
{
	[AutoloadEquip(EquipType.Head)]
	public class AfterlifeHood:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 38;
			Item.height = 22;

			Item.value = 10000;
			Item.rare = 6;
			Item.defense = 7;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Afterlife Hood");
			// Tooltip.SetDefault("Increases life regeneration");
		}

		public override void UpdateEquip(Player player)
		{
			player.crimsonRegen = true;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<AfterlifeBreastplate>() && legs.type == ModContent.ItemType<AfterlifeLeggings>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Quickly recovers you if you have low health. But at what cost...";
			if (player.statLife < 25)
			{
				player.lifeRegen += 40;
				player.statDefense *= 0;
			}
		}

		public override void ArmorSetShadows(Player player)
		{
			player.armorEffectDrawShadowLokis = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<SkullTeeth>(), 2);
			recipe.AddIngredient(ModContent.ItemType<SteelBar>(), 12);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}

	}
}
