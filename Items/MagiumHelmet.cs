using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class MagiumHelmet:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 38;
			Item.height = 22;

			Item.value = 18000;
			Item.rare = 5;
			Item.defense = 8;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Magium Helmet");
			/* Tooltip.SetDefault("9% increased magic critical strike chance\n" +
"Increases maximum mana by 40"); */
		}

		public override void UpdateEquip(Player player)
		{
			player.GetCritChance(DamageClass.Magic) += 9;
			player.statManaMax2 += 40;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<MagiumBreastplate>() && legs.type == ModContent.ItemType<MagiumGreaves>();
		}

		public override void UpdateArmorSet(Player p)
		{
			p.setBonus = "25% decreased mana cost";
			p.manaCost -= 0.25f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<RuneBar>(), 8);
			recipe.AddIngredient(ModContent.ItemType<MagiumShard>(), 6);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}

	}
}
