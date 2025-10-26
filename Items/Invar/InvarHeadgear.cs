using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Invar
{
	public abstract class _InvarHeadgear : TremorAbstractItem
	{
		public override string Texture => $"{typeof(_InvarHeadgear).NamespaceToPath()}/InvarHeadgear";

		protected sealed override void Defaults()
		{
			Item.width = 32;
			Item.height = 26;
			Item.value = Item.sellPrice(silver: 9);
			Item.rare = 1;
			Item.defense = 1;
		}

		protected sealed override void StaticDefaults()
		{
			// DisplayName.SetDefault("Invar Headgear");
			// Tooltip.SetDefault("6% increased melee damage");
		}

		public override void UpdateEquip(Player player)
		{
			player.GetDamage(DamageClass.Melee) += 0.06f;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<InvarBreastplate>() && legs.type == ModContent.ItemType<InvarGreaves>() || body.type == ModContent.ItemType<ReinforcedInvarBreastplate>() && legs.type == ModContent.ItemType<ReinforcedInvarGreaves>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "6% increased melee damage";
			player.GetDamage(DamageClass.Melee) += 0.06f;
		}
	}

	[AutoloadEquip(EquipType.Head)]
	public class ReinforcedInvarHeadgear : _InvarHeadgear
	{
		public override void SafeDefaults()
		{
			Item.defense += 1;
			Item.value = Item.sellPrice(silver: 11);
		}

		public override void SafeStaticDefaults()
		{
			// DisplayName.SetDefault("Reinforced Invar Headgear");
			/* Tooltip.SetDefault(Tooltip.GetDefault() + "\n" +
"Reinforced to grant +1 defense"); */
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<InvarHeadgear>());
			recipe.AddIngredient(ModContent.ItemType<InvarBar>(), 2);
			recipe.SetResult(this);
			recipe.AddTile(TileID.Anvils);
			recipe.AddRecipe();
		}
	}

	[AutoloadEquip(EquipType.Head)]
	public class InvarHeadgear : _InvarHeadgear
	{
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<InvarBar>(), 8);
			recipe.SetResult(this);
			recipe.AddTile(TileID.Anvils);
			recipe.AddRecipe();
		}
	}
}
