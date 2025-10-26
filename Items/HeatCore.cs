using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class HeatCore:TremorModItem
	{
		const int ShootType = ProjectileID.HeatRay; // Тип выстрела
		const float ShootRange = 600.0f; // Дальность выстрела
		const float ShootKN = 1.0f; // Отбрасывание 
		const int ShootRate = 40; // Частота выстрела (60 - 1 секунда)
		const int ShootCount = 2; // Лазеров за выстрел
		const float ShootSpeed = 30f; // Скорость выстрела (для лазера - дальность)
		const int spread = 45; // Разброс
		const float spreadMult = 0.045f; // Модификатор разброса

		int TimeToShoot = ShootRate;

		public override void SetDefaults()
		{

			Item.width = 36;
			Item.height = 36;

			Item.value = 240000;
			Item.rare = 9;
			Item.expert = true;
			Item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Heat Core");
			// Tooltip.SetDefault("Shoots rays at nearby enemies");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			if (--TimeToShoot <= 0)
			{
				TimeToShoot = ShootRate;
				int Target = GetTarget();
				if (Target != -1) Shoot(Target, GetDamage());
			}
		}

		int GetTarget()
		{
			int Target = -1;
			for (int k = 0; k < Main.npc.Length; k++)
			{
				if (Main.npc[k].active && Main.npc[k].lifeMax > 5 && !Main.npc[k].dontTakeDamage && !Main.npc[k].friendly && Main.npc[k].Distance(Main.player[Item.playerIndexTheItemIsReservedFor].Center) <= ShootRange && Collision.CanHitLine(Main.player[Item.playerIndexTheItemIsReservedFor].Center, 4, 4, Main.npc[k].Center, 4, 4))
				{
					Target = k;
					break;
				}
			}
			return Target;
		}

		int GetDamage()
		{
			return Main.player[Item.playerIndexTheItemIsReservedFor].GetSpecialProjectileDamage(10, 15);
		}

		void Shoot(int Target, int Damage)
		{
			Vector2 velocity = Helper.VelocityToPoint(Main.player[Item.playerIndexTheItemIsReservedFor].Center, Main.npc[Target].Center, ShootSpeed);
			for (int l = 0; l < ShootCount; l++)
			{
				velocity.X = velocity.X + Main.rand.Next(-spread, spread + 1) * spreadMult;
				velocity.Y = velocity.Y + Main.rand.Next(-spread, spread + 1) * spreadMult;
				int i = Projectile.NewProjectile(null, Main.player[Item.playerIndexTheItemIsReservedFor].Center.X, Main.player[Item.playerIndexTheItemIsReservedFor].Center.Y, velocity.X, velocity.Y, ShootType, Damage, ShootKN, Item.playerIndexTheItemIsReservedFor);
			}
		}
	}
}
