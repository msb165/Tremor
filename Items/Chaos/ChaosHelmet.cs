using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items.Chaos
{
	[AutoloadEquip(EquipType.Head)]
	public class ChaosHelmet:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 32;
			Item.height = 26;

			Item.value = 6000;
			Item.rare = 5;
			Item.defense = 8;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Chaos Helmet");
			/* Tooltip.SetDefault("Increases maximum life by 25\n" +
"Immune to most debuffs!"); */
		}

		public override void UpdateEquip(Player p)
		{
			p.statLifeMax2 += 25;
			p.buffImmune[44] = true;
			p.buffImmune[46] = true;
			p.buffImmune[47] = true;
			p.buffImmune[20] = true;
			p.buffImmune[22] = true;
			p.buffImmune[24] = true;
			p.buffImmune[23] = true;
			p.buffImmune[30] = true;
			p.buffImmune[31] = true;
			p.buffImmune[32] = true;
			p.buffImmune[33] = true;
			p.buffImmune[35] = true;
			p.buffImmune[36] = true;
			p.buffImmune[69] = true;
			p.buffImmune[70] = true;
			p.buffImmune[80] = true;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<ChaosBreastplate>() && legs.type == ModContent.ItemType<ChaosGreaves>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Increases life regeneration";
			player.lifeRegen += 2;
		}

		public override void ArmorSetShadows(Player player)
		{
			player.armorEffectDrawShadowLokis = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<ChaosBar>(), 14);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}
	}
}
