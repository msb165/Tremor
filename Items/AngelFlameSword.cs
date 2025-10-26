using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class AngelFlameSword:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 59;
			Item.DamageType = DamageClass.Melee;
			Item.width = 35;
			Item.height = 20;

			Item.useTime = 20;
			Item.useAnimation = 30;
			Item.useStyle = 1;
			Item.knockBack = 10;
			Item.value = 1002;
			Item.rare = 5;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Angel Flame Sword");
			// Tooltip.SetDefault("Ignites your enemies");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.Excalibur, 1);
			recipe.AddIngredient(ItemID.FieryGreatsword, 1);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();

		}
		public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
		{
			target.AddBuff(BuffID.OnFire, 140);
		}
	}
}

