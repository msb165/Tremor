using Terraria;
using Terraria.ModLoader;
using Tremor.Items.Antlion;

namespace Tremor.Items.Sandstone
{
	[AutoloadEquip(EquipType.Head)]
	public class SandStoneHelmet:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 32;
			Item.height = 26;
			Item.value = 400;

			Item.rare = 2;
			Item.defense = 4;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Dune Helmet");
			// Tooltip.SetDefault("10% increased movement speed");
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed += 0.1f;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<SandStoneBreastplate>() && legs.type == ModContent.ItemType<SandStoneGreaves>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Summons a Sandstorm to fight for you";
			player.AddBuff(ModContent.BuffType<Buffs.SandstormMinionBuff>(), 2);
		}

		public override void ArmorSetShadows(Player player)
		{
			player.armorEffectDrawShadow = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<SandstoneBar>(), 8);
			recipe.AddIngredient(ModContent.ItemType<AntlionShell>(), 1);
			recipe.AddIngredient(ModContent.ItemType<PetrifiedSpike>(), 4);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();
		}
	}
}
