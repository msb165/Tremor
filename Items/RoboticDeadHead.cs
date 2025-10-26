using Terraria;
using Terraria.ModLoader;
using Tremor.Items.Doom;

namespace Tremor.Items
{
	public class RoboticDeadHead:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.width = 26;
			Item.height = 20;
			Item.value = 110;
			Item.rare = 4;
			Item.defense = 10;

			Item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Robotic Dead Head");
			/* Tooltip.SetDefault("15% increased damage\n" +
"12% increased critical strike chance\n" +
"25% increased movement speed"); */
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetDamage(DamageClass.Generic) += 0.15f;
			player.GetCritChance(DamageClass.Generic) += 12;

			player.moveSpeed += 0.25f;
			player.maxRunSpeed += 0.25f;

			MPlayer modPlayer = Main.LocalPlayer.GetModPlayer<MPlayer>();
			modPlayer.alchemicalDamage += 0.15f;
			modPlayer.alchemicalCrit += 12;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<DeadHead>(), 1);
			recipe.AddIngredient(ModContent.ItemType<CarbonSteel>(), 15);
			recipe.AddIngredient(ModContent.ItemType<Doomstone>(), 5);
			recipe.AddIngredient(ModContent.ItemType<DeadTissue>(), 5);
			recipe.AddIngredient(ModContent.ItemType<Phantaplasm>(), 8);
			recipe.AddIngredient(ModContent.ItemType<EyeofOblivion>(), 2);
			recipe.SetResult(this);
			recipe.AddTile(ModContent.TileType<Tiles.AlchemyStationTile>());
			recipe.AddRecipe();
		}
	}
}
