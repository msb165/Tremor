using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor
{
	public class PiggyBank : GlobalItem
	{
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)//Add support for defender coins in bank3?
		{
			bool flag;
			int[] coins;

			if (item.type == ItemID.PiggyBank || item.type == ItemID.MoneyTrough)
			{
				coins = Utils.CoinsSplit(Utils.CoinsCount(out flag, Main.LocalPlayer.bank.item, new int[0]));
			}
			else if (item.type == ItemID.Safe)
			{
				coins = Utils.CoinsSplit(Utils.CoinsCount(out flag, Main.LocalPlayer.bank2.item, new int[0]));
			}
			else{return;}

			List<string> coinTexts = new List<string>(coins.Length);
			for (int i=0; i<3; i++)
			{
				if (coins[i] > 0)
				{
					coinTexts.Add($"{coins[i]} [i/s1:{ItemID.PlatinumCoin - i}]");
				}
			}

			if(coinTexts.Count>0)
			{
				tooltips.Add(new TooltipLine(mod, "", string.Join(" ",coinTexts)));
			}
		}
	}
}
