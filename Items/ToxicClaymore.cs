using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class ToxicClaymore:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 26;
			Item.DamageType = DamageClass.Melee;
			Item.width = 40;
			Item.height = 52;
			Item.useTime = 21;
			Item.useAnimation = 21;
			Item.useStyle = 1;
			Item.knockBack = 6;
			Item.value = 660;
			Item.rare = 1;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Toxic Claymore");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<ToxicHilt>(), 1);
			recipe.AddIngredient(ModContent.ItemType<ToxicBlade>(), 1);
			recipe.AddIngredient(ModContent.ItemType<BottledGlue>(), 1);
			recipe.SetResult(this);
			recipe.AddTile(ModContent.TileType<Tiles.GreatAnvilTile>());
			recipe.AddRecipe();
		}

		public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
		{
			if (Main.rand.NextBool(3))
			{
				target.AddBuff(70, 1200);
			}
		}
	}
}
