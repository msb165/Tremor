using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class ParaxydeStave:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.CloneDefaults(ItemID.Starfury);

			Item.damage = 68;
			//Item.melee = false;
			Item.DamageType = DamageClass.Magic;
			Item.width = 42;
			Item.height = 46;
			Item.useTime = 20;
			Item.mana = 10;

			Item.useAnimation = 20;
			Item.useStyle = 1;
			Item.shootSpeed = 10f;
			Item.staff[Item.type] = true;
			Item.knockBack = 3;
			Item.value = 15000;
			Item.rare = 5;
			Item.UseSound = SoundID.Item43;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Paraxyde Stave");
			// Tooltip.SetDefault("Summons paraxyde crystals to fall from the sky\n");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<ParaxydeShard>(), 11);
			recipe.AddIngredient(ItemID.FallenStar, 5);
			recipe.SetResult(this);
			recipe.AddTile(ModContent.TileType<Tiles.AlchematorTile>());
			recipe.AddRecipe();
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			type = 521;
			return base.Shoot(player, ref position, ref speedX, ref speedY, ref type, ref damage, ref knockBack);
		}

		public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.NextBool(2))
			{
				int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 27);
			}
		}
	}
}
