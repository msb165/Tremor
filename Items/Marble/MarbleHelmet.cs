using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Marble
{
	[AutoloadEquip(EquipType.Head)]
	public class MarbleHelmet:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.defense = 2;
			Item.width = 26;
			Item.height = 32;
			Item.value = 2500;
			Item.rare = 1;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Marble Helmet");
			// Tooltip.SetDefault("10% increased throwing velocity");
		}

		public override void UpdateEquip(Player p)
		{
			p.ThrownVelocity += 0.1f;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<MarbleBreastplate>() && legs.type == ModContent.ItemType<MarbleLeggings>();
		}

		public override void ArmorSetShadows(Player player)
		{
			player.armorEffectDrawShadowSubtle = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.MarbleBlock, 25);
			recipe.AddIngredient(ModContent.ItemType<StoneofLife>(), 1);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();
		}
	}
}
