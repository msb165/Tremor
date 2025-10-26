using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Coral
{
	[AutoloadEquip(EquipType.Head)]
	public class CoralHelmet:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 24;
			Item.height = 26;

			Item.value = 100;
			Item.rare = 1;
			Item.defense = 2;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Coral Helmet");
			// Tooltip.SetDefault("Allows you to swim");
		}

		public override void UpdateEquip(Player player)
		{
			player.accFlipper = true;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<CoralChestplate>() && legs.type == ModContent.ItemType<CoralGreaves>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Allows you to breath underwater and summons an starfish";
			if (player.breath < player.breathMax - 1)
			{
				player.breath = player.breathMax - 1;
			}
			player.AddBuff(ModContent.BuffType<Buffs.StarfishBuff>(), 2);
		}

		public override void ArmorSetShadows(Player player)
		{
			player.armorEffectDrawShadow = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.Coral, 8);
			recipe.AddIngredient(ItemID.Starfish, 6);
			recipe.SetResult(this);
			recipe.AddTile(18);
			recipe.AddRecipe();
		}

	}
}
