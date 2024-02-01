using System.Collections.Generic;


namespace ZM
{
	//public interface IZM
	//{
	//	int Count { get; }

	//	void Add(IZM zm);
	//	void Remove(IZM zm);
	//}


	/// <summary>
	/// 
	/// </summary>
	public class ZM
	{
		private ZM m_Parent;
		private List<ZM> m_Children;

		public int Count
		{
			get
			{
				return m_Children.Count;
			}
		}

		public ZM()
		{
			m_Parent = null;
			m_Children.Clear();
		}

		public void SetParent(ZM model)
		{
			m_Parent = model;
		}

		public void Add(ZM model)
		{
		}

		public void Remove(ZM model)
		{
		}
	}
}