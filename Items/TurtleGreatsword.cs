using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class TurtleGreatsword:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 95;
			Item.DamageType = DamageClass.Melee;
			Item.width = 94;
			Item.height = 94;
			Item.useTime = 45;
			Item.useAnimation = 45;
			Item.useStyle = 1;
			Item.knockBack = 8;
			Item.value = 50000;
			Item.rare = 8;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = false;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Turtle Greatsword");
			// Tooltip.SetDefault("");
		}

		public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
		{
			target.AddBuff(36, 300);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.TurtleShell);
			recipe.AddIngredient(ItemID.ChlorophyteBar, 20);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}
	}
}
