using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Ice.Items
{
	public class FrostLance:TremorModItem
	{
		public override void SetDefaults()
		{

			item.damage = 23;
			item.width = 76;
			item.height = 76;
			item.noUseGraphic = true;
			item.DamageType = DamageClass.Melee;
			item.useTime = 35;
			item.shoot = ModContent.ProjectileType<FrostLancePro>();
			item.shootSpeed = 3f;
			item.useAnimation = 35;
			item.useStyle = 5;
			item.knockBack = 9;
			item.value = 1000;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Frost Lance");
			Tooltip.SetDefault("");
		}

		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			target.AddBuff(44, 60);
		}
	}
}
