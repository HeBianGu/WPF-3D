using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSocketCollection
	/// </summary>
	/// <remarks>
	///     a collection for sockets.
	///
	/// Apart from being vtkCollection subclass for sockets, this class
	/// provides means to wait for activity on all the sockets in the
	/// collection simultaneously.
	/// </remarks>
	// Token: 0x02000AFC RID: 2812
	public class vtkSocketCollection : vtkCollection
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601D8BB RID: 121019 RVA: 0x0029BC90 File Offset: 0x00299E90
		static vtkSocketCollection()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSocketCollection.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSocketCollection"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601D8BC RID: 121020 RVA: 0x0029BCB8 File Offset: 0x00299EB8
		public vtkSocketCollection(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601D8BD RID: 121021
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSocketCollection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D8BE RID: 121022 RVA: 0x0029BCC8 File Offset: 0x00299EC8
		public new static vtkSocketCollection New()
		{
			vtkSocketCollection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSocketCollection.vtkSocketCollection_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSocketCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D8BF RID: 121023 RVA: 0x0029BD1C File Offset: 0x00299F1C
		public vtkSocketCollection() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSocketCollection.vtkSocketCollection_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601D8C0 RID: 121024 RVA: 0x0029BD60 File Offset: 0x00299F60
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601D8C1 RID: 121025
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSocketCollection_AddItem_01(HandleRef pThis, HandleRef soc);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D8C2 RID: 121026 RVA: 0x0029BD6C File Offset: 0x00299F6C
		public void AddItem(vtkSocket soc)
		{
			vtkSocketCollection.vtkSocketCollection_AddItem_01(base.GetCppThis(), (soc == null) ? default(HandleRef) : soc.GetCppThis());
		}

		// Token: 0x0601D8C3 RID: 121027
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSocketCollection_GetLastSelectedSocket_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the socket selected during the last SelectSockets(), if any.
		/// nullptr otherwise.
		/// </summary>
		// Token: 0x0601D8C4 RID: 121028 RVA: 0x0029BD9C File Offset: 0x00299F9C
		public vtkSocket GetLastSelectedSocket()
		{
			vtkSocket vtkSocket = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSocketCollection.vtkSocketCollection_GetLastSelectedSocket_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSocket = (vtkSocket)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSocket.Register(null);
				}
			}
			return vtkSocket;
		}

		// Token: 0x0601D8C5 RID: 121029
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSocketCollection_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D8C6 RID: 121030 RVA: 0x0029BE0C File Offset: 0x0029A00C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSocketCollection.vtkSocketCollection_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0601D8C7 RID: 121031
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSocketCollection_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D8C8 RID: 121032 RVA: 0x0029BE2C File Offset: 0x0029A02C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSocketCollection.vtkSocketCollection_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0601D8C9 RID: 121033
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSocketCollection_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D8CA RID: 121034 RVA: 0x0029BE48 File Offset: 0x0029A048
		public override int IsA(string type)
		{
			return vtkSocketCollection.vtkSocketCollection_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0601D8CB RID: 121035
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSocketCollection_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D8CC RID: 121036 RVA: 0x0029BE68 File Offset: 0x0029A068
		public new static int IsTypeOf(string type)
		{
			return vtkSocketCollection.vtkSocketCollection_IsTypeOf_06(type);
		}

		// Token: 0x0601D8CD RID: 121037
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSocketCollection_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D8CE RID: 121038 RVA: 0x0029BE84 File Offset: 0x0029A084
		public new vtkSocketCollection NewInstance()
		{
			vtkSocketCollection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSocketCollection.vtkSocketCollection_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSocketCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601D8CF RID: 121039
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSocketCollection_RemoveAllItems_09(HandleRef pThis);

		/// <summary>
		/// Overridden to unset SelectedSocket.
		/// </summary>
		// Token: 0x0601D8D0 RID: 121040 RVA: 0x0029BEDE File Offset: 0x0029A0DE
		public new void RemoveAllItems()
		{
			vtkSocketCollection.vtkSocketCollection_RemoveAllItems_09(base.GetCppThis());
		}

		// Token: 0x0601D8D1 RID: 121041
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSocketCollection_RemoveItem_10(HandleRef pThis, int i);

		/// <summary>
		/// Overridden to unset SelectedSocket.
		/// </summary>
		// Token: 0x0601D8D2 RID: 121042 RVA: 0x0029BEED File Offset: 0x0029A0ED
		public new void RemoveItem(int i)
		{
			vtkSocketCollection.vtkSocketCollection_RemoveItem_10(base.GetCppThis(), i);
		}

		// Token: 0x0601D8D3 RID: 121043
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSocketCollection_RemoveItem_11(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Overridden to unset SelectedSocket.
		/// </summary>
		// Token: 0x0601D8D4 RID: 121044 RVA: 0x0029BF00 File Offset: 0x0029A100
		public new void RemoveItem(vtkObject arg0)
		{
			vtkSocketCollection.vtkSocketCollection_RemoveItem_11(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601D8D5 RID: 121045
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSocketCollection_ReplaceItem_12(HandleRef pThis, int i, HandleRef arg1);

		/// <summary>
		/// Overridden to unset SelectedSocket.
		/// </summary>
		// Token: 0x0601D8D6 RID: 121046 RVA: 0x0029BF30 File Offset: 0x0029A130
		public new void ReplaceItem(int i, vtkObject arg1)
		{
			vtkSocketCollection.vtkSocketCollection_ReplaceItem_12(base.GetCppThis(), i, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x0601D8D7 RID: 121047
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSocketCollection_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D8D8 RID: 121048 RVA: 0x0029BF60 File Offset: 0x0029A160
		public new static vtkSocketCollection SafeDownCast(vtkObjectBase o)
		{
			vtkSocketCollection vtkSocketCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSocketCollection.vtkSocketCollection_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSocketCollection = (vtkSocketCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSocketCollection.Register(null);
				}
			}
			return vtkSocketCollection;
		}

		// Token: 0x0601D8D9 RID: 121049
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSocketCollection_SelectSockets_14(HandleRef pThis, uint msec);

		/// <summary>
		/// Select all Connected sockets in the collection. If msec is specified,
		/// it timesout after msec milliseconds on inactivity.
		/// Returns 0 on timeout, -1 on error; 1 is a socket was selected.
		/// The selected socket can be retrieved by GetLastSelectedSocket().
		/// </summary>
		// Token: 0x0601D8DA RID: 121050 RVA: 0x0029BFE0 File Offset: 0x0029A1E0
		public int SelectSockets(uint msec)
		{
			return vtkSocketCollection.vtkSocketCollection_SelectSockets_14(base.GetCppThis(), msec);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F1F RID: 7967
		public new const string MRFullTypeName = "Kitware.VTK.vtkSocketCollection";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F20 RID: 7968
		public new static readonly string MRClassNameKey = "class vtkSocketCollection";
	}
}
