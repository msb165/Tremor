using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Invar
{
	public abstract class _InvarHat : TremorAbstractItem
	{
		public override string Texture => $"{typeof(_InvarHat).NamespaceToPath()}/InvarHat";

		protected sealed override void Defaults()
		{
			Item.width = 32;
			Item.height = 26;
			Item.value = Item.sellPrice(silver: 9);
			Item.rare = 1;
			Item.defense = 2;
		}

		protected sealed override void StaticDefaults()
		{
			// DisplayName.SetDefault("Invar Hat");
			// Tooltip.SetDefault("10% increased melee speed");
		}

		public override void UpdateEquip(Player player)
		{
			player.GetAttackSpeed(DamageClass.Melee) += 0.1f;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<InvarBreastplate>() && legs.type == ModContent.ItemType<InvarGreaves>() || body.type == ModContent.ItemType<ReinforcedInvarBreastplate>() && legs.type == ModContent.ItemType<ReinforcedInvarGreaves>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "10% increased melee speed";
			player.GetAttackSpeed(DamageClass.Melee) += 0.1f;
		}
	}

	[AutoloadEquip(EquipType.Head)]
	public class ReinforcedInvarHat : _InvarHat
	{
		public override void SafeDefaults()
		{
			Item.defense += 1;
			Item.value = Item.sellPrice(silver: 11);
		}

		public override void SafeStaticDefaults()
		{
			// DisplayName.SetDefault("Reinforced Invar Hat");
			/* Tooltip.SetDefault(Tooltip.GetDefault() + "\n" +
"Reinforced to grant +1 defense"); */
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<InvarHat>());
			recipe.AddIngredient(ModContent.ItemType<InvarBar>(), 2);
			recipe.SetResult(this);
			recipe.AddTile(TileID.Anvils);
			recipe.AddRecipe();
		}
	}

	[AutoloadEquip(EquipType.Head)]
	public class InvarHat : _InvarHat
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
