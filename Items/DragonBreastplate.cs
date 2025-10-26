using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Body)]
	public class DragonBreastplate:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 30;
			Item.height = 26;

			Item.value = 35000;
			Item.rare = 11;
			Item.defense = 29;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Dragon Breastplate");
			/* Tooltip.SetDefault("50% increased ranged damage\n" +
"Increased ranged critical strike chance by 34"); */
		}

		public override void UpdateEquip(Player player)
		{
			player.GetDamage(DamageClass.Ranged) += 0.5f;
			player.GetCritChance(DamageClass.Ranged) += 34;
		}

		public virtual void ArmorSetShadows(Player player, ref bool longTrail, ref bool smallPulse, ref bool largePulse, ref bool shortTrail)
		{
			longTrail = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<DragonCapsule>(), 12);
			recipe.AddIngredient(ModContent.ItemType<EarthFragment>(), 10);
			recipe.AddTile(412);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
