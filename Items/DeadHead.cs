using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Flesh;

namespace Tremor.Items
{
	public class DeadHead:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.width = 26;
			Item.height = 20;
			Item.value = 110;
			Item.rare = 4;
			Item.defense = 5;

			Item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Dead Head");
			/* Tooltip.SetDefault("4% increased damage and critical strike chance\n" +
"15% increased movement speed"); */
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetDamage(DamageClass.Generic) += 0.04f;
			player.GetCritChance(DamageClass.Generic) += 4;

			player.moveSpeed += 0.15f;
			player.maxRunSpeed += 0.15f;

			MPlayer modPlayer = Main.LocalPlayer.GetModPlayer<MPlayer>();
			modPlayer.alchemicalDamage += 0.04f;
			modPlayer.alchemicalCrit += 4;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<TheBrain>(), 1);
			recipe.AddIngredient(ModContent.ItemType<AtisBlood>(), 15);
			recipe.AddIngredient(ItemID.Bone, 25);
			recipe.AddIngredient(ModContent.ItemType<UntreatedFlesh>(), 25);
			recipe.AddIngredient(ModContent.ItemType<SharpenedTooth>(), 6);
			recipe.AddIngredient(ItemID.Lens, 2);
			recipe.SetResult(this);
			recipe.AddTile(ModContent.TileType<Tiles.FleshWorkstationTile>());
			recipe.AddRecipe();
		}
	}
}
