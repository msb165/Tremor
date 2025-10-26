using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Nano
{
	public class NanoBlade:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 72;
			Item.DamageType = DamageClass.Melee;
			Item.width = 50;
			Item.height = 55;
			Item.useTime = 25;
			Item.useAnimation = 25;
			Item.useStyle = 1;
			Item.shootSpeed = 10f;
			Item.knockBack = 8;
			Item.value = 10000;
			Item.rare = 8;
			Item.UseSound = SoundID.Item1;
			Item.useTurn = false;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Nano Blade");
			// Tooltip.SetDefault("");
		}

		public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
		{
			target.AddBuff(144, 1200);
		}

		public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 59);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<NanoBar>(), 15);
			recipe.AddIngredient(ItemID.HallowedBar, 5);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}
	}
}
