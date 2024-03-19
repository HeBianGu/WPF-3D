using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkInformationKeyVectorKey
	/// </summary>
	/// <remarks>
	///    Key for vector-of-keys values.
	///
	/// vtkInformationKeyVectorKey is used to represent keys for
	/// vector-of-keys values in vtkInformation.
	/// </remarks>
	// Token: 0x02000B62 RID: 2914
	public class vtkInformationKeyVectorKey : vtkInformationKey
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601E75B RID: 124763 RVA: 0x002B2E37 File Offset: 0x002B1037
		static vtkInformationKeyVectorKey()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInformationKeyVectorKey.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInformationKeyVectorKey"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601E75C RID: 124764 RVA: 0x002B2E5F File Offset: 0x002B105F
		public vtkInformationKeyVectorKey(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601E75D RID: 124765 RVA: 0x002B2E6D File Offset: 0x002B106D
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601E75E RID: 124766
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationKeyVectorKey_Append_01(HandleRef pThis, HandleRef info, HandleRef value);

		/// <summary>
		/// Get/Set the value associated with this key in the given
		/// information object.
		/// </summary>
		// Token: 0x0601E75F RID: 124767 RVA: 0x002B2E78 File Offset: 0x002B1078
		public void Append(vtkInformation info, vtkInformationKey value)
		{
			vtkInformationKeyVectorKey.vtkInformationKeyVectorKey_Append_01(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		// Token: 0x0601E760 RID: 124768
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationKeyVectorKey_AppendUnique_02(HandleRef pThis, HandleRef info, HandleRef value);

		/// <summary>
		/// Get/Set the value associated with this key in the given
		/// information object.
		/// </summary>
		// Token: 0x0601E761 RID: 124769 RVA: 0x002B2EBC File Offset: 0x002B10BC
		public void AppendUnique(vtkInformation info, vtkInformationKey value)
		{
			vtkInformationKeyVectorKey.vtkInformationKeyVectorKey_AppendUnique_02(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		// Token: 0x0601E762 RID: 124770
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationKeyVectorKey_Get_03(HandleRef pThis, HandleRef info, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the value associated with this key in the given
		/// information object.
		/// </summary>
		// Token: 0x0601E763 RID: 124771 RVA: 0x002B2F00 File Offset: 0x002B1100
		public vtkInformationKey Get(vtkInformation info, int idx)
		{
			vtkInformationKey vtkInformationKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationKeyVectorKey.vtkInformationKeyVectorKey_Get_03(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), idx, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationKey = (vtkInformationKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationKey.Register(null);
				}
			}
			return vtkInformationKey;
		}

		// Token: 0x0601E764 RID: 124772
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInformationKeyVectorKey_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E765 RID: 124773 RVA: 0x002B2F88 File Offset: 0x002B1188
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkInformationKeyVectorKey.vtkInformationKeyVectorKey_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0601E766 RID: 124774
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInformationKeyVectorKey_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E767 RID: 124775 RVA: 0x002B2FA8 File Offset: 0x002B11A8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkInformationKeyVectorKey.vtkInformationKeyVectorKey_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0601E768 RID: 124776
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationKeyVectorKey_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E769 RID: 124777 RVA: 0x002B2FC4 File Offset: 0x002B11C4
		public override int IsA(string type)
		{
			return vtkInformationKeyVectorKey.vtkInformationKeyVectorKey_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0601E76A RID: 124778
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationKeyVectorKey_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E76B RID: 124779 RVA: 0x002B2FE4 File Offset: 0x002B11E4
		public new static int IsTypeOf(string type)
		{
			return vtkInformationKeyVectorKey.vtkInformationKeyVectorKey_IsTypeOf_07(type);
		}

		// Token: 0x0601E76C RID: 124780
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationKeyVectorKey_Length_08(HandleRef pThis, HandleRef info);

		/// <summary>
		/// Get/Set the value associated with this key in the given
		/// information object.
		/// </summary>
		// Token: 0x0601E76D RID: 124781 RVA: 0x002B3000 File Offset: 0x002B1200
		public int Length(vtkInformation info)
		{
			return vtkInformationKeyVectorKey.vtkInformationKeyVectorKey_Length_08(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x0601E76E RID: 124782
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationKeyVectorKey_MakeKey_09([MarshalAs(UnmanagedType.LPUTF8Str)] string name, [MarshalAs(UnmanagedType.LPUTF8Str)] string location, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This method simply returns a new vtkInformationKeyVectorKey, given a
		/// name and a location. This method is provided for wrappers. Use the
		/// constructor directly from C++ instead.
		/// </summary>
		// Token: 0x0601E76F RID: 124783 RVA: 0x002B3034 File Offset: 0x002B1234
		public static vtkInformationKeyVectorKey MakeKey(string name, string location)
		{
			vtkInformationKeyVectorKey vtkInformationKeyVectorKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationKeyVectorKey.vtkInformationKeyVectorKey_MakeKey_09(name, location, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationKeyVectorKey = (vtkInformationKeyVectorKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationKeyVectorKey.Register(null);
				}
			}
			return vtkInformationKeyVectorKey;
		}

		// Token: 0x0601E770 RID: 124784
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationKeyVectorKey_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E771 RID: 124785 RVA: 0x002B30A0 File Offset: 0x002B12A0
		public new vtkInformationKeyVectorKey NewInstance()
		{
			vtkInformationKeyVectorKey result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationKeyVectorKey.vtkInformationKeyVectorKey_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInformationKeyVectorKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E772 RID: 124786
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationKeyVectorKey_RemoveItem_11(HandleRef pThis, HandleRef info, HandleRef value);

		/// <summary>
		/// Get/Set the value associated with this key in the given
		/// information object.
		/// </summary>
		// Token: 0x0601E773 RID: 124787 RVA: 0x002B30FC File Offset: 0x002B12FC
		public void RemoveItem(vtkInformation info, vtkInformationKey value)
		{
			vtkInformationKeyVectorKey.vtkInformationKeyVectorKey_RemoveItem_11(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		// Token: 0x0601E774 RID: 124788
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationKeyVectorKey_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E775 RID: 124789 RVA: 0x002B3140 File Offset: 0x002B1340
		public new static vtkInformationKeyVectorKey SafeDownCast(vtkObjectBase o)
		{
			vtkInformationKeyVectorKey vtkInformationKeyVectorKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationKeyVectorKey.vtkInformationKeyVectorKey_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationKeyVectorKey = (vtkInformationKeyVectorKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationKeyVectorKey.Register(null);
				}
			}
			return vtkInformationKeyVectorKey;
		}

		// Token: 0x0601E776 RID: 124790
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationKeyVectorKey_ShallowCopy_13(HandleRef pThis, HandleRef from, HandleRef to);

		/// <summary>
		/// Copy the entry associated with this key from one information
		/// object to another.  If there is no entry in the first information
		/// object for this key, the value is removed from the second.
		/// </summary>
		// Token: 0x0601E777 RID: 124791 RVA: 0x002B31C0 File Offset: 0x002B13C0
		public override void ShallowCopy(vtkInformation from, vtkInformation to)
		{
			vtkInformationKeyVectorKey.vtkInformationKeyVectorKey_ShallowCopy_13(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (to == null) ? default(HandleRef) : to.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040020A3 RID: 8355
		public new const string MRFullTypeName = "Kitware.VTK.vtkInformationKeyVectorKey";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040020A4 RID: 8356
		public new static readonly string MRClassNameKey = "class vtkInformationKeyVectorKey";
	}
}
