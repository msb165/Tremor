using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Chlorophyte
{
	[AutoloadEquip(EquipType.Head)]
	public class ChlorophyteHeader:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 24;
			Item.height = 26;

			Item.value = 60000;
			Item.rare = 4;
			Item.defense = 8;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Chlorophyte Header");
			// Tooltip.SetDefault("28% increased thrown damage");
		}

		public override void UpdateEquip(Player player)
		{
			player.GetDamage(DamageClass.Throwing) += 0.28f;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == 1004 && legs.type == 1005;
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Increases thrown weapon velocity and summons a powerful leaf crystal to shoot at nearby enemies.";
			player.ThrownVelocity += 0.25f;
			player.AddBuff(60, 60, true);
		}

		public override void ArmorSetShadows(Player player)
		{
			player.armorEffectDrawOutlines = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.ChlorophyteBar, 12);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}
	}
}
