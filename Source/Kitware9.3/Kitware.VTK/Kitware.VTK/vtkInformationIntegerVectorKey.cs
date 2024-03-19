using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkInformationIntegerVectorKey
	/// </summary>
	/// <remarks>
	///    Key for integer vector values.
	///
	/// vtkInformationIntegerVectorKey is used to represent keys for integer
	/// vector values in vtkInformation.h
	/// </remarks>
	// Token: 0x02000B5F RID: 2911
	public class vtkInformationIntegerVectorKey : vtkInformationKey
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601E704 RID: 124676 RVA: 0x002B2434 File Offset: 0x002B0634
		static vtkInformationIntegerVectorKey()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInformationIntegerVectorKey.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInformationIntegerVectorKey"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601E705 RID: 124677 RVA: 0x002B245C File Offset: 0x002B065C
		public vtkInformationIntegerVectorKey(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601E706 RID: 124678 RVA: 0x002B246A File Offset: 0x002B066A
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601E707 RID: 124679
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationIntegerVectorKey_Append_01(HandleRef pThis, HandleRef info, int value);

		/// <summary>
		/// Get/Set the value associated with this key in the given
		/// information object.
		/// </summary>
		// Token: 0x0601E708 RID: 124680 RVA: 0x002B2478 File Offset: 0x002B0678
		public void Append(vtkInformation info, int value)
		{
			vtkInformationIntegerVectorKey.vtkInformationIntegerVectorKey_Append_01(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), value);
		}

		// Token: 0x0601E709 RID: 124681
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationIntegerVectorKey_Get_02(HandleRef pThis, HandleRef info);

		/// <summary>
		/// Get/Set the value associated with this key in the given
		/// information object.
		/// </summary>
		// Token: 0x0601E70A RID: 124682 RVA: 0x002B24A8 File Offset: 0x002B06A8
		public IntPtr Get(vtkInformation info)
		{
			return vtkInformationIntegerVectorKey.vtkInformationIntegerVectorKey_Get_02(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x0601E70B RID: 124683
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationIntegerVectorKey_Get_03(HandleRef pThis, HandleRef info, int idx);

		/// <summary>
		/// Get/Set the value associated with this key in the given
		/// information object.
		/// </summary>
		// Token: 0x0601E70C RID: 124684 RVA: 0x002B24DC File Offset: 0x002B06DC
		public int Get(vtkInformation info, int idx)
		{
			return vtkInformationIntegerVectorKey.vtkInformationIntegerVectorKey_Get_03(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), idx);
		}

		// Token: 0x0601E70D RID: 124685
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationIntegerVectorKey_Get_04(HandleRef pThis, HandleRef info, IntPtr value);

		/// <summary>
		/// Get/Set the value associated with this key in the given
		/// information object.
		/// </summary>
		// Token: 0x0601E70E RID: 124686 RVA: 0x002B2514 File Offset: 0x002B0714
		public void Get(vtkInformation info, IntPtr value)
		{
			vtkInformationIntegerVectorKey.vtkInformationIntegerVectorKey_Get_04(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), value);
		}

		// Token: 0x0601E70F RID: 124687
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInformationIntegerVectorKey_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E710 RID: 124688 RVA: 0x002B2544 File Offset: 0x002B0744
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkInformationIntegerVectorKey.vtkInformationIntegerVectorKey_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0601E711 RID: 124689
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInformationIntegerVectorKey_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E712 RID: 124690 RVA: 0x002B2564 File Offset: 0x002B0764
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkInformationIntegerVectorKey.vtkInformationIntegerVectorKey_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0601E713 RID: 124691
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationIntegerVectorKey_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E714 RID: 124692 RVA: 0x002B2580 File Offset: 0x002B0780
		public override int IsA(string type)
		{
			return vtkInformationIntegerVectorKey.vtkInformationIntegerVectorKey_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0601E715 RID: 124693
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationIntegerVectorKey_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E716 RID: 124694 RVA: 0x002B25A0 File Offset: 0x002B07A0
		public new static int IsTypeOf(string type)
		{
			return vtkInformationIntegerVectorKey.vtkInformationIntegerVectorKey_IsTypeOf_08(type);
		}

		// Token: 0x0601E717 RID: 124695
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationIntegerVectorKey_Length_09(HandleRef pThis, HandleRef info);

		/// <summary>
		/// Get/Set the value associated with this key in the given
		/// information object.
		/// </summary>
		// Token: 0x0601E718 RID: 124696 RVA: 0x002B25BC File Offset: 0x002B07BC
		public int Length(vtkInformation info)
		{
			return vtkInformationIntegerVectorKey.vtkInformationIntegerVectorKey_Length_09(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x0601E719 RID: 124697
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationIntegerVectorKey_MakeKey_10([MarshalAs(UnmanagedType.LPUTF8Str)] string name, [MarshalAs(UnmanagedType.LPUTF8Str)] string location, int length, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This method simply returns a new vtkInformationIntegerVectorKey, given a
		/// name, a location and a required length. This method is provided for
		/// wrappers. Use the constructor directly from C++ instead.
		/// </summary>
		// Token: 0x0601E71A RID: 124698 RVA: 0x002B25F0 File Offset: 0x002B07F0
		public static vtkInformationIntegerVectorKey MakeKey(string name, string location, int length)
		{
			vtkInformationIntegerVectorKey vtkInformationIntegerVectorKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationIntegerVectorKey.vtkInformationIntegerVectorKey_MakeKey_10(name, location, length, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerVectorKey = (vtkInformationIntegerVectorKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerVectorKey.Register(null);
				}
			}
			return vtkInformationIntegerVectorKey;
		}

		// Token: 0x0601E71B RID: 124699
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationIntegerVectorKey_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E71C RID: 124700 RVA: 0x002B265C File Offset: 0x002B085C
		public new vtkInformationIntegerVectorKey NewInstance()
		{
			vtkInformationIntegerVectorKey result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationIntegerVectorKey.vtkInformationIntegerVectorKey_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInformationIntegerVectorKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E71D RID: 124701
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationIntegerVectorKey_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E71E RID: 124702 RVA: 0x002B26B8 File Offset: 0x002B08B8
		public new static vtkInformationIntegerVectorKey SafeDownCast(vtkObjectBase o)
		{
			vtkInformationIntegerVectorKey vtkInformationIntegerVectorKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationIntegerVectorKey.vtkInformationIntegerVectorKey_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerVectorKey = (vtkInformationIntegerVectorKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerVectorKey.Register(null);
				}
			}
			return vtkInformationIntegerVectorKey;
		}

		// Token: 0x0601E71F RID: 124703
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationIntegerVectorKey_Set_13(HandleRef pThis, HandleRef info, IntPtr value, int length);

		/// <summary>
		/// Get/Set the value associated with this key in the given
		/// information object.
		/// </summary>
		// Token: 0x0601E720 RID: 124704 RVA: 0x002B2738 File Offset: 0x002B0938
		public void Set(vtkInformation info, IntPtr value, int length)
		{
			vtkInformationIntegerVectorKey.vtkInformationIntegerVectorKey_Set_13(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), value, length);
		}

		// Token: 0x0601E721 RID: 124705
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationIntegerVectorKey_Set_14(HandleRef pThis, HandleRef info);

		/// <summary>
		/// Get/Set the value associated with this key in the given
		/// information object.
		/// </summary>
		// Token: 0x0601E722 RID: 124706 RVA: 0x002B276C File Offset: 0x002B096C
		public void Set(vtkInformation info)
		{
			vtkInformationIntegerVectorKey.vtkInformationIntegerVectorKey_Set_14(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x0601E723 RID: 124707
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationIntegerVectorKey_ShallowCopy_15(HandleRef pThis, HandleRef from, HandleRef to);

		/// <summary>
		/// Copy the entry associated with this key from one information
		/// object to another.  If there is no entry in the first information
		/// object for this key, the value is removed from the second.
		/// </summary>
		// Token: 0x0601E724 RID: 124708 RVA: 0x002B279C File Offset: 0x002B099C
		public override void ShallowCopy(vtkInformation from, vtkInformation to)
		{
			vtkInformationIntegerVectorKey.vtkInformationIntegerVectorKey_ShallowCopy_15(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (to == null) ? default(HandleRef) : to.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400209D RID: 8349
		public new const string MRFullTypeName = "Kitware.VTK.vtkInformationIntegerVectorKey";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400209E RID: 8350
		public new static readonly string MRClassNameKey = "class vtkInformationIntegerVectorKey";
	}
}
