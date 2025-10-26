using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class ExecutionerAxe:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 245;
			Item.DamageType = DamageClass.Melee;
			Item.width = 66;
			Item.height = 66;
			Item.useTime = 45;
			Item.useAnimation = 45;
			Item.useStyle = 1;
			Item.knockBack = 25;
			Item.value = 12500;
			Item.rare = 11;
			Item.UseSound = SoundID.Item71;
			Item.autoReuse = false;
			Item.useTurn = false;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Executioner Axe");
			// Tooltip.SetDefault("");
		}

		public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
		{
			target.AddBuff(39, 120);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<NightCore>(), 1);
			recipe.AddIngredient(3467, 6);
			recipe.AddIngredient(ModContent.ItemType<MultidimensionalFragment>(), 8);
			recipe.AddIngredient(ModContent.ItemType<ConcentratedEther>(), 20);
			recipe.SetResult(this);
			recipe.AddTile(412);
			recipe.AddRecipe();
		}
	}
}
