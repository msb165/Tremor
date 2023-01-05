using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class SalamanderMask:TremorModItem
	{

		public override void SetDefaults()
		{

			item.width = 28;
			item.height = 22;
			item.rare = 1;

			item.value = 100;
			item.defense = 2;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Salamander Mask");
			Tooltip.SetDefault("Increases movement speed");
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed += 0.1f;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<SalamanderCloth>() && legs.type == ModContent.ItemType<SalamanderLeggings>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Increases armor penetration by 5";
			player.GetArmorPenetration(DamageClass.Generic) = 5;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<SalamanderSkin>(), 6);
			recipe.SetResult(this);
			recipe.AddTile(18);
			recipe.AddRecipe();
		}
	}
}
