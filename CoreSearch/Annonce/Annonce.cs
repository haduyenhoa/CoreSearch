using System;
using System.Collections;

namespace CoreSearch
{
	public class Annonce
	{
		public string Title;
		public string SubTitle;
		public string RawLink;
		public string PlainContent;
		public string HtmlContent;
		public Array ImageLinks;

		public DateTime PostDate;

		public Seller AnnonceSeller;

		public Location AnnonceLocation;

		public Annonce ()
		{
		}
	}
}

