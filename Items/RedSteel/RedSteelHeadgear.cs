using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items.RedSteel
{
	[AutoloadEquip(EquipType.Head)]
	public class RedSteelHeadgear:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.width = 26;
			Item.height = 20;
			Item.value = 200;
			Item.rare = 1;
			Item.defense = 8;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Red Steel Headgear");
			// Tooltip.SetDefault("10% increased melee damage");
		}

		public override void UpdateEquip(Player player)
		{
			player.GetDamage(DamageClass.Melee) += 0.1f;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<RedSteelChestplate>() && legs.type == ModContent.ItemType<RedSteelGreaves>();
		}

		public override void UpdateArmorSet(Player p)
		{
			p.setBonus = "Grants chance to dodge attack";
			p.blackBelt = true;
		}

		public override void AddRecipes()
		{
			//ModRecipe recipe = new ModRecipe();
			//recipe.AddIngredient(ModContent.ItemType<RedSteelArmorPiece>(), 5);
			//recipe.AddIngredient(ModContent.ItemType<RedSteelBar>(), 7);
			//recipe.SetResult(this);
			//recipe.AddTile(16);
			//recipe.AddRecipe();
		}
	}
}
