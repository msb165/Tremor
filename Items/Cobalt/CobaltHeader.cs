using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Cobalt
{
	[AutoloadEquip(EquipType.Head)]
	public class CobaltHeader:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 20;
			Item.height = 26;

			Item.value = 400;
			Item.rare = 4;
			Item.defense = 3;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Cobalt Header");
			// Tooltip.SetDefault("18% increased thrown damage");
		}

		public override void UpdateEquip(Player player)
		{
			player.GetDamage(DamageClass.Throwing) += 0.18f;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == 374 && legs.type == 375;
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Increases thrown weapon velocity";
			player.ThrownVelocity += 0.25f;
		}

		public override void ArmorSetShadows(Player player)
		{
			player.armorEffectDrawShadow = true;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.CobaltBar, 12);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();
		}
	}
}
